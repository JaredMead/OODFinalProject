using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class History
    {
        List<Party> partyHistory = new List<Party>();

        public void addtoHistory(Party selected)
        {
            partyHistory.Add(selected);
        }
    }
}
