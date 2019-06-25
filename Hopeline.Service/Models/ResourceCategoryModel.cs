using Hopeline.Service.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hopeline.Service.Models
{
    public class ResourceCategoryModel : BaseModel
    {
        public string user_code { get; set; }
        public string category_name { get; set; }
        public string category_decription { get; set; }
        public IEnumerable<ResourceModel> resources { get; set; }
    }
}
