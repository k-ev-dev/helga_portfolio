using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Helga_portfolio.Domain.Entities
{
    public class SinglePhoto : EntityBase
    {
        [Required(ErrorMessage = "Добавьте фотографию")]
        [Display(Name = "Фотография")]
        public override string TitleImagePath { get; set; }       


    }
}
