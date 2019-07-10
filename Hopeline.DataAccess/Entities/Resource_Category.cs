using Hopeline.DataAccess.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hopeline.DataAccess.Entities
{
    public class Resource_Category : BaseEntity
    {
        [Required]
        public string user_code { get; set; }
        [Required]
        public string category_name { get; set; }
        public string category_decription { get; set; }
        public int enable_flg { get; set; }
        public ICollection<Resource> resources { get; set; }
    }
}
