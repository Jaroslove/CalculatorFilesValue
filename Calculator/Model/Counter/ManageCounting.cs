using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.Model.Counter
{
    class ManageCounting
    {
        private Element startFolder;

        private BackgroundWorker worker;

        public ManageCounting(BackgroundWorker worker, Element startFolder)
        {
            this.worker = worker;
            this.startFolder = startFolder;
        }


    }
}
