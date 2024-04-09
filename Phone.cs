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
        //public int Number { get; set; }
        //public string Model { get; set; }
        //public double Weight { get; set; }


        private int _number;
        private string _model;
        private double _weight;


        public int Number
        { 
            get { return _number; } 
            set { _number = value; }
        }

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        public double Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public void Print()
        {
            Console.WriteLine(($"{this._number} - number, {this._model} - model, {this._weight} - weight"));
        }

        public Phone (int _number, string _model, double _weight)
        {
            Number = _number;
            Model = _model;
            Weight = _weight;
            var phone = new Phone(this._number,this._model);
        }

        public Phone(int _number, string _model)
        {
            Number = _number;
            Model = _model;
        }

        public Phone()
        {
        }

        public void ReceiveCall(string _name)
        {
            Console.WriteLine($"{_name} is calling you");
        }

        public void ReceiveCall(string _name, int _number)
        {
            Console.WriteLine($"{_name} {this._number} is calling you");
        }

        public int GetNumber()
        {
            return _number;
        }

        public void SendMessage(int _number)
        {

                Console.WriteLine($"Message is sent to: {this._number}");

        }


    }
}
