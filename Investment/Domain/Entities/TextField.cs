using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Investment.Domain.Entities
{
    public class TextField : EntityBase
    {
        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "დასახელება (თავსართი)")]
        public override string Title { get; set; } = "საინფორმაციო გვერდი";

        [Display(Name = "სრული აღწერა")]
        public override string Text { get; set; } = "ინფორმაცია კომპანიის საქმიანობის შესახებ";
    }
}
