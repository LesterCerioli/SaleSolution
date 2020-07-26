using System;
using System.Collections.Generic;
using System.Text;


namespace SaleSolution.Core.Commands
{
    public abstract class CityCommand : Command
    {
        public int Id { get; set; }
        public string CityName { get; set; }
        public int StateId { get; set; }
    }
}
