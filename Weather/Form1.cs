using HtmlAgilityPack;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather
{
    public partial class Form1 : Form
    {
        Timer timer;
        public Form1()
        {
            InitializeComponent();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Task.Factory.StartNew(() => LoadData());
        }

        public void LoadData()
        {
            var html = @"https://www.gismeteo.ua/";
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(html);

            this.cityLabel.Invoke((MethodInvoker)(() => this.cityLabel.Text = htmlDoc.DocumentNode.SelectSingleNode(@"//a[@class='link blue weather_current_link no_border']").InnerText.Trim()));

            this.dateLabel.Invoke((MethodInvoker)(() => this.dateLabel.Text = $"{DateTime.Now.DayOfWeek}, {DateTime.Now.Day}/{DateTime.Now.Month}, {DateTime.Now.Hour}:{DateTime.Now.Minute}"));
           
            this.tempLabel.Invoke((MethodInvoker)(() => this.tempLabel.Text = htmlDoc.DocumentNode.SelectSingleNode(@"//span[@class='value unit unit_temperature_c']").InnerText.Trim().Replace("minus;", "-")));
            
            this.weatherLabel.Invoke((MethodInvoker)(() => this.weatherLabel.Text = htmlDoc.DocumentNode.SelectSingleNode(@"//div[@class='description gray']").InnerText.Trim()));
            
            this.tempFeelingsLabel.Invoke((MethodInvoker)(() => this.tempFeelingsLabel.Text = $"По ощущению............................................." + htmlDoc.DocumentNode.SelectSingleNode(@"//div[@class='ii info_value']//span").InnerText.Trim().Replace("minus;", "-")));
            
            this.windLabel.Invoke((MethodInvoker)(() => this.windLabel.Text = "Ветер................................................" + htmlDoc.DocumentNode.SelectSingleNode(@"//span[@class='unit unit_wind_m_s']").InnerText.Trim()));
            
            this.pressureLabel.Invoke((MethodInvoker)(() => this.pressureLabel.Text = "Давление..............................." + htmlDoc.DocumentNode.SelectSingleNode(@"//span[@class='unit unit_pressure_mm_hg_atm']").InnerText.Trim()));
            
            this.wetLabel.Invoke((MethodInvoker)(() => this.wetLabel.Text = "Влажность..............................................." + htmlDoc.DocumentNode.SelectSingleNode(@"//div[@class='information _additional opened']//div[2]//div[2]").InnerText.Trim().Replace("nbsp;", " ")));
           
            this.activitylabel.Invoke((MethodInvoker)(() => this.activitylabel.Text = "Геомагнитная активность.............." + htmlDoc.DocumentNode.SelectSingleNode(@"//div[@class='information _additional opened']//div[3]//div[2]").InnerText.Trim()));
            
            this.waterTempLabel.Invoke((MethodInvoker)(() => this.waterTempLabel.Text = "Температура воды..............................." + htmlDoc.DocumentNode.SelectSingleNode(@"//div[@class='information _additional opened']//div[4]//div[2]").InnerText.Trim().Replace("minus;", " ")));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
