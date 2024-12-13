//using System;

//namespace DiamondProblemExample
//{
//    public interface WiFiDevice
//    {
//        void Connect();
//    }

//    public interface BluetoothDevice
//    {
//        void Connect();
//    }

//    public class SmartSpeaker : WiFiDevice, BluetoothDevice
//    {
//        void WiFiDevice.Connect()
//        {
//            Console.WriteLine("Connecting Smart Speaker using Wi-Fi...");
//        }

//        void BluetoothDevice.Connect()
//        {
//            Console.WriteLine("Connecting Smart Speaker using Bluetooth...");
//        }

//        public void ConnectWiFi()
//        {
//            Console.WriteLine("Connecting Smart Speaker using Wi-Fi...");

//        }

//        public void ConnectBluetooth()
//        {
//            Console.WriteLine("Connecting Smart Speaker using Bluetooth...");
//        }
//    }

//    class Shri
//    {
//        static void Main(string[] args)
//        {
//            SmartSpeaker speaker = new SmartSpeaker();
//            speaker.ConnectWiFi();
//            speaker.ConnectBluetooth();
//        }
//    }
//}
