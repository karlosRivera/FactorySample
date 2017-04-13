using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// code taken from this url http://stackoverflow.com/questions/40307029/c-sharp-how-to-return-instance-dynamically-by-generic

namespace Factory_GenericFactory5
{
    public partial class MiscGenericSample : Form
    {
        public MiscGenericSample()
        {
            InitializeComponent();
        }

        public static T GetInstance<T>(Importance objType)
        {
            if (objType == Importance.Employee)
                return (T)Convert.ChangeType((new Employee()), typeof(T));
            else
                return (T)Convert.ChangeType((new Teacher()), typeof(T));
        }

        public static T GetInstance<T>() where T : class, new()
        {
            return new T();
        }

        private void btnUPS_Click(object sender, EventArgs e)
        {
            Employee employee = GetInstance<Employee>(Importance.Employee);
            Teacher teacher = GetInstance<Teacher>(Importance.Teacher);

            Console.WriteLine(employee.GetType());
            Console.WriteLine(teacher.GetType());

            Console.ReadKey();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee employee = GetInstance<Employee>();
            Teacher teacher = GetInstance<Teacher>();

            Console.WriteLine(employee.GetType());
            Console.WriteLine(teacher.GetType());

            Console.ReadKey();
        }
    }

    public class Employee
    {
        string ID = "1";
        string Name = "i am employee";
    }

    public class Teacher
    {
        string ID = "2";
        string Name = "i am Teacher";
    }

    public enum Importance
    {
        Employee,
        Teacher
    };
}
