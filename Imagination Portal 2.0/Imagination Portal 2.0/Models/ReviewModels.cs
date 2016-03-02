using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using System.Data.Entity;

namespace Imagination_Portal_2._0.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Comment { get; set; }

        [Required]
        public int Score { get; set; }

        [Required]
        public int SolutionId { get; set; }

        public virtual Solution Solution { get; set; }
    }

}