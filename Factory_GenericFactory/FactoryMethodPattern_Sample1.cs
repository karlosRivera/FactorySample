using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// factory method pattern

namespace Factory_GenericFactory3
{
    public partial class FactoryMethodPattern_Sample1 : Form
    {
        public FactoryMethodPattern_Sample1()
        {
            InitializeComponent();
        }

        IShipFactory _IShipFactory = null;

        private void btnUPS_Click(object sender, EventArgs e)
        {
            _IShipFactory = new ShipperUPSFactory();
            _IShipFactory.GetShipper().Ship();
        }

        private void btnFedEx_Click(object sender, EventArgs e)
        {
            _IShipFactory = new ShipperFexExFactory();
            _IShipFactory.GetShipper().Ship();
        }

        private void btnPurolator_Click(object sender, EventArgs e)
        {
            _IShipFactory = new ShipperPurolatorFactory();
            _IShipFactory.GetShipper().Ship();
        }
    }

    public interface IShip
    {
        void Ship();
    }

    public class ShipperPurolator : IShip
    {
        public void Ship()
        {
            //-- code logic to implement shipping method for Purolator
            MessageBox.Show("Purolator ship start");
        }
    }

    public class ShipperUPS : IShip
    {
        public void Ship()
        {
            //-- code logic to implement shipping method for Purolator
            MessageBox.Show("UPS ship start");
        }
    }

    public class ShipperFedEx : IShip
    {
        public void Ship()
        {
            //-- code logic to implement shipping method for Purolator
            MessageBox.Show("FedEx ship start");
        }
    }

    // factory class start

    public interface IShipFactory
    {
        IShip GetShipper();  
    }

    public class ShipperFexExFactory : IShipFactory
    {
        public IShip GetShipper()
        {
            //-- code logic to implement shipping method for Purolator
            //MessageBox.Show("FedEx ship start");
            return new ShipperFedEx();
        }
    }

    public class ShipperUPSFactory : IShipFactory
    {
        public IShip GetShipper()
        {
            //-- code logic to implement shipping method for Purolator
            return new ShipperUPS();
        }
    }

    public class ShipperPurolatorFactory : IShipFactory
    {
        public IShip GetShipper()
        {
            //-- code logic to implement shipping method for Purolator
            return new ShipperPurolator();
        }
    }
}
