using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_2_Part1
{
    class NewCar : Car
    {
        private bool _extendedWarranty;

        public NewCar(CarMake make, string model, int year, decimal price, bool extendedWarranty) : base(make, model, year, price)
        {
            _extendedWarranty = extendedWarranty;
        }

       

        public bool ExtendedWarranty
        {
            get { return _extendedWarranty; }
            set { _extendedWarranty = value; }
        }


        public override string ToString()
        {
            return $"New Car\tMake: {Make}\t\tModel: {Model}\tYear: {Year}\tPrice: {Price}\tExtended Warranty: {ExtendedWarranty}\n";
        }

    }
}
