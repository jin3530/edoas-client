using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Edoas.DataAccess.DataEntity
{
     public class AttachmentEntity
    {

        [Key]
        public int id { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
        
        public virtual SentMessageEntity SentMessageEntity { get; set; }

    }
}
