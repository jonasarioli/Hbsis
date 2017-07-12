using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace HBSIS_Test_Clients.Models
{
    [Table("Cliente")]
    public partial class Cliente
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Nome { get; set; }

        [Required]
        public string Codigo { get; set; }

        [Required]
        public string Telefone { get; set; }

        [Required]
        public string Documento { get; set; }
            
    }    
}