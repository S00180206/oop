using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabSheet3Q2
{
    class Car
    {
        private string Make;
        public string make
        {
            get { return this.make; }
            set { this.make = value; }

            private string _model;

        public string Model
        {
            get { return _model; }
            set { _model = value; }
        }

        private int currentSpeed;

        public int CurrentSpeed
        {
            get { return currentSpeed; }
            set { currentSpeed = value; }
        }

        private double engineSize;

        public double EngineSize
        {
            get { return engineSize; }
            set { engineSize = value; }
        }


        public void DisplayCarInfo()
        {
            Console.WriteLine($"Car Make: {Make}");
            Console.WriteLine($"Car Model: {Model}");
            Console.WriteLine($"Current Speed: {CurrentSpeed}kpm");
            Console.WriteLine($"Engine Size: {EngineSize}");
        }

        public override string ToString()
        {
            return
                string.Format($"Car Make: {Make}" +
                                $"\nCar Model:{Model}" +
                                $"\nCurrent speed:{CurrentSpeed}" +
                                $"\nEngine Size:{EngineSize}");

        }

        public void Accelerate()
        {
            CurrentSpeed += 10;
            Console.WriteLine($"Current Speed is:{CurrentSpeed}");
        }
    }
}
