using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace N32_T2.Models
{
    public class ChatMassage : AuditableEntity
    {
        public int Id { get; set; }
        public string Subject { get; set; }
        public string Massage { get; set; }
        public int ChatId { get; set; }
        public override string createDate { get; set; }
        public override string modifiedDate { get; set; }

        public ChatMassage(int id, string subject, string massage, int chatid)
        {
            Id = id;
            Subject = subject;
            Massage = massage;
            ChatId = chatid;
            
        }
        public override int GetHashCode()
        {
            int hash = 0;
            //int hash = base.GetHashCode();
            hash = hash + Id;
            hash = hash + Subject.GetHashCode();
            hash = hash + Massage.GetHashCode();
            hash = hash + ChatId.GetHashCode();
            return hash;
        }
        public override bool Equals(object? obj)
        {
            return this.GetHashCode() == obj.GetHashCode();
        }
        public override string ToString()
        {
            return $"Id: {Id}   Subject: {Subject}  Massage: {Massage}  ChatId: {ChatId}";
        }
    }
}
