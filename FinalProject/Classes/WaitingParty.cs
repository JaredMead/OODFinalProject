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
            this.phoneNumber = "Not Given";
            if(phone.Count() != 0)
            {
                this.phoneNumber = phone[0];
            }
            waitlist.Add(this);
        }
        public WaitingParty(string name, params string[] phone) : base(name)
        {
            this.phoneNumber = "Not Given";
            if (phone.Count() != 0)
            {
                this.phoneNumber = phone[0];
            }
            waitlist.Add(this);
        }
        public WaitingParty(int size, params string[] phone) : base(size)
        {
            this.phoneNumber = "Not Given";
            if (phone.Count() != 0)
            {
                this.phoneNumber = phone[0];
            }
            waitlist.Add(this);
        }
        public WaitingParty(int size, string name, params string[] phone) : base(size, name)
        {
            this.phoneNumber = "Not Given";
            if (phone.Count() != 0)
            {
                this.phoneNumber = phone[0];
            }
            waitlist.Add(this);
        }
    }
}
