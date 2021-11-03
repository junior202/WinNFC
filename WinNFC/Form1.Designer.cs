
namespace WinNFC
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Bt_NFC = new System.Windows.Forms.Button();
            this.NFC_Rate = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.NFC_Port = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(633, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "显示区";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Black;
            this.textBox1.ForeColor = System.Drawing.Color.LawnGreen;
            this.textBox1.Location = new System.Drawing.Point(13, 20);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(610, 147);
            this.textBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Bt_NFC);
            this.groupBox2.Controls.Add(this.NFC_Rate);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.NFC_Port);
            this.groupBox2.Location = new System.Drawing.Point(12, 212);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 323);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "NFC接口";
            // 
            // Bt_NFC
            // 
            this.Bt_NFC.Location = new System.Drawing.Point(111, 288);
            this.Bt_NFC.Name = "Bt_NFC";
            this.Bt_NFC.Size = new System.Drawing.Size(75, 23);
            this.Bt_NFC.TabIndex = 4;
            this.Bt_NFC.Text = "连接设备";
            this.Bt_NFC.UseVisualStyleBackColor = true;
            this.Bt_NFC.Click += new System.EventHandler(this.Bt_NFC_Click);
            // 
            // NFC_Rate
            // 
            this.NFC_Rate.FormattingEnabled = true;
            this.NFC_Rate.Items.AddRange(new object[] {
            "115200",
            "76800",
            "56700",
            "19200",
            "9600"});
            this.NFC_Rate.Location = new System.Drawing.Point(65, 51);
            this.NFC_Rate.Name = "NFC_Rate";
            this.NFC_Rate.Size = new System.Drawing.Size(121, 20);
            this.NFC_Rate.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "波特率：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "端口号：";
            // 
            // NFC_Port
            // 
            this.NFC_Port.FormattingEnabled = true;
            this.NFC_Port.Location = new System.Drawing.Point(65, 20);
            this.NFC_Port.Name = "NFC_Port";
            this.NFC_Port.Size = new System.Drawing.Size(121, 20);
            this.NFC_Port.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listBox2);
            this.groupBox4.Location = new System.Drawing.Point(218, 212);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(427, 323);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "蓝牙设备";
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 12;
            this.listBox2.Location = new System.Drawing.Point(6, 20);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(411, 292);
            this.listBox2.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 410);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(347, 47);
            this.button1.TabIndex = 4;
            this.button1.Text = "写入NFC";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(6, 488);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(382, 29);
            this.progressBar1.TabIndex = 0;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.button1);
            this.groupBox5.Controls.Add(this.textBox4);
            this.groupBox5.Controls.Add(this.label7);
            this.groupBox5.Controls.Add(this.progressBar1);
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.textBox3);
            this.groupBox5.Controls.Add(this.textBox2);
            this.groupBox5.Controls.Add(this.label6);
            this.groupBox5.Location = new System.Drawing.Point(651, 12);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(394, 523);
            this.groupBox5.TabIndex = 5;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "操作区";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(28, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "设备MAC :";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(107, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(254, 29);
            this.textBox2.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(28, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "产品类码 :";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox3.Location = new System.Drawing.Point(107, 87);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(254, 29);
            this.textBox3.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(28, 145);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 17);
            this.label7.TabIndex = 10;
            this.label7.Text = "鸿蒙码流 :";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox4.Location = new System.Drawing.Point(107, 138);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(254, 29);
            this.textBox4.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1057, 547);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox5);
            this.Name = "Form1";
            this.Text = "NFC量产工具";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox NFC_Port;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox NFC_Rate;
        private System.Windows.Forms.Button Bt_NFC;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label6;
    }
}

