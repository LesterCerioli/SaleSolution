using System;
using System.Collections.Generic;
using System.Text;



namespace SaleSolution.Core.Entities
{
    public class City : Entity, IAggregateRoot
    {
        public City(Guid id, string cityname, Guid Id)
        {
            Id = id;
            CityName = CityName;
            StateId = StateId;
        }
        
        
        
        protected City() { }
        public int Id { get; set; }
        public string CityName { get; set; }
        public int StateId { get; set; }


        
    }
    

}
