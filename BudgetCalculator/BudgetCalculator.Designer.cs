namespace BudgetCalculator
{
    partial class BudgetCalculator
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BudgetCalculator));
            this.lblBudgetRemaining = new System.Windows.Forms.Label();
            this.tbBudgetRemaining = new System.Windows.Forms.TextBox();
            this.lblPayDate = new System.Windows.Forms.Label();
            this.dtPayDate = new System.Windows.Forms.DateTimePicker();
            this.cbIncludeToday = new System.Windows.Forms.CheckBox();
            this.lblDailyBudget = new System.Windows.Forms.Label();
            this.tbDailyBudget = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnCopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBudgetRemaining
            // 
            this.lblBudgetRemaining.AutoSize = true;
            this.lblBudgetRemaining.Location = new System.Drawing.Point(13, 14);
            this.lblBudgetRemaining.Name = "lblBudgetRemaining";
            this.lblBudgetRemaining.Size = new System.Drawing.Size(94, 13);
            this.lblBudgetRemaining.TabIndex = 6;
            this.lblBudgetRemaining.Text = "Budget Remaining";
            // 
            // tbBudgetRemaining
            // 
            this.tbBudgetRemaining.Location = new System.Drawing.Point(16, 30);
            this.tbBudgetRemaining.Name = "tbBudgetRemaining";
            this.tbBudgetRemaining.Size = new System.Drawing.Size(137, 20);
            this.tbBudgetRemaining.TabIndex = 1;
            // 
            // lblPayDate
            // 
            this.lblPayDate.AutoSize = true;
            this.lblPayDate.Location = new System.Drawing.Point(13, 74);
            this.lblPayDate.Name = "lblPayDate";
            this.lblPayDate.Size = new System.Drawing.Size(51, 13);
            this.lblPayDate.TabIndex = 7;
            this.lblPayDate.Text = "Pay Date";
            // 
            // dtPayDate
            // 
            this.dtPayDate.Location = new System.Drawing.Point(16, 90);
            this.dtPayDate.Name = "dtPayDate";
            this.dtPayDate.Size = new System.Drawing.Size(137, 20);
            this.dtPayDate.TabIndex = 2;
            // 
            // cbIncludeToday
            // 
            this.cbIncludeToday.AutoSize = true;
            this.cbIncludeToday.Location = new System.Drawing.Point(178, 92);
            this.cbIncludeToday.Name = "cbIncludeToday";
            this.cbIncludeToday.Size = new System.Drawing.Size(94, 17);
            this.cbIncludeToday.TabIndex = 3;
            this.cbIncludeToday.Text = "Include Today";
            this.cbIncludeToday.UseVisualStyleBackColor = true;
            // 
            // lblDailyBudget
            // 
            this.lblDailyBudget.AutoSize = true;
            this.lblDailyBudget.Location = new System.Drawing.Point(13, 186);
            this.lblDailyBudget.Name = "lblDailyBudget";
            this.lblDailyBudget.Size = new System.Drawing.Size(67, 13);
            this.lblDailyBudget.TabIndex = 9;
            this.lblDailyBudget.Text = "Daily Budget";
            // 
            // tbDailyBudget
            // 
            this.tbDailyBudget.BackColor = System.Drawing.SystemColors.Window;
            this.tbDailyBudget.Location = new System.Drawing.Point(16, 202);
            this.tbDailyBudget.Name = "tbDailyBudget";
            this.tbDailyBudget.ReadOnly = true;
            this.tbDailyBudget.Size = new System.Drawing.Size(137, 20);
            this.tbDailyBudget.TabIndex = 8;
            // 
            // btnCalculate
            // 
            this.btnCalculate.Location = new System.Drawing.Point(16, 140);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(252, 23);
            this.btnCalculate.TabIndex = 4;
            this.btnCalculate.Text = "Calculate";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.Location = new System.Drawing.Point(178, 201);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(90, 23);
            this.btnCopy.TabIndex = 5;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // BudgetCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 244);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.tbDailyBudget);
            this.Controls.Add(this.lblDailyBudget);
            this.Controls.Add(this.cbIncludeToday);
            this.Controls.Add(this.dtPayDate);
            this.Controls.Add(this.lblPayDate);
            this.Controls.Add(this.tbBudgetRemaining);
            this.Controls.Add(this.lblBudgetRemaining);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "BudgetCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Budget Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBudgetRemaining;
        private System.Windows.Forms.TextBox tbBudgetRemaining;
        private System.Windows.Forms.Label lblPayDate;
        private System.Windows.Forms.DateTimePicker dtPayDate;
        private System.Windows.Forms.CheckBox cbIncludeToday;
        private System.Windows.Forms.Label lblDailyBudget;
        private System.Windows.Forms.TextBox tbDailyBudget;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnCopy;
    }
}

