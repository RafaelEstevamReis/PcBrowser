// -----------------------------------------------------------------------
// 
//      Solution=PcBrowser
//      Project=PcBrowser
//      File=Form1.cs
//      Created=11-09-2021, 10:40
//      Modified=11-09-2021, 11:40
//      Author: bob noordam
// 
// -----------------------------------------------------------------------
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace PcBrowser {
    public partial class Form1 : Form {
        private readonly List<PerformanceCounterCategory> _categories;
        private readonly Timer _timer;
        private PerformanceCounter _counter;

        public Form1() {
            InitializeComponent();
            _categories = PerformanceCounterCategory.GetCategories().ToList();
            _timer = new Timer();
            _timer.Interval = 1000;
            _timer.Enabled = true;
            _timer.Tick += TimerOnTick;
        }

        private void BindData() {
            string catfilter = textBoxFilterCategorie.Text.Trim().ToLower();
            listBoxCategories.DataSource = _categories.Where(x => x.CategoryName.ToLower().IndexOf(catfilter) != -1).ToList();
            listBoxCategories.DisplayMember = "CategoryName";
        }

        private void Form1Shown(object sender, EventArgs e) {
            BindData();
        }

        private void ListBoxCategoriesSelectedIndexChanged(object sender, EventArgs e) {
            PerformanceCounterCategory categorie = listBoxCategories.SelectedItem as PerformanceCounterCategory;
            if (categorie == null) {
                MessageBox.Show(@"categorie error");
                return;
            }
            var instances = categorie.GetInstanceNames().ToList();
            listBoxInstances.DataSource = instances;
            if (!instances.Any()) {
                listBoxCounters.DataSource = null;
            }
            if(categorie.CategoryType == PerformanceCounterCategoryType.SingleInstance)
            {
                var counters = categorie.GetCounters();
                listBoxCounters.DataSource = counters.ToList();
                listBoxCounters.DisplayMember = "CounterName";
            }
        }

        private void ListBoxCountersSelectedIndexChanged(object sender, EventArgs e) {
            _counter = listBoxCounters.SelectedItem as PerformanceCounter;
        }

        private void ListBoxInstancesSelectedIndexChanged(object sender, EventArgs e) {
            PerformanceCounterCategory categorie = listBoxCategories.SelectedItem as PerformanceCounterCategory;
            if (categorie == null) {
                return;
            }
            string instance = listBoxInstances.SelectedItem.ToString();
            var counters = categorie.GetCounters(instance);
            listBoxCounters.DataSource = counters.ToList();
            listBoxCounters.DisplayMember = "CounterName";
        }

        private void TextBoxFilterCategorieTextChanged(object sender, EventArgs e) {
            BindData();
        }

        private void TimerOnTick(object sender, EventArgs e) {
            if (_counter == null) {
                textBoxCounterValue.Text = string.Empty;
                return;
            }
            textBoxCounterValue.Text = _counter.NextValue().ToString();
        }
    }
}