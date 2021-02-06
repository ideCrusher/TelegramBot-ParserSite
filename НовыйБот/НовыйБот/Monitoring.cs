using System;
using System.Windows.Forms;
using System.Diagnostics;

namespace НовыйБот
{
    public partial class Monitoring : Form
    {
        public Monitoring()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e) 
        {
            Stats.CountStats();
            ALL.Text = $"{Stats.ALL}";
            MaxInt.Text = $"{Stats.ThemsMax}/{Stats.MaxS} - {Stats.MaxInt};";
            MinInt.Text = $"{Stats.ThemsMin}/{Stats.MinS} - {Stats.MinInt};";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main.m.button1.Enabled = true;
            Main.m.textBox1.Enabled = true;

            Hide();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            loading.Habr();
            loading.DTF();

            loading.Igromania();
            Process.Start("C:/Users/User/Desktop/Бот+Парсер+Потоки/КонсольПарсерСайтов/КонсольПарсерСайтов/bin/Debug/КонсольПарсерСайтов.exe");
        }

        private void Monitoring_Load(object sender, EventArgs e)
        {

        }
    }
}
