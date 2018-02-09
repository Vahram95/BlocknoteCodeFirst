using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlocknotCodeFirst.Entities
{
    class Record : Entity
    {
        [Required]
        public string Name { get; set; }
        public string SureName { get; set; }
        [Required]
        public string Phone { get; set; }
        public string Email { get; set; }

        [ForeignKey(nameof(Address))]
        public int AddressID { get; set; }
        public virtual Address Address { get; set; }

    }
}
