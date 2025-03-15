using System.Data.SqlClient;

namespace ADOCRUDdemoTQ.Models
{
    public class EmployeeCRUD
    {
        //to read db connection from appsetting.json
        private IConfiguration configuration;
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public EmployeeCRUD(IConfiguration configuration) {
            this.configuration = configuration;
            con = new SqlConnection(this.configuration.GetConnectionString("defaultConnection"));
        }

        public IEnumerable<Employee> GetEmployees()
        {
            List<Employee> list = new List<Employee>();
            cmd = new SqlCommand("select * from Employee", con);
            con.Open();
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    Employee emp = new Employee();
                    emp.EmpId = Convert.ToInt32(dr["empid"]);
                    emp.EmpName = dr["empname"].ToString();
                    emp.Age = Convert.ToInt32(dr["age"]);
                    emp.Salary = Convert.ToInt32(dr["salary"]);
                    list.Add(emp);
                }
            }
            con.Close();
            return list;
        }
        public Employee GetEmployeeById(int id)
        {
            Employee emp = new Employee();
            cmd = new SqlCommand("select * from Employee where empid=@id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@id", id);
            dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                while (dr.Read())
                {
                    emp.EmpId = Convert.ToInt32(dr["empid"]);
                    emp.EmpName = dr["empname"].ToString();
                    emp.Age = Convert.ToInt32(dr["age"]);
                    emp.Salary = Convert.ToInt32(dr["salary"]);

                }
            }
            con.Close();
            return emp;
        }
        public int AddEmployee(Employee emp)
        {
            int result = 0;
            string qry = "insert into Employee values(@empname,@age,@salary)";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@empname", emp.EmpName);
            cmd.Parameters.AddWithValue("@age", emp.Age);
            cmd.Parameters.AddWithValue("@salary", emp.Salary);
            con.Open();
            result = cmd.ExecuteNonQuery();
            con.Close();
            return result;

        }
        public int UpdateEmployee(Employee emp)
        {
            int result = 0;
            string qry = "update Employee set empname=@empname,age=@age,salary=@salary where empid=@id";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@empname", emp.EmpName);
            cmd.Parameters.AddWithValue("@age", emp.Age);
            cmd.Parameters.AddWithValue("@salary", emp.Salary);
            cmd.Parameters.AddWithValue("@id", emp.EmpId);
            con.Open();
            result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
        public int DeleteEmployee(int id)
        {
            int result = 0;
            string qry = "delete from Employee where empid=@id";
            cmd = new SqlCommand(qry, con);
            cmd.Parameters.AddWithValue("@id", id);
            con.Open();
            result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }

    }
}
