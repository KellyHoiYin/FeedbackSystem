using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Feedback
{
    class Template
    {
        private Header header;
        private Section section;
        private string name;
        private string author;
        private string desc;

        public Header Header { get; set; }
        public Section Section { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public string Desc { get; set; }

        public void saveTemplate()
        {
            //ToDo save the template to the database
        }

        //modifyHeader
        //modifySection
    }
}
