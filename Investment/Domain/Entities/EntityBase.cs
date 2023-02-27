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

        [Display(Name = "დასახელება (თავსართი)")]
        public virtual string Title { get; set; }

        [Display(Name = "მოკლე აღწერა")]
        public virtual string Subtitle { get; set; }

        [Display(Name = "სრული აღწერა")]
        public virtual string Text { get; set; }

        [Display(Name = "პროექტის სტატუსი")]
        public virtual byte Status { get; set; }

        [Display(Name = "მთავარი ფოტო")]
        public virtual string TitleMainImagePath { get; set; }

        [Display(Name = "დამატებითი ფოტო")]
        public virtual string TitleSecondImagePath { get; set; }

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
