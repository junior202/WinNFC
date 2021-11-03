using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InTheHand.Net;
using InTheHand.Net.Bluetooth;
using InTheHand.Net.Sockets;

namespace WinNFC
{
    public partial class Form1 : Form
    {
        String serialPortName;


        /// <summary>
        /// 多线程的创建和管理
        /// </summary>
        /// 

       // Dictionary<string, Thread> dict = new Dictionary<string, Thread>();
        
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 搜索蓝牙
        /// </summary>
        /// <returns></returns>
        public static Dictionary<string, BluetoothAddress> GetClientBluetooth()
        {
            BluetoothRadio radio = BluetoothRadio.PrimaryRadio;//获取蓝牙适配器
            
                Dictionary<string, BluetoothAddress> dicBluetooth = new Dictionary<string, BluetoothAddress>();
                BluetoothClient client = new BluetoothClient();
                BluetoothDeviceInfo[] devices = client.DiscoverDevices();//搜索蓝牙 10秒钟
                foreach (BluetoothDeviceInfo d in devices)
                {
                    dicBluetooth[d.DeviceName] = d.DeviceAddress;
                }
                return dicBluetooth;
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x0219)
            {//设备改变
                if (m.WParam.ToInt32() == 0x8004)
                {//usb串口拔出
                    string[] ports = System.IO.Ports.SerialPort.GetPortNames();//重新获取串口
                    NFC_Port.Items.Clear();//清除comboBox里面的数据
                    NFC_Port.Items.AddRange(ports);//给comboBox1添加数据
                    if (Bt_NFC.Text == "关闭设备")
                    {//用户打开过串口
                        if (!serialPort1.IsOpen)
                        {//用户打开的串口被关闭:说明热插拔是用户打开的串口
                            Bt_NFC.Text = "连接设备";
                            serialPort1.Dispose();//释放掉原先的串口资源
                            NFC_Port.SelectedIndex = NFC_Port.Items.Count > 0 ? 0 : -1;//显示获取的第一个串口号
                        }
                        else
                        {
                            NFC_Port.Text = serialPortName;//显示用户打开的那个串口号
                        }
                    }
                    else
                    {//用户没有打开过串口
                        NFC_Port.SelectedIndex = NFC_Port.Items.Count > 0 ? 0 : -1;//显示获取的第一个串口号
                    }
                }
                else if (m.WParam.ToInt32() == 0x8000)
                {//usb串口连接上
                    string[] ports = System.IO.Ports.SerialPort.GetPortNames();//重新获取串口
                    NFC_Port.Items.Clear();
                    NFC_Port.Items.AddRange(ports);
                    if (Bt_NFC.Text == "关闭设备")
                    {//用户打开过一个串口
                        NFC_Port.Text = serialPortName;//显示用户打开的那个串口号
                    }
                    else
                    {
                        NFC_Port.SelectedIndex = NFC_Port.Items.Count > 0 ? 0 : -1;//显示获取的第一个串口号
                    }
                }
            }
            base.WndProc(ref m);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string[] ports = System.IO.Ports.SerialPort.GetPortNames();
            NFC_Port.Items.AddRange(ports);
            //Com_Port.Items.AddRange(ports);
            NFC_Port.SelectedIndex = NFC_Port.Items.Count > 0 ? 0 : -1;
            //Com_Port.SelectedIndex = Com_Port.Items.Count > 0 ? 0 : -1;

            

            NFC_Rate.Text = "115200";
            //Com_Rate.Text = "115200";
            BluetoothRadio radio = BluetoothRadio.PrimaryRadio;//获取蓝牙适配器
            if (radio == null)
            {
                Console.WriteLine("没有找到本机蓝牙设备!");
            }
            else
            {

                listBox2.DataSource = new BindingSource(GetClientBluetooth(), null);
            }
        }

        private void Bt_NFC_Click(object sender, EventArgs e)
        {
            if (Bt_NFC.Text == "连接设备")
            {//如果按钮显示的是打开串口
                try
                {//防止意外错误
                    serialPort1.PortName = NFC_Port.Text;//获取comboBox1要打开的串口号
                    serialPort1.BaudRate = int.Parse(NFC_Rate.Text);//获取comboBox2选择的波特率
                    serialPort1.DataBits = int.Parse("8");//设置数据位
                    /*设置停止位*/
                    serialPort1.StopBits = System.IO.Ports.StopBits.One; 
                    /*设置奇偶校验*/
                   serialPort1.Parity = System.IO.Ports.Parity.None;

                    serialPort1.Open();//打开串口

                    serialPort1.DataReceived += new SerialDataReceivedEventHandler(serialPort1_DataReceived);
                    Bt_NFC.Text = "关闭设备";//按钮显示关闭串口
                }
                catch (Exception err)
                {
                    MessageBox.Show("打开失败" + err.ToString(), "提示!");//对话框显示打开失败
                }
            }
            else
            {//要关闭串口
                try
                {//防止意外错误
                    serialPort1.Close();//关闭串口
                }
                catch (Exception) { }
                button1.Text = "连接设备";//按钮显示打开
            }
        }

        private void serialPort1_DataReceived(object sender, System.IO.Ports.SerialDataReceivedEventArgs e)
        {
            int len = serialPort1.BytesToRead;//获取可以读取的字节数
            byte[] buff = new byte[len];//创建缓存数据数组
            serialPort1.Read(buff, 0, len);//把数据读取到buff数组
            string str = Encoding.Default.GetString(buff);//Byte值根据ASCII码表转为 String
            Invoke((new Action(() => //C# 3.0以后代替委托的新方法
            {
                textBox1.AppendText(str);//对话框追加显示数据
            })));
        }

        /// <字节数组转16进制字符串>
        /// <param name="bytes"></param>
        /// <returns> String 16进制显示形式</returns>
        public static string byteToHexStr(byte[] bytes)
        {
            string returnStr = "";
            try
            {
                if (bytes != null)
                {
                    for (int i = 0; i < bytes.Length; i++)
                    {
                        returnStr += bytes[i].ToString("X2");
                        returnStr += " ";//两个16进制用空格隔开,方便看数据
                    }
                }
                return returnStr;
            }
            catch (Exception)
            {
                return returnStr;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            serialPort1.Write("OK");//串口发送数据
        }

        /// <字符串转16进制格式,不够自动前面补零>
        /// 
        /// </summary>
        /// <param name="hexString"></param>
        /// <returns></returns>
        private static byte[] strToToHexByte(String hexString)
        {
            int i;
            hexString = hexString.Replace(" ", "");//清除空格
            if ((hexString.Length % 2) != 0)//奇数个
            {
                byte[] returnBytes = new byte[(hexString.Length + 1) / 2];
                try
                {
                    for (i = 0; i < (hexString.Length - 1) / 2; i++)
                    {
                        returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
                    }
                    returnBytes[returnBytes.Length - 1] = Convert.ToByte(hexString.Substring(hexString.Length - 1, 1).PadLeft(2, '0'), 16);
                }
                catch
                {
                    MessageBox.Show("含有非16进制字符", "提示");
                    return null;
                }
                return returnBytes;
            }
            else
            {
                byte[] returnBytes = new byte[(hexString.Length) / 2];
                try
                {
                    for (i = 0; i < returnBytes.Length; i++)
                    {
                        returnBytes[i] = Convert.ToByte(hexString.Substring(i * 2, 2), 16);
                    }
                }
                catch
                {
                    MessageBox.Show("含有非16进制字符", "提示");
                    return null;
                }
                return returnBytes;
            }
        }
    }
}
