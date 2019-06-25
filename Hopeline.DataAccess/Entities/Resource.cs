using Hopeline.DataAccess.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hopeline.DataAccess.Entities
{
    public class Resource : BaseEntity
    {
        [StringLength(20, ErrorMessage = "Can not more than 20 characters")]
        [Required]
        public string user_code { get; set; }
        public byte[] image { get; set; }
        public int enabled_flg { get; set; }
        [Required]
        public string url { get; set; }
        [StringLength(50, ErrorMessage = "Can not more than 50 characters")]
        [Required]
        public string title { get; set; }
        public string desc { get; set; }

        public int resource_categoryId { get; set; }
        public Resource_Category resource_category { get; set; }
    }
}
