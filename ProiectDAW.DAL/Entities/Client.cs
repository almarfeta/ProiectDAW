using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectDAW.DAL.Entities
{
    public class Client
    {
        public int ClientId { get; set; }
        public string Nume { get; set; }
        public string Telefon { get; set; }
        public string Email { get; set; }
        public Adresa Adresa { get; set; }
        public ICollection<Cos> Cos { get; set; }

    }
}
