using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback
{
    class Header
    {
        private string headerID;
        private List<HeaderItem> headerItems;

        public string HeaderID { get; set; }
        public List<HeaderItem> HeaderItems { get; set; }

        public void addHeaderItem(HeaderItem item)
        {
            this.headerItems.Add(item);
        }

        public void removeHeaderItem(int index)
        {
            this.headerItems.RemoveAt(index);
        }
    }
}
