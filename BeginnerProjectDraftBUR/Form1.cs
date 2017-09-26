using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BeginnerProjectDraftBUR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            var myBuRatio = Double;
            var mySampleSize = Int32;
            var myCredibilityIndex = Double;
            myCredibiltyIndex == log(myBuRatio) * mySampleSize;

        }
    }
}
