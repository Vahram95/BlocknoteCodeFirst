using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocknotCodeFirst.Entities
{
    class City : Entity
    {
        [Required]
        public string Name { get; set; }

        [Required]
        [ForeignKey(nameof(Country))]
        public int CountryID { get; set; }
        public Country Country { get; set; }

    }
}
