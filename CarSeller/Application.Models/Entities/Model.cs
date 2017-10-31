using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models.Entities
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Make Make { get; set; }
        public int MakeId { get; set; }

        public FuelType FuelType { get; set; }
        public int FuelTypeId { get; set; }

        public Trim Trim { get; set; }
        public int TrimId { get; set; }
    }
}
