using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OverheadDisplay.Windows
{
    public partial class Overheads : UserControl
    {
        List<OverheadAssembly> assemblies = null;
        public Overheads(List<OverheadAssembly> assemblies)
        {
            InitializeComponent();
            this.assemblies = assemblies;
        }

    }
}
