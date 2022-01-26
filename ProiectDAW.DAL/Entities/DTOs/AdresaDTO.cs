using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectDAW.DAL.Entities.DTOs
{
    public class AdresaDTO
    {
        public int AdresaId { get; set; }
        public string Strada { get; set; }
        public string Numar { get; set; }
        public string Oras { get; set; }
        public string Judet { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }

        public AdresaDTO(Adresa adresa)
        {
            this.AdresaId = adresa.AdresaId;
            this.Strada = adresa.Strada;
            this.Numar = adresa.Numar;
            this.Oras = adresa.Oras;
            this.Judet = adresa.Judet;
            this.ClientId = adresa.ClientId;
            this.Client = adresa.Client;
        }
    }
}
