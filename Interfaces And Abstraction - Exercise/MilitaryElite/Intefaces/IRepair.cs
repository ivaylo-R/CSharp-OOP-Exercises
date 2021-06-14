using MilitaryElite.Models;
using System.Collections;
using System.Collections.Generic;

namespace MilitaryElite.Intefaces
{
    public interface IRepair 
    {
        string PartName { get; }

        int HoursWorked { get; }

    }
}
