using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace MiPrimerProyectoMVC.Models
{
    [Table("Cliente")]
    public partial class Cliente
    {
        [Key]
        [Column("id_cliente")]
        public int IdCliente { get; set; }
        [Column("nombre")]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Column("documento")]
        public int Documento { get; set; }
    }
}
