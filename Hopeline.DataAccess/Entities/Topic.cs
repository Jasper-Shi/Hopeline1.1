using Hopeline.DataAccess.Entities.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hopeline.DataAccess.Entities
{
    public class Topic : BaseEntity
    {
        [Required]
        [StringLength(20, ErrorMessage = "Can not more than 20 characters")]
        public string user_code { get; set; }
        public int enabled_flg { get; set; }
        [Required]
        [StringLength(50, ErrorMessage = "Can not more than 50 characters")]
        public string topic_name { get; set; }
        public string desc { get; set; }
    }
}
