using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SnakeMenu
{
    
    public partial class frmControlInput : Form
    {
        public frmHowTo frmHowTo; // Creating communication between forms.
        public char keyToHandle; // Init public char variable for taking care of which button was pressed in frmHowTo.

        public frmControlInput()
        {
            InitializeComponent();
        }

    }
}
