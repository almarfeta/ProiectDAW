using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectDAW.DAL.Entities
{
    public class Produs
    {
        public int ProdusId { get; set; }
        public string Nume { get; set; }
        public float Pret { get; set; }
        public int FurnizorId { get; set; }
        public Furnizor Furnizor { get; set; }
        public ICollection<Cos> Cos { get; set; }

    }
}
