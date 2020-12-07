using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SaveFileBackup
{
    public partial class Form1 : Form
    {
        private int c = 0;
        //private bool selectedMenu1 = true;
        private bool startedBackUp = false;
        private string saveFileName = "";
        private string saveFolderPath = "";
        private string backupFolderPath = "";
        public int timer = 0;
        static Thread t;
        List<string> pathList = new List<string>();

        string[] data = new string[5];

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(144, 218, 255);
            LoadPath();

            t = new Thread(Loop);
            t.Start();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(126, 210, 255);
            BackUpPanel.Visible = true;
        }
        private void setSaveFolderPath_Click(object sender, EventArgs e)
        {
            OpenFileDialog of = new OpenFileDialog();
            {
                if (of.ShowDialog() == DialogResult.OK)
                {
                    saveFolderPath = of.FileName;
                    //MessageBox.Show(saveFolderPath, "z", MessageBoxButtons.OK);

                    savePath.Text = saveFolderPath;
                    //pathList.Add("path1:" + saveFolderPath);

                    data[0] = saveFolderPath;
                    if (pathList.Count != 0)
                    {
                        pathList.Insert(0, "path1:" + saveFolderPath);
                        pathList.Insert(1, "path2:" + backupFolderPath);
                    }
                    else pathList.Add("path1:" + saveFolderPath);

                    string[] file = of.FileName.Split(new string[] { "\\" }, StringSplitOptions.None);
                    int size = file.Length;
                    saveFileName = file[size - 1];
                    string[] fileName = saveFileName.Split('.');
                    saveFileName = fileName[0];
                    //MessageBox.Show(saveFileName, "z", MessageBoxButtons.OK);
                    SavePathTextFile();
                }
            }
        }
        private void setBackupFolderPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                backupFolderPath = folderBrowserDialog.SelectedPath;
                backupPath.Text = backupFolderPath;

                if (pathList.Count == 1)
                {
                    pathList.Add("path2:" + backupFolderPath);
                }
                else if (pathList.Count == 2) pathList.Insert(1, "path2:" + backupFolderPath);
                if(pathList.Count == 3) pathList.RemoveAt(2);
                SavePathTextFile();
            }
        }
        private void SavePathTextFile()
        {
            using (FileStream fs = new FileStream("setting.txt", FileMode.Create))
            {
                StreamWriter sw = new StreamWriter(fs);
                
                for(int i = 0; i < 5; i++)
                {
                    if(data[i] != null)
                    {
                        sw.WriteLine(data[i], "\n");
                    } else sw.WriteLine("\n");
                }
                //for(int i = 0; i < pathList.Count; i++)
                //{
                //    sw.WriteLine(pathList[i], "\n");
                //}
                sw.Close();
            }
        }
        private void start_Click(object sender, EventArgs e)
        {
            Save();
            start.Enabled = true;
            //this.Visible = false;
        }

        private void LoadPath()
        {
            if(File.Exists("setting.txt"))
            {
                using (StreamReader sr = new StreamReader("setting.txt"))
                {
                    string line;
                    while((line = sr.ReadLine()) != null)
                    {
                        if(line.Contains("path1:"))
                        {
                            string[] path1 = line.Split(new string[] { "path1:" }, StringSplitOptions.None);
                            saveFolderPath = path1[1];
                            savePath.Text = saveFolderPath;
                            string[] path = saveFolderPath.Split(new string[] { "\\" }, StringSplitOptions.None);
                            int length = path.Length;
                            string temp = path[length - 1];
                            string[] temp2 = temp.Split(new string[] { "." }, StringSplitOptions.None);
                            saveFileName = temp2[0];
                            //MessageBox.Show(saveFileName, "z", MessageBoxButtons.OK);
                        }
                        if (line.Contains("path2:"))
                        {
                            string[] path2 = line.Split(new string[] { "path2:" }, StringSplitOptions.None);
                            backupFolderPath = path2[1];
                            backupPath.Text = backupFolderPath;
                        }
                    }
                }
            }
        }

        private void Save()
        {
            if (TimerTextBox.TextLength != 0)
            {
                startedBackUp = true;
                c = 0;
                count.Text = "0";
                timer = Convert.ToInt32(TimerTextBox.Text) * 60 * 1000;
                string timer2 = timer.ToString();
                MessageBox.Show(timer2, "z", MessageBoxButtons.OK);
            }
        }

        private void Loop()
        {
            while(true)
            {
                if(startedBackUp == true)
                {
                    c++;
                    count.Text = c.ToString();
                    MessageBox.Show("zz", "zz", MessageBoxButtons.OK);
                    string month = DateTime.Today.Month.ToString();
                    string day = DateTime.Today.Day.ToString();
                    string hour = DateTime.Now.Hour.ToString();
                    string min = DateTime.Now.Minute.ToString();

                    string sourceFile = saveFolderPath;
                    string file = saveFileName + " " + month + "월 " + day + "일 " + hour + "시 " + min + "분.zip";
                    string destinationFile = backupFolderPath + "\\" + file;

                    try
                    {
                        File.Copy(sourceFile, destinationFile, true);
                    }
                    catch (IOException iox)
                    {
                        Console.WriteLine(iox.Message);
                    }
                    Thread.Sleep(timer);
                }
            }

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Exit();
        }
        private void 종료ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Exit();
        }

        private void Exit()
        {
            t.Abort();
            Application.Exit();
        }
    }
}
