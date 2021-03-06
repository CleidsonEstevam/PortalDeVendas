using PortalDeVendas.Data;
using System.Collections.Generic;
using System.Linq;

namespace PortalDeVendas.Models.Services
{
    public class VendedorService 
    {
        private readonly PortalDeVendasContext _context;

        public VendedorService(PortalDeVendasContext context)
        {
            _context = context;
        }

        public List<Vendedor> FindAll() 
        {
            return _context.Vendedor.ToList();
        }
        public void Insert(Vendedor obj) 
        {
            obj.Departamento = _context.Departamento.First();
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
