using Investment;
using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Investment.Domain.Entities
{
    public class TextField : EntityBase
    {
        private readonly IStringLocalizer<SharedResource> sharedResource;

        public TextField()
        {

        }
        public TextField(IStringLocalizer<SharedResource> sharedResource)
        {
            this.sharedResource = sharedResource;
        }

        [Required]
        public string CodeWord { get; set; }

        [Display(Name = "Name (Title)")]
        public override string Title { get; set; } = "Information page";

        [Display(Name = "Full description")]
        public override string Text { get; set; } = "Information about the company's activities";
    }
}
