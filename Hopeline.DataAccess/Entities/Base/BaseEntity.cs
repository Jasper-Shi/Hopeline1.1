using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Hopeline.DataAccess.Entities.Base
{
    public class BaseEntity:IEntity
    {
        [Key]
        public int Id { get; set; }
        public string dateAdded { get; set; }
        public BaseEntity()
        {
            dateAdded = System.DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");
        }
    }
}
