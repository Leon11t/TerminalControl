namespace TerminalControl_v4
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSettClose = new System.Windows.Forms.Button();
            this.btnSaveSet = new System.Windows.Forms.Button();
            this.stopBitsBox = new System.Windows.Forms.ComboBox();
            this.parityBox = new System.Windows.Forms.ComboBox();
            this.dataBitsBox = new System.Windows.Forms.ComboBox();
            this.portBox = new System.Windows.Forms.ComboBox();
            this.boudBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Port = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSettClose);
            this.groupBox1.Controls.Add(this.btnSaveSet);
            this.groupBox1.Controls.Add(this.stopBitsBox);
            this.groupBox1.Controls.Add(this.parityBox);
            this.groupBox1.Controls.Add(this.dataBitsBox);
            this.groupBox1.Controls.Add(this.portBox);
            this.groupBox1.Controls.Add(this.boudBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Port);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(188, 232);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Налаштування портів";
            // 
            // btnSettClose
            // 
            this.btnSettClose.Location = new System.Drawing.Point(107, 193);
            this.btnSettClose.Name = "btnSettClose";
            this.btnSettClose.Size = new System.Drawing.Size(75, 33);
            this.btnSettClose.TabIndex = 11;
            this.btnSettClose.Text = "Закрити";
            this.btnSettClose.UseVisualStyleBackColor = true;
            this.btnSettClose.Click += new System.EventHandler(this.btnSettClose_Click);
            // 
            // btnSaveSet
            // 
            this.btnSaveSet.Location = new System.Drawing.Point(6, 193);
            this.btnSaveSet.Name = "btnSaveSet";
            this.btnSaveSet.Size = new System.Drawing.Size(75, 33);
            this.btnSaveSet.TabIndex = 10;
            this.btnSaveSet.Text = "Зберегти";
            this.btnSaveSet.UseVisualStyleBackColor = true;
            this.btnSaveSet.Click += new System.EventHandler(this.btnSaveSet_Click);
            // 
            // stopBitsBox
            // 
            this.stopBitsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stopBitsBox.FormattingEnabled = true;
            this.stopBitsBox.Items.AddRange(new object[] {
            "1",
            "1.5",
            "2"});
            this.stopBitsBox.Location = new System.Drawing.Point(6, 150);
            this.stopBitsBox.Name = "stopBitsBox";
            this.stopBitsBox.Size = new System.Drawing.Size(67, 21);
            this.stopBitsBox.TabIndex = 9;
            this.stopBitsBox.SelectedIndexChanged += new System.EventHandler(this.stopBitsBox_SelectedIndexChanged);
            // 
            // parityBox
            // 
            this.parityBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.parityBox.FormattingEnabled = true;
            this.parityBox.Items.AddRange(new object[] {
            "none",
            "odd",
            "even",
            "mark",
            "space"});
            this.parityBox.Location = new System.Drawing.Point(107, 101);
            this.parityBox.Name = "parityBox";
            this.parityBox.Size = new System.Drawing.Size(67, 21);
            this.parityBox.TabIndex = 8;
            this.parityBox.SelectedIndexChanged += new System.EventHandler(this.parityBox_SelectedIndexChanged);
            // 
            // dataBitsBox
            // 
            this.dataBitsBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dataBitsBox.FormattingEnabled = true;
            this.dataBitsBox.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8"});
            this.dataBitsBox.Location = new System.Drawing.Point(6, 101);
            this.dataBitsBox.Name = "dataBitsBox";
            this.dataBitsBox.Size = new System.Drawing.Size(67, 21);
            this.dataBitsBox.TabIndex = 7;
            this.dataBitsBox.SelectedIndexChanged += new System.EventHandler(this.dataBitsBox_SelectedIndexChanged);
            // 
            // portBox
            // 
            this.portBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.portBox.FormattingEnabled = true;
            this.portBox.Location = new System.Drawing.Point(107, 48);
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(67, 21);
            this.portBox.TabIndex = 6;
            this.portBox.SelectedIndexChanged += new System.EventHandler(this.portBox_SelectedIndexChanged);
            // 
            // boudBox
            // 
            this.boudBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.boudBox.FormattingEnabled = true;
            this.boudBox.Items.AddRange(new object[] {
            "4800",
            "9600",
            "14400",
            "19200",
            "115200"});
            this.boudBox.Location = new System.Drawing.Point(6, 48);
            this.boudBox.Name = "boudBox";
            this.boudBox.Size = new System.Drawing.Size(67, 21);
            this.boudBox.TabIndex = 5;
            this.boudBox.SelectedIndexChanged += new System.EventHandler(this.boudBox_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Stop bits";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(104, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Parity";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Data bits";
            // 
            // Port
            // 
            this.Port.AutoSize = true;
            this.Port.Location = new System.Drawing.Point(104, 32);
            this.Port.Name = "Port";
            this.Port.Size = new System.Drawing.Size(26, 13);
            this.Port.TabIndex = 1;
            this.Port.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Boudrate";
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(212, 252);
            this.Controls.Add(this.groupBox1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsForm";
            this.Text = "Налаштування";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveSet;
        private System.Windows.Forms.ComboBox stopBitsBox;
        private System.Windows.Forms.ComboBox parityBox;
        private System.Windows.Forms.ComboBox dataBitsBox;
        private System.Windows.Forms.ComboBox portBox;
        private System.Windows.Forms.ComboBox boudBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Port;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSettClose;
    }
}