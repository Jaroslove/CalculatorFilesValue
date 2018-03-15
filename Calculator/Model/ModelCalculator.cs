using Calculator.Model.Counter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model
{
    class ModelCalculator : IModelCalculator
    {
        private Element startFolder = null;

        public int Calculate(PassParam parametrs)
        {
            startFolder = new ElementFolder(parametrs.ChosenPath, new Parser());

            return startFolder.Count(parametrs.Worker, parametrs.E);
        }
    }
}
