

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PizzaStore.Entities; 
using System;
using System.Collections.Generic;
using System.Linq;

namespace MyApp.Namespace
{
    public class InventoryPageModel : PageModel
    {
        private readonly DbContext _context;

        public InventoryPageModel(DbContext context)
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
