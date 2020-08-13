using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ArticleCoreApi.Data;

namespace ArticleCoreApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public abstract class ArticleCoreDBController<TEntity, TRepository> : ControllerBase
        where TEntity : class, IEntity
        where TRepository : IRepository<TEntity>
    {
        private readonly TRepository repository;

        public ArticleCoreDBController(TRepository repository)
        {
            this.repository = repository;
        }


        // GET: api/[controller]
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TEntity>>> Get()
        {
            return await repository.GetAll();
        }

        // GET: api/[controller]/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TEntity>> Get(int id)
        {
            var article = await repository.Get(id);
            if (article == null)
            {
                return NotFound();
            }
            return article;
        }

        // PUT: api/[controller]/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Put(int id, TEntity article)
        {
            if (id != article.Id)
            {
                return BadRequest();
            }
            await repository.Update(article);
            return NoContent();
        }

        // POST: api/[controller]
        [HttpPost]
        public async Task<ActionResult<TEntity>> Post(TEntity article)
        {
            await repository.Add(article);
            return CreatedAtAction("Get", new { id = article.Id }, article);
        }

        // DELETE: api/[controller]/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TEntity>> Delete(int id)
        {
            var article = await repository.Delete(id);
            if (article == null)
            {
                return NotFound();
            }
            return article;
        }

    }
}
