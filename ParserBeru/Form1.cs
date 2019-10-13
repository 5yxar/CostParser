using ParserBeru.Core;
using ParserBeru.Core.Bera;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParserBeru
{
    public partial class Form1 : Form
    {

        ParserWorker<string[]> parser;
        public Form1()
        {
            InitializeComponent();
            parser = new ParserWorker<string[]>(
                new BeraParser()
                );

            parser.OnComleted += Parser_OnCompleted;
            parser.OnNewData += Parser_OnNewData;
        }

        private void Parser_OnNewData(object arg1, string[] arg2)
        {
            ListTitles.Items.AddRange(arg2);
        }

        private void Parser_OnCompleted(object obj)
        {
            MessageBox.Show("All works done!");

        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            parser.Settings = new BeraSettings((int)NumericStart.Value, (int)NumericEnd.Value);
            parser.Start();

        }

        private void ButtonAbort_Click(object sender, EventArgs e)
        {
            parser.Abort();
        }
    }
}
