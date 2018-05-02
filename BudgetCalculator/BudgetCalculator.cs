using System;
using System.Configuration;
using System.Globalization;
using System.Windows.Forms;

namespace BudgetCalculator
{
    public partial class BudgetCalculator : Form
    {
        private readonly int _cutOffDay = int.Parse(ConfigurationManager.AppSettings["CutOffDay"]);
        private double _dailyBudget;

        public BudgetCalculator()
        {
            InitializeComponent();
            dtPayDate.Value = DateTime.Today.Day < _cutOffDay ? new DateTime(DateTime.Today.Year, DateTime.Today.Month, _cutOffDay) : new DateTime(DateTime.Today.Year, DateTime.Today.Month + 1, _cutOffDay);
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (tbBudgetRemaining.Text.Length <= 0) return;

            double budgetRemaining;
            DateTime payDate;
            DateTime todayDate = DateTime.Today;
            bool includeToday;

            try
            {
                budgetRemaining = double.Parse(tbBudgetRemaining.Text);
                payDate = dtPayDate.Value.Date;
                includeToday = cbIncludeToday.Checked;
            }
            catch (Exception)
            {
                return;
            }

            int daysLeft = payDate.DayOfYear - todayDate.DayOfYear;
            if (daysLeft <= 0) return;
            if (includeToday) daysLeft++;
            _dailyBudget = budgetRemaining / daysLeft;
            tbDailyBudget.Text = _dailyBudget.ToString(CultureInfo.CurrentCulture);
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            if (tbDailyBudget.Text.Length <= 0) return;
            string clipboard;

            if (Math.Abs(_dailyBudget % 1) <= double.Epsilon * 100)
            {
                clipboard = "£" + _dailyBudget;
            }
            else
            {
                try
                {
                    clipboard = $"£{_dailyBudget.ToString(CultureInfo.CurrentCulture).Substring(0, _dailyBudget.ToString(CultureInfo.CurrentCulture).LastIndexOf('.') + 3)}";
                }
                catch (Exception)
                {
                    clipboard = $"£{_dailyBudget.ToString(CultureInfo.CurrentCulture).Substring(0, _dailyBudget.ToString(CultureInfo.CurrentCulture).LastIndexOf('.') + 2)}0";
                }
            }
            Clipboard.SetText(clipboard);
        }
    }
}
