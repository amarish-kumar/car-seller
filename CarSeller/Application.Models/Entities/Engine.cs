using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Entities
{
    public class Engine
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public ICollection<Trim> Trims { get; set; }

        public Engine()
        {
            Trims = new Collection<Trim>();
        }
    }
}
