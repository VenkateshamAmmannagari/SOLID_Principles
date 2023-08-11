using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Liskov.Substitution
{
    internal class ReadWriteFile //: ILoad,IWrite
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }
        public string LoadText()
        {
            return "Read only file";
        }
        public void SaveText()
        {
            // code for Saving the text
        }
    }
}
