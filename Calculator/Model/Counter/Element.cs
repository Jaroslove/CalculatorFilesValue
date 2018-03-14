using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model.Counter
{
    abstract class Element
    {
        public string Path { get; set; }

        public static int TotalNumberOfFiles { get; set; } = 0;

        private IParser parser;

        public Element(string path, IParser parser)
        {
            Path = path;
            this.parser = parser; 
        }

        public virtual int Count()
        {
            var list = parser.Parse(Path);

            int rezult = 0;

            list.ForEach(item => { rezult += item; });

            TotalNumberOfFiles--;

            return rezult;
        }
    }
}
