﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace BoscoWebsite.Models.EntityFrame
{
    [Table("tb_New")]
    public class New :CommonAbstract
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required(ErrorMessage = "Bạn không để trống tiêu đề tin")]
        [StringLength(150)]
        public string Title { get; set; }

        public string Alias { get; set; }

        public string Description { get; set; }

        [AllowHtml]
        public string Detail { get; set; }

        public string Image { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }

        public string SeoTitle { get; set; }
        public string SeoDescription { get; set; }
        public string SeoKeyWords { get; set; }

        public bool IsActive { get; set; }

        public virtual Category Category { get; set; }
    }
}