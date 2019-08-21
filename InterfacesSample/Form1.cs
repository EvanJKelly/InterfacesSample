using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InterfacesSample
{
    public partial class Form1 : Form
    {
        private readonly ILogger Log;
        public Form1(ILogger logger)
        {
            Log = logger;
            InitializeComponent();
        }

        private void btnLogData_Click(object sender, EventArgs e)
        {
            string input = txtinput.Text;
            log.WriteData(input);
            //instantiate logger
            //log the data

        }
    }
}
