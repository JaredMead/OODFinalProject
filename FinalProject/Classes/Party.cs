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
        #region Properties
        protected int _ID;
        public int ID
        {
            get
            {
                return _ID;
            }
        }
        protected string _name;
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        protected string _phone;
        public string phone
        {
            get
            {
                return _name;
            }
            set
            {
                _phone = value;
            }
        }
        #endregion
        
        public int partySize;
        // a timer to log how long a table has been here
        public Stopwatch timer = new Stopwatch();
        public long time;
        //count is used for asinging table IDs
        private static int count = 0;

        #region Constructors
        public Party()
        {
            count++;
            this._ID = count;
            this.name = "Default";
            this.partySize = 1;
            this.timer.Start();
        }
        public Party(int size)
        {
            count++;
            this._ID = count;
            this.name = "Default";
            this.partySize = size;
            this.timer.Start();
        }
        public Party(string name)
        {
            count++;
            this._ID = count;
            this.name = name;
            this.partySize = 1;
            this.timer.Start();
        }
        public Party(int size, string name)
        {
            count++;
            this._ID = count;
            this.name = name;
            this.partySize = size;
            this.timer.Start();
        }
        #endregion

        ~Party()
        {
        }
    }
}
