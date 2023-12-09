// CustomerPage.cshtml.cs

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PizzaStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp.Namespace
{
    public class CustomerPageModel : PageModel
    {
        private readonly DbContext _context; 

        public CustomerPageModel(DbContext context)
        {
            _context = context;
        }

        public List<Customer> Customers { get; set; }

        public void OnGet()
        {
            
            Customers = _context.Customers.ToList();
        }
    }
}
