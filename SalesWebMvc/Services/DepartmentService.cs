using SalesWebMvc.Data;
using SalesWebMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SalesWebMvc.Services
{
    public class DepartmentService
    {
        private readonly SalesWebMvcContext _context; //Previne que a dependência seja alterada

        public DepartmentService(SalesWebMvcContext context)
        {
            _context = context;
        }

        //Foi usado implementação assíncrona, que melhora a velocida de acesso à dados
        //Para isso foi utilizado as Tasks, que é um objeto que encapsula o processamento assíncrono, deixando a programação muito mais fácil
        public async Task<List<Department>> FindAllAsync()
        {
            return await _context.Department.OrderBy(x => x.Name).ToListAsync();
        }
    }
}
