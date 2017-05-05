namespace Laba7
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Airplane
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Airplane()
        {
            Crewmembers = new HashSet<Crewmember>();
        }

        [Key]
        public int PlaneId { get; set; }

        [Required]
        [StringLength(20)]
        public string Type { get; set; }

        [Required]
        [StringLength(30)]
        public string Model { get; set; }

        public int Places { get; set; }


        public int crewNumb;
        [Column(TypeName = "date")]
        public DateTime Issue { get; set; }

        [Required]
        public byte[] Pic { get; set; }

        public override string ToString()
        {
            string ou;
            ou = "ID: " + PlaneId + "; Модель: " + Model + "; Тип: " + Type + "; Произведён: " + Issue;
            return ou;
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Crewmember> Crewmembers { get; set; }
    }
}
