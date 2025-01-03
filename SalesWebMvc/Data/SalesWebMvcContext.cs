﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SalesWebMvc.Models;

namespace SalesWebMvc.Data
{
    public class SalesWebMvcContext : DbContext
    {
        public SalesWebMvcContext (DbContextOptions<SalesWebMvcContext> options)
            : base(options)
        {
        }

        public DbSet<DepartmentModel> Departament { get; set; } 
        public DbSet<SalesRecordModel> Record { get; set; }
        public DbSet<SellerModel> Seller { get; set; }   
    }
}
