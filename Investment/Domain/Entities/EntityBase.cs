using Microsoft.Extensions.Localization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Investment.Domain.Entities
{
    public abstract class EntityBase
    {

        protected EntityBase() => DateAdded = DateTime.UtcNow;

        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Name (Title)")]
        public virtual string Title { get; set; }

        [Display(Name = "დასახელება (თავსართი)")]
        public virtual string TitleGeo { get; set; }

        [Display(Name = "Short description")]
        public virtual string Subtitle { get; set; }

        [Display(Name = "მოკლე აღწერა")]
        public virtual string SubtitleGeo { get; set; }

        [Display(Name = "Full description")]
        public virtual string Text { get; set; }

        [Display(Name = "სრული აღწერა")]
        public virtual string TextGeo { get; set; }

        [Display(Name = "Project status")]
        public virtual byte Status { get; set; }

        [Display(Name = "Main photo")]
        public virtual string TitleMainImagePath { get; set; }

        [Display(Name = "Second Photo")]
        public virtual string TitleSecondImagePath { get; set; }

        [Display(Name = "Top Project")]
        public bool IsFavorit { get; set; }

        [Display(Name = "დასახელები SEO მეტატეგი")]
        public  string MetaTitle { get; set; }

        [Display(Name = "აღწერის SEO მეტატეგი")]
        public  string MetaDescription { get; set; }

        [Display(Name = "კლავიშების SEO მეტატეგი")]
        public  string MetaKeywords { get; set; }


        [DataType(DataType.Time)]
        public  DateTime DateAdded { get; set; }

    }
}
