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
    public sealed partial class NewConnection : Bases.PopupBase
    {
        private List<ConnectionAssembly> connections;
        private List<ConnectionInfo> createdconnections;
        private ConnectionAssembly connection;
        private Bases.DesignBase reference;
        private Connections parentreference;
        public NewConnection(Bases.DesignBase reference, Connections parentreference, List<ConnectionAssembly> connections
            , List<ConnectionInfo> createdconnections)
            : base(reference)
        {
            if (Utils.Referenced)
            {
                InitializeComponent();
                this.DoubleBuffered = true;
                this.connections = connections;
                this.createdconnections = createdconnections;
                this.reference = reference;
                this.parentreference = parentreference;
                EnableActivation();
            }
            else { this.Dispose(); }
                        
            Type.SelectedText = "Bluetooth";
            this.Height = 256;
            DrawConnections();
        }

        private void DrawConnections()
        {
            List.Controls.Clear();
            if (connections.Count == 0)
            {
                Label label = new Label();
                label.AutoSize = true;
                label.Text = "\r\nThere are no available connections.\r\nClick 'Download Drivers' above to download some.";
                label.Name = "null";
                label.BringToFront();
                List.Controls.Add(label);
                return;
            }

            foreach (ConnectionAssembly item in connections)
            {
                AddItem(item);
            }
        }

        private void AddItem(ConnectionAssembly connection)
        {
            Label label = new Label();
            label.AutoEllipsis = true;
            label.Image = global::OverheadDisplay.Properties.Resources.reference_16xLG;
            label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label.Location = new System.Drawing.Point(3, 0);
            label.Name = connection.id;
            label.Size = new System.Drawing.Size(243, 18);
            label.TabIndex = 1;
            label.Text = "       " + connection.name;
            label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            label.MouseDown += Item_MouseDown;
            label.MouseEnter += Item_MouseEnter;
            label.MouseClick += Item_MouseClick;
            label.MouseLeave += Item_MouseLeave;
            label.MouseUp += Item_MouseUp;
            List.Controls.Add(label);
        }


        internal override void Control_Resize(object sender, EventArgs e)
        {
            base.Control_Resize(sender, e);
        }

        internal override void CloseForm_Click(object sender, EventArgs e)
        {
            base.CloseForm_Click(sender, e);
        }

        private void Online_Click(object sender, EventArgs e)
        {
                      
        }

        private void Item_MouseEnter(object sender, EventArgs e)
        {
            Label s = (Label)sender;
            if (s.Name == "null") { return; }
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
            if (s.Name == "null") { return; }
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
            if (s.Name == "null") { return; }
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
            if (s.Name == "null") { return; }
            if (s.BackColor == SystemColors.HotTrack)
            {
                if (s.Name.StartsWith("ON:"))
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

        private void Item_MouseClick(object sender, MouseEventArgs e)
        {
            Label s = (Label)sender;
            if (s.Name == "null") { return; }
            if (!s.Name.StartsWith("ON:"))            
            {
                foreach (Label item in List.Controls.OfType<Label>())
                {
                    item.BackColor = SystemColors.Control;
                    item.ForeColor = Color.Black;
                    item.Name = item.Name.Replace("ON:", "");           
                }
                s.BackColor = Color.DodgerBlue;
                s.ForeColor = Color.White;
                s.Name = "ON:" + s.Name;
                this.Height = 405;

                //Get library from name
                //Get list of created connections and libraries to create name (ex. Arduino1)

                string id = s.Name.Replace("ON:", "");
                ConnectionAssembly _connection = null;
                foreach (ConnectionAssembly item in connections)
                {
                    if (item.id == id)
                    {
                        _connection = item;
                        break;
                    }
                }

                string name = null;
                if (_connection.brick.reference.staticname != null)
                {
                    name = _connection.brick.reference.staticname;
                    if (!CheckNameStart(name))
                    {
                        int n = 2;
                        name = null;
                        while (name == null)
                        {
                            if (CheckNameStart(_connection.brick.reference.staticname + " (" + n + ")"))
                            {
                                name = _connection.brick.reference.staticname + " (" + n + ")";
                            }
                            n++;
                        }
                    }
                    ConnName.Enabled = false;
                }
                else
                {
                    int n = 1;                    
                    while (name == null)
                    {
                        if (CheckNameStart(_connection.name + n.ToString()))
                        {
                            name = _connection.name + n;
                        }
                        n++;
                    }
                    ConnName.Enabled = true;
                }


                ConnName.Text = name;
                Type.Items.Clear();
                foreach (Bases.BrickBase.ConnectionType item in _connection.brick.supportedtypes)
                {
                    switch (item)
                    {
                        case OverheadDisplay.Bases.BrickBase.ConnectionType.Bluetooth:
                            Type.Items.Add("Bluetooth");                            
                            break;
                        case OverheadDisplay.Bases.BrickBase.ConnectionType.USB:
                            Type.Items.Add("USB");  
                            break;
                        case OverheadDisplay.Bases.BrickBase.ConnectionType.WiFi:
                            Type.Items.Add("WiFi");  
                            break;
                        default:
                            break;
                    }
                }
                Type.SelectedIndex = 0;
                Port.Text = "1";
                UpdateType();
                connection = _connection;
            }
        }

        private bool CheckNameStart(string name)
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

        private void Type_SelectedValueChanged(object sender, EventArgs e)
        {
            UpdateType();
        }

        private void UpdateType()
        {
            if (Type.SelectedIndex == Type.FindString("Bluetooth"))
            {
                label8.Visible = true;
                Port.Visible = true;
            }
            else
            {
                label8.Visible = false;
                Port.Visible = false;
            }
        }

        private void Port_TextChanged(object sender, EventArgs e)
        {
            if ((Port.Text.Trim() == "") || (Port.Text == null))
            {
                Connect.Enabled = false;
            }
            else
            {
                if (CheckName())
                {
                    Connect.Enabled = true;
                }
                else
                {
                    Connect.Enabled = false;
                }
            }
        }

        private void ConnName_TextChanged(object sender, EventArgs e)
        {
            if (!CheckName())
            {
                Connect.Enabled = false;
            }
            else
            {
                if ((Port.Text.Trim() == "") || (Port.Text == null))
                {
                    Connect.Enabled = false;
                }
                else
                {
                    Connect.Enabled = true;
                }
            }
        }

        private bool CheckName()
        {
            if ((ConnName.Text.Trim() == "") || (ConnName.Text == null))
            {
                return false;
            }
            for (int i = 0; i < createdconnections.Count; i++)
            {
                //ConnectionAssembly item = createdconnections.Keys.ToList()[i];
                string title = createdconnections[i].name;
                if (ConnName.Text == title)
                {
                    return false;
                }
            }
            return true;
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            Control[] list = new Control[] { Connect, Port, Type, ConnName, List, Online, CloseForm };
            foreach (Control item in list)
            {
                item.Enabled = false;
            }
            Connect.Text = "         Connecting...";

            Type type = connection.brick.type;
            object[] args = new object[] { };

            ConnectionInfo con = new ConnectionInfo();

            if (Type.SelectedIndex == Type.FindString("Bluetooth"))
            {
                con.port = "COM" + Port.Text;
                con.type = Bases.BrickBase.ConnectionType.Bluetooth;
            }
            if (Type.SelectedIndex == Type.FindString("WiFi"))
            {
                con.port = null;
                con.type = Bases.BrickBase.ConnectionType.WiFi;
            }
            if (Type.SelectedIndex == Type.FindString("USB"))
            {
                con.port = null;
                con.type = Bases.BrickBase.ConnectionType.USB;
            }

            args = new object[] { con.type, con.port };

            Bases.BrickBase brick = (Bases.BrickBase)Activator.CreateInstance(type, args);

            try
            {
                brick.Connect();
                ErrorPopup form = new ErrorPopup(reference, ErrorCriticality.OK, "Connection successful!  Device '" + ConnName.Text.Trim() + "' added to Connections!");
                form.ShowDialog();
            }
            catch (Exception ex)
            {
                ErrorPopup error = new ErrorPopup(reference, ErrorCriticality.Warning, "Unable to connect to the device.\r\n[" + brick.name + "]  " + ex.Message);
                error.ShowDialog();
                ErrorPopup q = new ErrorPopup(reference, ErrorCriticality.Question
                    , "Save this connection anyway?");
                q.ShowDialog();
                if (!q.status)
                {
                    q.Dispose();
                    error.Dispose();
                    foreach (Control item in list)
                    {
                        item.Enabled = true;
                    }
                    Connect.Text = "         Connect";
                    return;
                }
                q.Dispose();
                error.Dispose();
                                
            }
            
            con.brickreference = brick;
            con.connection = connection;
            con.name = ConnName.Text.Trim();
                       
            createdconnections.Add(con);
            parentreference.createdconnections = createdconnections;
            parentreference.ConnectionsChanged();

            this.Dispose();
            return;
            

        }


    }
}
