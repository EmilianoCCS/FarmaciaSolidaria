 namespace ProjFarmacia
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Estoque")]
    public partial class Estoque
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? IdDoador { get; set; }

        public int IdInstituicao { get; set; }

        public int IdRemedio { get; set; }

        [Column(TypeName = "date")]
        public DateTime DataSaida { get; set; }

        public virtual Doadores Doadores { get; set; }

        public virtual Instituicoes Instituicoes { get; set; }

        public virtual Remedios Remedios { get; set; }
    }
}
