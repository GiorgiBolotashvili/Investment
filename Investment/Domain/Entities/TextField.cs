﻿using Investment;
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

        [Display(Name = "დასახელება (თავსართი)")]
        public override string Title { get; set; } = "საინფორმაციო გვერდი";

        [Display(Name = "სრული აღწერა")]
        public override string Text { get; set; } = "ინფორმაცია კომპანიის საქმიანობის შესახებ";
    }
}
