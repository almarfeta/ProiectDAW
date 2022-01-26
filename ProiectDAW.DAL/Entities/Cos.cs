using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectDAW.DAL.Entities
{
    public class Cos
    {
        public int CosId { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int ProdusId { get; set; }
        public Produs Produs { get; set; }

    }
}
