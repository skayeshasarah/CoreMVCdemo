using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CoreMVCdemo.data;
using Microsoft.Extensions.DependencyInjection;
using CoreMVCdemo.Models;

namespace CoreMVCdemo.Models
{
    public class seed
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new Bookcontext(
                serviceProvider.GetRequiredService<DbContextOptions<Bookcontext>>()))
            {
                if (context.Books.Any())
                {
                    return;
                }
                context.Books.AddRange(
                    new Book
                    {
                        Btitle = "India short stories",
                        Category = "fiction",
                        Price = 716.00,
                        Authorname = "narayan",
                        publisher = "pengwin",
                        Releasedate = Convert.ToDateTime("10-09-2014")

                    },
                    new Book
                    {
                        Btitle = " american stories",
                        Category = "fiction",
                        Price = 1000.00,
                        Authorname = "pandu",
                        publisher = "kranthi",
                        Releasedate = Convert.ToDateTime("06-08-2016")
                    });
                context.SaveChanges();
            }
        }
    }
}
