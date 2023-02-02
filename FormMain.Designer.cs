
namespace DirectSSTPTester
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxMessageToSend = new System.Windows.Forms.TextBox();
            this.comboBoxTargetName = new System.Windows.Forms.ComboBox();
            this.buttonRefreshFMO = new System.Windows.Forms.Button();
            this.textBoxMessageReceived = new System.Windows.Forms.TextBox();
            this.buttonSend = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxMessageToSend
            // 
            this.textBoxMessageToSend.AllowDrop = true;
            this.textBoxMessageToSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMessageToSend.Location = new System.Drawing.Point(12, 12);
            this.textBoxMessageToSend.Multiline = true;
            this.textBoxMessageToSend.Name = "textBoxMessageToSend";
            this.textBoxMessageToSend.Size = new System.Drawing.Size(948, 346);
            this.textBoxMessageToSend.TabIndex = 0;
            this.textBoxMessageToSend.DragDrop += new System.Windows.Forms.DragEventHandler(this.TextBoxMessageToSend_DragDrop);
            this.textBoxMessageToSend.DragEnter += new System.Windows.Forms.DragEventHandler(this.TextBoxMessageToSend_DragEnter);
            // 
            // comboBoxTargetName
            // 
            this.comboBoxTargetName.FormattingEnabled = true;
            this.comboBoxTargetName.Location = new System.Drawing.Point(12, 371);
            this.comboBoxTargetName.Name = "comboBoxTargetName";
            this.comboBoxTargetName.Size = new System.Drawing.Size(272, 45);
            this.comboBoxTargetName.TabIndex = 1;
            // 
            // buttonRefreshFMO
            // 
            this.buttonRefreshFMO.Location = new System.Drawing.Point(290, 364);
            this.buttonRefreshFMO.Name = "buttonRefreshFMO";
            this.buttonRefreshFMO.Size = new System.Drawing.Size(169, 52);
            this.buttonRefreshFMO.TabIndex = 2;
            this.buttonRefreshFMO.Text = "更新";
            this.buttonRefreshFMO.UseVisualStyleBackColor = true;
            this.buttonRefreshFMO.Click += new System.EventHandler(this.ButtonRefreshFMO_Click);
            // 
            // textBoxMessageReceived
            // 
            this.textBoxMessageReceived.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMessageReceived.Location = new System.Drawing.Point(12, 422);
            this.textBoxMessageReceived.Multiline = true;
            this.textBoxMessageReceived.Name = "textBoxMessageReceived";
            this.textBoxMessageReceived.ReadOnly = true;
            this.textBoxMessageReceived.Size = new System.Drawing.Size(948, 287);
            this.textBoxMessageReceived.TabIndex = 4;
            // 
            // buttonSend
            // 
            this.buttonSend.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSend.Location = new System.Drawing.Point(791, 366);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(169, 52);
            this.buttonSend.TabIndex = 3;
            this.buttonSend.Text = "送信";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.ButtonSend_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(972, 721);
            this.Controls.Add(this.buttonSend);
            this.Controls.Add(this.textBoxMessageReceived);
            this.Controls.Add(this.buttonRefreshFMO);
            this.Controls.Add(this.comboBoxTargetName);
            this.Controls.Add(this.textBoxMessageToSend);
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "FormMain";
            this.Text = "DirectSSTPTester";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain_FormClosed);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMessageToSend;
        private System.Windows.Forms.ComboBox comboBoxTargetName;
        private System.Windows.Forms.Button buttonRefreshFMO;
        private System.Windows.Forms.TextBox textBoxMessageReceived;
        private System.Windows.Forms.Button buttonSend;
    }
}

