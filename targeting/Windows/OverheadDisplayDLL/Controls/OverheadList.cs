using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;

namespace OverheadDisplay.Controls
{
    public sealed partial class OverheadList : Bases.ControlBase
    {
        List<OverheadAssembly> assemblies = null;
        List<Folder> folders = new List<Folder>();
        public OverheadList(List<OverheadAssembly> assemblies)
        {
            if (Utils.Referenced)
            {
                InitializeComponent();
                this.DoubleBuffered = true;
                this.assemblies = assemblies;
                EnumerateAssemblies();
                EnableActivation();
            }
            else { this.Dispose(); }
        }

        private class Folder
        {
            public Folder()
            {

            }
            public List<Folder> folders = new List<Folder>();
            public List<OverheadAssembly> assemblies = new List<OverheadAssembly>();
            public int distancen = 0;
            public string name = "[BASE]";
            public bool contents_visible = false;
        }

        public void EnumerateAssemblies()
        {
            ResetList();
            folders.Clear();
            //Ensure each assembly's location starts with 'Controls'
            foreach (OverheadAssembly item in assemblies)
            {
                if (item.location[0] != "[BASE]")
                {
                    assemblies.Remove(item);
                }
            }            

            //Goal: list all assemblies
            //need to enumerate all folders

            //for every assembly,
            //looking at every spot in location[]...
            //...if it is not the last spot, add the spot's folder to the previous folder            
            //...if it is the last spot, add this assembly to this folder

            Folder root = new Folder();
            root.distancen = 0;
            root.folders = new List<Folder>();
            root.name = "[BASE]";
            root.assemblies = new List<OverheadAssembly>();
            folders.Add(root);

            foreach (OverheadAssembly item in assemblies)
            {
                if (item.location.Count() > 1)
                {
                    for (int i = 1; i < item.location.Count(); i++)
                    {
                        string loc = item.location[i];                        

                        //add the current folder to the previous folder
                        predicate_folder = new Folder();
                        predicate_folder.distancen = i;
                        predicate_folder.name = loc;
                        Folder check = folders.Find(checkFolder_AlreadyExistsSimple);
                        if (check == null)
                        {
                            predicate_folder = new Folder();
                            predicate_folder.distancen = i - 1;
                            predicate_folder.name = item.location[i - 1];
                            Folder newfolder = new Folder();
                            newfolder.distancen = i;
                            newfolder.name = loc;                            
                            folders.Find(checkFolder_AlreadyExistsSimple).folders.Add(newfolder);
                            folders.Add(newfolder);
                        }

                        if (i + 1 == item.location.Count())
                        {
                            //if location currently is in the last spot, add the assembly to the current folder
                            predicate_folder = new Folder();
                            predicate_folder.distancen = i;
                            predicate_folder.name = loc;
                            folders.Find(checkFolder_AlreadyExistsSimple).assemblies.Add(item);
                        }
                        
                    }
                }
                else
                {
                    //if the item is in the base
                    predicate_folder = root;
                    folders.Find(checkFolder_AlreadyExists).assemblies.Add(item);                    
                }
            }


            //Draw Base
            predicate_folder = root;
            DrawContents(folders.Find(checkFolder_AlreadyExists), 0, 0);

            if (assemblies.Count == 0)
            {
                Label label = new Label();

                label.AutoEllipsis = true;
                label.AutoSize = true;
                label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                label.Name = "null";
                label.Size = new System.Drawing.Size(this.Size.Width - 26 - label.Location.X, 40);
                label.TabIndex = 0;
                label.Text = "There are no overheads in the library.\r\nClick the Online button above to download overheads!";
                label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                label.BackColor = Color.Transparent;
                label.BackColor = Color.Transparent;
                List.Controls.Add(label);
            }

            return;
        }
        
        private Folder predicate_folder;
        private bool checkFolder_AlreadyExists(Folder folder)
        {
            return (folder == predicate_folder);
        }
        private bool checkFolder_AlreadyExistsSimple(Folder folder)
        {
            return ((folder.name == predicate_folder.name) && (folder.distancen == predicate_folder.distancen));
        }
        
        private void AddItem(bool folder, int location, int distancen, OverheadAssembly assembly, Folder fold)
        {

            if (!folder)
            {
                Panel panel = new Panel();
                Label label = new Label();                

                label.AutoEllipsis = true;
                label.Image = global::OverheadDisplay.Properties.Resources.ASCube_16xLG;
                label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                label.Location = new System.Drawing.Point((16 * distancen), 0);
                label.Name = "assemblyitem";
                label.Size = new System.Drawing.Size(this.Size.Width - 26 - label.Location.X, 18);
                label.TabIndex = 0;
                label.Text = "       " + assembly.name;
                label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                label.BackColor = Color.Transparent;
                label.MouseUp += Item_MouseUp;
                label.MouseDown += Item_MouseDown;
                label.MouseEnter += Item_MouseEnter;
                label.MouseLeave += Item_MouseLeave;
                label.Click += Item_Click;
                label.MouseDown += Activate_MouseDown;
                label.BackColor = Color.Transparent;

                panel.Controls.Add(label);
                panel.Location = new System.Drawing.Point(0, 0);
                panel.Margin = new System.Windows.Forms.Padding(0);
                panel.Name = "assemblyitem";
                panel.Size = new System.Drawing.Size(this.Size.Width - 26, 18);
                panel.TabIndex = 0;
                panel.BackColor = System.Drawing.SystemColors.Control;
                panel.MouseUp += Item_MouseUp;
                panel.MouseDown += Item_MouseDown;
                panel.MouseEnter += Item_MouseEnter;
                panel.MouseLeave += Item_MouseLeave;
                panel.MouseDown += Activate_MouseDown;
                panel.BackColor = Color.Transparent;
                panel.Click += Item_Click;

                panel.Controls.Add(label);
                List.Controls.Add(panel);
                List.Controls.SetChildIndex(panel, location);
            }
            else
            {
                Panel panel = new Panel();
                Label label = new Label();                

                label.AutoEllipsis = true;
                label.Image = global::OverheadDisplay.Properties.Resources.folder_Closed_16xLG;
                label.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
                label.Location = new System.Drawing.Point((16 * distancen), 0);
                label.Name = "folderitem";
                label.Size = new System.Drawing.Size(this.Size.Width - 26 - label.Location.X, 18);
                label.TabIndex = 0;
                label.Text = "       " + fold.name;
                label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
                label.BackColor = Color.Transparent;
                label.MouseUp += Item_MouseUp;
                label.MouseDown += Item_MouseDown;
                label.MouseEnter += Item_MouseEnter;
                label.MouseLeave += Item_MouseLeave;
                label.MouseDown += Activate_MouseDown;
                label.Click += Item_Click;
                label.BackColor = Color.Transparent;

                panel.Controls.Add(label);
                panel.Location = new System.Drawing.Point(0, 0);
                panel.Margin = new System.Windows.Forms.Padding(0);
                panel.Name = "folderitem";
                panel.Size = new System.Drawing.Size(this.Size.Width - 26, 18);
                panel.TabIndex = 0;
                panel.BackColor = System.Drawing.SystemColors.Control;
                panel.MouseUp += Item_MouseUp;
                panel.MouseDown += Item_MouseDown;
                panel.MouseEnter += Item_MouseEnter;
                panel.MouseLeave += Item_MouseLeave;
                panel.MouseDown += Activate_MouseDown;
                panel.BackColor = Color.Transparent;
                panel.Click += Item_Click;

                panel.Controls.Add(label);
                List.Controls.Add(panel);
                List.Controls.SetChildIndex(panel, location);
            }

            /*foreach (Control item in list)
            {
                List.Controls.Add(item);
            }*/

        }

        private void ItemEvent(Label sender)
        {
            //Find which panel the label is on (location)
            int location = -1;
            Panel panel = new Panel();
            for (int i = 0; i < List.Controls.Count; i++)
            {
                if (List.Controls[i].Contains(sender))
                {
                    location = i;
                    panel = (Panel)List.Controls[i];
                }
            }
            //Find the label's location on the panel (distance)
            int distance = (sender.Location.X / 16) + 1;
            //Get folder or assembly by name and distance
            if (sender.Name == "assemblyitem")
            {
                //get assembly by name and distance
                foreach (Folder folder in folders)
                {
                    foreach (OverheadAssembly assembly in folder.assemblies)
                    {
                        if ((assembly.name == sender.Text.Trim()) && (folder.distancen + 1 == distance))
                        {
                            Type type = assembly.overheadform.type;
                            UserControl instance = (UserControl)(Activator.CreateInstance(type));

                            Form parentForm = (this.Parent as Form);
                            parentForm.Controls.Add((Control)instance);
                            instance.Location = new Point(this.Width / 3, this.Height / 3);
                            instance.BringToFront();
                            this.BringToFront();
                            return;
                        }
                    }
                }
            }
            if (sender.Name == "folderitem")
            {
                //get folder by name and distance
                predicate_folder = new Folder();
                predicate_folder.name = sender.Text.Trim();
                predicate_folder.distancen = distance;
                Folder match = folders.Find(checkFolder_AlreadyExistsSimple);
                if (match == null)
                { }
                else
                {
                    if (match.contents_visible == false)
                    {
                        DrawContents(match, distance, location + 1);
                        match.contents_visible = true;
                        sender.Image = global::OverheadDisplay.Properties.Resources.folder_Open_16xLG;
                    }
                    else
                    {
                        Queue<Folder> queue = new Queue<Folder>();
                        List<Folder> children = new List<Folder>();
                        queue.Enqueue(match);
                        children.Add(match);
                        while (queue.Count > 0)
                        {
                            Folder item = queue.Dequeue();
                            foreach (Folder i in item.folders)
                            {
                                queue.Enqueue(i);
                                children.Add(i);
                            }
                            
                            //no need to search for the respective assemblies, just the folders                                                        
                        }

                        for (int i = location + 1; i < location + 1 + children.Count; i++)
                        {
                            //find location of item
                            RemoveContents(children[i - location - 1], location + 1);
                            children[i - location - 1].contents_visible = false;
                            sender.Image = global::OverheadDisplay.Properties.Resources.folder_Closed_16xLG;
                        }
                    }
                }
            }

            //Note: label.Name is either "assemblyitem" or "folderitem"

            //if folder, DrawContents(folder, distance, location) or RemoveContents()
            //if assembly, create an instance on the main form
        }

        private void DrawContents(Folder folder, int baseN, int startloc)
        {
            for (int i = startloc; i < startloc + folder.folders.Count; i++)
			{
                AddItem(true, i, baseN, null, folder.folders[i - startloc]);
			}
            for (int i = startloc + folder.folders.Count + 1; i < startloc + folder.assemblies.Count + folder.folders.Count + 1; i++)
            {
                AddItem(false, i, baseN, folder.assemblies[i - startloc - folder.folders.Count - 1], null);
            }            
        }

        private void RemoveContents(Folder folder, int startloc)
        {
            int max = startloc;
            if (folder.contents_visible)
            {
                max = max + folder.assemblies.Count + folder.folders.Count;
            }
            for (int i = startloc; i < max; i++)
            {
                List.Controls.RemoveAt(i);
            }
            /*for (int i = startloc; i < startloc + folder.assemblies.Count; i++)
            {
                List.Controls.RemoveAt(i);
            }        */
        }

        internal override void Control_Resize(object sender, EventArgs e)
        {
            base.Control_Resize(sender, e);
            List.Size = new Size(this.Size.Width - 9, this.Size.Height - 58);
            foreach (Panel item in List.Controls.OfType<Panel>())
            {
                item.Width = this.Size.Width - 26;
                item.Controls[0].Width = this.Size.Width - 26 - item.Controls[0].Location.X;
            }
        }

        #region Events
        private void ResetList()
        {
            List.Controls.Clear();
        }

        private void Refresh_Click(object sender, EventArgs e)
        {
            EnumerateAssemblies();
        }

        private void Item_MouseEnter(object sender, EventArgs e)
        {
            Panel s = new Panel();
            if (sender.GetType() == typeof(Panel))
            {
                s = (Panel)sender;                
            }
            if (sender.GetType() == typeof(Label))
            {
                s = GetPanel((Label)sender);
            }
            if (s.BackColor == Color.Transparent)
            {
                s.BackColor = SystemColors.ControlLightLight;
                s.ForeColor = Color.Black;
                return;
            }
            if (s.BackColor == SystemColors.ControlLightLight)
            {
                s.BackColor = SystemColors.HotTrack;
                s.ForeColor = Color.White;
            }
        }

        private Panel GetPanel(Label sender)
        {
            foreach (Panel item in List.Controls.OfType<Panel>())
            {
                if (item.Contains(sender))
                {
                    return item;
                }
            }
            return null;
        }

        private void Item_MouseLeave(object sender, EventArgs e)
        {
            Panel s = new Panel();
            if (sender.GetType() == typeof(Panel))
            {
                s = (Panel)sender;
            }
            if (sender.GetType() == typeof(Label))
            {
                s = GetPanel((Label)sender);
            }
            if (s.BackColor == SystemColors.HotTrack)
            {
                s.BackColor = SystemColors.ControlLightLight;
                s.ForeColor = Color.Black;
                return;
            }
            if (s.BackColor == SystemColors.ControlLightLight)
            {
                s.BackColor = Color.Transparent;
            }
        }

        private void Item_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button == System.Windows.Forms.MouseButtons.Left) || (e.Button == System.Windows.Forms.MouseButtons.Right))
            {
                Panel s = new Panel();
                if (sender.GetType() == typeof(Panel))
                {
                    s = (Panel)sender;
                }
                if (sender.GetType() == typeof(Label))
                {
                    s = GetPanel((Label)sender);
                }
                if (s.BackColor == SystemColors.ControlLightLight)
                {
                    s.BackColor = SystemColors.HotTrack;
                    s.ForeColor = Color.White;
                }
            }
        }

        private void Item_MouseUp(object sender, MouseEventArgs e)
        {
            Panel s = new Panel();
            if (sender.GetType() == typeof(Panel))
            {
                s = (Panel)sender;
            }
            if (sender.GetType() == typeof(Label))
            {
                s = GetPanel((Label)sender);
            }
            if (s.BackColor == SystemColors.HotTrack)
            {
                s.BackColor = SystemColors.ControlLightLight;
                s.ForeColor = Color.Black;                
                return;
            }
        }

        private void Item_Click(object sender, EventArgs e)
        {
            Panel s = new Panel();
            Label d = new Label();
            if (sender.GetType() == typeof(Panel))
            {
                s = (Panel)sender;
                d = (Label)s.Controls[0];
            }
            if (sender.GetType() == typeof(Label))
            {
                s = GetPanel((Label)sender);
                d = (Label)sender;
            }
            s.BackColor = SystemColors.ControlLightLight;
            s.ForeColor = Color.Black;            
            ItemEvent(d);
        }

        private Dictionary<Button, Image> originals = new Dictionary<Button, Image>();
        private void ButtonAction_EnabledChanged(object sender, EventArgs e)
        {
            Button s = (Button)sender;
            if (s.Enabled)
            {
                if (!originals.ContainsKey(s))
                {
                    originals.Add(s, s.Image);
                }
                else
                {
                    foreach (Button item in originals.Keys)
                    {
                        if (s == item)
                        {
                            s.Image = item.Image;
                        }
                    }
                }
            }
            else
            {
                if (!originals.ContainsKey(s))
                {
                    originals.Add(s, s.Image);
                }
                else
                {
                    s.Image = Utils.MakeGrayscale((Bitmap)s.Image);
                }
            }
        }
        #endregion

        private void Online_Click(object sender, EventArgs e)
        {
            List<OnlineOverheads> checks = Parent.Controls.OfType<OnlineOverheads>().ToList();
            if (checks.Count == 0)
            {
                OverheadDisplay.Controls.OnlineOverheads online = new OnlineOverheads(assemblies);
                this.Parent.Controls.Add(online);
                online.Location = new Point(this.Location.X + 25, this.Location.Y + 25);
                online.ActivateForm();
            }
            else { checks[0].ActivateForm(); }
        }
                


    }
}
