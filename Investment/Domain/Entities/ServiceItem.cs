using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Investment.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "Enter Project Name")]
        [Display(Name = "Project Name")]
        public override string Title { get; set; }

        [Required(ErrorMessage = "შეიყვანეთ პროექტის სახელი")]
        [Display(Name = "დასახელება (თავსართი)")]
        public virtual string TitleGeo { get; set; }

        [Display(Name = "Short description of the project")]
        public override string Subtitle { get; set; }

        [Display(Name = "პროექტის მოკლე აღწერა")]
        public virtual string SubtitleGeo { get; set; }

        [Display(Name = "Full description of the project")]
        public override string Text { get; set; }

        [Display(Name = "პროექტის სრული აღწერა")]
        public virtual string TextGeo { get; set; }
    }
}
