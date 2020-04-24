﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pos
{
 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double total = 0.0d;

        

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.AddRange(new object[] { "正常收费", "满300减100", "打8折"});
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CashContext cc = null;
            switch (comboBox1.SelectedItem.ToString())
            {
                case "正常收费":
                    cc = new CashContext(new CashNormal());
                    break;
                case "满300减100":
                    cc = new CashContext(new CashReturn("300", "100"));
                    break;
                case "打8折":
                    cc = new CashContext(new CashRebate("8"));
                    break;
            }

            double totalPrices = 0d;
            totalPrices = cc.GetResult(Convert.ToDouble(textBox1.Text) * Convert.ToDouble(textBox2.Text));
            total = total + totalPrices;
            listBox1.Items.Add("单价: " + textBox1.Text + "数量：" + textBox2.Text + " " + comboBox1.SelectedItem + "合计：" + totalPrices.ToString());
            label5.Text = total.ToString();
        }
    }
}
