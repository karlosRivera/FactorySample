using System;
using System.Reflection;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory_GenericFactory6
{
    public partial class GenericWithReflection : Form
    {
        public GenericWithReflection()
        {
            InitializeComponent();
        }

        ShipperFactory oFactory = null;

        private void btnUPS_Click(object sender, EventArgs e)
        {
           oFactory = new ShipperFactory();
           oFactory.CreateInstance(Shippers.UPS).Ship();
        }

        private void btnFedEx_Click(object sender, EventArgs e)
        {
            oFactory = new ShipperFactory();
            oFactory.CreateInstance(Shippers.FedEx).Ship();
        }

        private void btnPurolator_Click(object sender, EventArgs e)
        {
            oFactory = new ShipperFactory();
            oFactory.CreateInstance(Shippers.Purolator).Ship();
        }
    }


    public interface IShip
    {
        Shippers Shipper { get; }
        void Ship();
    }

    public enum Shippers
    {
        UPS,
        FedEx,
        Purolator,
    }

    public class UPSShipper : IShip
    {
        public Shippers Shipper
        {
            get
            {
                return Shippers.UPS;
            }
        }

        public void Ship()
        {
            /*TODO: Implement*/
            MessageBox.Show("UPS Service");
        }
    }

    public class FedExShipper : IShip
    {
        public Shippers Shipper
        {
            get
            {
                return Shippers.FedEx;
            }
        }

        public void Ship() {  
            /*TODO: Implement*/
            MessageBox.Show("FedEx Service");
        }
    }

    public class PurolatorShipper : IShip
    {
        public Shippers Shipper
        {
            get
            {
                return Shippers.Purolator;
            }
        }

        public void Ship()
        {
            /*TODO: Implement*/
            MessageBox.Show("Purolator Service");
        }
    }
    //Add additional implementations

    public class ShipperFactory
    {
        public Dictionary<Shippers, Func<IShip>> shipperCreators { get; private set; }

        public ShipperFactory()
        {
            //Here, we use reflection and Linq to find all IShip implementations;
            //other methods to dynamically set up the dictionary exist
            shipperCreators = Assembly.GetExecutingAssembly().GetTypes()
                .Where(t => typeof(IShip).IsAssignableFrom(t) && t.IsInterface == false)
                .Select(t => new Func<IShip>(() => Activator.CreateInstance(t) as IShip))
                .ToDictionary(f => f().Shipper);
        }

        public IShip CreateInstance(Shippers type)
        {
            return shipperCreators[type]();
        }

        public Func<IShip> GetFactoryMethod(Shippers type)
        {
            return shipperCreators[type];
        }
    }
}
