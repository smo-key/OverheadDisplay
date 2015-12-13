using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Threading;

namespace OverheadDisplay
{   

    public partial class Startup : Form
    {
        private Thread start;
        private delegate void InvokeMethod();
        private delegate void InvokeStatus(string status);
        private void Start()
        {
            OverheadDisplay.Utils.Reference("F2E5149C-CDB6-4925-9B53-B2Y5FB5D9XFD", 1000);
            InvokeStatus i = new InvokeStatus(UpdateStatus);
            if (!Utils.Referenced) 
            {
                Assets.PreLoad_Error error = new Assets.PreLoad_Error("An internal error has occured.\r\n[Overhead Display]  " +
                    "Library 'OverheadDisplayDLL.dll' is corrupted and cannot be read.");
                error.ShowDialog();
                return;
            }
            List<OverheadAssembly> assemblies = new List<OverheadAssembly>();

            //check overheads and connections for containing all proper methods
            #region Overheads
            foreach (string filename in Directory.GetFiles(Directory.GetCurrentDirectory() + "\\Overheads\\", "*.dll", System.IO.SearchOption.AllDirectories))
            {
                try
                {
                    FileInfo info = new FileInfo(filename);                    
                    Invoke(i, new object[] { "Loading " + info.Name });

                    Assembly Assembly = Assembly.LoadFrom(filename);
                    Type[] type = Assembly.GetTypes();
                    Type myType = null; //Assembly.GetType("OverheadForm", true, true);
                    foreach (Type t in type)
                    {
                        if (t.Name == "OverheadForm")
                        {
                            myType = t;
                        }
                    }

                    object myInstance = null;

                    OverheadAssembly assembly = new OverheadAssembly( Assembly, filename, info.Name );
                    object overheadinstance = null;
                    
                    myInstance = Activator.CreateInstance(myType);
                    OverheadAssembly.OverheadForm form = new OverheadAssembly.OverheadForm();
                    form.type = myType;
                    assembly.overheadform = form;
                    overheadinstance = myInstance;                    

                    PropertyInfo prop_stub = myType.GetProperty("versionkey");
                    MethodInfo method_stub = prop_stub.GetGetMethod();
                    string versionkey = (string)(method_stub.Invoke(myInstance, null));

                    bool error = true;
                    if (versionkey == "F2B72989-7053-44F6-A7A7-60CFCB61E777")
                    {
                        prop_stub = myType.GetProperty("publisher");
                        method_stub = prop_stub.GetGetMethod();
                        string publisher = (string)(method_stub.Invoke(myInstance, null));
                        prop_stub = myType.GetProperty("copyright");
                        method_stub = prop_stub.GetGetMethod();
                        string copyright = (string)(method_stub.Invoke(myInstance, null));
                        prop_stub = myType.GetProperty("id");
                        method_stub = prop_stub.GetGetMethod();
                        string id = (string)(method_stub.Invoke(myInstance, null));
                        prop_stub = myType.GetProperty("name");
                        method_stub = prop_stub.GetGetMethod();
                        string name = (string)(method_stub.Invoke(myInstance, null));
                        prop_stub = myType.GetProperty("location");
                        method_stub = prop_stub.GetGetMethod();
                        string[] location = (string[])(method_stub.Invoke(myInstance, null));
                        prop_stub = myType.GetProperty("version");
                        method_stub = prop_stub.GetGetMethod();
                        int[] version = (int[])(method_stub.Invoke(myInstance, null));
                        prop_stub = myType.GetProperty("scope");
                        method_stub = prop_stub.GetGetMethod();
                        OverheadAssembly.Scope[] scope = (OverheadAssembly.Scope[])(method_stub.Invoke(myInstance, null));
                                                
                        assembly.publisher = publisher;
                        assembly.copyright = copyright;
                        assembly.id = id;
                        assembly.name = name;
                        assembly.location = location;
                        assembly.version = version;
                        assembly.versionkey = versionkey;
                        assembly.scope = scope;
                        error = false;
                    }

                    if (error) { throw new Exception(); }

                    OverheadAssembly.PropertiesForm propsform = new OverheadAssembly.PropertiesForm();
                    myType = null; //Assembly.GetType("OverheadForm", true, true);
                    foreach (Type t in type)
                    {
                        if (t.Name == "PropertiesForm")
                        {
                            myType = t;
                        }                        
                    }
                    myInstance = null;
                    try
                    {
                        myInstance = Activator.CreateInstance(myType, new object[] { overheadinstance });
                        propsform.type = myType;
                    }
                    catch (Exception)
                    {
                        propsform.type = null;
                    }
                    assembly.propertiesform = propsform;

                    OverheadAssembly.EventForm eventform = new OverheadAssembly.EventForm();
                    myType = null; //Assembly.GetType("OverheadForm", true, true);
                    foreach (Type t in type)
                    {
                        if (t.Name == "EventsForm")
                        {
                            myType = t;
                        }
                    }
                    myInstance = null;
                    try
                    {
                        myInstance = Activator.CreateInstance(myType, new object[] { overheadinstance });
                        eventform.type = myType;
                    }
                    catch (Exception)
                    {
                        eventform.type = null;
                    }
                    assembly.eventform = eventform;

                    assemblies.Add(assembly);
                    
                }
                catch (Exception)
                {

                }
            }

            try
            {
                assemblies.Sort(CompareAssembly_ByID);
                Int32 index = 0;
                while (index < assemblies.Count - 1)
                {
                    if (assemblies[index].assembly == assemblies[index + 1].assembly)
                        assemblies.RemoveAt(index);
                    else
                        index++;
                }
            }
            catch
            {

            }

            #endregion

            #region Connections
            List<ConnectionAssembly> connections = new List<ConnectionAssembly>();

            foreach (string filename in Directory.GetFiles(Directory.GetCurrentDirectory() + "\\Connections\\", "*.dll", System.IO.SearchOption.AllDirectories))
            {
                try
                {

                    FileInfo info = new FileInfo(filename);
                    Invoke(i, new object[] { "Loading " + info.Name });

                    Assembly Assembly = Assembly.LoadFrom(filename);
                    Type[] types = Assembly.GetTypes();
                    Type myType = null; //Assembly.GetType("OverheadForm", true, true);
                    foreach (Type t in types)
                    {
                        if (t.Name == "Brick")
                        {
                            myType = t;
                        }
                    }
                    object myInstance = null;
                    ConnectionAssembly connection = new ConnectionAssembly(Assembly, filename, info.Name);
                    ConnectionAssembly.Brick brick;
                    Bases.BrickBase back;

                    myInstance = Activator.CreateInstance(myType);

                    brick = new ConnectionAssembly.Brick();
                    back = (Bases.BrickBase)myInstance;
                    brick.type = myType;

                    PropertyInfo prop_stub = myType.GetProperty("versionkey");
                    MethodInfo method_stub = prop_stub.GetGetMethod();
                    string versionkey = (string)(method_stub.Invoke(myInstance, null));

                    bool error = true;
                    if (versionkey == "7BEFF4B5-6C9C-43C4-8A89-0AC589162F95")
                    {
                        prop_stub = myType.GetProperty("publisher");
                        method_stub = prop_stub.GetGetMethod();
                        string publisher = (string)(method_stub.Invoke(myInstance, null));
                        prop_stub = myType.GetProperty("copyright");
                        method_stub = prop_stub.GetGetMethod();
                        string copyright = (string)(method_stub.Invoke(myInstance, null));
                        prop_stub = myType.GetProperty("id");
                        method_stub = prop_stub.GetGetMethod();
                        string id = (string)(method_stub.Invoke(myInstance, null));
                        prop_stub = myType.GetProperty("name");
                        method_stub = prop_stub.GetGetMethod();
                        string name = (string)(method_stub.Invoke(myInstance, null));
                        prop_stub = myType.GetProperty("version");
                        method_stub = prop_stub.GetGetMethod();
                        int[] version = (int[])(method_stub.Invoke(myInstance, null));
                        prop_stub = myType.GetProperty("supportedtypes");
                        method_stub = prop_stub.GetGetMethod();
                        Bases.BrickBase.ConnectionType[] supportedtypes = (Bases.BrickBase.ConnectionType[])(method_stub.Invoke(myInstance, null));
                        prop_stub = myType.GetProperty("ports");
                        method_stub = prop_stub.GetGetMethod();
                        List<Bases.Port> ports = (List<Bases.Port>)(method_stub.Invoke(myInstance, null));

                        connection.publisher = publisher;
                        connection.copyright = copyright;
                        connection.id = id;
                        connection.name = name;
                        connection.version = version;
                        connection.versionkey = versionkey;

                        ConnectionAssembly.Brick main = new ConnectionAssembly.Brick();
                        main.supportedtypes = supportedtypes;
                        main.reference = back;
                        main.ports = ports;
                        main.type = myType;

                        //Prepare Actions
                        foreach (Type t in types)
                        {
                            if (t.Name == "Actions")
                            {
                                myType = t;
                            }
                        }
                        ConnectionAssembly.Actions actionlist = new ConnectionAssembly.Actions();
                        actionlist.actions = new List<ConnectionAssembly.Action>();

                        //Prepare Actions.actions
                        foreach (Type t in types)
                        {
                            try
                            {
                                ConnectionAssembly.Action action = new ConnectionAssembly.Action();
                                Bases.BrickBase.Action _action;
                                _action = (Bases.BrickBase.Action)Activator.CreateInstance(t);
                                action.type = t;
                                action.reference = _action;
                                action.name = _action.name;
                                action.argtype = _action.argtype;
                                action.argoptional = _action.argoptional;
                                action.argnames = _action.argnames;
                                actionlist.actions.Add(action);
                            }
                            catch
                            {
                                continue;
                            }
                        }
                        connection.brick = main;
                        connection.actions = actionlist;
                        connections.Add(connection);
                        error = false;
                    }
                    if (error) { throw new Exception(); }
                }
                catch
                {

                }
            }

            //check for duplicates
            try
            {
                connections.Sort(CompareConnection_ByID);
                Int32 index = 0;
                while (index < connections.Count - 1)
                {
                    if (connections[index].assembly == connections[index + 1].assembly)
                        connections.RemoveAt(index);
                    else
                        index++;
                }
            }
            catch
            {

            }

            #endregion

            //To get the values of an enum...
            //Enum.GetValues(connections[0].actions.actions[0].argtype[0])

            Invoke(i, new object[] { "Initializing..." });
            start = new Thread(() => Run(assemblies, connections));

            #if !DEBUG
                System.Threading.Thread.Sleep(2000);
            #endif

            start.IsBackground = false;
            start.Name = "Main Thread";
            start.Start();
            InvokeMethod m = new InvokeMethod(Die);
            Invoke(m, new object[] { });
        }

        int CompareAssembly_ByID(OverheadAssembly a, OverheadAssembly b)
        {
            OverheadAssembly c1 = (OverheadAssembly)a;
            OverheadAssembly c2 = (OverheadAssembly)b;
            return String.Compare(c1.id, c2.id, true);
        }

        int CompareConnection_ByID(ConnectionAssembly a, ConnectionAssembly b)
        {
            ConnectionAssembly c1 = (ConnectionAssembly)a;
            ConnectionAssembly c2 = (ConnectionAssembly)b;
            return String.Compare(c1.id, c2.id, true);
        }

        public void Run(List<OverheadAssembly> assemblies, List<ConnectionAssembly> connections)
        {
            //OverheadDisplay.Menu form = new Menu();
            Application.Run(new Design(assemblies, connections));
        }

        public void Die()
        {
            System.Threading.Thread.Sleep(100);
            this.Close();
        }

        public Startup()
        {
            InitializeComponent();
            //Load and test overhead assemblies
            start = new System.Threading.Thread(Start);
            start.IsBackground = true;
            start.Name = "Start Thread";
            start.Start();            
        }
        private void UpdateStatus(string status)
        {
            Status.Text = status;
        }

    }

}
