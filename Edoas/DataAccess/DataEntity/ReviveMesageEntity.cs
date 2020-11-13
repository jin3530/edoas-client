using SQLite.CodeFirst;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edoas.DataAccess.DataEntity
{
    public class ReviveMesageEntity
    {
        [Key]
        public int id { get; set; }
        [Unique,Required]
        public string Uid { get; set; }
        public string Title { get; set; }
        public string ShortTitle
        {
            get
            {
                if (Title.Length > 10)
                {
                    return Title.Substring(0, 10) + "...";
                }
                return Title;
            }
        }
        public string Date { get; set; }
        public string Context { get; set; }
        public string ShortContext
        {
            get
            {
                if (Context.Length > 30)
                {
                    return Context.Substring(0, 30) + "...";
                }
                return Context;
            }
        }
        public virtual ICollection<AttachmentEntity> Attachments { get; set; }
        public bool HasAttachment
        {
            get { return Attachments.Count > 0; }
        }
        public override bool Equals(object obj)
        {
            if (obj == null)
            {
                return false;
            }
            if ((obj.GetType().Equals(this.GetType())) == false)
            {
                return false;
            }
            ReviveMesageEntity temp = null;
            temp = (ReviveMesageEntity)obj;

            return this.Uid.Equals(temp.Uid);

        }

        //重写GetHashCode方法（重写Equals方法必须重写GetHashCode方法，否则发生警告

        public override int GetHashCode()
        {
            return this.Uid.GetHashCode();
        }
        public string Sender { get; set; }
        public string SenderId { get; set; }
    }
}
