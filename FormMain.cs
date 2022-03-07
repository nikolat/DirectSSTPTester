using System;
using System.Windows.Forms;
using SSTPLib;
using System.IO;
using System.Text;
using System.Drawing;
using System.Collections.Generic;

namespace DirectSSTPTester
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            string txtPath = "default.txt";
            if (System.IO.File.Exists(txtPath))
            {
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                System.IO.StreamReader sr = new StreamReader(txtPath, Encoding.GetEncoding("UTF-8"));
                string s = sr.ReadToEnd();
                sr.Close();
                string charset = getEncoding(s);
                sr = new StreamReader(txtPath, Encoding.GetEncoding(charset));
                s = sr.ReadToEnd();
                sr.Close();
                this.textBoxMessageToSend.Text = s;
            }
            SearchGhost();

            string iconPath = Environment.ProcessPath;
            Icon ico = Icon.ExtractAssociatedIcon(iconPath);
            this.Icon = ico;
        }

        private void buttonRefreshFMO_Click(object sender, EventArgs e)
        {
            SearchGhost();
        }

        private void SearchGhost()
        {
            this.comboBoxTargetName.Items.Clear();
            SakuraFMO fmo = new SakuraFMO("SakuraUnicode");
            fmo.Update(true);
            string[] names = fmo.GetGhostNames();
            if (names.Length > 0)
            {
                this.comboBoxTargetName.Items.AddRange(names);
                this.comboBoxTargetName.SelectedIndex = 0;
            }
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            string s = this.textBoxMessageToSend.Text;
            string t = this.comboBoxTargetName.Text;
            DSSTPSender ds = new DSSTPSender();
            ds.SendMessageTimeOut = 10000;
            ds.RecvMessageTimeOut = 10000;
            string r = ds.GetSSTPResponse(t, s);
            ds.Dispose();
            this.textBoxMessageReceived.Text = r;
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void textBoxMessageToSend_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // ドラッグ中のファイルやディレクトリの取得
                string[] drags = (string[])e.Data.GetData(DataFormats.FileDrop);
                e.Effect = DragDropEffects.None;
                foreach (string d in drags)
                {
                    if (!System.IO.File.Exists(d))
                    {
                        // ファイル以外であればイベント・ハンドラを抜ける
                        return;
                    }
                    if (!Path.GetExtension(d).Equals(".txt"))
                    {
                        return;
                    }
                }
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void textBoxMessageToSend_DragDrop(object sender, DragEventArgs e)
        {
            // ドラッグ＆ドロップされたファイル
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string d in files)
            {
                if (!System.IO.File.Exists(d))
                {
                    continue;
                }
                if (!Path.GetExtension(d).Equals(".txt"))
                {
                    continue;
                }
                Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                System.IO.StreamReader sr = new StreamReader(d, Encoding.GetEncoding("UTF-8"));
                string s = sr.ReadToEnd();
                sr.Close();
                string charset = getEncoding(s);
                sr = new StreamReader(d, Encoding.GetEncoding(charset));
                s = sr.ReadToEnd();
                sr.Close();
                this.textBoxMessageToSend.Text = s;
            }
        }

        private string getEncoding(string text)
        {
            List<string> msg = new List<string>(text.Split("\r\n"));
            string charset = "";
            foreach (string s in msg)
            {
                if (s.StartsWith("Charset: "))
                {
                    charset = s[9..];
                    break;
                }
            }
            System.Text.Encoding enc;
            try
            {
                enc = System.Text.Encoding.GetEncoding(charset);
            }
            catch (ArgumentException)
            {
                charset = "UTF-8";
            }
            return charset;
        }
    }
}
