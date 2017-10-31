using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Entities
{
    public class Trim
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Engine Engine { get; set; }
        public int EngineId { get; set; }

        public ICollection<Model> Models { get; set; }

        public Trim()
        {
            Models = new Collection<Model>();
        }
    }
}
