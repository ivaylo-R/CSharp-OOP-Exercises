using System;
using System.Collections.Generic;
using System.Text;

namespace _04
{
    public class Dough
    {
        private const double CALORIES_PER_GRAM = 2;
        private const double MINIMUM_DOUGH_WEIGHT = 1;
        private const double MAXIMUM_DOUGH_WEIGHT = 200;
        private string flour;
        private double weight;
        


        public Dough()
        {

        }
        public Dough(string flourType, string bakingTechnique, double weight)
            : this()
        {
            FlourType = flourType;
            BakingTechnique = bakingTechnique;
            Weight = weight;
        }

        public string FlourType
        {
            get => this.flour;

            private set
            {
                if (value.ToLower() != "white" && value.ToLower() != "wholegrain")
                {
                    throw new Exception("Invalid type of dough.");
                }
                this.flour = value;
            }
        }
        public string BakingTechnique { get; private set; }
        public double Weight
        {
            get => this.weight;
            private set
            {
                if (value < MINIMUM_DOUGH_WEIGHT || value > MAXIMUM_DOUGH_WEIGHT)
                {
                    throw new Exception("Dough weight should be in the range [1..200].");
                }
                this.weight = value;
            }
        }

        public double FindDoughCalories()
        {
            double result =  (CALORIES_PER_GRAM * this.Weight) * FindDoughModifier() * FindTechniqueModifier();
            return result;
        }

    
        private double FindTechniqueModifier()
        {
            double techniqueModifier = 0;
            switch (this.BakingTechnique)
            {
                case "crispy":
                    techniqueModifier = 0.9;
                    break;
                case "chewy":
                    techniqueModifier = 1.1;
                    break;
                case "homemade":
                    techniqueModifier = 1.0;
                    break;
            }
            return techniqueModifier;
        }
        private double FindDoughModifier()
        {
            double doughtModifier = 0;
            switch (this.FlourType)
            {
                case "white":
                    doughtModifier = 1.5;
                    break;
                case "wholegrain":
                    doughtModifier = 1.0;
                    break;
            }
            return doughtModifier;
        }

    }
}
