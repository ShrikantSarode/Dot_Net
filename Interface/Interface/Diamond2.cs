using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    interface Apple
    {
        void Charging();
        void PlayMusic();

        void CustomerCare();

    }
    interface Mac : Apple
    {
        void Charging();
        void PlayMusic();

        void Deskstop();

    }
    interface Iphone : Apple
    {
        void Charging();
        void PlayMusic();

        void Calling();
    }
    class User : Iphone, Mac
    {
        public void Charging()
        {
            Console.WriteLine("Charging is On");
        }


        public void PlayMusic()
        {
            Console.WriteLine("Playing Music");
        }

        public void Calling()
        {
            Console.WriteLine("Iphone Can Call ");
        }

        public void Deskstop()
        {
            Console.WriteLine("Mac has Os (Laptop)");
        }
        public void CustomerCare()
        {
            Console.WriteLine("Apple Customer Care");
        }

        //static void Main(string[] args)
        //{

        //    User user = new User();
        //    user.Charging();
        //    user.PlayMusic();
        //    user.Calling(); 
        //    user.Deskstop();
        //    user.CustomerCare();    
        //}


    }
}
