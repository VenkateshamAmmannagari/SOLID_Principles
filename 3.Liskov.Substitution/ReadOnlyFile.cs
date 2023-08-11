using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Liskov.Substitution
{
    public class ReadOnlyFile : File //ILoad
    {
        public string FilePath { get; set; }
        public string FileText { get; set; }
        public string LoadText()
        {
            return "Read only file";
        }
        /// <summary>
        ///  Thorughs expection since it;s for saving
        /// </summary>
        public void SaveText()
        {
            throw new IOException("Can't save");
        }
    }
}
