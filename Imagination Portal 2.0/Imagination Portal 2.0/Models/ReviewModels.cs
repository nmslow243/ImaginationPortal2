using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Imagination_Portal_2._0.Models
{
    public class Review
    {
        public int Id { get; set; }
        public string Comment { get; set; }

        [Required]
        public int Score { get; set; }

        [Required]
        public int SolutionId { get; set; }

        public virtual Solution Solution { get; set; }

        public virtual ApplicationUser User { get; set; }

        public int? UserId { get; set; }

        public Guid userGUID { get; set; }

    }

}