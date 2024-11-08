using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_232410101065_utspbo.App.Context
{
    internal class Pengguna
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string nama { get; set; }
        [Required]
        public string nim { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public int semester { get; set; }
        [ForeignKey("M_Prodi")]
        public int id_prodi { get; set; }

    }
}
