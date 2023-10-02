using Ef0010.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ef0010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context=new AppDbContext())
            {
                foreach(var item in context.Sections.Include(x=>x.Course))
                {
                    Console.WriteLine($"Section:{item.SectionName}" +
                        $"         Course{item.Course.CourseName}");
                }
            }
        }
    }
}
