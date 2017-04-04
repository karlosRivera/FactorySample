using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory_GenericFactory
{
    public partial class FactorySample1 : Form
    {
        public FactorySample1()
        {
            InitializeComponent();
        }

        IShip objActivity = null;


        private void btnUPS_Click(object sender, EventArgs e)
        {
            objActivity = ShipperFactory.CreateInstance(Shipper.UPS);
            objActivity.Ship();
        }

        private void btnFedEx_Click(object sender, EventArgs e)
        {
            objActivity = ShipperFactory.CreateInstance(Shipper.FedEx);
            objActivity.Ship();
        }

        private void btnPurolator_Click(object sender, EventArgs e)
        {
            objActivity = ShipperFactory.CreateInstance(Shipper.Purolator);
            objActivity.Ship();
        }
    }

    public enum Shipper
    {
        UPS = 1,
        FedEx = 2,
        Purolator = 3
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

    public class ShipperFexEx : IShip
    {
        public void Ship()
        {
            //-- code logic to implement shipping method for Purolator
            MessageBox.Show("FedEx ship start");
        }
    }

    public class ShipperFactory
    {
        public static IShip CreateInstance(Shipper enumModuleName)
        {
            IShip objActivity = null;

            switch (enumModuleName)
            {
                case Shipper.UPS:
                    objActivity = new ShipperUPS();
                    break;
                case Shipper.FedEx:
                    objActivity = new ShipperFexEx();
                    break;
                case Shipper.Purolator:
                    objActivity = new ShipperPurolator();
                    break;
                default:
                    break;
            }
            return objActivity;
        }
    }
}
