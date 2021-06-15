﻿using System;
using System.Text;

namespace Animals
{
    public abstract class Animal
    {
        private const string InvalidData = "Invalid input!";
        private string name;
        private int age;
        private string gender;

        protected Animal(string name, int age, string gender)
        {
            Name = name;
            Age = age;
            Gender = gender;
        }

        public string Name
        {
            get => this.name;
            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException(InvalidData);
                }

                this.name = value;
            }
        }
        public int Age
        {
            get => this.age;
            private set
            {
                if (value<0)
                {
                    throw new ArgumentException(InvalidData);
                }

                this.age = value;
            }
        }
        public virtual string Gender
        {
            get => this.gender;
            private set
            {
                if (value!="Male"&&value!="Female")
                {
                    throw new ArgumentException(InvalidData);
                }

                this.gender = value;
            }
        }

        protected abstract string ProduceSound();

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.GetType().Name);
            sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");
            sb.AppendLine($"{this.ProduceSound()}");

            return sb.ToString().TrimEnd();
        }
    }
}
