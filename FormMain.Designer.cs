
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
            textBoxMessageToSend = new System.Windows.Forms.TextBox();
            comboBoxTargetName = new System.Windows.Forms.ComboBox();
            buttonRefreshFMO = new System.Windows.Forms.Button();
            textBoxMessageReceived = new System.Windows.Forms.TextBox();
            buttonSend = new System.Windows.Forms.Button();
            SuspendLayout();
            // 
            // textBoxMessageToSend
            // 
            textBoxMessageToSend.AllowDrop = true;
            textBoxMessageToSend.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxMessageToSend.Location = new System.Drawing.Point(12, 12);
            textBoxMessageToSend.Multiline = true;
            textBoxMessageToSend.Name = "textBoxMessageToSend";
            textBoxMessageToSend.Size = new System.Drawing.Size(949, 346);
            textBoxMessageToSend.TabIndex = 0;
            textBoxMessageToSend.DragDrop += TextBoxMessageToSend_DragDrop;
            textBoxMessageToSend.DragEnter += TextBoxMessageToSend_DragEnter;
            // 
            // comboBoxTargetName
            // 
            comboBoxTargetName.FormattingEnabled = true;
            comboBoxTargetName.Location = new System.Drawing.Point(12, 371);
            comboBoxTargetName.Name = "comboBoxTargetName";
            comboBoxTargetName.Size = new System.Drawing.Size(272, 45);
            comboBoxTargetName.TabIndex = 1;
            // 
            // buttonRefreshFMO
            // 
            buttonRefreshFMO.Location = new System.Drawing.Point(290, 364);
            buttonRefreshFMO.Name = "buttonRefreshFMO";
            buttonRefreshFMO.Size = new System.Drawing.Size(169, 52);
            buttonRefreshFMO.TabIndex = 2;
            buttonRefreshFMO.Text = "更新";
            buttonRefreshFMO.UseVisualStyleBackColor = true;
            buttonRefreshFMO.Click += ButtonRefreshFMO_Click;
            // 
            // textBoxMessageReceived
            // 
            textBoxMessageReceived.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            textBoxMessageReceived.Location = new System.Drawing.Point(12, 422);
            textBoxMessageReceived.Multiline = true;
            textBoxMessageReceived.Name = "textBoxMessageReceived";
            textBoxMessageReceived.ReadOnly = true;
            textBoxMessageReceived.Size = new System.Drawing.Size(949, 287);
            textBoxMessageReceived.TabIndex = 4;
            // 
            // buttonSend
            // 
            buttonSend.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            buttonSend.Location = new System.Drawing.Point(792, 366);
            buttonSend.Name = "buttonSend";
            buttonSend.Size = new System.Drawing.Size(169, 52);
            buttonSend.TabIndex = 3;
            buttonSend.Text = "送信";
            buttonSend.UseVisualStyleBackColor = true;
            buttonSend.Click += ButtonSend_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(15F, 37F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(972, 721);
            Controls.Add(buttonSend);
            Controls.Add(textBoxMessageReceived);
            Controls.Add(buttonRefreshFMO);
            Controls.Add(comboBoxTargetName);
            Controls.Add(textBoxMessageToSend);
            MinimumSize = new System.Drawing.Size(800, 600);
            Name = "FormMain";
            Text = "DirectSSTPTester";
            FormClosed += FormMain_FormClosed;
            Load += FormMain_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMessageToSend;
        private System.Windows.Forms.ComboBox comboBoxTargetName;
        private System.Windows.Forms.Button buttonRefreshFMO;
        private System.Windows.Forms.TextBox textBoxMessageReceived;
        private System.Windows.Forms.Button buttonSend;
    }
}

