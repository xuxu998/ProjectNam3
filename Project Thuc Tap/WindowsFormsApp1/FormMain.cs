using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.IO;
using System.Xml;
using System.Threading;

namespace WindowsFormsApp1
{
    public partial class AGVData : Form
    {
        private string user;
        public AGVData(string user)
        {
            InitializeComponent();
            List<string> Product = new List<string> { "None", "1", "2" };
            List<string> StatusStation1 = new List<string> { "Deliver", "Not Deliver" };
            List<string> StatusStation2 = new List<string> { "Deliver", "Not Deliver" };
            string [] Ports = SerialPort.GetPortNames();
            string[] BaudRate1 = { "1200", "2400", "4800", "9600", "19200", "38400", "57600", "115200" };
            PortCb.DataSource = Ports;
            BaudRate.DataSource = BaudRate1;
            BaudRate.SelectedIndex = 3;
            cmbDeliver1.DataSource = StatusStation1;
            cmbDeliver2.DataSource = StatusStation2;
            cmbMaterial.DataSource = Product;
            this.user = user;
            timer1.Interval = 2500;
            timer1.Enabled = false;
            Available1.ForeColor = Color.Green;
            Available2.ForeColor = Color.Green;
            Available3.ForeColor = Color.Green;
         //  Battery.Enabled = false;
            AGV.DataSource = Hiden.AGVdata("select * from AGV");

       
        }
        

        private void FormMain_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Startbtn_Click(object sender, EventArgs e)
        {
            int Case = 0;
            if (serialPort1.IsOpen == true)
            {
                var tagCmdList = new List<TagCommand>();
                var tagCmdForward = new List<TagCommand>();
                var tagCmdBackward = new List<TagCommand>();
                // string simu = "";

                //int i;
                if (cmbDeliver1.SelectedItem.ToString() == "Deliver" && cmbDeliver2.SelectedItem.ToString() == "Deliver")
                {
                    Case = 1;
                    for (int i = 1; i < 6; i++)
                    {
                        TagCommand tagCmdTemp = new TagCommand();
                        tagCmdTemp.TagId = (byte)(i);
                        if (i == 1)
                        { tagCmdTemp.setTagCommand("Collect " + cmbMaterial.SelectedItem.ToString()); }
                        else if (i == 2 || i == 4)
                        { tagCmdTemp.setTagCommand("Right"); }
                        else
                        { tagCmdTemp.setTagCommand("Deliver"); }

                        tagCmdList.Add(tagCmdTemp);
                    }
                    // old code
                    for (int i = 5; i > 0; i--)
                    {
                        TagCommand tagCmdTemp = new TagCommand();
                        tagCmdTemp.TagId = (byte)(i);
                        if (i == 4 || i == 2 || i == 1)
                        {
                            tagCmdTemp.setTagCommand("Straight");
                        }
                        if (i == 5 || i == 3)
                        {
                            tagCmdTemp.setTagCommand("Left");
                        }
                        tagCmdList.Add(tagCmdTemp);
                    }
                    // new code
                    /* for(int i=5;i>0;i--)
                     {
                         TagCommand tagCmdTemp = new TagCommand();
                         tagCmdTemp.TagId = (byte)(i);
                         if (i == 5)
                         {
                            tagCmdTemp.setTagCommand("Reverse");
                         }
                         else {
                            tagCmdTemp.setTagCommand("Straight");
                         }
                         tagCmdList.Add(tagCmdTemp);

                     }*/

                }
                if (cmbDeliver1.SelectedItem.ToString() == "Not Deliver" && cmbDeliver2.SelectedItem.ToString() == "Deliver")
                {
                    Case = 2;
                    for (int i = 1; i < 6; i++)
                    {
                        TagCommand tagCmdTemp = new TagCommand();
                        tagCmdTemp.TagId = (byte)(i);
                        if (i == 1)
                        { tagCmdTemp.setTagCommand("Collect " + cmbMaterial.SelectedItem.ToString()); }
                        else if (i == 2 || i == 4)
                        { tagCmdTemp.setTagCommand("Right"); }
                        else if (i == 3)
                        {
                            tagCmdTemp.setTagCommand("Straight");
                        }
                        else
                        { tagCmdTemp.setTagCommand("Deliver"); }
                        tagCmdList.Add(tagCmdTemp);
                    }
                    // old code
                    for (int i = 5; i > 0; i--)
                    {
                        TagCommand tagCmdTemp = new TagCommand();
                        tagCmdTemp.TagId = (byte)(i);
                        if (i == 4 || i == 2 || i == 1)
                        {
                            tagCmdTemp.setTagCommand("Straight");
                        }
                        if (i == 5 || i == 3)
                        {
                            tagCmdTemp.setTagCommand("Left");
                        }
                        tagCmdList.Add(tagCmdTemp);
                    }
                    // new code
                    /*for(int i=5;i>0;i++)
                     {
                         TagCommand tagCmdTemp = new TagCommand();
                         tagCmdTemp.TagId = (byte)(i);
                         if (i == 5)
                             {
                             tagCmdTemp.setTagCommand("Reverse");
                         }
                         else {
                             tagCmdTemp.setTagCommand("Straight");
                         }
                         tagCmdList.Add(tagCmdTemp);
                     }*/
                }
                if (cmbDeliver1.SelectedItem.ToString() == "Deliver" && cmbDeliver2.SelectedItem.ToString() == "Not Deliver")
                {
                    Case = 3;
                    for (int i = 1; i < 5; i++)
                    {
                        TagCommand tagCmdTemp = new TagCommand();
                        tagCmdTemp.TagId = (byte)(i);
                        if (i == 1)
                        { tagCmdTemp.setTagCommand("Collect " + cmbMaterial.SelectedItem.ToString()); }
                        else if (i == 2)
                        { tagCmdTemp.setTagCommand("Right"); }
                        else if (i == 3)
                        { tagCmdTemp.setTagCommand("Deliver"); }
                        else
                        { tagCmdTemp.setTagCommand("Reverse"); }
                        tagCmdList.Add(tagCmdTemp);
                    }

                    for (int i = 4; i > 0; i--)
                    {
                        TagCommand tagCmdTemp = new TagCommand();
                        tagCmdTemp.TagId = (byte)(i);
                        if (i == 4 || i == 2 || i == 1)
                        {
                            tagCmdTemp.setTagCommand("Straight");
                        }
                        if (i == 5 || i == 3)
                        {
                            tagCmdTemp.setTagCommand("Left");
                        }
                        tagCmdList.Add(tagCmdTemp);
                    }
                    //new
                    /*for (int i = 5; i > 0; i++)
                    {
                        TagCommand tagCmdTemp = new TagCommand();
                        tagCmdTemp.TagId = (byte)(i);
                        if (i == 3)
                        {  tagCmdTemp.setTagCommand("Reverse"); }
                        else { tagCmdTemp.setTagCommand("Straight"); }
                        tagCmdList.Add(tagCmdTemp);
                    }*/

                }
                byte[] tripRouteData = new byte[tagCmdList.Count * 2];
                int idx = 0;
                foreach (TagCommand _tagCommand in tagCmdList)
                {
                    byte[] idCmdPair = _tagCommand.getIdCmdPair();
                    Buffer.BlockCopy(idCmdPair, 0, tripRouteData, idx, idCmdPair.Length);
                    idx += idCmdPair.Length;
                }
                Route s = new Route();
                s.setOutput(0x01, tripRouteData);
                txtOutput.Text = BitConverter.ToString(s.OutputPacket);

                if (Case == 2)
                { byte[] case1 = { 0x7A , 0x19 , 0xFE , 0x01 ,0x01 , 0x13 , 0x01 , 0x08 ,0x02 , 0x04, 0x03 , 0x03 , 0x04 , 0x06 ,0x04 , 0x02 , 0x03 , 0x01 , 0x02 , 0x01  ,0x01 ,0x09 ,0x7F }; serialPort1.Write(case1, 0, 23); }
                if (Case == 1)
                { byte[] case2 = {  }; serialPort1.Write(case2, 0, 8); }
                if(Case == 3)
                { byte[] case3 = {  }; serialPort1.Write(case3, 0, 8); }
            
                //byte[] data = 
                //string Temp = txtOutput.Text;

                // Luu vao co so du lieu
                int statusStation = Hiden.StatusStation(cmbDeliver1.SelectedItem.ToString(), cmbDeliver2.SelectedItem.ToString());
                DateTime time = DateTime.Now;
                string time1 = Hiden.Date(time.ToString());
                switch (statusStation)
                {

                    case 1:
                        Hiden.Data("insert into HistoryDelivery values('" + this.user + "','" + time1 + "','" + "2'" + ",'1'," + "'Type " + this.cmbMaterial.SelectedItem.ToString() + "')");
                        Hiden.Data("insert into HistoryDelivery values('" + this.user + "','" + time1 + "','" + "1'" + ",'1'," + "'Type " + this.cmbMaterial.SelectedItem.ToString() + "')");
                        break;
                    case 2:
                        Hiden.Data("insert into HistoryDelivery values('" + this.user + "','" + time1 + "','" + "2'" + ",'1'," + "'Type " + this.cmbMaterial.SelectedItem.ToString() + "')");
                        break;
                    case 3:
                        Hiden.Data("insert into HistoryDelivery values('" + this.user + "','" + time1 + "','" + "1'" + ",'1'," + "'Type " + this.cmbMaterial.SelectedItem.ToString() + "')");
                        break;
                }
                timer1.Enabled = true;
                Call1.Enabled = true;
                Call2.Enabled = true;
                Call3.Enabled = true;
            }
            else
            {
                MessageBox.Show("Your port is not available !");
            }
            //Simulation simu1 = new Simulation(simu);
            //simu1.Show();
            
        }


        private void cmbMaterial_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           // if (cmbMaterial.SelectedIndex == 0)
            //{
              //  this.Box.Enabled = false;
           // }
           // else this.Box.Enabled = true;
        }

        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void Connectbtn_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.PortName = PortCb.Text;
                //serialPort1.Open();
                if (serialPort1.IsOpen == false)
                {
                    bool status = false;
                    if (BaudRate.SelectedItem.ToString() != serialPort1.BaudRate.ToString())
                    {

                        MessageBox.Show("Choose the baud rate again!");
                        status = true;

                    }
                    if (status == false)
                    {
                        serialPort1.Open();
                        if (serialPort1.IsOpen == true)
                        {
                            Connectbtn.Text = "Connected";
                            Connectbtn.ForeColor = Color.Green;
                            MessageBox.Show("Your port is connected successfully");
                            Connectbtn.Enabled = false;
                        }
                        else
                        {
                            MessageBox.Show("Your port is not connected successfully. Please try again");

                        }

                    }

                }
            }
            catch
            {
                MessageBox.Show("There is no port available");
            }
            
        }

        private void Disconnectbtn_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            if(serialPort1.IsOpen==false)
            {
                Connectbtn.Enabled = true;
                Connectbtn.Text = "Connect";
                Connectbtn.ForeColor = Color.Black;
                MessageBox.Show("Your port is disconnected successfully");
            }
            else
            {
                MessageBox.Show("Your port can not be disconnected at the moment");
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            int i = 0;
        }

        private void Call1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }
       // int i = 0;
       /* private void timer1_Tick(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen == true)
            {
                byte[] c = { 0x04};
                serialPort1.Write(c, 0, 1);
                int s = serialPort1.ReadByte();
                txtOutput.Text = s.ToString();
                if (s == 48)
                {
                    Available1.Text = "Ready";
                    Available1.ForeColor = Color.Green;
                    Call1.Enabled = true;
                    Available2.Text = "Ready";
                    Available2.ForeColor = Color.Green;
                    Call2.Enabled = true;
                    Available3.Text = "Ready";
                    Available3.ForeColor = Color.Green;
                    Call3.Enabled = true;
                }
                if (s == 49)
                {
                    Available1.Text = "Ready";
                    Available1.ForeColor = Color.Green;
                    Call1.Enabled = true;
                    Available2.Text = "Ready";
                    Available2.ForeColor = Color.Green;
                    Call2.Enabled = true;
                    Available3.Text = "Not Ready";
                    Available3.ForeColor = Color.Red;
                    Call3.Enabled = false;
                }
                if (s == 50)
                {
                    Available1.Text = "Ready";
                    Available1.ForeColor = Color.Green;
                    Call1.Enabled = true;
                    Available2.Text = "Not Ready";
                    Available2.ForeColor = Color.Red;
                    Call2.Enabled = false;
                    Available3.Text = "Ready";
                    Available3.ForeColor = Color.Green;
                    Call3.Enabled = true;
                }
                if (s == 51)
                {
                    Available1.Text = "Ready";
                    Available1.ForeColor = Color.Green;
                    Call1.Enabled = true;
                    Available2.Text = "Not Ready";
                    Available2.ForeColor = Color.Red;
                    Call2.Enabled = false;
                    Available3.Text = "Not Ready";
                    Available3.ForeColor = Color.Red;
                    Call3.Enabled = false;
                }
                if (s == 52)
                {
                    Available1.Text = "Not Ready";
                    Available1.ForeColor = Color.Red;
                    Call1.Enabled = false;
                    Available2.Text = "Ready";
                    Available2.ForeColor = Color.Green;
                    Call2.Enabled = true;
                    Available3.Text = "Ready";
                    Available3.ForeColor = Color.Green;
                    Call3.Enabled = true;
                }
                if (s == 53)
                {
                    Available1.Text = "Not Ready";
                    Available1.ForeColor = Color.Red;
                    Call1.Enabled = false;
                    Available2.Text = "Ready";
                    Available2.ForeColor = Color.Green;
                    Call2.Enabled = true;
                    Available3.Text = "Not Ready";
                    Available3.ForeColor = Color.Red;
                    Call3.Enabled = false;
                }
                if (s == 54)
                {
                    Available1.Text = "Not Ready";
                    Available1.ForeColor = Color.Red;
                    Call1.Enabled = false;
                    Available2.Text = "Not Ready";
                    Available2.ForeColor = Color.Red;
                    Call2.Enabled = false;
                    Available3.Text = "Ready";
                    Available3.ForeColor = Color.Green;
                    Call3.Enabled = true;
                }
                if (s == 55)
                {
                    Available1.Text = "Not Ready";
                    Available1.ForeColor = Color.Red;
                    Call1.Enabled = false;
                    Available2.Text = "Not Ready";
                    Available2.ForeColor = Color.Red;
                    Call2.Enabled = false;
                    Available3.Text = "Not Ready";
                    Available3.ForeColor = Color.Red;
                    Call3.Enabled = false;
                }
            }*/
            /*if(serialPort1.IsOpen==true)
            {
                i++;
                txtOutput.Text = i.ToString();
            }*/

       // }

        private void button1_Click(object sender, EventArgs e)
        {
            Call1.Enabled = false;
            Call2.Enabled = false;
            Call3.Enabled = false;
           // timer1.Enabled = false;
            if (Call1.Checked == true)
            {
                byte agv = 0x01;
                agvAvailable agv1 = new agvAvailable(agv);
                txtOutput.Text = BitConverter.ToString(agv1.OutputPacket);
                serialPort1.Write(agv1.OutputPacket, 0, agv1.OutputPacket.Length);

            }
            if (Call2.Checked == true)
            {
                byte agv = 0x02;
                agvAvailable agv1 = new agvAvailable(agv);
                txtOutput.Text = BitConverter.ToString(agv1.OutputPacket);
            }
        }
        
/*        private void Confirm_Click(object sender, EventArgs e)
        {
            Thread AGV = new Thread(
                delegate ()
                {
                    if (serialPort1.IsOpen == true)
                    {
                        byte[] c = { 0x99 };
                        serialPort1.Write(c, 0, 1);
                        int s = serialPort1.ReadByte();
                        txtOutput.Text = s.ToString();
 
                        if (s == 48)
                        {
                            Available1.Text = "Ready";
                            Available1.ForeColor = Color.Green;
                            Call1.Enabled = true;
                            Available2.Text = "Ready";
                            Available2.ForeColor = Color.Green;
                            Call2.Enabled = true;
                            Available3.Text = "Ready";
                            Available3.ForeColor = Color.Green;
                            Call3.Enabled = true;
                        }
                        if (s == 49)
                        {
                            Available1.Text = "Ready";
                            Available1.ForeColor = Color.Green;
                            Call1.Enabled = true;
                            Available2.Text = "Ready";
                            Available2.ForeColor = Color.Green;
                            Call2.Enabled = true;
                            Available3.Text = "Not Ready";
                            Available3.ForeColor = Color.Red;
                            Call3.Enabled = false;
                        }
                        if (s == 50)
                        {
                            Available1.Text = "Ready";
                            Available1.ForeColor = Color.Green;
                            Call1.Enabled = true;
                            Available2.Text = "Not Ready";
                            Available2.ForeColor = Color.Red;
                            Call2.Enabled = false;
                            Available3.Text = "Ready";
                            Available3.ForeColor = Color.Green;
                            Call3.Enabled = true;
                        }
                        if (s == 51)
                        {
                            Available1.Text = "Ready";
                            Available1.ForeColor = Color.Green;
                            Call1.Enabled = true;
                            Available2.Text = "Not Ready";
                            Available2.ForeColor = Color.Red;
                            Call2.Enabled = false;
                            Available3.Text = "Not Ready";
                            Available3.ForeColor = Color.Red;
                            Call3.Enabled = false;
                        }
                        if (s == 52)
                        {
                            Available1.Text = "Not Ready";
                            Available1.ForeColor = Color.Red;
                            Call1.Enabled = false;
                            Available2.Text = "Ready";
                            Available2.ForeColor = Color.Green;
                            Call2.Enabled = true;
                            Available3.Text = "Ready";
                            Available3.ForeColor = Color.Green;
                            Call3.Enabled = true;
                        }
                        if (s == 53)
                        {
                            Available1.Text = "Not Ready";
                            Available1.ForeColor = Color.Red;
                            Call1.Enabled = false;
                            Available2.Text = "Ready";
                            Available2.ForeColor = Color.Green;
                            Call2.Enabled = true;
                            Available3.Text = "Not Ready";
                            Available3.ForeColor = Color.Red;
                            Call3.Enabled = false;
                        }
                        if (s == 54)
                        {
                            Available1.Text = "Not Ready";
                            Available1.ForeColor = Color.Red;
                            Call1.Enabled = false;
                            Available2.Text = "Not Ready";
                            Available2.ForeColor = Color.Red;
                            Call2.Enabled = false;
                            Available3.Text = "Ready";
                            Available3.ForeColor = Color.Green;
                            Call3.Enabled = true;
                        }
                        if (s == 55)
                        {
                            Available1.Text = "Not Ready";
                            Available1.ForeColor = Color.Red;
                            Call1.Enabled = false;
                            Available2.Text = "Not Ready";
                            Available2.ForeColor = Color.Red;
                            Call2.Enabled = false;
                            Available3.Text = "Not Ready";
                            Available3.ForeColor = Color.Red;
                            Call3.Enabled = false;
                        }
                        Thread.Sleep(50);
                    }
                }
                );
            AGV.Start();    

        }*/

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            System.Threading.Thread.Sleep(500);
            int count = 0;
            int inputLength = serialPort1.ReadBufferSize;
            byte[] input = new byte[inputLength];
            count = serialPort1.Read(input, 0, inputLength);

            byte[] data = new byte[count];
            Buffer.BlockCopy(input, 0, data, 0, count);

            if (data[0] == Packet.START_BYTE && data[1] == count && data[count - 1] == Packet.END_BYTE)
            {
                Packet rxpacket = new Packet();
                byte message_type = rxpacket.getMessageType(data);
                if (message_type == Packet.AGV_PARAM_TYPE)
                {
                    agvParam paramPacket = new agvParam();
                    paramPacket.parsePacket(data);

                    // Display data
                    Invoke(new MethodInvoker(() => LBPosition.Text = paramPacket.Position_agv.ToString()));
                    Invoke(new MethodInvoker(() => LBSpeed.Text = paramPacket.Speed_agv.ToString()));
                    Invoke(new MethodInvoker(() => LBStatus.Text = paramPacket.Status_agv()));
                    Invoke(new MethodInvoker(() => LBBattery.Text = paramPacket.Battery_agv.ToString()));


                }

            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
