using System;
using System.Windows.Forms;
using GENERAL_DPI6.JMS;
using GENERAL_DPI6.Models.Connection;
using MaterialSkin;
using MaterialSkin.Controls;

namespace DPI6_Casus
{
    public partial class Form1 : MaterialForm
    {
        private Producer producer;

        public Form1()
        {
            InitializeComponent();

            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue400, Primary.Blue500,
                Primary.Blue500, Accent.LightBlue200,
                TextShade.WHITE
            );

            producer = new Producer(Guid.NewGuid().ToString());
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dtpTime.Format = DateTimePickerFormat.Custom;
            dtpTime.ShowUpDown = true;
            dtpTime.CustomFormat = "HH:mm";
        }

        private void sendConnectionRequest()
        {
            DateTime date = dtpDate.Value;
            DateTime time = dtpTime.Value;
            string cityFrom = cbCityFrom.SelectedText;
            string cityTo = cbCityTo.SelectedText;

            if(date != null && time != null && !String.IsNullOrEmpty(cityFrom) && !String.IsNullOrEmpty(cityTo)){
                ConnectionRequest connectionRequest = new ConnectionRequest(date, time, cityFrom, cityTo);
                producer.SendConnectionRequest(connectionRequest);
            }
        }
    }
}
