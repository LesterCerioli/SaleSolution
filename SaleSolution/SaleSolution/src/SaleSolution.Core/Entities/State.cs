using System;
using System.Collections.Generic;
using System.Text;

namespace SaleSolution.Core.Entities
{
    public class State
    {
        public State(Guid id, string StateName)
        {
            Id = id;
            StateName = stateName;

        }


        protected State() { }
        public string Name { get; private set; }

    }
}
