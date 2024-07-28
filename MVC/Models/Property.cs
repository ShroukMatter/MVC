using Microsoft.AspNetCore.DataProtection.KeyManagement;
using static System.Net.Mime.MediaTypeNames;
using System;

namespace MVC.Models
{
    public class Property
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Type { get; set; } //House, Apartment, Commercial
        public string City { get; set; }
        public string State { get; set; }
        public string Address { get; set; }

        public int Bedrooms { get; set; }
        public int Bathrooms { get; set; }
        public int SquareFeet { get; set; }

        public string Status { get; set; } //Available, Sold, Pending

        public Decimal Price { get; set; }

    }
}

