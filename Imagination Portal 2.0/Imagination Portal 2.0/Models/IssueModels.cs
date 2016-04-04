using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;
using System.Data.Entity;
using System.Web.Mvc;

namespace Imagination_Portal_2._0.Models
{
    public class Issue
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [UIHint("tinymce_jquery_full"), AllowHtml]
        public string Description { get; set; }
        public int Priority { get; set; }
        public virtual ICollection<Solution> Solutions { get; set; }
    }
}