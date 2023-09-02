using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MiPrimerProyectoMVC.Models
{
    [Table("Servicio")]
    public partial class Servicio
    {
        [Key]
        [Column("id_servicio")]
        public int IdServicio { get; set; }
        [Column("descripcion")]
        [StringLength(100)]
        public string Descripcion { get; set; }
        [Column("valor")]
        public int Valor { get; set; }
    }
}
