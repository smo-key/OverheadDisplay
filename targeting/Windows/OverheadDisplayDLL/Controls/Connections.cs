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
    public sealed partial class Connections : Bases.ControlBase
    {
        private List<ConnectionAssembly> connections;
        public List<ConnectionInfo> createdconnections;
        private ConnectionInfo selected;
        private FlowLayoutPanel otherpanel = null;
        public Connections(List<ConnectionAssembly> connections, List<ConnectionInfo> createdconnections)
        {
            if (Utils.Referenced)
            {
                InitializeComponent();
                this.DoubleBuffered = true;
                this.createdconnections = createdconnections;
                this.connections = connections;
                EnableActivation();
            }
            else { this.Dispose(); }

            Selected.Text = "Connect to Device";
            Selected.Image = null;
            Info.Text = "Press 'Connect to Device' to start a new connection.";
            Rename.Enabled = false;
            Refresh.Enabled = false;
            Disconnect.Enabled = false;
            Other.Visible = false;
            List.Controls.Clear();
            /*Label bad = Info;
            bad.Text = "This displays the motors and sensors on the connection."
            + "\r\nClick 'Connect to Device' to initialize this connection.";
            bad.Name = "bad";
            List.Controls.Add(bad);*/
        }

        internal override void Control_Resize(object sender, EventArgs e)
        {
            base.Control_Resize(sender, e);
            int i = this.Width;
            Selected.Width = i - 12;
            Other.Location = new Point(i - 30, Other.Location.Y);
            Disconnect.Location = new Point(i - 31, Disconnect.Location.Y);
            Refresh.Location = new Point(i - 58, Refresh.Location.Y);
            Rename.Location = new Point(i - 85, Rename.Location.Y);
            Info.Width = i - 94;
            List.Width = i - 14;
            List.Height = this.Height - 141;
            foreach (Control item in List.Controls)
            {
                item.Width = i - 37;
            }
        }

        internal override void CloseForm_Click(object sender, EventArgs e)
        {
            base.CloseForm_Click(sender, e);
        }

        private void Selected_Click(object sender, EventArgs e)
        {
            if (Selected.Text == "Connect to Device")
            {
                NewConnection con = new NewConnection((Bases.DesignBase)this.Parent, this, connections, createdconnections);
                con.ShowDialog();
            }
        }

        public void ConnectionsChanged()
        {
            if (createdconnections.Count < 1)
            {
                Selected.Text = "Connect to Device";
                Selected.Image = null;
                Info.Text = "Press 'Connect to Device' to start a new connection.";
                Rename.Enabled = false;
                Refresh.Enabled = false;
                Disconnect.Enabled = false;
                Other.Visible = false;
                List.Controls.Clear();
                return;
            }
            selected = createdconnections[createdconnections.Count - 1];
            RefreshDetails();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            if (createdconnections.Count < 1)
            {
                Selected.Text = "Connect to Device";
                Selected.Image = null;
                Info.Text = "Press 'Connect to Device' to start a new connection.";
                Rename.Enabled = false;
                Refresh.Enabled = false;
                Disconnect.Enabled = false;
                Other.Visible = false;
                List.Controls.Clear();
                return;
            }
            RefreshDetails();
        }

        private void RefreshDetails()
        {
            Other.Visible = true;
            Selected.Text = "         " + selected.name;
            string status;
            if (selected.brickreference.IsConnected)
            {
                Selected.Image = global::OverheadDisplay.Properties.Resources.StatusAnnotations_Complete_and_ok_32xLG_color;
                status = "Connected";
            }
            else
            {
                Selected.Image = global::OverheadDisplay.Properties.Resources.StatusAnnotations_Critical_32xLG_color;
                status = "Not Connected";
            }

            if (selected.type == Bases.BrickBase.ConnectionType.Bluetooth)
            {
                Info.Text = "Device: " + selected.brickreference.name + "\r\nStatus: " + status + "\r\nBluetooth Port " + selected.port;
            }
            else
            {
                Info.Text = "Device: " + selected.brickreference.name + "\r\nStatus: " + status;
            }

            if (selected.connection.brick.reference.staticname == null)
            {
                Rename.Enabled = true;
            }
            else
            {
                Rename.Enabled = false;
            }

            Refresh.Enabled = true;
            Disconnect.Enabled = true;
            List.Controls.Clear();

            foreach (OverheadDisplay.Bases.Port item in selected.brickreference.ports)
            {
                Label label = new Label();
                item.GetStatus();
                label.AutoEllipsis = true;
                if (item.type == Bases.BrickBase.ControlType.Motor)
                {
                    label.Image = global::OverheadDisplay.Properties.Resources.gear_16xLG;
                }
                else
                {
                    label.Image = global::OverheadDisplay.Properties.Resources.ASCube_16xLG;
                }
                label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                label.Location = new System.Drawing.Point(3, 0);
                label.Name = item.status_ready.ToString();
                label.Size = new System.Drawing.Size(263, 18);
                label.TabIndex = 1;
                label.Text = "       " + item.name + " <" + item.status + ">";
                label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                label.MouseDown += Activate_MouseDown;
                List.Controls.Add(label);
            }

            //Test connections for duplicate names (this can occur after a name changes)

            foreach (ConnectionInfo item in createdconnections)
            {
                string name = item.name;
                if (!CheckNameTest(item.name, item))
                {
                    name = null;
                    if (item.connection.brick.reference.staticname != null)
                    {
                        name = item.connection.brick.reference.staticname;
                        if (!CheckNameTest(name, item))
                        {
                            int i = 2;
                            name = null;
                            while (name == null)
                            {
                                if (CheckNameTest(item.connection.brick.reference.staticname + " (" + i + ")", item))
                                {
                                    name = item.connection.brick.reference.staticname + " (" + i + ")";
                                }
                                i++;
                            }
                        }
                    }
                    else
                    {
                        int i = 1;
                        while (name == null)
                        {
                            if (CheckNameTest(item.connection.name + i.ToString(), item))
                            {
                                name = item.connection.name + i;
                            }
                            i++;
                        }
                    }
                    Selected.Text = "         " + name;
                }

                item.name = name;
            }
        }

        private void Disconnect_Click(object sender, EventArgs e)
        {
            ErrorPopup form = new ErrorPopup((Bases.DesignBase)this.Parent, ErrorCriticality.Question
                , "Are you sure you want to remove and disconnect from this connection?");
            form.ShowDialog();
            if (form.status)
            {
                try
                {
                    selected.brickreference.Disconnect();
                }
                catch (Exception ex)
                {
                    ErrorPopup popup = new ErrorPopup((Bases.DesignBase)this.Parent, ErrorCriticality.Warning
                , "Unable to disconnect from the device.\r\n[" + selected.name + "]  " + ex.Message);
                    popup.ShowDialog();
                    ErrorPopup form2 = new ErrorPopup((Bases.DesignBase)this.Parent, ErrorCriticality.Question
                , "Remove the connection without disconnecting?");
                    form2.ShowDialog();
                    if (!form2.status)
                    {
                        return;
                    }
                }
                createdconnections.Remove(selected);
                ConnectionsChanged();
            }
        }

        private void Rename_Click(object sender, EventArgs e)
        {
            OverheadDisplay.Controls.Rename form = new Rename((Bases.DesignBase)this.Parent, selected.name);
            form.ShowDialog();
            if (form.status == null) { return; }
            foreach (ConnectionInfo item in createdconnections)
            {
                if (item.name == form.status)
                {
                    ErrorPopup popup = new ErrorPopup((Bases.DesignBase)this.Parent, ErrorCriticality.Warning
                , "A device with the same name already exists!");
                    popup.ShowDialog();
                    return;
                }
            }

            selected.name = form.status;
            RefreshDetails();
        }

        private void Other_Click(object sender, EventArgs e)
        {
            if (otherpanel != null)
            {
                DestroyPanel();
                return;
            }
            FlowLayoutPanel panel = new FlowLayoutPanel();
            panel.AutoScroll = true;
            panel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            panel.Location = new System.Drawing.Point(5, 70 + 8);
            panel.Margin = new System.Windows.Forms.Padding(0);
            panel.Name = "otherpanel";
            panel.Size = new System.Drawing.Size(288, 181 - 8);
            panel.TabIndex = 37;
            panel.WrapContents = false;

            foreach (ConnectionInfo item in createdconnections)
            {
                Label label = new Label();
                label.AutoEllipsis = true;
                if (item == selected)
                {
                    label.BackColor = System.Drawing.SystemColors.Highlight;
                    label.ForeColor = Color.White;
                }
                else
                {
                    label.BackColor = System.Drawing.SystemColors.Control;
                    label.ForeColor = Color.Black;
                }                
                if (item.brickreference.IsConnected)
                {
                    label.Image = global::OverheadDisplay.Properties.Resources.StatusAnnotations_Complete_and_ok_16xLG_color;
                }
                else
                {
                    label.Image = global::OverheadDisplay.Properties.Resources.StatusAnnotations_Critical_16xLG_color;
                }
                label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                label.Location = new System.Drawing.Point(3, 0);
                if (item == selected)
                {
                    label.Name = "Selected";
                }
                else
                {
                    label.Name = "Not Selected";
                }
                label.Size = new System.Drawing.Size(263, 18);
                label.TabIndex = 1;

                string name = item.name;
                if (!CheckNameTest(item.name, item))
                {
                    name = null;
                    if (item.connection.brick.reference.staticname != null)
                    {
                        name = item.connection.brick.reference.staticname;
                        if (!CheckNameTest(name, item))
                        {
                            int i = 2;
                            name = null;
                            while (name == null)
                            {
                                if (CheckNameTest(item.connection.brick.reference.staticname + " (" + i + ")", item))
                                {
                                    name = item.connection.brick.reference.staticname + " (" + i + ")";
                                }
                                i++;
                            }
                        }
                    }
                    else
                    {
                        int i = 1;
                        while (name == null)
                        {
                            if (CheckNameTest(item.connection.name + i.ToString(), item))
                            {
                                name = item.connection.name + i;
                            }
                            i++;
                        }
                    }
                    Selected.Text = "         " + name;
                }

                item.name = name;

                label.Text = "       " + name;
                label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                label.MouseDown += Item_MouseDown;
                label.MouseUp += Item_MouseUp;
                label.MouseLeave += Item_MouseLeave;
                label.MouseEnter += Item_MouseEnter;
                label.MouseClick += Item_MouseClick;
                panel.Controls.Add(label);
            }

            Label label2 = new Label();
            label2.AutoEllipsis = true;            
            label2.BackColor = System.Drawing.SystemColors.Control;
            label2.ForeColor = Color.Black;
            label2.Image = global::OverheadDisplay.Properties.Resources.action_add_16xLG;
            label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label2.Location = new System.Drawing.Point(3, 0);
            label2.Name = "AddConnection";
            label2.Size = new System.Drawing.Size(263, 18);
            label2.TabIndex = 1;
            label2.Text = "       Add Connection";
            label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label2.MouseDown += Item_MouseDown;
            label2.MouseUp += Item_MouseUp;
            label2.MouseLeave += Item_MouseLeave;
            label2.MouseEnter += Item_MouseEnter;
            label2.MouseClick += Item_MouseClick;

            panel.Controls.Add(label2);
            Border.Controls.Add(panel);
            panel.BringToFront();
            otherpanel = panel;
            Other.MouseDown -= Activate_MouseDown;
        }

        private bool CheckNameTest(string name, ConnectionInfo info)
        {
            for (int i = 0; i < createdconnections.Count; i++)
            {
                if ((name == createdconnections[i].name) && (createdconnections[i] != info))
                {
                    return false;
                }
            }
            return true;
        }

        private bool CheckNameTest(string name)
        {
            for (int i = 0; i < createdconnections.Count; i++)
            {
                if (name == createdconnections[i].name)
                {
                    return false;
                }
            }
            return true;
        }

        private void Item_MouseClick(object sender, MouseEventArgs e)
        {
            Label s = (Label)sender;
            if (s.Name == "AddConnection")
            {
                RefreshDetails();
                DestroyPanel();
                NewConnection form = new NewConnection((Bases.DesignBase)this.Parent, this, connections, createdconnections);
                form.ShowDialog();
                return;
            }
            string name = s.Text.Trim();
            ConnectionInfo con = null;
            foreach (ConnectionInfo item in createdconnections)
            {
                if (item.name == name)
                {
                    con = item;
                    break;
                }
            }
            selected = con;
            RefreshDetails();
            DestroyPanel();
        }

        private void DestroyPanel()
        {
            otherpanel.Dispose();
            otherpanel = null;
            Other.MouseDown += Activate_MouseDown;
        }

        public override void DeactivateForm()
        {
            base.DeactivateForm();
            if (otherpanel != null)
            {
                DestroyPanel();
            }
        }

        private void Item_MouseEnter(object sender, EventArgs e)
        {
            Label s = (Label)sender;
            if (s.BackColor == SystemColors.Control)
            {
                s.BackColor = SystemColors.ControlLightLight;
                s.ForeColor = Color.Black;
            }
            if (s.BackColor == SystemColors.Highlight)
            {
                s.BackColor = Color.DodgerBlue;
                s.ForeColor = Color.White;
            }
        }

        private void Item_MouseLeave(object sender, EventArgs e)
        {
            Label s = (Label)sender;
            if (s.BackColor == SystemColors.ControlLightLight)
            {
                s.BackColor = SystemColors.Control;
                s.ForeColor = Color.Black;
            }
            if (s.BackColor == Color.DodgerBlue)
            {
                s.BackColor = SystemColors.Highlight;
                s.ForeColor = Color.White;
            }
        }

        private void Item_MouseDown(object sender, MouseEventArgs e)
        {
            Label s = (Label)sender;
            if (s.BackColor == SystemColors.ControlLightLight)
            {
                s.BackColor = SystemColors.HotTrack;
                s.ForeColor = Color.White;
            }
            if (s.BackColor == Color.DodgerBlue)
            {
                s.BackColor = SystemColors.HotTrack;
                s.ForeColor = Color.White;
            }
        }

        private void Item_MouseUp(object sender, MouseEventArgs e)
        {
            Label s = (Label)sender;
            if (s.BackColor == SystemColors.HotTrack)
            {
                if (s.Name == "Selected")
                {
                    s.BackColor = Color.DodgerBlue;
                    s.ForeColor = Color.White;
                }
                else
                {
                    s.BackColor = SystemColors.ControlLightLight;
                    s.ForeColor = Color.Black;
                }
            }
        }

    }
}
