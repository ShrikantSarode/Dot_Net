//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

////Hirarchical Inheritance
//namespace Interface
//{
//    class RazoPay
//    {
         
//        void send()
//        {

//        }
//        void scanQRcode()
//        {

//        }
//        void payBills()
//        {

//        }
//        void ShowBalance()
//        {

//        }
//    }
//    class GooglePay : RazoPay
//    {
//        public void payBills()
//        {
//            Console.WriteLine("Pay Bills");

//        }

//        public void scanQRcode()
//        {
//            Console.WriteLine("Scan QRcode");
//        }

//        public void send()
//        {
//            Console.WriteLine("Send Money");
//        }

//        public void ShowBalance()
//        {
//            Console.WriteLine("Show Balance");
//        }
//    }
//    class Paytm : RazoPay
//    {
//        public void payBills()
//        {
//            Console.WriteLine("Pay Bills");

//        }

//        public void scanQRcode()
//        {
//            Console.WriteLine("Scan QRcode");
//        }

//        public void send()
//        {
//            Console.WriteLine("Send Money");
//        }

//        public void ShowBalance()
//        {
//            Console.WriteLine("Show Balance");
//        }
//    }
//    class PhonePay : RazoPay
//    {
//        public void payBills()
//        {
//            Console.WriteLine("Pay Bills");

//        }

//        public void scanQRcode()
//        {
//            Console.WriteLine("Scan QRcode");
//        }

//        public void send()
//        {
//            Console.WriteLine("Send Money");
//        }

//        public void ShowBalance()
//        {
//            Console.WriteLine("Show Balance");
//        }
//    }
//    class App
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Google Pay");
//            GooglePay gp = new GooglePay();
//            gp.scanQRcode();
//            gp.send();
//            gp.ShowBalance();
//            gp.payBills();



//            Console.WriteLine("========================");
//            Console.WriteLine("Phone Pay");
//            PhonePay phonePay = new PhonePay();

//            phonePay.scanQRcode();
//            phonePay.send();
//            phonePay.ShowBalance();
//            phonePay.payBills();

//            Console.WriteLine("========================");
//            Console.WriteLine("Paytm");

//            Paytm paytm = new Paytm();
//            paytm.scanQRcode();
//            paytm.send();
//            paytm.ShowBalance();
//            paytm.payBills();
//        }
//    }
//}
