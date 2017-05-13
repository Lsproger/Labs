using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.Spatial;

namespace _12_laba_EF_
{
    public partial class Superhero
    {

        public Superhero()
        {
            Superteams = new HashSet<Superteam>();
        }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(20)]
        public string SuperMight { get; set; }

        public int Age { get; set; }

        [Required]
        public string TeamName { get; set; }

        [Key]
        public int Id { get; set; }
        [ForeignKey("TeamName")]
        public virtual Superteam Superteam{ get; set; }
        public virtual ICollection<Superteam> Superteams { get; set; }
    }
}
