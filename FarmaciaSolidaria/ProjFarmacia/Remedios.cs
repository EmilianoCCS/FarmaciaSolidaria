namespace ProjFarmacia
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Remedios
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Remedios()
        {
            Estoque = new HashSet<Estoque>();
        }

        public int Id { get; set; }

        public int FK_Doadores_Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Nome { get; set; }

        [Column(TypeName = "date")]
        public DateTime Validade { get; set; }

        [Required]
        [StringLength(400)]
        public string PrincipioAtivo { get; set; }

        [Column(TypeName = "date")]
        public DateTime Entrada { get; set; }

        public int Quantidade { get; set; }

        public virtual Doadores Doadores { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Estoque> Estoque { get; set; }
    }
}
