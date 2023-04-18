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
using ExcelDataReader;

namespace Anten_init
{
    struct Radar_property
    {
        string Name;
        string SysName;
        string Eth_MAC;
        string Wlan_MAC;
        string Bridge_IP;
        string Frequency;
    }
    public partial class Form1 : Form
    {
        List<Radar_property> Data;
        DataTable Datas;
        DataSet dataSet;
        string commands;
        RichTextBox box;
        public Form1()
        {
            InitializeComponent();
        }
        public DataTable ReadXlsx(string filepath)
        {
            try
            {
                FileStream stream = File.Open(filepath, FileMode.Open, FileAccess.Read);
                //2. Reading from a OpenXml Excel file (2007 format; *.xlsx)
                IExcelDataReader excelReader2 = ExcelReaderFactory.CreateOpenXmlReader(stream);
                dataSet = excelReader2.AsDataSet();
                dataGridView1.DataSource = dataSet.Tables[0];
                DataTable result2 = new DataTable();
                result2 = dataSet.Tables[0];

                //for (int i = 0; i < result2.Rows.Count; i++)
                //{
                //    for (int j = 0; j < result2.Columns.Count; j++)
                //    {
                //        var val = result2.Rows[i][j].ToString();
                //        listBox1.Items.Add(val.ToString());
                //    }
                //    listBox1.Items.Add("---------------------------------------");
                //}
                return result2;
            }
            catch (Exception ex)
            {
                label2.Text=ex.Message;
                return null;
            }
        }
        private void CreateFile(int rownum)
        {
            
            string name = Datas.Rows[rownum][0].ToString();
            string Sysname = Datas.Rows[rownum][1].ToString();
            string Eth_MAC = Datas.Rows[rownum][2].ToString();
            string IPaddress = Datas.Rows[rownum][4].ToString();
            string Frequency = Datas.Rows[rownum][5].ToString();
            string Wlan_MACR = "";
            if ((rownum % 2) == 0)
                Wlan_MACR = Datas.Rows[rownum - 1][3].ToString();
            else
                Wlan_MACR = Datas.Rows[rownum + 1][3].ToString();

            string cmds = commands;
            string temp = cmds.Replace("[Eth MAC]", Eth_MAC);
            cmds = temp.Replace("[Frequency]", Frequency);
            temp = cmds.Replace("[Sys Name]", Sysname);
            cmds = temp.Replace("[if R(n) is an odd number, input Wlan MAC of R(n+1), Else, input Wlan MAC of R(n-1)]", Wlan_MACR);
            temp = cmds.Replace("[ip address of R(n)]", IPaddress);
            cmds = temp.Replace("[Sys Name of R(n)]", Sysname);

            try
            {
                string fileout = Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory);
                File.WriteAllText(fileout+ "\\"+name + ".rsc", cmds);
                label2.Text ="File Created Successfully";
            }
            catch (Exception exx)
            {
                label2.Text = exx.Message;
            }
        }

        private void AddTextToRichBox(string cmd)
        {
            int k = 0;
            while (true)
            //for(int i=0;i<8;i++)
            {
                if (cmd.Length < 1)
                    break;
                int str = cmd.IndexOf("[");
                int stp = cmd.IndexOf("]");
                if(stp>str && str > 0)
                {
                    string blc = cmd.Substring(0, str - 1);
                    string rd = cmd.Substring(str, stp - str + 1);
                    cmd = cmd.Substring(stp + 1);//,cmd.Length-stp-1);

                    richTextBox1.SelectionColor = Color.Black;
                    richTextBox1.AppendText(blc);
                    richTextBox1.SelectionColor = Color.Red;
                    richTextBox1.AppendText(rd);
                    k += 1;
                    Console.WriteLine(k);
                    //box.AppendText(blc, System.Drawing.Color.Black);
                    //box.AppendText(rd, System.Drawing.Color.Red);
                }
                else
                {
                    break;
                }

            }
            

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            create_btn.Enabled = false;
            Createall_btn.Enabled = false;

        }
        
        private void richTextBox2_ddd(object o,EventArgs e)
        {
            Console.WriteLine("gggg \n");
        }
        private void Createall_btn_Click(object sender, EventArgs e)
        {
            for (int i = 3; i < Datas.Rows.Count; i++)
            {
                commands = richTextBox1.Text;
                CreateFile(i);
            }
        }

        private void create_btn_Click(object sender, EventArgs e)
        {
            string Radarname = textBox1.Text;
            for (int i = 3; i < Datas.Rows.Count; i++)
            {
                if(Datas.Rows[i][0].ToString()== Radarname)
                {
                    commands = richTextBox1.Text;
                    CreateFile(i);
                }
                    
            }
        }

        private void ApplyBtn_Click(object sender, EventArgs e)
        {
            string cmd = richTextBox1.Text;
            richTextBox1.Text = "";
            AddTextToRichBox(cmd);
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            if(TextAddressText.Text!="" && dataAddressText.Text != "")
            {
                try
                {
                    Datas = new DataTable();
                    Datas = ReadXlsx(dataAddressText.Text);

                    //RichTextBox box = new RichTextBox
                    //{
                    //    Size = new Size(449, 96),
                    //    Location=new Point(250, 211),
                    //    Font = new Font("Courier New", 9)
                    //};
                    //this.Controls.Add(box);

                    commands = File.ReadAllText(TextAddressText.Text);
                    AddTextToRichBox(commands);

                    create_btn.Enabled = true;
                    Createall_btn.Enabled = true;
                }
                catch (Exception exx)
                {
                    MessageBox.Show("Error current in loading file ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Fill Boxs ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void Loadxlsxbtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "data files (*.xls)|*.xls|(*.xlsx)|*.xlsx|All files (*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                string filePath = op.FileName;
                dataAddressText.Text = filePath;
            }
        }

        private void LoadtxtBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            op.Filter = "txt files (*.rsc)|*.rsc|All files (*.*)|*.*";
            if (op.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                string filePath = op.FileName;
                TextAddressText.Text = filePath;
            }

        }
    }


    //public static class RichTextBoxExtensions
    //{
    //    public static void AppendText(this RichTextBox box, string text, Color color)
    //    {
    //        box.SelectionStart = box.TextLength;
    //        box.SelectionLength = 0;

    //        box.SelectionColor = color;
    //        box.AppendText(text);
    //        box.SelectionColor = box.ForeColor;
    //    }
    //}
}
