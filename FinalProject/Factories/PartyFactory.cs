using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class PartyFactory
    {
        public PartyFactory()
        {
            _PartyList = new List<Party>();
        }

        protected static List<Party> _PartyList;
        public static IList<Party> createdParties
        {
            get
            {
                return _PartyList.AsReadOnly();
            }
        }

        public static Party newParty()
        {
            Party temp = new Party();
            _PartyList.Add(temp);
            return temp;
        }
        public static Party newParty(int size)
        {
            Party temp = new Party(size);
            _PartyList.Add(temp);
            return temp;
        }
        public static Party newParty(string name)
        {
            Party temp = new Party(name);
            _PartyList.Add(temp);
            return temp;
        }
        public static Party newParty(int size, string name)
        {
            Party temp = new Party(size, name);
            _PartyList.Add(temp);
            return temp;
        }
    }
}