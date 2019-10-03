﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
    public class Car
    {
        private string make;

        public string Make
        {
            get { return this.make; }
            set { this.make = value; }
        }

        private string _model;

        public string Model
        {
            get { return _model; }
            set { this._model = value; }
        }

        private int currentSpeed;

        public int CurrentSpeed
        {
            get { return currentSpeed; }
            set { this.currentSpeed = value; }
        }

        private double engineSize;

        public double EngineSize
        {
            get { return engineSize; }
            set { this.engineSize = value; }
        }

        public void DisplayCarInfo()
        {
            Console.WriteLine($"Car make: {Make}");
            Console.WriteLine($"Car model: {Model}");
            Console.WriteLine($"Current speed: {CurrentSpeed}");
            Console.WriteLine($"Engine Size: {EngineSize}");
        }
    }
}
