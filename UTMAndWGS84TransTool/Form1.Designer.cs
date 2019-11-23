namespace UTMAndWGS84TransTool
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLon = new System.Windows.Forms.TextBox();
            this.txtLat = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rdoS = new System.Windows.Forms.RadioButton();
            this.rdoN = new System.Windows.Forms.RadioButton();
            this.txtZone = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnWGS84ToUTM = new System.Windows.Forms.Button();
            this.btnUTMToWGS84 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lon:";
            this.label1.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lat:";
            this.label2.UseWaitCursor = true;
            // 
            // txtLon
            // 
            this.txtLon.Location = new System.Drawing.Point(60, 29);
            this.txtLon.Name = "txtLon";
            this.txtLon.Size = new System.Drawing.Size(151, 21);
            this.txtLon.TabIndex = 2;
            this.txtLon.UseWaitCursor = true;
            // 
            // txtLat
            // 
            this.txtLat.Location = new System.Drawing.Point(60, 70);
            this.txtLat.Name = "txtLat";
            this.txtLat.Size = new System.Drawing.Size(151, 21);
            this.txtLat.TabIndex = 3;
            this.txtLat.UseWaitCursor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtLat);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtLon);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(217, 117);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "WGS84";
            this.groupBox1.UseWaitCursor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoS);
            this.groupBox2.Controls.Add(this.rdoN);
            this.groupBox2.Controls.Add(this.txtZone);
            this.groupBox2.Controls.Add(this.txtY);
            this.groupBox2.Controls.Add(this.txtX);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(295, 26);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(223, 200);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "UTM";
            this.groupBox2.UseWaitCursor = true;
            // 
            // rdoS
            // 
            this.rdoS.AutoSize = true;
            this.rdoS.Location = new System.Drawing.Point(84, 170);
            this.rdoS.Name = "rdoS";
            this.rdoS.Size = new System.Drawing.Size(29, 16);
            this.rdoS.TabIndex = 8;
            this.rdoS.TabStop = true;
            this.rdoS.Text = "S";
            this.rdoS.UseVisualStyleBackColor = true;
            this.rdoS.UseWaitCursor = true;
            // 
            // rdoN
            // 
            this.rdoN.AutoSize = true;
            this.rdoN.Checked = true;
            this.rdoN.Location = new System.Drawing.Point(84, 148);
            this.rdoN.Name = "rdoN";
            this.rdoN.Size = new System.Drawing.Size(29, 16);
            this.rdoN.TabIndex = 7;
            this.rdoN.TabStop = true;
            this.rdoN.Text = "N";
            this.rdoN.UseVisualStyleBackColor = true;
            this.rdoN.UseWaitCursor = true;
            // 
            // txtZone
            // 
            this.txtZone.Location = new System.Drawing.Point(43, 114);
            this.txtZone.Name = "txtZone";
            this.txtZone.Size = new System.Drawing.Size(70, 21);
            this.txtZone.TabIndex = 6;
            this.txtZone.UseWaitCursor = true;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(43, 70);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(166, 21);
            this.txtY.TabIndex = 5;
            this.txtY.UseWaitCursor = true;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(43, 29);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(166, 21);
            this.txtX.TabIndex = 4;
            this.txtX.UseWaitCursor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 12);
            this.label6.TabIndex = 3;
            this.label6.Text = "Hemisphere:";
            this.label6.UseWaitCursor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "Zone:";
            this.label5.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 12);
            this.label4.TabIndex = 1;
            this.label4.Text = "Y:";
            this.label4.UseWaitCursor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "X:";
            this.label3.UseWaitCursor = true;
            // 
            // btnWGS84ToUTM
            // 
            this.btnWGS84ToUTM.Location = new System.Drawing.Point(240, 53);
            this.btnWGS84ToUTM.Name = "btnWGS84ToUTM";
            this.btnWGS84ToUTM.Size = new System.Drawing.Size(49, 23);
            this.btnWGS84ToUTM.TabIndex = 6;
            this.btnWGS84ToUTM.Text = ">>";
            this.btnWGS84ToUTM.UseVisualStyleBackColor = true;
            this.btnWGS84ToUTM.UseWaitCursor = true;
            // 
            // btnUTMToWGS84
            // 
            this.btnUTMToWGS84.Location = new System.Drawing.Point(240, 94);
            this.btnUTMToWGS84.Name = "btnUTMToWGS84";
            this.btnUTMToWGS84.Size = new System.Drawing.Size(49, 23);
            this.btnUTMToWGS84.TabIndex = 7;
            this.btnUTMToWGS84.Text = "<<";
            this.btnUTMToWGS84.UseVisualStyleBackColor = true;
            this.btnUTMToWGS84.UseWaitCursor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(443, 253);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 23);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.UseWaitCursor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 298);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnUTMToWGS84);
            this.Controls.Add(this.btnWGS84ToUTM);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "UTM-WGS84转换工具";
            this.UseWaitCursor = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLon;
        private System.Windows.Forms.TextBox txtLat;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdoS;
        private System.Windows.Forms.RadioButton rdoN;
        private System.Windows.Forms.TextBox txtZone;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.Button btnWGS84ToUTM;
        private System.Windows.Forms.Button btnUTMToWGS84;
        private System.Windows.Forms.Button btnClear;
    }
}

