using MilitaryElite.Intefaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Models
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public List<IPrivate> privates;
        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary,List<IPrivate> privates) 
            : base(id, firstName, lastName, salary)
        {
            this.privates = new List<IPrivate> ();
        }

        public IReadOnlyCollection<IPrivate> Privates => this.privates;


        public void AddPrivate(IPrivate @private)
        {
            this.privates.Add(@private);
        }
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("Privates:");
            foreach (var currentPrivate in this.privates)
            {
                sb.AppendLine($"  {currentPrivate}");
            }
            return sb.ToString().Trim();
        }

    }
}
