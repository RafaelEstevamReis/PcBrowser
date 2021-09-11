
namespace PcBrowser
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listBoxCategories = new System.Windows.Forms.ListBox();
            this.listBoxInstances = new System.Windows.Forms.ListBox();
            this.listBoxCounters = new System.Windows.Forms.ListBox();
            this.textBoxFilterCategorie = new System.Windows.Forms.TextBox();
            this.textBoxCounterValue = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.listBoxCategories, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBoxInstances, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.listBoxCounters, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxFilterCategorie, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.textBoxCounterValue, 2, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // listBoxCategories
            // 
            this.listBoxCategories.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCategories.FormattingEnabled = true;
            this.listBoxCategories.Location = new System.Drawing.Point(3, 35);
            this.listBoxCategories.Name = "listBoxCategories";
            this.listBoxCategories.Size = new System.Drawing.Size(260, 380);
            this.listBoxCategories.TabIndex = 0;
            this.listBoxCategories.SelectedIndexChanged += new System.EventHandler(this.ListBoxCategoriesSelectedIndexChanged);
            // 
            // listBoxInstances
            // 
            this.listBoxInstances.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxInstances.FormattingEnabled = true;
            this.listBoxInstances.Location = new System.Drawing.Point(269, 35);
            this.listBoxInstances.Name = "listBoxInstances";
            this.listBoxInstances.Size = new System.Drawing.Size(260, 380);
            this.listBoxInstances.TabIndex = 1;
            this.listBoxInstances.SelectedIndexChanged += new System.EventHandler(this.ListBoxInstancesSelectedIndexChanged);
            // 
            // listBoxCounters
            // 
            this.listBoxCounters.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxCounters.FormattingEnabled = true;
            this.listBoxCounters.Location = new System.Drawing.Point(535, 35);
            this.listBoxCounters.Name = "listBoxCounters";
            this.listBoxCounters.Size = new System.Drawing.Size(262, 380);
            this.listBoxCounters.TabIndex = 2;
            this.listBoxCounters.SelectedIndexChanged += new System.EventHandler(this.ListBoxCountersSelectedIndexChanged);
            // 
            // textBoxFilterCategorie
            // 
            this.textBoxFilterCategorie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxFilterCategorie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFilterCategorie.Location = new System.Drawing.Point(3, 3);
            this.textBoxFilterCategorie.Name = "textBoxFilterCategorie";
            this.textBoxFilterCategorie.Size = new System.Drawing.Size(260, 26);
            this.textBoxFilterCategorie.TabIndex = 3;
            this.textBoxFilterCategorie.TextChanged += new System.EventHandler(this.TextBoxFilterCategorieTextChanged);
            // 
            // textBoxCounterValue
            // 
            this.textBoxCounterValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCounterValue.Enabled = false;
            this.textBoxCounterValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCounterValue.Location = new System.Drawing.Point(535, 421);
            this.textBoxCounterValue.Name = "textBoxCounterValue";
            this.textBoxCounterValue.Size = new System.Drawing.Size(262, 26);
            this.textBoxCounterValue.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Performancecounter browser";
            this.Shown += new System.EventHandler(this.Form1Shown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listBoxCategories;
        private System.Windows.Forms.ListBox listBoxInstances;
        private System.Windows.Forms.ListBox listBoxCounters;
        private System.Windows.Forms.TextBox textBoxFilterCategorie;
        private System.Windows.Forms.TextBox textBoxCounterValue;
    }
}

