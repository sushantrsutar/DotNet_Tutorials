using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Test
{   /*2.Create a base class Building that stores the number of floors of a building,
     * number of rooms and it’s total footage. Create a derived class House that inherits Building and
     * also stores the number of bedrooms and bathrooms. Demonstrate the working of the classes. 
     * create a second derived class Office that inherits Building and stores the number of telephones and tables.
     * Now demonstrate the working of all three classes*/
    public  class Building
    {
        public int Floors;
        public int Rooms;
        public int TotalFootage;

        public Building(int Floors,int Rooms,int TotalFootage) 
        {
            this.Floors = Floors;
            this.Rooms = Rooms;
            this.TotalFootage = TotalFootage;
        }

        public virtual void ShowData() {
            Console.WriteLine($"Floors : {Floors}, Rooms : {Rooms}, TotalFootage : {TotalFootage}");
        }
    }

    public class House : Building{
        public int BedRooms;
        public int BathRooms;

        public House(int Floors, int Rooms, int TotalFootage, int bedRooms, int bathRooms):base(Floors, Rooms, TotalFootage)
        {
            this.BedRooms = bedRooms;
            this.BathRooms = bathRooms;
        }
        public override void ShowData() {
            base.ShowData();
            Console.WriteLine($" , Bed rooms : {BedRooms} , Bath rooms : {BathRooms}");
        }
    }

    public class Office :Building
    {
        public int TelePhone;
        public int Tables;

        public Office(int Floors, int Rooms, int TotalFootage,int TelePhone,int Tables):base(Floors, Rooms, TotalFootage) 
        {
            this.TelePhone = TelePhone;
            this.Tables = Tables;
        }

        public override void ShowData()
        {
            base.ShowData();
            Console.WriteLine($" , TelePhone : {TelePhone} , Tables : {Tables}");
        }
    }
}
