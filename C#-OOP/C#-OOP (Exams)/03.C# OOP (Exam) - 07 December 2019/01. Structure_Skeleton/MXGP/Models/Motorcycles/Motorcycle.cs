namespace MXGP.Models.Motorcycles
{
    using System;

    using MXGP.Models.Motorcycles.Contracts;
    using MXGP.Utilities.Messages;

    public abstract class Motorcycle : IMotorcycle
    {
        private string model;

        public Motorcycle(string model, int horsePower, double cubicCentimeters)
        {
            this.Model = model;
            this.HorsePower = horsePower; 
            this.CubicCentimeters = cubicCentimeters;
        }

        public string Model
        {
            get => this.model;
            private set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length < 4)
                {
                    throw new ArgumentException(ExceptionMessages.InvalidModel);
                }

                this.model = value;
            }
        }

        public virtual int HorsePower { get; protected set; }

        public double CubicCentimeters { get; private set; }

        public double CalculateRacePoints(int laps)
        {
            return this.CubicCentimeters / this.HorsePower * laps;
        }
    }
}