using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model.Counter
{
    class ElementFolder : Element
    {
        private List<Element> list;

        public ElementFolder(string path, IParser parser) : base(path, parser)
        {
            list = new List<Element>();

            if (File.GetAttributes(path).HasFlag(FileAttributes.Directory))
            {
                var allFilesDir = Directory.GetFileSystemEntries(path, "*", SearchOption.TopDirectoryOnly);

                foreach (var item in allFilesDir)
                {
                    if (File.GetAttributes(item).HasFlag(FileAttributes.Directory))
                    {
                        list.Add(new ElementFolder(item, parser));
                    }
                    else if (File.Exists(item) && System.IO.Path.GetExtension(item) == ".txt")
                    {
                        list.Add(new ElementFile(item, parser)); 
                    }
                }
            }
        }

        public override int Count(BackgroundWorker worker = null, DoWorkEventArgs e = null)
        {
            int rezult = 0;

            list.ForEach(item => rezult += item.Count(worker, e));

            return rezult;
        }
    }
}
