using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;
using System.Reflection;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.Xml.Serialization;

namespace WindowsFormsApplication1
{
    public interface IPlugins
    {

        string Name { get; }
        string Format { get; }

        void UsePlugin(string inputFile, string outputFile);

        void DeUsePlugin(string inputFile, string outputFile);
    }

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        [Serializable]
        public class Organization 
        {
            public string Name { get; set; }
            public string Phone { get; set; }
            public Organization(string Name, string Phone)
            {
                this.Name = Name;
                this.Phone = Phone;
            }

            public Organization()
            { }
        }
        [Serializable]
        public class Driver : Organization
        {
            public string DriverName { get; set; }
            public string PriceofHour { get; set; }
            public Driver(string Name, string Phone, string DriverName, string PriceofHour)
                : base(Name, Phone)
            {
                this.DriverName = DriverName;
                this.PriceofHour = PriceofHour;
            }
            public Driver()
            { }
        }
        [Serializable]
        public class Taxi : Driver
        {
            public string NumberofTaxi { get; set; }
            public string Priceperkm { get; set; }
            public Taxi(string Name, string Phone, string DriverName, string PriceofHour, string Priceperkm,string NumberofTaxi)
                : base(Name, Phone, DriverName, PriceofHour)
            {
                this.Priceperkm = Priceperkm;
                this.NumberofTaxi = NumberofTaxi;
            }
            public Taxi()
            { }
        }
        [Serializable]
        public class MiniBus : Driver
        {
            public string NumberofMiniBus { get; set; }
            public string Size { get; set; }
            public MiniBus(string Name, string Phone, string DriverName, string PriceofHour, string Size, string NumberofMiniBus)
                : base(Name, Phone, DriverName, PriceofHour)
            {
                this.Size = Size;
                this.NumberofMiniBus = NumberofMiniBus;
            }
            public MiniBus()
            { }
        }
        [Serializable]
        public class Bus : Driver
        {
            public string NumberofBus { get; set; }
            public string TicketPrice { get; set; }
            public Bus(string Name, string Phone, string DriverName, string PriceofHour, string TicketPrice, string NumberofBus)
                : base(Name, Phone, DriverName, PriceofHour)
            {
                this.TicketPrice = TicketPrice;
                this.NumberofBus = NumberofBus;
            }
            public Bus()
            { }
        }
        [Serializable]
        public class Route 
        {
            public Bus RouteBus { get; set; }
            public string RouteTime { get; set; }
            public string RouteNumber { get; set; }
            public Route(Bus RouteBus, string RouteTime, string RouteNumber)
            {
                this.RouteBus = RouteBus;
                this.RouteTime = RouteTime;
                this.RouteNumber = RouteNumber;
            }
            public Route()
            { }
        }

        public interface ISerialization
        {
            void Serialize(AllLists Lists, string path);
            AllLists Deserialize(string Filepath);
        }


        public class BinarySerialization : ISerialization
        {
            public void Serialize(AllLists Lists, string path)
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(path, FileMode.Create))
                {
                    formatter.Serialize(fs, Lists);
                }
            }

            public AllLists Deserialize(string Filepath)
            {
                AllLists newList;
                BinaryFormatter formatter = new BinaryFormatter();
                using (FileStream fs = new FileStream(Filepath, FileMode.OpenOrCreate))
                {
                    newList = (AllLists)formatter.Deserialize(fs);
                }
                return newList;
            }
        }

        public class XMLSerialization : ISerialization
        {
            public void Serialize(AllLists Lists, string path)
            {
                XmlSerializer OrganizationListSer = new XmlSerializer(typeof(AllLists));
                using (FileStream fx = new FileStream(path, FileMode.Create))
                {
                    OrganizationListSer.Serialize(fx, Lists);
                }
            }

            public AllLists Deserialize(string Filepath)
            {
                AllLists lists;
                XmlSerializer OrganizationListDeSer = new XmlSerializer(typeof(AllLists));
                using (FileStream fx = new FileStream(Filepath, FileMode.OpenOrCreate))
                {
                    lists = (AllLists)OrganizationListDeSer.Deserialize(fx);
                }
                return lists;
            }
        }


        public class TextSerialization : ISerialization
        {
            public void Serialize(AllLists Lists, string path)
            {
                using (StreamWriter file = new StreamWriter(path, false))
                {
                }
                
                    using (StreamWriter file = new StreamWriter(path, true))
                    {
                        file.WriteLine("<OrganizationList>");
                        foreach (Organization i in Lists.SecOrganizationList)
                        {
                            file.WriteLine("<nextel>");
                            file.WriteLine(i.Name);
                            file.WriteLine(i.Phone);
                        }
                        file.WriteLine("<DriverList>");
                        foreach (Driver i in Lists.SecDriverList)
                        {
                            file.WriteLine("<nextel>");
                            file.WriteLine(i.Name);
                            file.WriteLine(i.Phone);
                            file.WriteLine(i.DriverName);
                            file.WriteLine(i.PriceofHour);
                        }
                        file.WriteLine("<TaxiList>");
                        foreach (Taxi i in Lists.SecTaxiList)
                        {
                            file.WriteLine("<nextel>");
                            file.WriteLine(i.Name);
                            file.WriteLine(i.Phone);
                            file.WriteLine(i.DriverName);
                            file.WriteLine(i.PriceofHour);
                            file.WriteLine(i.NumberofTaxi);
                            file.WriteLine(i.Priceperkm);
                        }
                        file.WriteLine("<MiniBusList>");
                        foreach (MiniBus i in Lists.SecMiniBusList)
                        {
                            file.WriteLine("<nextel>");
                            file.WriteLine(i.Name);
                            file.WriteLine(i.Phone);
                            file.WriteLine(i.DriverName);
                            file.WriteLine(i.PriceofHour);
                            file.WriteLine(i.NumberofMiniBus);
                            file.WriteLine(i.Size);
                        }
                        file.WriteLine("<BusList>");
                        foreach (Bus i in Lists.SecBusList)
                        {
                            file.WriteLine("<nextel>");
                            file.WriteLine(i.Name);
                            file.WriteLine(i.Phone);
                            file.WriteLine(i.DriverName);
                            file.WriteLine(i.PriceofHour);
                            file.WriteLine(i.NumberofBus);
                            file.WriteLine(i.TicketPrice);
                        }
                        file.WriteLine("<RouteList>");
                        foreach (Route i in Lists.SecRouteList)
                        {
                            file.WriteLine("<nextel>");
                            file.WriteLine(i.RouteBus.Name);
                            file.WriteLine(i.RouteBus.Phone);
                            file.WriteLine(i.RouteBus.DriverName);
                            file.WriteLine(i.RouteBus.PriceofHour);
                            file.WriteLine(i.RouteBus.NumberofBus);
                            file.WriteLine(i.RouteBus.TicketPrice);
                            file.WriteLine(i.RouteTime);
                            file.WriteLine(i.RouteNumber);
                        }
                    }
                
            }
            

            public AllLists Deserialize(string Filepath)
            {
                AllLists lists = new AllLists();
                List<Organization> BufOrganizationList = new List<Organization>(0);
                List<Driver> BufDriverList = new List<Driver>(0);
                List<Taxi> BufTaxiList = new List<Taxi>(0);
                List<MiniBus> BufMiniBusList = new List<MiniBus>(0);
                List<Bus> BufBusList = new List<Bus>(0);
                List<Route> BufRouteList = new List<Route>(0);
                string line;
                using (StreamReader file = new StreamReader(Filepath))
                {
                    while ((line = file.ReadLine()) != null)
                    {
                        if (line == "<OrganizationList>")
                        {
                            while ((line = file.ReadLine()) == "<nextel>")
                            {

                                BufOrganizationList.Capacity++;
                                BufOrganizationList.Add(new Organization(file.ReadLine(), file.ReadLine()));
                            }
                        }
                        if (line == "<DriverList>")
                        {
                            while ((line = file.ReadLine()) == "<nextel>")
                            {
                                BufDriverList.Capacity++;
                                BufDriverList.Add(new Driver(file.ReadLine(), file.ReadLine(), file.ReadLine(), file.ReadLine()));
                            }
                        }
                        if (line == "<TaxiList>")
                        {
                            while ((line = file.ReadLine()) == "<nextel>")
                            {
                                BufTaxiList.Capacity++;
                                BufTaxiList.Add(new Taxi(file.ReadLine(), file.ReadLine(), file.ReadLine(), file.ReadLine(), file.ReadLine(), file.ReadLine()));
                            }
                        }
                        if (line == "<MiniBusList>")
                        {
                            while ((line = file.ReadLine()) == "<nextel>")
                            {
                                BufMiniBusList.Capacity++;
                                BufMiniBusList.Add(new MiniBus(file.ReadLine(), file.ReadLine(), file.ReadLine(), file.ReadLine(), file.ReadLine(), file.ReadLine()));
                            }
                        }
                        if (line == "<BusList>")
                        {
                            while ((line = file.ReadLine()) == "<nextel>")
                            {
                                BufBusList.Capacity++;
                                BufBusList.Add(new Bus(file.ReadLine(), file.ReadLine(), file.ReadLine(), file.ReadLine(), file.ReadLine(), file.ReadLine()));
                            }
                        }
                        if (line == "<RouteList>")
                        {
                            while ((line = file.ReadLine()) == "<nextel>")
                            {
                                Bus fn = new Bus(file.ReadLine(), file.ReadLine(), file.ReadLine(), file.ReadLine(), file.ReadLine(), file.ReadLine());
                                BufRouteList.Capacity++;
                                BufRouteList.Add(new Route(fn, file.ReadLine(), file.ReadLine()));
                            }
                        }
                    }
                }
                lists.SecOrganizationList = BufOrganizationList;
                lists.SecDriverList = BufDriverList;
                lists.SecTaxiList = BufTaxiList;
                lists.SecMiniBusList = BufMiniBusList;
                lists.SecBusList = BufBusList;
                lists.SecRouteList = BufRouteList;
                return lists;
            }
        }



        [Serializable]
        public class AllLists
        {
            public List<Organization> SecOrganizationList;
            public List<Driver> SecDriverList;
            public List<Taxi> SecTaxiList;
            public List<MiniBus> SecMiniBusList;
            public List<Bus> SecBusList;
            public List<Route> SecRouteList;
            public AllLists()
            { }
        }

        private void Form1_Activated(object sender, EventArgs e)
        {
            
        }

        List<Organization> OrganizationList = new List<Organization>(0);
        List<Driver> DriverList = new List<Driver>(0);
        List<Taxi> TaxiList = new List<Taxi>(0);
        List<MiniBus> MiniBusList = new List<MiniBus>(0);
        List<Bus> BusList = new List<Bus>(0);
        List<Route> RouteList = new List<Route>(0);
        public int Num_Organization = 0;
        public int Num_Driver = 0;
        public int Num_Taxi = 0;
        public int Num_MiniBus = 0;
        public int Num_Bus = 0;
        public int Num_Route = 0;

        private void Add_Class (object sender, EventArgs e)
        {
            #region for Organization
            if (Classes.SelectedItem.ToString() == "Organization")
            {
                Organizations.Items.Clear();
                OrganizationList.Capacity++;
                Num_Organization++;
                OrganizationList.Add(new Organization(NameBox.Text, PhoneBox.Text));
                foreach (Organization i in OrganizationList)
                {
                    Organizations.Items.Add(i.Name);
                }
                NameBox.Clear();
                PhoneBox.Clear();

            }
             #endregion
            #region for Drivers
            if (Classes.SelectedItem.ToString() == "Driver")
            {
                Organizations.Items.Clear();
                DriverList.Capacity++;
                Num_Driver++;
                DriverList.Add(new Driver(NameBox.Text, PhoneBox.Text, DriverNameBox.Text, PriceofHourBox.Text));
                foreach (Driver i in DriverList)
                {
                    Organizations.Items.Add(i.DriverName);
                }
                DriverNameBox.Clear();
                PriceofHourBox.Clear();
                NameBox.Clear();
                PhoneBox.Clear();

            }
            #endregion
            #region for Taxi
            if (Classes.SelectedItem.ToString() == "Taxi")
            {
                Organizations.Items.Clear();
                TaxiList.Capacity++;
                Num_Taxi++;
                TaxiList.Add(new Taxi(NameBox.Text, PhoneBox.Text, DriverNameBox.Text, PriceofHourBox.Text, PriceperkmBox.Text, NumberBox.Text));
                foreach (Taxi i in TaxiList)
                {
                    Organizations.Items.Add(i.NumberofTaxi);
                }
                DriverNameBox.Clear();
                PriceofHourBox.Clear();
                NameBox.Clear();
                PhoneBox.Clear();
                PriceperkmBox.Clear();
                NumberBox.Clear();

            }
            #endregion
            #region for MiniBus
            if (Classes.SelectedItem.ToString() == "MiniBus")
            {
                Organizations.Items.Clear();
                MiniBusList.Capacity++;
                Num_MiniBus++;
                MiniBusList.Add(new MiniBus(NameBox.Text, PhoneBox.Text, DriverNameBox.Text, PriceofHourBox.Text, PriceperkmBox.Text, NumberBox.Text));
                foreach (MiniBus i in MiniBusList)
                {
                    Organizations.Items.Add(i.NumberofMiniBus);
                }
                DriverNameBox.Clear();
                PriceofHourBox.Clear();
                NameBox.Clear();
                PhoneBox.Clear();
                PriceperkmBox.Clear();
                NumberBox.Clear();

            }
            #endregion
            #region for Bus
            if (Classes.SelectedItem.ToString() == "Bus")
            {
                Organizations.Items.Clear();
                BusList.Capacity++;
                Num_Bus++;
                BusList.Add(new Bus(NameBox.Text, PhoneBox.Text, DriverNameBox.Text, PriceofHourBox.Text, PriceperkmBox.Text, NumberBox.Text));
                foreach (Bus i in BusList)
                {
                    Organizations.Items.Add(i.NumberofBus);
                }
                DriverNameBox.Clear();
                PriceofHourBox.Clear();
                NameBox.Clear();
                PhoneBox.Clear();
                PriceperkmBox.Clear();
                NumberBox.Clear();

            }
            #endregion
            #region for Route
            if (Classes.SelectedItem.ToString() == "Route")
            {
                Organizations.Items.Clear();
                RouteList.Capacity++;
                Num_Route++;
                Bus fn = new Bus(NameBox.Text, PhoneBox.Text, DriverNameBox.Text, PriceofHourBox.Text, PriceperkmBox.Text, NumberBox.Text);
                RouteList.Add(new Route(fn, RouteTimeBox.Text, RouteNumberBox.Text));
                foreach (Route i in RouteList)
                {
                    Organizations.Items.Add(i.RouteNumber);
                }
                DriverNameBox.Clear();
                PriceofHourBox.Clear();
                NameBox.Clear();
                PhoneBox.Clear();
                PriceperkmBox.Clear();
                NumberBox.Clear();
                RouteTimeBox.Clear();
                RouteNumberBox.Clear();

            }
            #endregion
        }

        public List<IPlugins> objects;
        public List<Assembly> assemblies;
        public List<Type> pluginTypes;
        Type pluginType = typeof(IPlugins);
        


        private void Form1_Load(object sender, EventArgs e)
        {
            Classes.Items.Add("Organization");
            Classes.Items.Add("Driver");
            Classes.Items.Add("Taxi");
            Classes.Items.Add("MiniBus");
            Classes.Items.Add("Bus");
            Classes.Items.Add("Route");
            label1.Hide();
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
            label6.Hide();
            label7.Hide();
            label8.Hide();
            NameBox.Hide();
            PhoneBox.Hide();
            DriverNameBox.Hide();
            PriceofHourBox.Hide();
            PriceperkmBox.Hide();
            NumberBox.Hide();
            RouteTimeBox.Hide();
            RouteNumberBox.Hide();
            SaveLoadBox.Items.Add("Binary");
            SaveLoadBox.Items.Add("XML");
            SaveLoadBox.Items.Add("Text");
            Plugins.Items.Add("None");
            if (Directory.Exists(@"D:\foulder\ООТПиСП\2\WindowsFormsApplication1\Plugins"))
            {
                string[] dllFileNames = Directory.GetFiles(@"D:\foulder\ООТПиСП\2\WindowsFormsApplication1\Plugins", "*.dll", SearchOption.AllDirectories);
                assemblies = new List<Assembly>(dllFileNames.Length);
                int kost=2;
                foreach (string dllFile in dllFileNames)
                { 
                    if(kost % 2 == 0)
                    {
                        AssemblyName name = AssemblyName.GetAssemblyName(dllFile);
                        Assembly assembly = Assembly.Load(name);
                        assemblies.Add(assembly);
                    }
                    kost++;
                }
                pluginTypes = new List<Type>();
                foreach (Assembly assembly in assemblies)
                {
                    if (assembly != null)
                    {
                        Type[] types = assembly.GetTypes();
                        foreach (Type type in types)
                        {
                            if (type.IsInterface || type.IsAbstract)
                            {
                                continue;
                            }
                            else
                            {
                                if (type.GetInterface(pluginType.FullName) != null)
                                {
                                    pluginTypes.Add(type);
                                }
                            }
                        }
                    }
                }
                objects = new List<IPlugins>(pluginTypes.Count);
                foreach (Type type in pluginTypes)
                {
                    IPlugins plugin = (IPlugins)Activator.CreateInstance(type);
                    objects.Add(plugin);
                }
                foreach (var item in objects)
                {
                    Plugins.Items.Add(item.Name);
                }


                

            }
        }

        private void Organizations_Click(object sender, EventArgs e)
        {
            try
            {

                if (Classes.SelectedItem.ToString() == "Organization")
                    foreach (Organization i in OrganizationList)
                    {
                        if (i.Name == Organizations.SelectedItem.ToString())
                        {
                            NameBox.Text = i.Name;
                            PhoneBox.Text = i.Phone;
                        }
                    }

                if (Classes.SelectedItem.ToString() == "Driver")
                    foreach (Driver i in DriverList)
                    {
                        if (i.DriverName == Organizations.SelectedItem.ToString())
                        {
                            NameBox.Text = i.Name;
                            PhoneBox.Text = i.Phone;
                            DriverNameBox.Text = i.DriverName;
                            PriceofHourBox.Text = i.PriceofHour;
                        }
                    }

                if (Classes.SelectedItem.ToString() == "Taxi")
                    foreach (Taxi i in TaxiList)
                    {
                        if (i.NumberofTaxi == Organizations.SelectedItem.ToString())
                        {
                            NameBox.Text = i.Name;
                            PhoneBox.Text = i.Phone;
                            DriverNameBox.Text = i.DriverName;
                            PriceofHourBox.Text = i.PriceofHour;
                            PriceperkmBox.Text = i.Priceperkm;
                            NumberBox.Text = i.NumberofTaxi;
                        }
                    }

                if (Classes.SelectedItem.ToString() == "MiniBus")
                    foreach (MiniBus i in MiniBusList)
                    {
                        if (i.NumberofMiniBus == Organizations.SelectedItem.ToString())
                        {
                            NameBox.Text = i.Name;
                            PhoneBox.Text = i.Phone;
                            DriverNameBox.Text = i.DriverName;
                            PriceofHourBox.Text = i.PriceofHour;
                            PriceperkmBox.Text = i.Size;
                            NumberBox.Text = i.NumberofMiniBus;
                        }
                    }
                if (Classes.SelectedItem.ToString() == "Bus")
                    foreach (Bus i in BusList)
                    {
                        if (i.NumberofBus == Organizations.SelectedItem.ToString())
                        {
                            NameBox.Text = i.Name;
                            PhoneBox.Text = i.Phone;
                            DriverNameBox.Text = i.DriverName;
                            PriceofHourBox.Text = i.PriceofHour;
                            PriceperkmBox.Text = i.TicketPrice;
                            NumberBox.Text = i.NumberofBus;
                        }
                    }
                if (Classes.SelectedItem.ToString() == "Route")
                    foreach (Route i in RouteList)
                    {
                        if (i.RouteNumber == Organizations.SelectedItem.ToString())
                        {
                            NameBox.Text = i.RouteBus.Name;
                            PhoneBox.Text = i.RouteBus.Phone;
                            DriverNameBox.Text = i.RouteBus.DriverName;
                            PriceofHourBox.Text = i.RouteBus.PriceofHour;
                            PriceperkmBox.Text = i.RouteBus.TicketPrice;
                            NumberBox.Text = i.RouteBus.NumberofBus;
                            RouteTimeBox.Text = i.RouteTime;
                            RouteNumberBox.Text = i.RouteNumber;
                        }
                    }
            }
            catch
            {
            }
            
        }

        private void Change_Click(object sender, EventArgs e)
        {
            #region for Organization
            if (Classes.SelectedItem.ToString() == "Organization")
            {
                if (NameBox.Text != "" && PhoneBox.Text != "")
                {
                    int trig = 0;
                    foreach (Organization i in OrganizationList)
                    {
                        if (i.Name == NameBox.Text && i.Name != Organizations.SelectedItem.ToString())
                        {
                            trig++;
                        }
                    }
                    if (trig == 0)
                    {
                        foreach (Organization i in OrganizationList)
                        {
                            if (i.Name == Organizations.SelectedItem.ToString())
                            {
                                i.Name = NameBox.Text;
                                i.Phone = PhoneBox.Text;
                            }
                        }
                        Organizations.Items.Clear();
                        foreach (Organization i in OrganizationList)
                        {
                            Organizations.Items.Add(i.Name);
                        }
                        NameBox.Clear();
                        PhoneBox.Clear();
                    }
                    else { MessageBox.Show("This organization already exists."); }
                }
                else { MessageBox.Show("Fill all fields and choose object."); }
            }
             #endregion
            #region for Driver
            if (Classes.SelectedItem.ToString() == "Driver")
            {
                if (NameBox.Text != "" && PhoneBox.Text != "" && DriverNameBox.Text != "" && PriceofHourBox.Text != "")
                {
                    int trig = 0;
                    foreach (Driver i in DriverList)
                    {
                        if (i.DriverName == DriverNameBox.Text && i.DriverName != Organizations.SelectedItem.ToString())
                        {
                            trig++;
                        }
                    }
                    if (trig == 0)
                    {
                        foreach (Driver i in DriverList)
                        {
                            if (i.DriverName == Organizations.SelectedItem.ToString())
                            {
                                i.Name = NameBox.Text;
                                i.Phone = PhoneBox.Text;
                                i.DriverName = DriverNameBox.Text;
                                i.PriceofHour = PriceofHourBox.Text;
                            }
                        }
                        Organizations.Items.Clear();
                        foreach (Driver i in DriverList)
                        {
                            Organizations.Items.Add(i.DriverName);
                        }
                        NameBox.Clear();
                        PhoneBox.Clear();
                        PriceofHourBox.Clear();
                        DriverNameBox.Clear();
                    }
                    else { MessageBox.Show("This Driver already exists."); }
                }
                else { MessageBox.Show("Fill all fields and choose object."); }
            
 }
            #endregion
            #region for Taxi
            if (Classes.SelectedItem.ToString() == "Taxi")
            {
                if (NameBox.Text != "" && PhoneBox.Text != "" && DriverNameBox.Text != "" && PriceofHourBox.Text != "" &&
                    PriceperkmBox.Text != "" && NumberBox.Text != "")
                {
                    int trig = 0;
                    foreach (Taxi i in TaxiList)
                    {
                        if (i.NumberofTaxi == NumberBox.Text && i.NumberofTaxi != Organizations.SelectedItem.ToString())
                        {
                            trig++;
                        }
                    }
                    if (trig == 0)
                    {
                        foreach (Taxi i in TaxiList)
                        {
                            if (i.NumberofTaxi == Organizations.SelectedItem.ToString())
                            {
                                i.Name = NameBox.Text;
                                i.Phone = PhoneBox.Text;
                                i.DriverName = DriverNameBox.Text;
                                i.PriceofHour = PriceofHourBox.Text;
                                i.Priceperkm = PriceperkmBox.Text;
                                i.NumberofTaxi = NumberBox.Text;
                            }
                        }
                        Organizations.Items.Clear();
                        foreach (Taxi i in TaxiList)
                        {
                            Organizations.Items.Add(i.NumberofTaxi);
                        }
                        NameBox.Clear();
                        PhoneBox.Clear();
                        PriceofHourBox.Clear();
                        DriverNameBox.Clear();
                        PriceperkmBox.Clear();
                        NumberBox.Clear();
                    }
                    else { MessageBox.Show("This Taxi already exists."); }
                }
                else { MessageBox.Show("Fill all fields and choose object."); }

            }
            #endregion
            #region for MiniBus
            if (Classes.SelectedItem.ToString() == "MiniBus")
            {
                if (NameBox.Text != "" && PhoneBox.Text != "" && DriverNameBox.Text != "" && PriceofHourBox.Text != "" &&
                    PriceperkmBox.Text != "" && NumberBox.Text != "")
                {
                    int trig = 0;
                    foreach (MiniBus i in MiniBusList)
                    {
                        if (i.NumberofMiniBus == NumberBox.Text && i.NumberofMiniBus != Organizations.SelectedItem.ToString())
                        {
                            trig++;
                        }
                    }
                    if (trig == 0)
                    {
                        foreach (MiniBus i in MiniBusList)
                        {
                            if (i.NumberofMiniBus == Organizations.SelectedItem.ToString())
                            {
                                i.Name = NameBox.Text;
                                i.Phone = PhoneBox.Text;
                                i.DriverName = DriverNameBox.Text;
                                i.PriceofHour = PriceofHourBox.Text;
                                i.Size = PriceperkmBox.Text;
                                i.NumberofMiniBus = NumberBox.Text;
                            }
                        }
                        Organizations.Items.Clear();
                        foreach (MiniBus i in MiniBusList)
                        {
                            Organizations.Items.Add(i.NumberofMiniBus);
                        }
                        NameBox.Clear();
                        PhoneBox.Clear();
                        PriceofHourBox.Clear();
                        DriverNameBox.Clear();
                        PriceperkmBox.Clear();
                        NumberBox.Clear();
                    }
                    else { MessageBox.Show("This MiniBus already exists."); }
                }
                else { MessageBox.Show("Fill all fields and choose object."); }

            }
            #endregion
            #region for Bus
            if (Classes.SelectedItem.ToString() == "Bus")
            {
                if (NameBox.Text != "" && PhoneBox.Text != "" && DriverNameBox.Text != "" && PriceofHourBox.Text != "" &&
                    PriceperkmBox.Text != "" && NumberBox.Text != "")
                {
                    int trig = 0;
                    foreach (Bus i in BusList)
                    {
                        if (i.NumberofBus == NumberBox.Text && i.NumberofBus != Organizations.SelectedItem.ToString())
                        {
                            trig++;
                        }
                    }
                    if (trig == 0)
                    {
                        foreach (Bus i in BusList)
                        {
                            if (i.NumberofBus == Organizations.SelectedItem.ToString())
                            {
                                i.Name = NameBox.Text;
                                i.Phone = PhoneBox.Text;
                                i.DriverName = DriverNameBox.Text;
                                i.PriceofHour = PriceofHourBox.Text;
                                i.TicketPrice = PriceperkmBox.Text;
                                i.NumberofBus = NumberBox.Text;
                            }
                        }
                        Organizations.Items.Clear();
                        foreach (Bus i in BusList)
                        {
                            Organizations.Items.Add(i.NumberofBus);
                        }
                        NameBox.Clear();
                        PhoneBox.Clear();
                        PriceofHourBox.Clear();
                        DriverNameBox.Clear();
                        PriceperkmBox.Clear();
                        NumberBox.Clear();
                    }
                    else { MessageBox.Show("This MiniBus already exists."); }
                }
                else { MessageBox.Show("Fill all fields and choose object."); }

            }
            #endregion
            #region for Route
            if (Classes.SelectedItem.ToString() == "Route")
            {
                if (NameBox.Text != "" && PhoneBox.Text != "" && DriverNameBox.Text != "" && PriceofHourBox.Text != "" &&
                    PriceperkmBox.Text != "" && NumberBox.Text != "" && RouteNumberBox.Text != "" && RouteTimeBox.Text != "")
                {
                    int trig = 0;
                    foreach (Route i in RouteList)
                    {
                        if (i.RouteNumber == RouteNumberBox.Text && i.RouteNumber != Organizations.SelectedItem.ToString())
                        {
                            trig++;
                        }
                    }
                    if (trig == 0)
                    {
                        foreach (Route i in RouteList)
                        {
                            if (i.RouteNumber == Organizations.SelectedItem.ToString())
                            {
                                i.RouteBus.Name = NameBox.Text;
                                i.RouteBus.Phone = PhoneBox.Text;
                                i.RouteBus.DriverName = DriverNameBox.Text;
                                i.RouteBus.PriceofHour = PriceofHourBox.Text;
                                i.RouteBus.TicketPrice = PriceperkmBox.Text;
                                i.RouteBus.NumberofBus = NumberBox.Text;
                                i.RouteTime = RouteTimeBox.Text;
                                i.RouteNumber = RouteNumberBox.Text;
                            }
                        }
                        Organizations.Items.Clear();
                        foreach (Route i in RouteList)
                        {
                            Organizations.Items.Add(i.RouteNumber);
                        }
                        NameBox.Clear();
                        PhoneBox.Clear();
                        PriceofHourBox.Clear();
                        DriverNameBox.Clear();
                        PriceperkmBox.Clear();
                        NumberBox.Clear();
                        RouteTimeBox.Clear();
                RouteNumberBox.Clear();
                    }
                    else { MessageBox.Show("This MiniBus already exists."); }
                }
                else { MessageBox.Show("Fill all fields and choose object."); }

            }
            #endregion
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            #region For organization
            if (Classes.SelectedItem.ToString() == "Organization")
            {
                foreach (Organization i in OrganizationList)
                {
                    if (i.Name == Organizations.SelectedItem.ToString())
                    {
                        OrganizationList.Remove(i);
                        break;
                    }
                }
                Organizations.Items.Clear();
                foreach (Organization i in OrganizationList)
                {
                    Organizations.Items.Add(i.Name);
                }
                NameBox.Clear();
                PhoneBox.Clear();

            }
 #endregion
            #region For Drivers
            if (Classes.SelectedItem.ToString() == "Driver")
            {
                foreach (Driver i in DriverList)
                {
                    if (i.DriverName == Organizations.SelectedItem.ToString())
                    {
                        DriverList.Remove(i);
                        break;
                    }
                }
                Organizations.Items.Clear();
                foreach (Driver i in DriverList)
                {
                    Organizations.Items.Add(i.DriverName);
                }
                NameBox.Clear();
                PhoneBox.Clear();
                PriceofHourBox.Clear();
                DriverNameBox.Clear();
            }
            #endregion
            #region For Taxi
            if (Classes.SelectedItem.ToString() == "Taxi")
            {
                foreach (Taxi i in TaxiList)
                {
                    if (i.NumberofTaxi == Organizations.SelectedItem.ToString())
                    {
                        TaxiList.Remove(i);
                        break;
                    }
                }
                Organizations.Items.Clear();
                foreach (Taxi i in TaxiList)
                {
                    Organizations.Items.Add(i.NumberofTaxi);
                }
                NameBox.Clear();
                PhoneBox.Clear();
                PriceofHourBox.Clear();
                DriverNameBox.Clear();
                PriceperkmBox.Clear();
                NumberBox.Clear();
            }
            #endregion
            #region For MiniBus
            if (Classes.SelectedItem.ToString() == "MiniBus")
            {
                foreach (MiniBus i in MiniBusList)
                {
                    if (i.NumberofMiniBus == Organizations.SelectedItem.ToString())
                    {
                        MiniBusList.Remove(i);
                        break;
                    }
                }
                Organizations.Items.Clear();
                foreach (MiniBus i in MiniBusList)
                {
                    Organizations.Items.Add(i.NumberofMiniBus);
                }
                NameBox.Clear();
                PhoneBox.Clear();
                PriceofHourBox.Clear();
                DriverNameBox.Clear();
                PriceperkmBox.Clear();
                NumberBox.Clear();
            }
            #endregion
            #region For Bus
            if (Classes.SelectedItem.ToString() == "Bus")
            {
                foreach (Bus i in BusList)
                {
                    if (i.NumberofBus == Organizations.SelectedItem.ToString())
                    {
                        BusList.Remove(i);
                        break;
                    }
                }
                Organizations.Items.Clear();
                foreach (Bus i in BusList)
                {
                    Organizations.Items.Add(i.NumberofBus);
                }
                NameBox.Clear();
                PhoneBox.Clear();
                PriceofHourBox.Clear();
                DriverNameBox.Clear();
                PriceperkmBox.Clear();
                NumberBox.Clear();
            }
            #endregion
            #region For Route
            if (Classes.SelectedItem.ToString() == "Route")
            {
                foreach (Route i in RouteList)
                {
                    if (i.RouteNumber == Organizations.SelectedItem.ToString())
                    {
                        RouteList.Remove(i);
                        break;
                    }
                }
                Organizations.Items.Clear();
                foreach (Route i in RouteList)
                {
                    Organizations.Items.Add(i.RouteNumber);
                }
                NameBox.Clear();
                PhoneBox.Clear();
                PriceofHourBox.Clear();
                DriverNameBox.Clear();
                PriceperkmBox.Clear();
                NumberBox.Clear();
                RouteTimeBox.Clear();
                RouteNumberBox.Clear();
            }
            #endregion
        }

        private void Classes_SelectedIndexChanged(object sender, EventArgs e)
        {
            Organizations.Items.Clear();
            if (Classes.SelectedItem.ToString() == "Organization")
            {
                foreach (Organization i in OrganizationList)
                {
                    Organizations.Items.Add(i.Name);
                }
                label1.Show();
                label2.Show();
                label3.Hide();
                label4.Hide();
                label5.Hide();
                label6.Hide();
                label7.Hide();
                label8.Hide();
                NameBox.Show();
                PhoneBox.Show();
                DriverNameBox.Hide();
                PriceofHourBox.Hide();
                PriceperkmBox.Hide();
                NumberBox.Hide();
                RouteTimeBox.Hide();
                RouteNumberBox.Hide();
            }
            if (Classes.SelectedItem.ToString() == "Driver")
            {
                foreach (Driver i in DriverList)
                {
                    Organizations.Items.Add(i.DriverName);
                }
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Hide();
                label6.Hide();
                label7.Hide();
                label8.Hide();
                NameBox.Show();
                PhoneBox.Show();
                DriverNameBox.Show();
                PriceofHourBox.Show();
                PriceperkmBox.Hide();
                NumberBox.Hide();
                RouteTimeBox.Hide();
                RouteNumberBox.Hide();
            }
            if (Classes.SelectedItem.ToString() == "Taxi")
            {
                label5.Text = "Priceperkm";
                foreach (Taxi i in TaxiList)
                {
                    Organizations.Items.Add(i.NumberofTaxi);
                }
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Hide();
                label8.Hide();
                NameBox.Show();
                PhoneBox.Show();
                DriverNameBox.Show();
                PriceofHourBox.Show();
                PriceperkmBox.Show();
                NumberBox.Show();
                RouteTimeBox.Hide();
                RouteNumberBox.Hide();
            }
            if (Classes.SelectedItem.ToString() == "MiniBus")
            {
                label5.Text = "Size";
                foreach (MiniBus i in MiniBusList)
                {
                    Organizations.Items.Add(i.NumberofMiniBus);
                }
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Hide();
                label8.Hide();
                NameBox.Show();
                PhoneBox.Show();
                DriverNameBox.Show();
                PriceofHourBox.Show();
                PriceperkmBox.Show();
                NumberBox.Show();
                RouteTimeBox.Hide();
                RouteNumberBox.Hide();
            }
            if (Classes.SelectedItem.ToString() == "Bus")
            {
                label5.Text = "TicketPrice";
                foreach (Bus i in BusList)
                {
                    Organizations.Items.Add(i.NumberofBus);
                }
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Hide();
                label8.Hide();
                NameBox.Show();
                PhoneBox.Show();
                DriverNameBox.Show();
                PriceofHourBox.Show();
                PriceperkmBox.Show();
                NumberBox.Show();
                RouteTimeBox.Hide();
                RouteNumberBox.Hide();
            }
            if (Classes.SelectedItem.ToString() == "Route")
            {
                label5.Text = "TicketPrice";
                foreach (Route i in RouteList)
                {
                    Organizations.Items.Add(i.RouteNumber);
                }
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Show();
                label7.Show();
                label8.Show();
                NameBox.Show();
                PhoneBox.Show();
                DriverNameBox.Show();
                PriceofHourBox.Show();
                PriceperkmBox.Show();
                NumberBox.Show();
                RouteTimeBox.Show();
                RouteNumberBox.Show();
            }

        }


        private void Savesr_Click(object sender, EventArgs e)
        {
            string archedfilename;
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            Organizations.Items.Clear();
            AllLists lists = new AllLists();
            lists.SecOrganizationList = OrganizationList;
            lists.SecDriverList = DriverList;
            lists.SecTaxiList = TaxiList;
            lists.SecMiniBusList = MiniBusList;
            lists.SecBusList = BusList;
            lists.SecRouteList = RouteList;
            archedfilename = filename;
            if (SaveLoadBox.SelectedItem.ToString() == "Binary")
            {
                BinarySerialization BS = new BinarySerialization();
                BS.Serialize(lists, filename);
                archedfilename=filename.Replace(".dat","");
            }
            if (SaveLoadBox.SelectedItem.ToString() == "XML")
            {
                XMLSerialization XS = new XMLSerialization();
                XS.Serialize(lists, filename);
                archedfilename=filename.Replace(".xml","");
            }

            if (SaveLoadBox.SelectedItem.ToString() == "Text")
            {
                TextSerialization TX = new TextSerialization();
                TX.Serialize(lists, filename);
                archedfilename=filename.Replace(".txt","");

            }
            if (Plugins.SelectedItem.ToString() == "None")
            {
            }
            else
            {
                foreach (var item in objects)
                {
                    if (Plugins.SelectedItem.ToString() == item.Name)
                    {
                        item.UsePlugin(filename, archedfilename + item.Format);
                    }
                }
            }
        }

        private void Loadsr_Click(object sender, EventArgs e)
        {

            Organizations.Items.Clear();
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            return;
            string filename = openFileDialog1.FileName;
            string dearchedfilename = filename;
            AllLists lists = new AllLists();
            
                
                foreach (var item in objects)
                {
                    if (filename.EndsWith(item.Format))
                    {
                        dearchedfilename = filename.Replace(item.Format,"");
                        if (SaveLoadBox.SelectedItem.ToString() == "Binary")
                        {
                            dearchedfilename = dearchedfilename + ".dat";
                        }

                        if (SaveLoadBox.SelectedItem.ToString() == "XML")
                        {
                            dearchedfilename = dearchedfilename + ".xml";
                        }
                        if (SaveLoadBox.SelectedItem.ToString() == "Text")
                        {
                            dearchedfilename = dearchedfilename + ".txt";
                        }
                        item.DeUsePlugin(filename, dearchedfilename);
                    }
                }
            
            if (SaveLoadBox.SelectedItem.ToString() == "Binary")
            {
                BinarySerialization BS = new BinarySerialization();
                lists = BS.Deserialize(dearchedfilename);  
            }

            if (SaveLoadBox.SelectedItem.ToString() == "XML")
            {
                XMLSerialization XS = new XMLSerialization();
                lists = XS.Deserialize(dearchedfilename);                 
            }
            if (SaveLoadBox.SelectedItem.ToString() == "Text")
            {
                TextSerialization TX = new TextSerialization();
                lists = TX.Deserialize(dearchedfilename);   
            }
            OrganizationList = lists.SecOrganizationList;
            DriverList = lists.SecDriverList;
            TaxiList = lists.SecTaxiList;
            MiniBusList = lists.SecMiniBusList;
            BusList = lists.SecBusList;
            RouteList = lists.SecRouteList;
            File.Delete(dearchedfilename);
            
        }

        





        




   

       

     
    }

    
}
