using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Saga.Music.Interfaces.Models
{
    public class SearchItemModel
    {
        public Saga.Specification.Enumerations.SearchItemTypes Type { get; set; } 

        public int Id { get; set; }
        
        public string Label { get; set; }
        
        public bool? Setting { get; set; }

        public override string ToString()
        {
            return "(" + Type + ") " + Label + " {" + Setting + "} ";
        }
    }
}
