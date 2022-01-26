using System;
using System.Collections.Generic;
using System.Linq;

namespace PortalDeVendas.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime Data { get; set; }
        public double PisoSalarial { get; set; }
        public Departamento Departamento { get; set; }
        public ICollection<RelatorioDeVendas> Vendas { get; set; } = new List<RelatorioDeVendas>();

        public Vendedor()
        {

        }
        public Vendedor(int id, string name, string email, DateTime data, double pisoSalarial, Departamento departamento)
        {
            Id = id;
            Name = name;
            Email = email;
            Data = data;
            PisoSalarial = pisoSalarial;
            Departamento = departamento;
        }

        public void AddVenda(RelatorioDeVendas relVendas) 
        {
            Vendas.Add(relVendas);
        }
        public void RemoveVenda(RelatorioDeVendas relVendas)
        {
            Vendas.Remove(relVendas);
        }
        public double TotalDeVendas(DateTime inicial, DateTime final)
        {
            return Vendas.Where(x => x.Data >= inicial && x.Data <= final).Sum(x => x.Total);
        }
    }
}
