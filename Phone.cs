using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;
using System.Xml.Linq;

namespace Console_App
{
    internal class Phone
    {
        public int Number { get; set; }
        public string Model { get; set; }
        public double Weight { get; set; }

        public void Print()
        {
            Console.WriteLine(($"{Number} - number, {Model} - model, {Weight} - weight"));
        }

        public Phone (int number, string model, double weight)
        {
            Number = number;
            Model = model;
            Weight = weight;
            var phone = new Phone(Number,Model);
        }

        public Phone(int number, string model)
        {
            Number = number;
            Model = model;
        }

        public Phone()
        {
        }

        public void ReceiveCall(string name)
        {
            Console.WriteLine($"{name} is calling you");
        }

        public void ReceiveCall(string name, int number)
        {
            Console.WriteLine($"{name} {number} is calling you");
        }

        public int GetNumber()
        {
            return Number;
        }

        public void SendMessage(int number)
        {

                Console.WriteLine($"Message is sent to: {number}");

        }


    }
}
