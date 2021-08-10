using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_2_Part1
{
    class Car
    {
        protected CarMake _make;
        protected string _model;
        protected int _year;
        protected decimal _price;

        public Car(CarMake make, string model, int year, decimal price)
        {
            _make = make;
            _model = model;
            _year = year;
            _price = price;

        }

      

        public CarMake Make
        {
            get { return _make; }
            set { _make = value; }
        }

       

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }
       

        public int Year
        {
            get { return _year; }
            set { _year = value; }
        }
       

        public decimal Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public override string ToString()
        {
            return $"";
        }


    }
}
