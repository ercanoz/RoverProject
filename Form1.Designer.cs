namespace RoverProject
{
    partial class Form1
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
            this.buttonMove = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelRoverDirection1 = new System.Windows.Forms.Label();
            this.labelRoverY1 = new System.Windows.Forms.Label();
            this.labelRoverX1 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelRoverDirection2 = new System.Windows.Forms.Label();
            this.labelRoverY2 = new System.Windows.Forms.Label();
            this.labelRoverX2 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtInputValues = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonMove
            // 
            this.buttonMove.Location = new System.Drawing.Point(329, 161);
            this.buttonMove.Name = "buttonMove";
            this.buttonMove.Size = new System.Drawing.Size(75, 23);
            this.buttonMove.TabIndex = 0;
            this.buttonMove.Text = "MOVE";
            this.buttonMove.UseVisualStyleBackColor = true;
            this.buttonMove.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelRoverDirection1);
            this.groupBox1.Controls.Add(this.labelRoverY1);
            this.groupBox1.Controls.Add(this.labelRoverX1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(447, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(255, 97);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rover 1";
            // 
            // labelRoverDirection1
            // 
            this.labelRoverDirection1.AutoSize = true;
            this.labelRoverDirection1.Location = new System.Drawing.Point(66, 58);
            this.labelRoverDirection1.Name = "labelRoverDirection1";
            this.labelRoverDirection1.Size = new System.Drawing.Size(0, 13);
            this.labelRoverDirection1.TabIndex = 10;
            // 
            // labelRoverY1
            // 
            this.labelRoverY1.AutoSize = true;
            this.labelRoverY1.Location = new System.Drawing.Point(160, 28);
            this.labelRoverY1.Name = "labelRoverY1";
            this.labelRoverY1.Size = new System.Drawing.Size(0, 13);
            this.labelRoverY1.TabIndex = 9;
            // 
            // labelRoverX1
            // 
            this.labelRoverX1.AutoSize = true;
            this.labelRoverX1.Location = new System.Drawing.Point(90, 28);
            this.labelRoverX1.Name = "labelRoverX1";
            this.labelRoverX1.Size = new System.Drawing.Size(0, 13);
            this.labelRoverX1.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(136, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(17, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Y:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(66, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "X:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 58);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Direction:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Location:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelRoverDirection2);
            this.groupBox2.Controls.Add(this.labelRoverY2);
            this.groupBox2.Controls.Add(this.labelRoverX2);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Location = new System.Drawing.Point(447, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(255, 97);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Rover 2";
            // 
            // labelRoverDirection2
            // 
            this.labelRoverDirection2.AutoSize = true;
            this.labelRoverDirection2.Location = new System.Drawing.Point(66, 58);
            this.labelRoverDirection2.Name = "labelRoverDirection2";
            this.labelRoverDirection2.Size = new System.Drawing.Size(0, 13);
            this.labelRoverDirection2.TabIndex = 17;
            // 
            // labelRoverY2
            // 
            this.labelRoverY2.AutoSize = true;
            this.labelRoverY2.Location = new System.Drawing.Point(160, 28);
            this.labelRoverY2.Name = "labelRoverY2";
            this.labelRoverY2.Size = new System.Drawing.Size(0, 13);
            this.labelRoverY2.TabIndex = 16;
            // 
            // labelRoverX2
            // 
            this.labelRoverX2.AutoSize = true;
            this.labelRoverX2.Location = new System.Drawing.Point(90, 28);
            this.labelRoverX2.Name = "labelRoverX2";
            this.labelRoverX2.Size = new System.Drawing.Size(0, 13);
            this.labelRoverX2.TabIndex = 15;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(136, 28);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Y:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(66, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(17, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "X:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 58);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(52, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Direction:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(6, 28);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 13);
            this.label15.TabIndex = 11;
            this.label15.Text = "Location:";
            // 
            // txtInputValues
            // 
            this.txtInputValues.Location = new System.Drawing.Point(34, 47);
            this.txtInputValues.Multiline = true;
            this.txtInputValues.Name = "txtInputValues";
            this.txtInputValues.Size = new System.Drawing.Size(382, 109);
            this.txtInputValues.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.buttonMove);
            this.groupBox3.Location = new System.Drawing.Point(12, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(429, 200);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Input Values";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 710);
            this.Controls.Add(this.txtInputValues);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox3);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonMove;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelRoverY1;
        private System.Windows.Forms.Label labelRoverX1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label labelRoverDirection1;
        private System.Windows.Forms.Label labelRoverDirection2;
        private System.Windows.Forms.Label labelRoverY2;
        private System.Windows.Forms.Label labelRoverX2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtInputValues;
        private System.Windows.Forms.GroupBox groupBox3;
    }
}

