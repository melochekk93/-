
namespace Гонки_кнопок
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CAR2 = new Гонки_кнопок.ButtonCompare();
            this.CAR3 = new Гонки_кнопок.ButtonCompare();
            this.CAR1 = new Гонки_кнопок.ButtonCompare();
            this.CAR4 = new Гонки_кнопок.ButtonCompare();
            this.START = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.STOP = new System.Windows.Forms.Button();
            this.PAUSE = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // CAR2
            // 
            this.CAR2.Location = new System.Drawing.Point(29, 70);
            this.CAR2.Name = "CAR2";
            this.CAR2.Size = new System.Drawing.Size(75, 23);
            this.CAR2.TabIndex = 0;
            this.CAR2.Text = "CAR2";
            this.CAR2.UseVisualStyleBackColor = true;
            this.CAR2.Click += new System.EventHandler(this.CAR2_Click);
            // 
            // CAR3
            // 
            this.CAR3.Location = new System.Drawing.Point(29, 99);
            this.CAR3.Name = "CAR3";
            this.CAR3.Size = new System.Drawing.Size(75, 23);
            this.CAR3.TabIndex = 1;
            this.CAR3.Text = "CAR3";
            this.CAR3.UseVisualStyleBackColor = true;
            this.CAR3.Click += new System.EventHandler(this.CAR3_Click);
            // 
            // CAR1
            // 
            this.CAR1.Location = new System.Drawing.Point(29, 41);
            this.CAR1.Name = "CAR1";
            this.CAR1.Size = new System.Drawing.Size(75, 23);
            this.CAR1.TabIndex = 2;
            this.CAR1.Text = "CAR1";
            this.CAR1.UseVisualStyleBackColor = true;
            this.CAR1.Click += new System.EventHandler(this.CAR1_Click);
            // 
            // CAR4
            // 
            this.CAR4.Location = new System.Drawing.Point(29, 128);
            this.CAR4.Name = "CAR4";
            this.CAR4.Size = new System.Drawing.Size(75, 23);
            this.CAR4.TabIndex = 3;
            this.CAR4.Text = "CAR4";
            this.CAR4.UseVisualStyleBackColor = true;
            this.CAR4.Click += new System.EventHandler(this.CAR4_Click);
            // 
            // START
            // 
            this.START.BackColor = System.Drawing.Color.White;
            this.START.Location = new System.Drawing.Point(3, 3);
            this.START.Name = "START";
            this.START.Size = new System.Drawing.Size(65, 58);
            this.START.TabIndex = 5;
            this.START.Text = "START";
            this.START.UseVisualStyleBackColor = false;
            this.START.Click += new System.EventHandler(this.START_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.STOP);
            this.panel1.Controls.Add(this.PAUSE);
            this.panel1.Controls.Add(this.START);
            this.panel1.Location = new System.Drawing.Point(368, 219);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(214, 64);
            this.panel1.TabIndex = 7;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // STOP
            // 
            this.STOP.BackColor = System.Drawing.Color.White;
            this.STOP.Enabled = false;
            this.STOP.Location = new System.Drawing.Point(145, 3);
            this.STOP.Name = "STOP";
            this.STOP.Size = new System.Drawing.Size(65, 58);
            this.STOP.TabIndex = 7;
            this.STOP.Text = "STOP";
            this.STOP.UseVisualStyleBackColor = false;
            this.STOP.Click += new System.EventHandler(this.STOP_Click);
            // 
            // PAUSE
            // 
            this.PAUSE.BackColor = System.Drawing.Color.White;
            this.PAUSE.Enabled = false;
            this.PAUSE.Location = new System.Drawing.Point(74, 3);
            this.PAUSE.Name = "PAUSE";
            this.PAUSE.Size = new System.Drawing.Size(65, 58);
            this.PAUSE.TabIndex = 6;
            this.PAUSE.Text = "PAUSE";
            this.PAUSE.UseVisualStyleBackColor = false;
            this.PAUSE.Click += new System.EventHandler(this.PAUSE_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Гонки_кнопок.Properties.Resources.Finish;
            this.pictureBox1.InitialImage = global::Гонки_кнопок.Properties.Resources.Finish;
            this.pictureBox1.Location = new System.Drawing.Point(697, 41);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 110);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CAR4);
            this.Controls.Add(this.CAR1);
            this.Controls.Add(this.CAR3);
            this.Controls.Add(this.CAR2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ButtonCompare CAR2;
        private ButtonCompare CAR3;
        private ButtonCompare CAR1;
        private ButtonCompare CAR4;

        private System.Windows.Forms.Button START;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button STOP;
        private System.Windows.Forms.Button PAUSE;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

