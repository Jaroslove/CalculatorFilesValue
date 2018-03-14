using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model.Counter
{
    interface IParser
    {
        List<int> Parse(string path);

        List<int> ParseFromString(string[] str);
    }
}
