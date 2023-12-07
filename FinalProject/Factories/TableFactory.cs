using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class TableFactory
    {
        public TableFactory()
        {
            privateTableList = new List<Table>();
        }
        private List<Table> privateTableList;
        public IList<Table> createdTables
        {
            get
            {
                return privateTableList.AsReadOnly();
            }
        }

        public Table newTable(int tableID, int maxPartySize)
        {
            Table temp = new Table(tableID, maxPartySize);
            privateTableList.Add(temp);
            return temp;
        }

    }
}
