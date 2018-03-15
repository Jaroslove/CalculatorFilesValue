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
        public BackgroundWorker Worker { get; set; }
        public event EventHandler DoWork;

        private string chosenPath;

        //Model.Counter.Element startFolder;

        public string ChosenPath { get => chosenPath; }
        public int CountedValue { get; set; }

        public ViewCalculator()
        {
            InitializeComponent();

            InitBackWoker();
        }

        private void InitBackWoker()
        {
            Worker = new BackgroundWorker()
            {
                WorkerReportsProgress = true,
                WorkerSupportsCancellation = true,
            };

            Worker.DoWork += Worker_DoWork;

            Worker.RunWorkerCompleted += Worker_RunWorkerCompleted;

            Worker.ProgressChanged += Worker_ProgressChanged;

            Worker.WorkerReportsProgress = true;

            Worker.WorkerSupportsCancellation = true;
        }

        private void Worker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            progressBar.Value = e.ProgressPercentage;
        }

        private void Worker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                lblResult.Text = e.Error.Message;
            }
            else if(e.Cancelled)
            {
                lblResult.Text = "The current task was canceled!";
            }
            else
            {
                lblResult.Text = e.Result.ToString();
            }
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;

            Calculate(e.Argument.ToString(), worker, e);

            e.Result = CountedValue;
            //e.Result = Calculate(e.Argument.ToString(), worker, e);
        }

        private void ChosePath(object obj, EventArgs e)
        {
            using (FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog())
            {
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    lblChosenPath.Text = chosenPath = folderBrowserDialog.SelectedPath;

                    Worker.RunWorkerAsync(chosenPath);
                }
            }
        }

        private void Calculate(string chosenPath, BackgroundWorker worker, DoWorkEventArgs e)
        {
            var passParam = new Model.Counter.PassParam(chosenPath, worker, e);

            DoWork?.Invoke(passParam, null);
            //startFolder = new Model.Counter.ElementFolder(chosenPath, new Model.Counter.Parser());

            //return CountedValue = startFolder.Count(worker, e);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Worker.CancelAsync();
        }
    }
}
