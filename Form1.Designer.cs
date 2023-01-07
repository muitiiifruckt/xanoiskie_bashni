namespace Ханойские_башни
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.Speed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.button_solve = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pic_hotisontal_tower = new System.Windows.Forms.PictureBox();
            this.pic_tower_3 = new System.Windows.Forms.PictureBox();
            this.pic_tower_2 = new System.Windows.Forms.PictureBox();
            this.pic_tower_1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_hotisontal_tower)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_tower_3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_tower_2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_tower_1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.Speed);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.button_solve);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(1501, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(132, 753);
            this.panel1.TabIndex = 0;
            // 
            // Speed
            // 
            this.Speed.AutoSize = true;
            this.Speed.Location = new System.Drawing.Point(12, 62);
            this.Speed.Name = "Speed";
            this.Speed.Size = new System.Drawing.Size(48, 16);
            this.Speed.TabIndex = 2;
            this.Speed.Text = "Speed";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Count of Disks";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(5, 81);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(115, 22);
            this.numericUpDown2.TabIndex = 1;
            this.numericUpDown2.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(5, 29);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(115, 22);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // button_solve
            // 
            this.button_solve.Location = new System.Drawing.Point(5, 153);
            this.button_solve.Name = "button_solve";
            this.button_solve.Size = new System.Drawing.Size(115, 23);
            this.button_solve.TabIndex = 0;
            this.button_solve.Text = "Solve";
            this.button_solve.UseVisualStyleBackColor = true;
            this.button_solve.Click += new System.EventHandler(this.button_solve_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Black;
            this.pictureBox3.Location = new System.Drawing.Point(1086, 733);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(180, 20);
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Black;
            this.pictureBox2.Location = new System.Drawing.Point(601, 733);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 20);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pic_hotisontal_tower
            // 
            this.pic_hotisontal_tower.BackColor = System.Drawing.Color.Black;
            this.pic_hotisontal_tower.Location = new System.Drawing.Point(146, 733);
            this.pic_hotisontal_tower.Name = "pic_hotisontal_tower";
            this.pic_hotisontal_tower.Size = new System.Drawing.Size(180, 20);
            this.pic_hotisontal_tower.TabIndex = 1;
            this.pic_hotisontal_tower.TabStop = false;
            // 
            // pic_tower_3
            // 
            this.pic_tower_3.BackColor = System.Drawing.SystemColors.Desktop;
            this.pic_tower_3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pic_tower_3.Location = new System.Drawing.Point(1169, 253);
            this.pic_tower_3.Name = "pic_tower_3";
            this.pic_tower_3.Size = new System.Drawing.Size(15, 500);
            this.pic_tower_3.TabIndex = 2;
            this.pic_tower_3.TabStop = false;
            // 
            // pic_tower_2
            // 
            this.pic_tower_2.BackColor = System.Drawing.SystemColors.Desktop;
            this.pic_tower_2.Location = new System.Drawing.Point(685, 253);
            this.pic_tower_2.Name = "pic_tower_2";
            this.pic_tower_2.Size = new System.Drawing.Size(15, 500);
            this.pic_tower_2.TabIndex = 2;
            this.pic_tower_2.TabStop = false;
            // 
            // pic_tower_1
            // 
            this.pic_tower_1.BackColor = System.Drawing.SystemColors.Desktop;
            this.pic_tower_1.Location = new System.Drawing.Point(232, 253);
            this.pic_tower_1.Name = "pic_tower_1";
            this.pic_tower_1.Size = new System.Drawing.Size(15, 500);
            this.pic_tower_1.TabIndex = 2;
            this.pic_tower_1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(1633, 753);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pic_hotisontal_tower);
            this.Controls.Add(this.pic_tower_3);
            this.Controls.Add(this.pic_tower_2);
            this.Controls.Add(this.pic_tower_1);
            this.Name = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_hotisontal_tower)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_tower_3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_tower_2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pic_tower_1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_solve;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.PictureBox pic_hotisontal_tower;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pic_tower_1;
        private System.Windows.Forms.PictureBox pic_tower_2;
        private System.Windows.Forms.PictureBox pic_tower_3;
        private System.Windows.Forms.Label Speed;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
    }
}

