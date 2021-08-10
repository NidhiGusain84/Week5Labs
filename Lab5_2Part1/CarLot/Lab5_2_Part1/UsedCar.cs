using System;
using System.Collections.Generic;
using System.Text;

namespace Lab5_2_Part1
{
    class UsedCar : Car
    {
        private int _numberOfOwners;
        private int _mileage;
        

        public UsedCar(CarMake make, string model, int year, decimal price, int numberOfOwners, int mileage) : base(make, model, year, price)
        {
            _numberOfOwners = numberOfOwners;
            _mileage = mileage;
        }

       

        public int NumberOfOwners
        {
            get { return _numberOfOwners; }
            set { _numberOfOwners = value; }
        }

      

        public int Mileage
        {
            get { return _mileage; }
            set { _mileage = value; }
        }



        public override string ToString()
        {
            return $"Used Car\tMake: {Make}\t\tModel: {Model}\tYear: {Year}\tPrice: {Price}\tNumber of Owners: {NumberOfOwners}\tMileage: {Mileage}\n";
        }

    }
}
