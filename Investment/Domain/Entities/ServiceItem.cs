using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Investment.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "შეიყვანეთ პროექტის დასახელება")]
        [Display(Name = "პროექტის დასახელება")]
        public override string Title { get; set; }

        [Display(Name = "პროექტის მოკლე აღწერა")]
        public override string Subtitle { get; set; }

        [Display(Name = "პროექტის სრული აღწერა")]
        public override string Text { get; set; }
    }
}
