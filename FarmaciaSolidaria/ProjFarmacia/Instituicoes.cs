namespace ProjFarmacia
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Instituicoes
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Instituicoes()
        {
            Estoque = new HashSet<Estoque>();
        }

        public int Id { get; set; }

        [Required]
        [StringLength(150)]
        public string Nome { get; set; }

        [Required]
        [StringLength(200)]
        public string Endereco { get; set; }

        [Required]
        [StringLength(100)]
        public string Bairro { get; set; }

        [Required]
        [StringLength(2)]
        public string UF { get; set; }

        [Required]
        [StringLength(70)]
        public string Cidade { get; set; }

        [Required]
        [StringLength(50)]
        public string CNPJ { get; set; }

        [Required]
        [StringLength(15)]
        public string Telefone { get; set; }

        [Required]
        [StringLength(80)]
        public string Email { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Estoque> Estoque { get; set; }
    }
}
