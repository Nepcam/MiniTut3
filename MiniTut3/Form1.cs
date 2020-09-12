using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiniTut3
{
    enum RoomTypes { Large, Standard, Suite }; // enum available to all code
    
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            Room r1 = new Room(100, RoomTypes.Standard, 3);
            Room r2 = new Room(120, RoomTypes.Large, 4);
            Room r3 = new Room(140, RoomTypes.Suite, 6);

            listBoxData.Items.Add(r1);
            listBoxData.Items.Add(r2);
            listBoxData.Items.Add(r3);

            r1.Capacity = 5;
            listBoxData.Items.Add(r1);
        }
    }
}
