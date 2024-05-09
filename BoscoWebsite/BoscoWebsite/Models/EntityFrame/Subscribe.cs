using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoscoWebsite.Models.EntityFrame
{
    [Table("tb_Subscribe")]
    public class Subscribe
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        
        public int Id { get; set;}

        [EmailAddress]
        [Required]
        public string Email { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}