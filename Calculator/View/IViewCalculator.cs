using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.View
{
    interface IViewCalculator
    {
        string ChosenPath { get; }
        int CountedValue { get; set; }
        event EventHandler DoWork;
        BackgroundWorker Worker {get; set;}
    }
}
