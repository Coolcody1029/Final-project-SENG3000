// OrderPage.cshtml.cs

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PizzaStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp.Namespace
{
    public class OrderPageModel : PageModel
    {
        private readonly DbContext _context; 
        
        public OrderPageModel(DbContext context)
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
