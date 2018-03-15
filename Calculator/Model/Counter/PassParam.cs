using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model.Counter
{
    class PassParam
    {
        public string ChosenPath { get; set; }
        public BackgroundWorker Worker { get; set; }
        public DoWorkEventArgs E { get; set; }

        public PassParam(string chosenPath, BackgroundWorker worker, DoWorkEventArgs e)
        {
            ChosenPath = chosenPath;
            Worker = worker;
            E = e;
        }
    }
}
