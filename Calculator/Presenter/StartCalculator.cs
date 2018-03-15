using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Calculator.Model;
using Calculator.View;
using System.Windows.Forms;

namespace Calculator.Presenter
{
    class StartCalculator
    {
        private IModelCalculator model;
        private IViewCalculator view;

        private StartCalculator(IModelCalculator model, IViewCalculator view)
        {
            this.model = model;
            this.view = view;
            view.DoWork += View_DoWork;
        }

        private void View_DoWork(object sender, EventArgs e)
        {
            view.CountedValue = model.Calculate(sender as Model.Counter.PassParam);
        }

        public static Form GetCalculatorForm()
        {
            IModelCalculator model = new ModelCalculator();
            IViewCalculator view = new ViewCalculator();
            new StartCalculator(model, view);

            return (Form)view;
        }
    }
}
