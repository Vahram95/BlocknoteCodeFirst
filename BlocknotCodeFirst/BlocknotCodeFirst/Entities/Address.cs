using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocknotCodeFirst.Entities
{
    class Address : Entity
    {
        [Required]
        [ForeignKey(nameof(City))]
        public int CityID { get; set; }
        public string Street { get; set; }
        public virtual City City { get; set; }
        public string ZIP { get; set; }
    }
}
