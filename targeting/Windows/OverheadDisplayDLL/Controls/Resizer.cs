using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace OverheadDisplay.Controls
{
    public partial class Resizer : UserControl
    {
        public Resizer()
        {
            InitializeComponent();
            this.brush = Brushes.Black;
            IsPopup = false;
        }
        public Resizer(Brush color)
        {
            InitializeComponent();
            this.brush = color;
            IsPopup = false;
        }

        private Point _distance = new Point(20, 20);

        private void MoveThis()
        {
            try
            {
                this.Location = new Point(parent.Size.Width - distance.X, parent.Size.Height - distance.Y);
            }
            catch { }
        }

        public Point distance
        {
            get
            {
                return _distance;
            }
            set
            {                
                _distance = value;
                MoveThis();
            }
        }
        public Control parent { get; set; }
        public bool IsPopup { get; set; }
        public Brush brush { get; set; }
        Graphics gfx = null;
        private void Resizer_Paint(object sender, PaintEventArgs e)
        {            
            gfx = e.Graphics;
            Pen pen = new Pen(Color.Black);            
            int x = -1;
            for (int i = 10; i <= 16; i = i+2)
            {
                x++;
                for (int j = 16; j >= 16 - (x * 2); j = j-2)
                {
                    Point point = new Point(i, j);
                    gfx.FillRegion(brush, new Region(new Rectangle(i, j, 1, 1))); ;
                }
            }
            MoveThis();
        }        
        
        #region Drag
        private int locx = 0;
        private int locy = 0;
        private int sizex = 0;
        private int sizey = 0;
        private bool drag = false;
        private void Resizer_MouseDown(object sender, MouseEventArgs e)
        {
            //locx and locy = the mouse's position ON THE FORM
            locx = MousePosition.X;
            locy = MousePosition.Y;
            sizex = parent.Size.Width;
            sizey = parent.Size.Height;
            drag = true;
            if (!IsPopup)
            {
                Bases.DesignBase form = (Bases.DesignBase)parent.Parent;
                if (parent.Parent != null) { form = (Bases.DesignBase)parent.Parent; }
                else
                {
                    form = (Bases.DesignBase)parent;
                }
                Utils.BringToFront(form);
            }
            else
            {
                parent.BringToFront();
            }
        }

        private void Resizer_MouseMove(object sender, MouseEventArgs e)
        {
            if (drag == true)
            {
                if (e.Button == MouseButtons.Left)
                {
                    //this.Location = new Point(MousePosition.X - locx, MousePosition.Y - locy);
                    int a = sizex + (MousePosition.X - locx);
                    int b = sizey + (MousePosition.Y - locy);
                    if ((a > parent.MaximumSize.Width) && (parent.MaximumSize.Width != 0)) { a = parent.MaximumSize.Width; }
                    if ((a < parent.MinimumSize.Width) && (parent.MaximumSize.Width != 0)) { a = parent.MinimumSize.Width; }
                    if ((b > parent.MaximumSize.Height) && (parent.MaximumSize.Height != 0)) { b = parent.MaximumSize.Height; }
                    if ((b < parent.MinimumSize.Height) && (parent.MaximumSize.Height != 0)) { b = parent.MinimumSize.Height; }
                    parent.Size = new Size(a, b);
                    MoveThis();
                    this.BringToFront();
                }
                else
                {
                    drag = false;
                }
            }
        }
        #endregion

    }
}
