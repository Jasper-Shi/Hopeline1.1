using System;
using System.Collections.Generic;
using System.Text;

namespace Hopeline.Service.Models.Base
{
    public class BaseModel : IBaseModel
    {
        public BaseModel()
        {
            dateAdded = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        }
        public int Id { get; set; }
        public string dateAdded { get; set; }
    }
}
