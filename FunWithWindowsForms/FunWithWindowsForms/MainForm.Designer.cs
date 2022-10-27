namespace FunWithWindowsForms
{
    partial class MainForm
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.btnLegend = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tbArea = new System.Windows.Forms.TextBox();
            this.tbLength = new System.Windows.Forms.TextBox();
            this.tbRadius = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlLegend = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            this.pnlLegend.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pnlMain.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlMain.Controls.Add(this.btnLegend);
            this.pnlMain.Controls.Add(this.button1);
            this.pnlMain.Controls.Add(this.tbArea);
            this.pnlMain.Controls.Add(this.tbLength);
            this.pnlMain.Controls.Add(this.tbRadius);
            this.pnlMain.Controls.Add(this.label3);
            this.pnlMain.Controls.Add(this.label2);
            this.pnlMain.Controls.Add(this.label1);
            this.pnlMain.Location = new System.Drawing.Point(5, 5);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(217, 292);
            this.pnlMain.TabIndex = 0;
            // 
            // btnLegend
            // 
            this.btnLegend.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLegend.Location = new System.Drawing.Point(96, 249);
            this.btnLegend.Name = "btnLegend";
            this.btnLegend.Size = new System.Drawing.Size(96, 23);
            this.btnLegend.TabIndex = 7;
            this.btnLegend.Text = "Hide legend <=";
            this.btnLegend.UseVisualStyleBackColor = false;
            this.btnLegend.Click += new System.EventHandler(this.btnLegend_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(107, 379);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tbArea
            // 
            this.tbArea.Location = new System.Drawing.Point(42, 170);
            this.tbArea.Name = "tbArea";
            this.tbArea.Size = new System.Drawing.Size(150, 20);
            this.tbArea.TabIndex = 5;
            this.tbArea.Text = "0";
            this.tbArea.TextChanged += new System.EventHandler(this.tbArea_TextChanged);
            this.tbArea.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCommon_KeyPress);
            // 
            // tbLength
            // 
            this.tbLength.Location = new System.Drawing.Point(42, 109);
            this.tbLength.Name = "tbLength";
            this.tbLength.Size = new System.Drawing.Size(150, 20);
            this.tbLength.TabIndex = 4;
            this.tbLength.Text = "0";
            this.tbLength.TextChanged += new System.EventHandler(this.tbLength_TextChanged);
            this.tbLength.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCommon_KeyPress);
            // 
            // tbRadius
            // 
            this.tbRadius.Location = new System.Drawing.Point(42, 48);
            this.tbRadius.Name = "tbRadius";
            this.tbRadius.Size = new System.Drawing.Size(150, 20);
            this.tbRadius.TabIndex = 3;
            this.tbRadius.Text = "0";
            this.tbRadius.TextChanged += new System.EventHandler(this.tbRadius_TextChanged);
            this.tbRadius.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCommon_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "S:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "C:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "R:";
            // 
            // pnlLegend
            // 
            this.pnlLegend.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlLegend.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnlLegend.Controls.Add(this.label6);
            this.pnlLegend.Controls.Add(this.label5);
            this.pnlLegend.Controls.Add(this.label4);
            this.pnlLegend.Location = new System.Drawing.Point(228, 5);
            this.pnlLegend.Name = "pnlLegend";
            this.pnlLegend.Size = new System.Drawing.Size(273, 292);
            this.pnlLegend.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(14, 160);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 38);
            this.label6.TabIndex = 2;
            this.label6.Text = "Circle area\r\nS = πr²";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(14, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(239, 38);
            this.label5.TabIndex = 1;
            this.label5.Text = "Circumference (length of the circle)\r\nC = 2πr";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(14, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 19);
            this.label4.TabIndex = 0;
            this.label4.Text = "Radius of the circle";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 301);
            this.Controls.Add(this.pnlLegend);
            this.Controls.Add(this.pnlMain);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(520, 340);
            this.MinimumSize = new System.Drawing.Size(520, 340);
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "CircleCalc";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.pnlLegend.ResumeLayout(false);
            this.pnlLegend.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.TextBox tbArea;
        private System.Windows.Forms.TextBox tbLength;
        private System.Windows.Forms.TextBox tbRadius;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlLegend;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLegend;
        private System.Windows.Forms.Button button1;
    }
}

