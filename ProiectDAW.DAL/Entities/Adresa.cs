using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectDAW.DAL.Entities
{
    public class Adresa
    {
        public int AdresaId { get; set; }
        public string Strada { get; set; }
        public string Numar { get; set; }
        public string Oras { get; set; }
        public string Judet { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
    }
}
