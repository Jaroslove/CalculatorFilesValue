using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model.Counter
{
    class ElementFile : Element
    {
        public ElementFile(string path, IParser parser) : base(path, parser)
        {
            TotalNumberOfFiles++;
        }        
    }
}
