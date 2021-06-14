﻿using MilitaryElite.Intefaces;
using System.Text;

namespace MilitaryElite.Models
{
    public class Spy : Soldier,ISpy
    {
        public Spy(int id, string firstName, string lastName,  int codeNum) 
            : base(id, firstName, lastName)
        {
            this.CodeNumber = codeNum;
        }

        public int CodeNumber { get; }
        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine(base.ToString());
            sb.AppendLine($"Code Number: {this.CodeNumber}");

            return sb.ToString().Trim();
        }


    }
}
