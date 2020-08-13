using ArticleCoreApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArticleCoreApi.Data.EFCore
{
    public class EfCoreArticleRepository : EfCoreRepository<Article, ArticleCoreApiContext>
    {
        public EfCoreArticleRepository(ArticleCoreApiContext context) : base(context)
        {

        }
        // We can add new methods specific to the article repository here in the future
    }
}
