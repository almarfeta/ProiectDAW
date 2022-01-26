using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProiectDAW.DAL.Entities.DTOs
{
    public class CosDTO
    {
        public int CosId { get; set; }
        public int ClientId { get; set; }
        public Client Client { get; set; }
        public int ProdusId { get; set; }
        public Produs Produs { get; set; }

        public CosDTO(Cos cos)
        {
            this.CosId = cos.CosId;
            this.ClientId = cos.ClientId;
            this.Client = cos.Client;
            this.ProdusId = cos.ProdusId;
            this.Produs = cos.Produs;
        }

    }
}
