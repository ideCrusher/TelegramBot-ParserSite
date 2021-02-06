
namespace НовыйБот
{
    partial class Monitoring
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
            this.components = new System.ComponentModel.Container();
            this.MaxViews = new System.Windows.Forms.Label();
            this.MinViews = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.MinInt = new System.Windows.Forms.Label();
            this.MaxInt = new System.Windows.Forms.Label();
            this.ALL = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.TotalViews = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MaxViews
            // 
            this.MaxViews.AutoSize = true;
            this.MaxViews.Location = new System.Drawing.Point(5, 88);
            this.MaxViews.Name = "MaxViews";
            this.MaxViews.Size = new System.Drawing.Size(215, 20);
            this.MaxViews.TabIndex = 0;
            this.MaxViews.Text = "Больше всего просмотров:";
            // 
            // MinViews
            // 
            this.MinViews.AutoSize = true;
            this.MinViews.Location = new System.Drawing.Point(5, 136);
            this.MinViews.Name = "MinViews";
            this.MinViews.Size = new System.Drawing.Size(216, 20);
            this.MinViews.TabIndex = 1;
            this.MinViews.Text = "Меньше всего просмотров:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.MinInt);
            this.groupBox1.Controls.Add(this.MaxInt);
            this.groupBox1.Controls.Add(this.ALL);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.TotalViews);
            this.groupBox1.Controls.Add(this.MaxViews);
            this.groupBox1.Controls.Add(this.MinViews);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(311, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(477, 376);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация за сегодня";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(249, 333);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(209, 37);
            this.button3.TabIndex = 7;
            this.button3.Text = "Статистика за месяц";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MinInt
            // 
            this.MinInt.AutoSize = true;
            this.MinInt.Location = new System.Drawing.Point(226, 136);
            this.MinInt.Name = "MinInt";
            this.MinInt.Size = new System.Drawing.Size(53, 20);
            this.MinInt.TabIndex = 6;
            this.MinInt.Text = "MinInt";
            // 
            // MaxInt
            // 
            this.MaxInt.AutoSize = true;
            this.MaxInt.Location = new System.Drawing.Point(226, 88);
            this.MaxInt.Name = "MaxInt";
            this.MaxInt.Size = new System.Drawing.Size(57, 20);
            this.MaxInt.TabIndex = 5;
            this.MaxInt.Text = "MaxInt";
            // 
            // ALL
            // 
            this.ALL.AutoSize = true;
            this.ALL.Location = new System.Drawing.Point(226, 44);
            this.ALL.Name = "ALL";
            this.ALL.Size = new System.Drawing.Size(38, 20);
            this.ALL.TabIndex = 4;
            this.ALL.Text = "ALL";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(23, 333);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(210, 37);
            this.button1.TabIndex = 3;
            this.button1.Text = "Расширеный просмотр";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // TotalViews
            // 
            this.TotalViews.AutoSize = true;
            this.TotalViews.Location = new System.Drawing.Point(6, 44);
            this.TotalViews.Name = "TotalViews";
            this.TotalViews.Size = new System.Drawing.Size(152, 20);
            this.TotalViews.TabIndex = 2;
            this.TotalViews.Text = "Всего просмотров:";
            // 
            // groupBox2
            // 
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(293, 426);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Последние запросы";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.Location = new System.Drawing.Point(578, 401);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(210, 37);
            this.button2.TabIndex = 8;
            this.button2.Text = "Выход";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 300000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Monitoring
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Monitoring";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Monitoring";
            this.Load += new System.EventHandler(this.Monitoring_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label MaxViews;
        private System.Windows.Forms.Label MinViews;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label MinInt;
        private System.Windows.Forms.Label MaxInt;
        private System.Windows.Forms.Label ALL;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label TotalViews;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}