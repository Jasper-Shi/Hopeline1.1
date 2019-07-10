using Hopeline.Service.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hopeline.Service.Models
{
    public class ResourceModel : BaseModel
    {
        public string user_code { get; set; }
        public byte[] image { get; set; }
        public int enabled_flg { get; set; }
        public string title { get; set; }
        public string desc { get; set; }
        public string url { get; set; }

        public int resource_CategoryId { get; set; }
        public ResourceCategoryModel resourceCategory { get; set; }
    }
}
