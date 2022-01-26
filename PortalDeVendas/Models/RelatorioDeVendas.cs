using PortalDeVendas.Models.Enums;
using System;

namespace PortalDeVendas.Models
{
    public class RelatorioDeVendas
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Total { get; set; }
        public StatusDeVenda Status { get; set; }
        public Vendedor Vendedor { get; set; }

        public RelatorioDeVendas()
        {

        }
        public RelatorioDeVendas(int id, DateTime data, double total, StatusDeVenda status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Total = total;
            Status = status;
            Vendedor = vendedor;
        }

    }
}
