using System;
using System.Windows.Forms;
using GENERAL_DPI6.JMS;
using GENERAL_DPI6.Models;
using GENERAL_DPI6.Models.Connection;
using MaterialSkin;
using MaterialSkin.Controls;

namespace DPI6_Casus
{
    public partial class Form1 : MaterialForm
    {
        private Client client;

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

            client = new Client();

            cbCityFrom.Items.Add("Düsseldorf");
            cbCityTo.Items.Add("Kiev");
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
            string cityFrom = cbCityFrom.SelectedItem.ToString();
            string cityTo = cbCityTo.SelectedItem.ToString();

            if(date != null && time != null && !String.IsNullOrEmpty(cityFrom) && !String.IsNullOrEmpty(cityTo)){
                ConnectionRequest connectionRequest = new ConnectionRequest(date, time, cityFrom, cityTo);
                RequestReply<ConnectionRequest, ConnectionReply> requestReply = new RequestReply<ConnectionRequest, ConnectionReply>(connectionRequest, null);
                client.SendConnectionRequest(requestReply);
            }
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            sendConnectionRequest();
        }
    }
}
