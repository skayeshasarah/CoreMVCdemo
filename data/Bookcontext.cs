using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CoreMVCdemo.Models;
using Microsoft.EntityFrameworkCore;

namespace CoreMVCdemo.data
{
    public class Bookcontext:DbContext
    {
        public Bookcontext(DbContextOptions<Bookcontext> options):base(options)
        {

        }
        public DbSet<Book> Books { get; set; }
    }
}
