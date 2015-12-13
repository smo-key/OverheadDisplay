using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OverheadDisplay.Bases
{
    public partial class DesignBase : Form
    {
        public DesignBase()
        {
            InitializeComponent();
        }

        //This form allows the DLL to reference calls in the design form
        public virtual Panel ref_TopPanel { get; set; }
        public virtual Panel ref_BottomPanel { get; set; }
        public virtual Controls.Resizer ref_Resizer { get; set; }
    }
}
