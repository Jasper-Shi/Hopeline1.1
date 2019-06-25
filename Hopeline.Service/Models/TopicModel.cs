using Hopeline.Service.Models.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Hopeline.Service.Models
{
    public class TopicModel : BaseModel
    {
        public string user_code { get; set; }
        public int enabled_flg { get; set; }
        public string topic_name { get; set; }
        public string desc { get; set; }
    }
}
