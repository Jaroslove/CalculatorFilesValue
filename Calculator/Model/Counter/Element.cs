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

            return rezult;
        }
    }
}
