using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    public class Encap2
    {

        //5 variables
        private static string CollegeName;
        private const int No_Of_Students = 70;
        private readonly int presentStudents;
        private string name;
        private int rollNumber;
        private string batch = "Aug-24";
        private bool attendance;

        //all constructors

        //default constructor
        public Encap2()
        {
            Console.WriteLine("This is Default Constructor");
        }

        //Para constructor
        public Encap2(int presentStudents, string name, int rollNumber, string batch, bool attendance)
        {
            this.presentStudents = presentStudents;
            this.name = name;
            this.rollNumber = rollNumber;
            this.batch = batch;
            this.attendance = attendance;
        }



        //copy constructor
        public Encap2(Encap2 s)
        {
            this.presentStudents = presentStudents;
            this.name = name;
            this.rollNumber = rollNumber;
            this.batch = batch;
            this.attendance = attendance;
        }
        //static Cons
        static Encap2()
        {
            CollegeName = "MET";
        }

        public void checkAttendance()
        {
            if (!attendance)
            {
                Console.WriteLine("Absent");
            }
            else
            {
                Console.WriteLine("Present");
            }
        }

        //getter and setter

        public static string collegeName
        {
            get { return CollegeName; }
            set { CollegeName = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int rollNo
        {
            get { return rollNumber; }
            set { rollNumber = value; }
        }

        public bool Attendance
        {
            get { return attendance; }
            set { attendance = value; }
        }

        public static void StaticMethod()
        {
            Console.WriteLine("This static method");
        }


        public void Display()
        {
            //     private static string CollegeName;
            //private const int No_Of_Students = 70;
            //private readonly int presentStudents;
            //private string name;
            //private int rollNumber;
            //private string batch = "Aug-24";
            //private bool attendance;
            Console.WriteLine("College Name: " + CollegeName);
            Console.WriteLine(" No Of Students: " + No_Of_Students);
            Console.WriteLine(" Present Students: " + presentStudents);
            Console.WriteLine(" Name: " + name);
            Console.WriteLine(" RollNumber: " + rollNumber);
            Console.WriteLine(" Batch: " + batch);
            Console.WriteLine(" Attendance: " + attendance);
        }




        //logical operator
        //if else

        //loop
        //method static and instance 
        //all acess modifier
        //encapsulation
    }
    class StudentManagement
    {
        static void Main(string[] args)
        {
            Encap2 s = new Encap2();
            s.checkAttendance();
            s.Display();
            Encap2.StaticMethod();

            Console.WriteLine("=================================");

            Encap2 student2 = new Encap2(55, "Shrikant", 101, "Aug-24", true);
            student2.Display();

            Console.WriteLine("=================================");

            // Using getters and setters to modify properties
            student2.Name = "Om Shirudkar";
            //student2.rollNumber = 102;
            student2.Attendance = false;
            student2.checkAttendance();
            student2.Display();

        }
    }
}
