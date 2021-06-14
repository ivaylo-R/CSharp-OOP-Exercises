using MilitaryElite.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Intefaces
{
    public interface ISpecialisedSoldier : IPrivate
    {
        Corps Corps { get; }


    }
}
