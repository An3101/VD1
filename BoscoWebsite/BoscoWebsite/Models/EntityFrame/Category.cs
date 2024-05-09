using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;



namespace BoscoWebsite.Models.EntityFrame
{
    [Table("tb_Category")]
    public class Category : CommonAbstract
    {
        public Category()
        {
            this.news = new HashSet<New>();
        }


        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required(ErrorMessage = "Tên danh mục không được để trống")]
        public string Title { get; set; }

        public string Alias { get; set; }

        public string Link { get; set; }

        //public string TypeCode { get; set; }

        [StringLength(350)]
        public string Description { get; set; }

        [StringLength(150)]
        public string SeoTitle { get; set; }

        [StringLength(150)]
        public string SeoDescription { get; set; }

        [StringLength(150)]
        public string SeoKeyWords { get; set; }
        public int Position { get; set; }
        public bool IsActive { get; set; }

        public ICollection<New> news { get; set; }

        public ICollection<Posts> posts { get; set; }
        

    }
}