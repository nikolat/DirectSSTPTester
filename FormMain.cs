using System;
using System.Windows.Forms;
using System.IO;
using System.Text;
using System.Drawing;
using System.Collections.Generic;
using SSTPLib;

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
            if (File.Exists(txtPath))
            {
                this.textBoxMessageToSend.Text = GetText(txtPath);
            }
            SearchGhost();

            string iconPath = Environment.ProcessPath;
            Icon ico = Icon.ExtractAssociatedIcon(iconPath);
            this.Icon = ico;
        }

        private void ButtonRefreshFMO_Click(object sender, EventArgs e)
        {
            SearchGhost();
        }

        private void SearchGhost()
        {
            this.comboBoxTargetName.Items.Clear();
            SakuraFMO fmo = new("SakuraUnicode");
            fmo.Update(true);
            string[] names = fmo.GetGhostNames();
            if (names.Length > 0)
            {
                this.comboBoxTargetName.Items.AddRange(names);
                this.comboBoxTargetName.SelectedIndex = 0;
            }
        }

        private void ButtonSend_Click(object sender, EventArgs e)
        {
            string s = this.textBoxMessageToSend.Text;
            string t = this.comboBoxTargetName.Text;
            DSSTPSender ds = new()
            {
                SendMessageTimeOut = 10000,
                RecvMessageTimeOut = 10000
            };
            string r = ds.GetSSTPResponse(t, s);
            ds.Dispose();
            this.textBoxMessageReceived.Text = r;
        }

        private void FormMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void TextBoxMessageToSend_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                // ドラッグ中のファイルやディレクトリの取得
                string[] drags = (string[])e.Data.GetData(DataFormats.FileDrop);
                e.Effect = DragDropEffects.None;
                foreach (string d in drags)
                {
                    if (!File.Exists(d))
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

        private void TextBoxMessageToSend_DragDrop(object sender, DragEventArgs e)
        {
            // ドラッグ＆ドロップされたファイル
            string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
            foreach (string d in files)
            {
                if (!File.Exists(d))
                {
                    continue;
                }
                if (!Path.GetExtension(d).Equals(".txt"))
                {
                    continue;
                }
                this.textBoxMessageToSend.Text = GetText(d);
            }
        }

        private static string GetText(string txtPath)
        {
            string charset = GetEncoding(txtPath);
            StreamReader sr = new(txtPath, Encoding.GetEncoding(charset));
            List<string> text = new();
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                text.Add(line);
            }
            sr.Close();
            return string.Join(Environment.NewLine, text.ToArray());
        }

        private static string GetEncoding(string txtPath)
        {
            StreamReader sr = new(txtPath, Encoding.GetEncoding("UTF-8"));
            List<string> msg = new();
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                msg.Add(line);
            }
            sr.Close();
            string charset = "";
            foreach (string s in msg)
            {
                if (s.StartsWith("Charset: "))
                {
                    charset = s[9..];
                    break;
                }
            }
            Encoding enc;
            try
            {
                enc = Encoding.GetEncoding(charset);
            }
            catch (ArgumentException)
            {
                charset = "UTF-8";
            }
            return charset;
        }
    }
}
