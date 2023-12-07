using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class Party
    {
        int guestID;

        public string partyName;

        string phoneNumber;

        public int partySize;

        public Stopwatch timer = new Stopwatch();
        public long time;

        private static int count = 0;

        #region Constructors
        public Party()
        {
            count++;
            this.guestID = count;
            this.partyName = "Default";
            this.partySize = 1;
            this.timer.Start();
        }
        public Party(int size)
        {
            count++;
            this.guestID = count;
            this.partyName = "Default";
            this.partySize = size;
            this.timer.Start();
        }
        public Party(string name)
        {
            count++;
            this.guestID = count;
            this.partyName = name;
            this.partySize = 1;
            this.timer.Start();
        }
        public Party(int size, string name)
        {
            count++;
            this.guestID = count;
            this.partyName = name;
            this.partySize = size;
            this.timer.Start();
        }
        #endregion


        ~Party()
        {
        }
    }
}
