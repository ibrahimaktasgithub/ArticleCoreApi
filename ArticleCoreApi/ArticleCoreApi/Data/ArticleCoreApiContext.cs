using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ArticleCoreApi.Models
{
    public class ArticleCoreApiContext : DbContext
    {
        public ArticleCoreApiContext (DbContextOptions<ArticleCoreApiContext> options)
            : base(options)
        {
        }

        public DbSet<ArticleCoreApi.Models.Article> Article { get; set; }
    }
}
