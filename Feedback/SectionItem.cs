using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback
{
    class SectionItem
    {
        private string codeChosen;
        private string title;
        private List<string> codes;
        private string comment;

        public string CodeChosen { get; set; }
        public string Title { get; set; }
        public List<string> Codes { get; set; }
        public string Comment { get; set; }

        public void importCode(string codeID)
        {
            //import the codes from the database and set it to the List<string> codes
        }

        public void addCodes(string newCode)
        {
            this.codes.Add(newCode);
        }

        public void removeCodes(int index)
        {
            this.codes.RemoveAt(index);
        }
    }
}
