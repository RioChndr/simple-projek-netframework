using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace website_pertama.Models
{
    public class Anggota
    {
        public String nama { get; set; }
        public String jenis_kelamin { get; set; }
        public String alamat { get; set; }
        public int umur { get; set; }
        public Boolean sudah_punya_pacar { get; set; }
        
    }
}