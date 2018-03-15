using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model.Counter
{
    class CountingValues
    {
        public int TotalNumberOfFiles { get; set; }

        public int CurrentCountedNumberOfFiles { get; set; }

        public BackgroundWorker Worker { get; set; }

        public void CountCurrentProgress()
        {
            Worker.ReportProgress((++CurrentCountedNumberOfFiles / TotalNumberOfFiles) * 100 );
        }
    }
}
