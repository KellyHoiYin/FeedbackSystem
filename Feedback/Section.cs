using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback
{
    class Section
    {
        private string sectionID;
        private List<SectionItem> sectionItems;

        public string SectionID { get; set; }
        public List<string> SectionItems { get; set; }

        public void addSectionItem(SectionItem item)
        {
            this.sectionItems.Add(item);
        }

        public void removeSectionItem(int index)
        {
            this.sectionItems.RemoveAt(index);
        }

        //editComments(int index)
        //chooseCode(int indexForItem,int indexForCode)
    }
}
