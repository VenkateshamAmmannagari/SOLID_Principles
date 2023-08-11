using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Liskov.Substitution
{
    internal class SQLFileManager:File
    {
        public List<File> allFiles { get;set; }
        //public List<ILoad> loadAllFiles { get; set; }
        //public List<IWrite> writeAllFiles { get; set; }

        public string GetTextFromFiles()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in allFiles)
            {
                sb.Append(item.LoadText());
            }
            return sb.ToString();
        }

        public void SaveTextIntoFiles()
        {
            foreach (var item in allFiles)
            {
                if (!(item is ReadOnlyFile)) // condition which is voilating the LS
                    item.SaveText();
            }
        }
    }
}
