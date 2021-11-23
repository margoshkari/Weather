using HtmlAgilityPack;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Weather
{
    public partial class Form1 : Form
    {
        Timer timer;
        string html = @"https://www.gismeteo.ua/weather-dnipro-5077/now/";
        HtmlWeb web = new HtmlWeb();
        HtmlAgilityPack.HtmlDocument htmlDoc;

        public Form1()
        {
            InitializeComponent();

            htmlDoc = web.Load(html);

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
            this.cityLabel.Invoke((MethodInvoker)(() => this.cityLabel.Text = htmlDoc.DocumentNode.SelectSingleNode(@"//div[@class='pageinfo_title index-h1']//h1").InnerText.Trim()));

            this.dateLabel.Invoke((MethodInvoker)(() => this.dateLabel.Text = $"{DateTime.Now.DayOfWeek}, {DateTime.Now.Day}/{DateTime.Now.Month}, {DateTime.Now.Hour}:{DateTime.Now.Minute}"));

            this.tempLabel.Invoke((MethodInvoker)(() => this.tempLabel.Text = htmlDoc.DocumentNode.SelectSingleNode(@"//span[@class='unit unit_temperature_c']").InnerText.Trim().Replace("minus;", "-")));

            this.weatherLabel.Invoke((MethodInvoker)(() => this.weatherLabel.Text = htmlDoc.DocumentNode.SelectSingleNode(@"//span[@class='tip _top _center']").InnerText.Trim()));

            this.tempFeelingsLabel.Invoke((MethodInvoker)(() => this.tempFeelingsLabel.Text = $"По ощущению............................................." + htmlDoc.DocumentNode.SelectSingleNode(@"//div[@class='now__feel']//span[@class='unit unit_temperature_c']").InnerText.Trim().Replace("minus;", "-")));

            this.windLabel.Invoke((MethodInvoker)(() => this.windLabel.Text = "Ветер................................................" + htmlDoc.DocumentNode.SelectSingleNode(@"//div[@class='nowinfo__block']//div[@class='unit unit_wind_m_s']").InnerText.Trim().Replace(" ", "").Replace("\n", " ")));

            this.pressureLabel.Invoke((MethodInvoker)(() => this.pressureLabel.Text = "Давление..............................." + htmlDoc.DocumentNode.SelectSingleNode(@"//div[@class='nowinfo__item nowinfo__item_pressure']//div[@class='unit unit_pressure_mm_hg_atm']").InnerText.Trim().Replace(" ", "").Replace("\n", " ")));

            this.wetLabel.Invoke((MethodInvoker)(() => this.wetLabel.Text = "Влажность..............................................." + htmlDoc.DocumentNode.SelectSingleNode(@"//div[@class='nowinfo__item nowinfo__item_humidity']//div[@class='nowinfo__value']").InnerText.Trim() + "%"));

            this.activitylabel.Invoke((MethodInvoker)(() => this.activitylabel.Text = "Геомагнитная активность.............." + htmlDoc.DocumentNode.SelectSingleNode(@"//div[@class='nowinfo__item nowinfo__item_gm']//div[@class='nowinfo__value']").InnerText.Trim() + " балл"));

            this.waterTempLabel.Invoke((MethodInvoker)(() => this.waterTempLabel.Text = "Температура воды..............................." + htmlDoc.DocumentNode.SelectSingleNode(@"//div[@class='nowinfo__item nowinfo__item_water']//div[@class='nowinfo__value']").InnerText.Trim().Replace("minus;", " ")));
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((sender as ComboBox).SelectedIndex == 0)
                html = @"https://www.gismeteo.ua/weather-dnipro-5077/now/";
            else if ((sender as ComboBox).SelectedIndex == 1)
                html = @"https://www.gismeteo.ua/weather-kyiv-4944/now/";
            else if ((sender as ComboBox).SelectedIndex == 2)
                html = @"https://www.gismeteo.ua/weather-odessa-4982/now/";
            else if ((sender as ComboBox).SelectedIndex == 3)
                html = @"https://www.gismeteo.ua/weather-lviv-4949/now/";

            htmlDoc = web.Load(html);
        }
    }
}
