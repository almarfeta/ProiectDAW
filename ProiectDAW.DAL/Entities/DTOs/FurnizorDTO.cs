using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectDAW.DAL.Entities.DTOs
{
    public class FurnizorDTO
    {
        public int FurnizorId { get; set; }
        public string Nume { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public List<Produs> Produse { get; set; }

        public FurnizorDTO(Furnizor furnizor)
        {
            this.FurnizorId = furnizor.FurnizorId;
            this.Nume = furnizor.Nume;
            this.Telefon = furnizor.Telefon;
            this.Email = furnizor.Email;
            this.Produse = new List<Produs>();
        }
    }
}
