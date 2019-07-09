using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MVC.PatternLesson.Models
{
    public class MVCPatternLessonContext : DbContext
    {
        public MVCPatternLessonContext (DbContextOptions<MVCPatternLessonContext> options)
            : base(options)
        {
        }

        public DbSet<MVC.PatternLesson.Models.Movie> Movie { get; set; }
    }
}
