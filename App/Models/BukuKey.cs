using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_232410101065_utspbo.App.Models
{
    internal class BukuKey
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string judul { get; set; }
        [Required]
        public string pengarang { get; set; }
        [Required]
        public string tahun_terbit { get; set; }
        [Required]
    }

}
