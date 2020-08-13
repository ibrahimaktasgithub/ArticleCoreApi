using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using ArticleCoreApi.Data;

namespace ArticleCoreApi.Models
{
    public class Article : IEntity
    {
        public int Id { get; set; }

        [Required]
        [StringLength(30, MinimumLength = 2)]
        public string Name { get; set; }

        [Required]
        [StringLength(30)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z""'\s-]*$")]
        public string Writer { get; set; }

        [Required]
        [StringLength(int.MaxValue, MinimumLength = 2)]
        public string Text { get; set; }
    }
}
