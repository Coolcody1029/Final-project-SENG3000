// OrderPage.cshtml.cs

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PizzaStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using dbContext = PizzaStore.Data.dbContext;

namespace MyApp.Namespace
{
    public class OrderPageModel : PageModel
    {
        private readonly dbContext _context; 
        
        public OrderPageModel(dbContext context)
        {
            _context = context;
        }

        public List<Order> Orders { get; set; }

        public void OnGet()
        {
            
            Orders = _context.Set<Order>().ToList();
        }

    }
}
