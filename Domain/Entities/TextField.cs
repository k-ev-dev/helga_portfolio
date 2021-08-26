using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Helga_portfolio.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Заголовок публикации")]
        public override string Title { get; set; } = "Заголовок публикации.";

        [Display(Name = "Содержание публикации")]
        public override string Description { get; set; } = "Содержание публикации.";
    }
}
