using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{

    [Table("users")]
    public class Usuario
    {
        [Display(Name = "Id")]
        [Column("id")]
        public int Id { get; set; }

        [Display(Name = "Nome")]
        [Column("nome")]
        public string Nome { get; set; }

        [Display(Name = "Password")]
        [Column("senha")]
        public string Password { get; set; }

        [Display(Name = "Email")]
        [Column("email")]
        public string Email { get; set; }

        [Display(Name = "Endereço")]
        [Column("endereco")]
        public string Endereco { get; set; }

        [Display(Name = "Data_Nasciomento")]
        [Column("data_nascimento")]
        public DateTime Data_Nasciomento { get; set; }
    }
}
