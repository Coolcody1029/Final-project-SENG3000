

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PizzaStore.Entities; 
using System;
using System.Collections.Generic;
using System.Linq;
using dbContext = PizzaStore.Data.dbContext;

namespace MyApp.Namespace
{
    public class InventoryPageModel : PageModel
    {
        private readonly dbContext _context;

        public InventoryPageModel(dbContext context)
        {
            _context = context;
        }

        public List<Product> InventoryItems { get; set; }

        public void OnGet()
        {
            // Fetch inventory items from your database and assign them to InventoryItems
            InventoryItems = _context.Set<Product>().ToList();
        }
    }
}
