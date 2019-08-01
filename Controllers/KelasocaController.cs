using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using website_pertama.Models;

namespace website_pertama.Controllers
{
    public class KelasocaController : Controller
    {
        // GET: Kelasoca
        public ActionResult Index()
        {
            // link = localhost:1023/kelasoca/index

            DataKelasModel kelas = new DataKelasModel();
            kelas.nama_materi = ".NET Framework";

            kelas.anggotaKelas = new List<Anggota>();
            kelas.anggotaKelas.Add(new Anggota() { nama = "Rio Chandra", alamat = "Bandung", jenis_kelamin = "Laki-laki", sudah_punya_pacar = false, umur = 19 });
            kelas.anggotaKelas.Add(new Anggota() { nama = "Ari", alamat = "bandung", jenis_kelamin = "laki-laki", sudah_punya_pacar = false, umur = 22 });
            kelas.anggotaKelas.Add(new Anggota() { nama = "Annisa", alamat = "bandung", jenis_kelamin = "Perempuan", sudah_punya_pacar = false, umur = 20 });
            kelas.anggotaKelas.Add(new Anggota() { nama = "Hudri", alamat = "bandung", jenis_kelamin = "laki-laki", sudah_punya_pacar = false, umur = 25 });



            return View(kelas);
        }
    }
}