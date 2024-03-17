﻿using Microsoft.EntityFrameworkCore;
using WebAPI_FUN.Models;

namespace WebAPI_FUN.DataContext
{
    public class ApplicationDbContext : DbContext
    {

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) 
        {
        }

        public DbSet<FuncionarioModel> Funcionarios { get; set; }    
    }
}
