using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
        class Organization
        {
            public string Name { get; set; }
            public string Phone { get; set; }
            public Organization(string Name, string Phone)
            {
                this.Name = Name;
                this.Phone = Phone;
            }
        }

        class Driver : Organization
        {
            public string DriverName { get; set; }
            public string PriceofHour { get; set; }
            public Driver(string Name, string Phone, string DriverName, string PriceofHour)
                : base(Name, Phone)
            {
                this.DriverName = DriverName;
                this.PriceofHour = PriceofHour;
            }
        }

        class Taxi : Driver
        {
            public string NumberofTaxi { get; set; }
            public string Priceperkm { get; set; }
            public Taxi(string Name, string Phone, string DriverName, string PriceofHour, string Priceperkm,string NumberofTaxi)
                : base(Name, Phone, DriverName, PriceofHour)
            {
                this.Priceperkm = Priceperkm;
                this.NumberofTaxi = NumberofTaxi;
            }
        }

        class MiniBus : Driver
        {
            public string NumberofMiniBus { get; set; }
            public string Size { get; set; }
            public MiniBus(string Name, string Phone, string DriverName, string PriceofHour, string Size, string NumberofMiniBus)
                : base(Name, Phone, DriverName, PriceofHour)
            {
                this.Size = Size;
                this.NumberofMiniBus = NumberofMiniBus;
            }
        }

        class Bus : Driver
        {
            public string NumberofBus { get; set; }
            public string TicketPrice { get; set; }
            public Bus(string Name, string Phone, string DriverName, string PriceofHour, string TicketPrice, string NumberofBus)
                : base(Name, Phone, DriverName, PriceofHour)
            {
                this.TicketPrice = TicketPrice;
                this.NumberofBus = NumberofBus;
            }
        }

        class Route 
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
        //List<Bus> RouteBusList = new List<Bus>(0);
        public int Num_Organization = 0;
        public int Num_Driver = 0;
        public int Num_Taxi = 0;
        public int Num_MiniBus = 0;
        public int Num_Bus = 0;
        public int Num_Route = 0;
        //public int Num_RouteBus = 0;

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
                //RouteBusList.Capacity++;
                //Num_RouteBus++;
                //RouteBusList.Add(new Bus(NameBox.Text, PhoneBox.Text, DriverNameBox.Text, PriceofHourBox.Text, PriceperkmBox.Text, NumberBox.Text));
                Bus fn = new Bus(NameBox.Text, PhoneBox.Text, DriverNameBox.Text, PriceofHourBox.Text, PriceperkmBox.Text, NumberBox.Text);
                RouteList.Add(new Route(fn, RouteTimeBox.Text, RouteNumberBox.Text));
                //RouteBusList[RouteBusList.Count - 1]
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


        }

        private void Organizations_Click(object sender, EventArgs e)
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
                        NumberBox.Text=i.NumberofTaxi;
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

        





        




   

       

     
    }

    
}
