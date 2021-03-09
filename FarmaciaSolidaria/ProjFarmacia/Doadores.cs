namespace ProjFarmacia
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Doadores
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Doadores()
        {
            Remedios = new HashSet<Remedios>();
            Estoque = new HashSet<Estoque>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Nome { get; set; }

        [Required]
        [StringLength(50)]
        public string Cpf { get; set; }

        [Required]
        [StringLength(150)]
        public string Endereco { get; set; }

        [Required]
        [StringLength(70)]
        public string Bairro { get; set; }

        [Required]
        [StringLength(2)]
        public string Estado { get; set; }

        [Required]
        [StringLength(100)]
        public string Cidade { get; set; }

        [Required]
        [StringLength(20)]
        public string Telefone { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Remedios> Remedios { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Estoque> Estoque { get; set; }

    }
}
