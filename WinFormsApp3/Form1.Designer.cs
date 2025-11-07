namespace WinFormsApp3
{
    partial class Form1
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
            tableLayoutPanel1 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            k20radioButton6 = new RadioButton();
            k12radioButton5 = new RadioButton();
            k10radioButton4 = new RadioButton();
            k8radioButton3 = new RadioButton();
            k6radioButton2 = new RadioButton();
            k4radioButton1 = new RadioButton();
            groupBox2 = new GroupBox();
            button1 = new Button();
            groupBox3 = new GroupBox();
            pictureBox1 = new PictureBox();
            ResultLabel = new Label();
            tableLayoutPanel1.SuspendLayout();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(groupBox1, 0, 0);
            tableLayoutPanel1.Controls.Add(groupBox2, 0, 1);
            tableLayoutPanel1.Controls.Add(groupBox3, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(551, 606);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(k20radioButton6);
            groupBox1.Controls.Add(k12radioButton5);
            groupBox1.Controls.Add(k10radioButton4);
            groupBox1.Controls.Add(k8radioButton3);
            groupBox1.Controls.Add(k6radioButton2);
            groupBox1.Controls.Add(k4radioButton1);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(3, 3);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(545, 196);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Wybor kosci";
            // 
            // k20radioButton6
            // 
            k20radioButton6.AutoSize = true;
            k20radioButton6.Font = new Font("Segoe UI", 20F);
            k20radioButton6.Location = new Point(280, 138);
            k20radioButton6.Name = "k20radioButton6";
            k20radioButton6.RightToLeft = RightToLeft.No;
            k20radioButton6.Size = new Size(81, 41);
            k20radioButton6.TabIndex = 5;
            k20radioButton6.TabStop = true;
            k20radioButton6.Text = "K20";
            k20radioButton6.UseVisualStyleBackColor = true;
            // 
            // k12radioButton5
            // 
            k12radioButton5.AutoSize = true;
            k12radioButton5.Font = new Font("Segoe UI", 20F);
            k12radioButton5.Location = new Point(280, 91);
            k12radioButton5.Name = "k12radioButton5";
            k12radioButton5.Size = new Size(81, 41);
            k12radioButton5.TabIndex = 4;
            k12radioButton5.TabStop = true;
            k12radioButton5.Text = "K12";
            k12radioButton5.UseVisualStyleBackColor = true;
            // 
            // k10radioButton4
            // 
            k10radioButton4.AutoSize = true;
            k10radioButton4.Font = new Font("Segoe UI", 20F);
            k10radioButton4.Location = new Point(280, 44);
            k10radioButton4.Name = "k10radioButton4";
            k10radioButton4.Size = new Size(81, 41);
            k10radioButton4.TabIndex = 3;
            k10radioButton4.TabStop = true;
            k10radioButton4.Text = "K10";
            k10radioButton4.UseVisualStyleBackColor = true;
            k10radioButton4.CheckedChanged += k10radioButton4_CheckedChanged;
            // 
            // k8radioButton3
            // 
            k8radioButton3.AutoSize = true;
            k8radioButton3.Font = new Font("Segoe UI", 20F);
            k8radioButton3.Location = new Point(169, 138);
            k8radioButton3.Name = "k8radioButton3";
            k8radioButton3.Size = new Size(66, 41);
            k8radioButton3.TabIndex = 2;
            k8radioButton3.TabStop = true;
            k8radioButton3.Text = "K8";
            k8radioButton3.UseVisualStyleBackColor = true;
            // 
            // k6radioButton2
            // 
            k6radioButton2.AutoSize = true;
            k6radioButton2.Font = new Font("Segoe UI", 20F);
            k6radioButton2.Location = new Point(169, 91);
            k6radioButton2.Name = "k6radioButton2";
            k6radioButton2.Size = new Size(66, 41);
            k6radioButton2.TabIndex = 1;
            k6radioButton2.TabStop = true;
            k6radioButton2.Text = "K6";
            k6radioButton2.UseVisualStyleBackColor = true;
            // 
            // k4radioButton1
            // 
            k4radioButton1.AutoSize = true;
            k4radioButton1.Font = new Font("Segoe UI", 20F);
            k4radioButton1.Location = new Point(169, 44);
            k4radioButton1.Name = "k4radioButton1";
            k4radioButton1.Size = new Size(66, 41);
            k4radioButton1.TabIndex = 0;
            k4radioButton1.TabStop = true;
            k4radioButton1.Text = "K4";
            k4radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(button1);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(3, 205);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(545, 196);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Losowanie";
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Segoe UI", 20F);
            button1.Location = new Point(3, 19);
            button1.Name = "button1";
            button1.Size = new Size(539, 174);
            button1.TabIndex = 0;
            button1.Text = "Losuj";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(pictureBox1);
            groupBox3.Controls.Add(ResultLabel);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(3, 407);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(545, 196);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Wynik";
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Location = new Point(3, 19);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(539, 174);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // ResultLabel
            // 
            ResultLabel.Dock = DockStyle.Fill;
            ResultLabel.Font = new Font("Segoe UI", 20F);
            ResultLabel.Location = new Point(3, 19);
            ResultLabel.Name = "ResultLabel";
            ResultLabel.Size = new Size(539, 174);
            ResultLabel.TabIndex = 0;
            ResultLabel.Text = "Wynik";
            ResultLabel.TextAlign = ContentAlignment.MiddleCenter;
            ResultLabel.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(551, 606);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RadioButton k20radioButton6;
        private RadioButton k12radioButton5;
        private RadioButton k10radioButton4;
        private RadioButton k8radioButton3;
        private RadioButton k6radioButton2;
        private RadioButton k4radioButton1;
        private Button button1;
        private Label ResultLabel;
        private PictureBox pictureBox1;
    }
}
