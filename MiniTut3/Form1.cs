using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MiniTut3
{
    enum RoomTypes { Large, Standard, Suite }; // enum available to all code

    public partial class Form1 : Form
    {
        List<Room> roomList = new List<Room>();

        public Form1()
        {
            InitializeComponent();
        }

        private void UpdateListBox()
        {
            listBoxData.Items.Clear();
            foreach (Room room in roomList)
            {
                listBoxData.Items.Add(room);
            }
        }

        private void buttonTest_Click(object sender, EventArgs e)
        {
            try
            {
                Motel m1 = new Motel("Motel Whitianga", "140 Highway 35", "022-315-4618");
                Console.WriteLine(m1);

                m1.AddRoom(100, RoomTypes.Suite, 5);
                Console.WriteLine(m1.GetRoomInfo());

                m1.MotelRoom.Capacity = 3;
                Console.WriteLine(m1.GetRoomInfo());

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            //// create some room objects for testing purposes
            //Room r1 = new Room(100, RoomTypes.Standard, 3);
            //Room r2 = new Room(120, RoomTypes.Large, 4);
            //Room r3 = new Room(140, RoomTypes.Suite, 6);

            //roomList.Add(r1);
            //roomList.Add(r2);
            //roomList.Add(r3);
            //// another way to add an object 
            //roomList.Add(new Room(134, RoomTypes.Suite, 16));
            //roomList.Add(new Room(135, RoomTypes.Large, 3));

            //r1.Capacity = 50;

            //// the foreach loop makes the list read only
            //// you can't add or remove elements from the list inside the foreach loop
            //// you can change values inside the objects
            //foreach (Room room in roomList)
            //{
            //    Console.WriteLine(room);
            //}
            //UpdateListBox();

            ////for(int i = 0; roomList.Count; i++)
            ////{
            ////    Console.WriteLine(roomList[i]);
            ////}

            ////// display the room information in the listbox
            ////listBoxData.Items.Add(r1);
            ////listBoxData.Items.Add(r2);
            ////listBoxData.Items.Add(r3);
            ////// change the capacity of a room and re-display it
            ////r1.Capacity = 5;
            ////listBoxData.Items.Add(r1);
        }

        private void buttonAddRoom_Click(object sender, EventArgs e)
        {
            int roomNo = 0;
            RoomTypes roomType;
            int capacity = 0;

            try
            {
                roomNo = int.Parse(textBoxRoomNo.Text);
                roomType = (RoomTypes)Enum.Parse(typeof(RoomTypes), comboBoxRoomType.Text);
                capacity = int.Parse(textBoxCapcity.Text);

                roomList.Add(new Room(roomNo, roomType, capacity));
                UpdateListBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter writer;

            openFileDialog1.Filter = "CSV FIles|*.csv|All Files|*.*";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                writer = File.CreateText(saveFileDialog1.FileName);
                foreach (Room r in roomList)
                {
                    writer.WriteLine(r.ToCsvString());
                }
                writer.Close();
            }
        }

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader reader;
            string line = "";
            string[] csvArray;
            int roomNo = 0;
            RoomTypes roomType;
            int capacity = 0;

            roomList.Clear();
            listBoxData.Items.Clear();

            openFileDialog1.Filter = "CSV FIles|*.csv|All Files|*.*";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                reader = File.OpenText(openFileDialog1.FileName);
                while(!reader.EndOfStream)
                {
                    try
                    {
                        line = reader.ReadLine();
                        csvArray = line.Split(',');
                        if (csvArray.Length == 3)
                        {
                            roomNo = int.Parse(csvArray[0]);
                            roomType = (RoomTypes)Enum.Parse(typeof(RoomTypes), csvArray[1]);
                            capacity = int.Parse(csvArray[2]);

                            roomList.Add(new Room(roomNo, roomType, capacity));
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Error: " + line);
                    }
                }
                reader.Close();
                UpdateListBox();
            }
        }
    }
}
