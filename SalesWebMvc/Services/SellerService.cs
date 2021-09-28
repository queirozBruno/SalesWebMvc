using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Services
{
    public class SellerService
    {
        //Vai ter que ter uma dependência para o DBContext
        private readonly SalesWebMvcContext _context; //Previne que a dependência seja alterada
        
        public SellerService(SalesWebMvcContext context)
        {
            _context = context;
        }

        public List<Seller> FindAll() => _context.Seller.ToList();        

        //Insere um seller no bd
        public void Insert(Seller obj)
        {
            _context.Add(obj);
            _context.SaveChanges();
        }
    }
}
