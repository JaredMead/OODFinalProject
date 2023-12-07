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
            _TableList = new List<Table>();
        }
        private static List<Table> _TableList;
        public static IList<Table> createdTables
        {
            get
            {
                return _TableList.AsReadOnly();
            }
        }

        public Table newTable(int tableID, int maxPartySize)
        {
            Table temp = new Table(tableID, maxPartySize);
            _TableList.Add(temp);
            return temp;
        }

    }
}
