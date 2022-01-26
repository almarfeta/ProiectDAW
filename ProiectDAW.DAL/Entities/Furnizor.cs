using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectDAW.DAL.Entities
{
    public class Furnizor
    {
        public int FurnizorId { get; set; }
        public string Nume { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public ICollection<Produs> Produse { get; set; }
    }
}
