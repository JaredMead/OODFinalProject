using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class Layout
    {
        string layoutName;

        List<Table> tables = new List<Table>();

        List<Section> sections = new List<Section>();

        public Layout()
        {
            //open create table tool
        }

        void saveLayout()
        {
            //save the data of all section and assigned tables
        }
        ~Layout()
        {
            //delete all saved data about the layout

            //delete any displayed sections and tables
        }
    }
}
