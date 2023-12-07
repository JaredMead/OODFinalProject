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
            sectionList = new List<Section>();
        }
        
        private List<Section> sectionList;
        public IList<Section> createdSections
        {
            get
            {
                return sectionList.AsReadOnly();
            }
        }

        public Section newSection()
        {
            Section temp = new Section();
            sectionList.Add(temp);
            return temp;
        }
    }
}
