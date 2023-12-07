using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    public class PartyFactory
    {
        public PartyFactory()
        {
            privatePartyList = new List<Party>();
        }
        private List<Party> privatePartyList;
        public IList<Party> createdTables
        {
            get
            {
                return privatePartyList.AsReadOnly();
            }
        }

        public Party newParty()
        {
            Party temp = new Party();
            privatePartyList.Add(temp);
            return temp;
        }
        public Party newParty(int size)
        {
            Party temp = new Party(size);
            privatePartyList.Add(temp);
            return temp;
        }
        public Party newParty(string name)
        {
            Party temp = new Party(name);
            privatePartyList.Add(temp);
            return temp;
        }
        public Party newParty(int size, string name)
        {
            Party temp = new Party(size, name);
            privatePartyList.Add(temp);
            return temp;
        }
    }
}
