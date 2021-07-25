﻿using MaterialCalculator.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaterialCalculator.DAL.Context
{
    public class MaterialCalculatorDBContext: DbContext
    {       

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb; Database=MaterialsDB");

        public DbSet<MaterialDto> Materials { get; set; }
        public DbSet<SupplierDto> Suppliers { get; set; }
        public DbSet<OrderListDto> OrderList { get; set; }
    }
}
