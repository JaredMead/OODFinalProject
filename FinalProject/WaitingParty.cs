using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class WaitingParty: Party
    {
        protected string _phoneNumber;
        public string phoneNumber
        {
            get
            {
                return _phoneNumber;
            }
            set
            {
                _phoneNumber = value;
            }
        }

        public static List<WaitingParty> waitlist = new List<WaitingParty>();

        public WaitingParty(params string[] phone) : base()
        {
            waitlist.Add(this);
            if(phone[0] != null)
            {
                this.phoneNumber = phone[0];
            }
        }
        public WaitingParty(string name, params string[] phone) : base(name)
        {
            waitlist.Add(this);
            if (phone[0] != null)
            {
                this.phoneNumber = phone[0];
            }
        }
        public WaitingParty(int size, params string[] phone) : base(size)
        {
            waitlist.Add(this);
            if (phone[0] != null)
            {
                this.phoneNumber = phone[0];
            }
        }
        public WaitingParty(int size, string name, params string[] phone) : base(size, name)
        {
            waitlist.Add(this);
            if (phone[0] != null)
            {
                this.phoneNumber = phone[0];
            }
        }
    }
}
