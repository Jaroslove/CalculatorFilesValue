using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator.View
{
    public partial class ViewCalculator : Form, IViewCalculator
    {
        private BackgroundWorker worker;
        private string chosenPath;

        public string ChosenPath { get => chosenPath; }

        public ViewCalculator()
        {
            InitializeComponent();

            InitBackWoker();
        }

        private void InitBackWoker()
        {
            worker = new BackgroundWorker();

            worker.DoWork += Worker_DoWork;

            worker.RunWorkerCompleted += Worker_RunWorkerCompleted;

            worker.ProgressChanged += Worker_ProgressChanged;

            worker.WorkerReportsProgress = true;

            worker.WorkerSupportsCancellation = true;
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            throw new NotImplementedException();
        }

        private void ChosePath(object obj, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    lblChosenPath.Text = chosenPath = folderBrowserDialog.SelectedPath;
                }
            }
        }
    }
}
