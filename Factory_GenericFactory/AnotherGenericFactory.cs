using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Factory_GenericFactory4
{
    public partial class AnotherGenericFactory : Form
    {
        public AnotherGenericFactory()
        {
            InitializeComponent();
        }

        private void btnUPS_Click(object sender, EventArgs e)
        {
            ShipperFactory.CreateInstance(Shipper.UPS).Ship();
        }

        private void btnFedEx_Click(object sender, EventArgs e)
        {
            ShipperFactory.CreateInstance(Shipper.FedEx).Ship();
        }

        private void btnPurolator_Click(object sender, EventArgs e)
        {
            ShipperFactory.CreateInstance(Shipper.Purolator).Ship();
        }
    }

    public enum Shipper
    {
        UPS,
        FedEx,
        Purolator
    }

    public interface IShip
    {
        void Ship();
    }

    public abstract class ShipperBase : IShip
    {
        //Etc
        public abstract void Ship();

    }

    public class ShipperUPS : ShipperBase
    {
        public override void Ship()
        {
            //-- code logic to implement shipping method for Purolator
            MessageBox.Show("UPS ship start");
        }
    }

    public class ShipperFedEx : ShipperBase
    {
        public override void Ship()
        {
            //-- code logic to implement shipping method for Purolator
            MessageBox.Show("FedEX ship start");
        }
    }

    public class ShipperPurolator : ShipperBase
    {
        public override void Ship()
        {
            //-- code logic to implement shipping method for Purolator
            MessageBox.Show("Purolator ship start");
        }
    }

    public class ShipperFactory
    {
        private static TShip Create<TShip>()
            where TShip : IShip, // interface contract constraint
            new() // public parameter-less constructor constraint
        {
            return new TShip();
        }

        public static readonly IDictionary<Shipper, Func<IShip>> Creators =
            new Dictionary<Shipper, Func<IShip>>()
        {
            { Shipper.UPS, () => Create<ShipperUPS>() },
            { Shipper.FedEx, () => Create<ShipperFedEx>() },
            { Shipper.Purolator, () => Create<ShipperPurolator>() }
        };

        public static IShip CreateInstance(Shipper enumModuleName)
        {
            return Creators[enumModuleName]();
        }
    }
}
