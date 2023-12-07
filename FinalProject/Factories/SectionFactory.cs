using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    class SectionFactory
    {
        public SectionFactory()
        {
            _sectionList = new List<Section>();
        }
        
        protected static List<Section> _sectionList;
        public static IList<Section> createdSections
        {
            get
            {
                return _sectionList.AsReadOnly();
            }
        }

        public static Section newSection()
        {
            Section temp = new Section();
            _sectionList.Add(temp);
            return temp;
        }
    }
}
