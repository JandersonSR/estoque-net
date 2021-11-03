using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication4.Models
{
    [Table("itens")]
    public class Item
    {
        [Display(Name = "Id")]
        [Column("id")]
        public int id { get; set; }

        [Display(Name = "descricao")]
        [Column("descricao")]
        public string descricao { get; set; }
    }
}
