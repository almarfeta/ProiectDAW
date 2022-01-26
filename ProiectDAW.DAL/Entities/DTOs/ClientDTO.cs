using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectDAW.DAL.Entities.DTOs
{
    public class ClientDTO
    {
        public int ClientId { get; set; }
        public string Nume { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public Adresa Adresa { get; set; }
        public List<Cos> Cos { get; set; }

        public ClientDTO(Client client)
        {
            this.ClientId = client.ClientId;
            this.Nume = client.Nume;
            this.Telefon = client.Telefon;
            this.Email = client.Email;
            this.Adresa = client.Adresa;
            this.Cos = new List<Cos>();
        }

    }
}
