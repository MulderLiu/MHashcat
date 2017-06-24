using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.CheckedListBox;

namespace WindowsFormsHashcat
{
    public partial class Form1 : Form
    {      
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog.InitialDirectory = @"D:\Decrypt\caps\";
            openFileDialog.Filter = "cap文件|*.cap";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtFilePath.Text = openFileDialog.FileName;                
            }
        }

        public static void RunCmd(List<string> cmd, out string output)
        {
            string CmdPath = @"C:\Windows\System32\cmd.exe";

            using (Process p = new Process())
            {
                p.StartInfo.FileName = CmdPath;
                p.StartInfo.UseShellExecute = false;        //是否使用操作系统shell启动
                p.StartInfo.RedirectStandardInput = true;   //接受来自调用程序的输入信息
                p.StartInfo.RedirectStandardOutput = true;  //由调用程序获取输出信息
                p.StartInfo.RedirectStandardError = true;   //重定向标准错误输出
                p.StartInfo.CreateNoWindow = true;          //不显示程序窗口
                p.Start();//启动程序

                //向cmd窗口写入命令
                // p.StandardInput.WriteLine(cmd);
                //向标准输入写入要执行的命令。这里使用&是批处理命令的符号，表示前面一个命令不管是否执行成功都执行后面(exit)命令，如果不执行exit命令，后面调用ReadToEnd()方法会假死
                //同类的符号还有&&和||前者表示必须前一个命令执行成功才会执行后面的命令，后者表示必须前一个命令执行失败才会执行后面的命令
                foreach (string item in cmd)
                {
                    p.StandardInput.WriteLine(item);
                }

                p.StandardInput.WriteLine("exit");
                p.StandardInput.AutoFlush = true;

                //获取cmd窗口的输出信息
                output = p.StandardOutput.ReadToEnd();
                p.WaitForExit();//等待程序执行完退出进程
                p.Close();
            }
        }

        private void ConvertToHccapx_Click(object sender, EventArgs e)
        {
            //saveFileDialog.InitialDirectory = "z:\\";
            //saveFileDialog.OverwritePrompt = true;
            //saveFileDialog.Filter=

            FileInfo fileinfo;
            if (txtFilePath.Text.Length == 0)
            {
                return;
            }
            else
            {
                fileinfo = new FileInfo(txtFilePath.Text);
            }
            List<string> list = new List<string>();
            list.Add(@" d:&");
            list.Add(string.Format(@" cd D:\Decrypt\hashcat-utils-1.8\bin &"));
            string newFile = fileinfo.Name.Replace(fileinfo.Extension, ".hccapx");
            list.Add(string.Format(@" cap2hccapx.exe {0} z:\{1} &", txtFilePath.Text, newFile));

            string output = "";
            RunCmd(list, out output);

            if (txtResult.Text.Length!=0)
            {
                txtResult.Text += "\n";
            }
            txtResult.Text += output;
            txtResult.Text += " \n**-----------------------------**";
            checkedListBox.Items.Add(newFile, true);
        }
             

        private void btnOpenDir_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            dialog.Description = "请选择文件路径";

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                DirectoryInfo theFolder = new DirectoryInfo(foldPath);
                FileInfo[] dirInfo = theFolder.GetFiles();
                //遍历文件夹  
                foreach (FileInfo file in dirInfo)
                {
                    MessageBox.Show(file.ToString());
                }
            }
        }

        private void btnDele_Click(object sender, EventArgs e)
        {
            for (int i = checkedListBox.Items.Count-1; i >=0; i--)
            {
                if (checkedListBox.GetItemChecked(i))
                {
                    checkedListBox.Items.RemoveAt(i);
                }                  
            }
        }
    }
}
