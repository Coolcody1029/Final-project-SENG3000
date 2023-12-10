// CustomerPage.cshtml.cs

using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PizzaStore.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using dbContext = PizzaStore.Data.dbContext;


namespace MyApp.Namespace
{
    public class CustomerPageModel : PageModel
    {
        private readonly dbContext _context; 

        public CustomerPageModel(dbContext context)
        {
            _context = context;
        }

        public List<Customer> Customers { get; set; }

        public void OnGet()
        {
            
            Customers = _context.Set<Customer>().ToList();

            foreach (var customer in Customers)
            {
                Console.WriteLine($"Customer ID: {customer.CustomerId}, Name: {customer.FirstName} {customer.LastName}");
            }
        }
    }
}
