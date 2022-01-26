using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectDAW.DAL.Entities.DTOs
{
    public class ProdusDTO
    {
        public int ProdusId { get; set; }
        public string Nume { get; set; }
        public float Pret { get; set; }
        public int FurnizorId { get; set; }
        public Furnizor Furnizor { get; set; }
        public List<Cos> Cos { get; set; }

        public ProdusDTO(Produs produs)
        {
            this.ProdusId = produs.ProdusId;
            this.Nume = produs.Nume;
            this.Pret = produs.Pret;
            this.FurnizorId = produs.FurnizorId;
            this.Furnizor = produs.Furnizor;
            this.Cos = new List<Cos>();
        }

    }
}
