using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;

namespace Calculator.Model.Counter
{
    abstract class Element
    {
        public string Path { get; set; }

        public static int TotalNumberOfFiles { get; set; }

        public static int CountedNumberOfFiles { get; set; }

        private IParser parser;

        public Element(string path, IParser parser)
        {
            Path = path;
            this.parser = parser; 
        }

        public virtual int Count(BackgroundWorker worker = null, DoWorkEventArgs e = null)
        {
            var list = parser.Parse(Path);

            int rezult = 0;

            if (worker != null)
            {
                if (worker.CancellationPending)
                {
                    e.Cancel = true;
                }
                else
                {
                    list.ForEach(item => { rezult += item; });

                    CountedNumberOfFiles++;
                    Thread.Sleep(500);
                    worker.ReportProgress((CountedNumberOfFiles / TotalNumberOfFiles) * 100);

                    return rezult;
                }
            }

            list.ForEach(item => { rezult += item; });

            CountedNumberOfFiles++;

            return rezult;
        }
    }
}
