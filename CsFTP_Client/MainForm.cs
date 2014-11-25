using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CsFTP_Client
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //var uilpath = "ftp://127.0.0.1/folder/";//360.txt
            //var loginName = "hefju";
            //var pwd = "1";
            //clsFTP ftp = new clsFTP(new Uri(uilpath), loginName, pwd);

            //FileInfo fileinfo = new FileInfo(@"D:\Forftp\数据库.txt");
            //string username = "hefju";
            //string password = "1";
            //FtpHelper.UploadFile(fileinfo, uilpath, username, password);

            FTPClient ftp = new FTPClient();
            var b=   ftp.fileCheckExist("/folder", "360.txt");
            MessageBox.Show(b.ToString());




           // MessageBox.Show("执行完毕");
            //this.Cursor = Cursors.AppStarting;


            //if (!ftp.MakeDirectory(vision))
            //{
            //    MessageBox.Show("文件夹'" + vision + "'创建失败！");
            //    return;
            //}

            //文件上传
            //    if (ftp.UploadFile(@"D:\Forftp\数据库.txt", true) == false)
            //    {
            //        MessageBox.Show("上传文件失败！");
            //        return;
            //    }


            //    MessageBox.Show("更新程序发布完成！");
            //    this.Cursor = Cursors.Default;
            //}

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            FTPClient ftp = new FTPClient();
            var b = ftp.fileUpload(@"D:\Forftp\", "数据库.txt", @"ftp://192.168.1.200/folder/", "333.txt");
            MessageBox.Show(b.ToString());

            this.Cursor = Cursors.Default;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //对比的名字是ftp下的路径对比,  例如: folder/111.txt
            FTPClient ftp = new FTPClient();
            var b = ftp.fileCheckExist("ftp://127.0.0.1/folder", "folder/111.txt");
            MessageBox.Show(b.ToString());
        }














    }
}
