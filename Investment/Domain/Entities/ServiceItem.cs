using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Investment.Domain.Entities
{
    public class ServiceItem : EntityBase
    {
        [Required(ErrorMessage = "შეავსეთ მომსახურების დასახელება")]
        [Display(Name = "მომსახურების დასახელება")]
        public override string Title { get; set; }

        [Display(Name = "მომსახურების მოკლე აღწერა")]
        public override string Subtitle { get; set; }

        [Display(Name = "მომსახურების სრული აღწერა")]
        public override string Text { get; set; }
    }
}
