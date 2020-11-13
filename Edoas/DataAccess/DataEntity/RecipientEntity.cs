using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edoas.DataAccess.DataEntity
{
    public class RecipientEntity
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public bool IsReaded { get; set; }

        public virtual SentMessageEntity SentMessageEntity { get; set; }
    }
}
