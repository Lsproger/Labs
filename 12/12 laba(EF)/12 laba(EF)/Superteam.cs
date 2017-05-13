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
    public partial  class Superteam
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Superteam()
        {
            Superheroes = new HashSet<Superhero>();
        }
        [Key]
        [StringLength(20)]
        public string TeamName { get; set; }

        public string TColor { get; set; }

        public int Id { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual Superhero Superhero { get; set; }
        public virtual ICollection<Superhero> Superheroes { get; set; }
    }
}
