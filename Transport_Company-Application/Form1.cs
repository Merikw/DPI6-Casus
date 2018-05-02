using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using GENERAL_DPI6.Database;
using GENERAL_DPI6.Database.Implementation;
using GENERAL_DPI6.Database.Interface_repo_s;
using GENERAL_DPI6.Enums;
using GENERAL_DPI6.JMS;
using GENERAL_DPI6.Models.DB_Models;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Transport_Company_Application
{
    public partial class Form1 : MaterialForm
    {
        private ICityDB cityDB;
        private TransportCompany transportCompany;

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

            rbTypeBus.Select();

            setAddedCompany(false);

            cityDB = new CityDB();
            setCitiesAsync();
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
        }

        private void btnAddCompany_Click(object sender, System.EventArgs e)
        {
            TRANSPORT_TYPE transportType = TRANSPORT_TYPE.BUS;

            if (rbTypeBus.Checked)
            {
                transportType = TRANSPORT_TYPE.BUS;
            }
            else if (rbTypePlane.Checked)
            {
                transportType = TRANSPORT_TYPE.AIRPLANE;
            }
            else if (rbTypeTrain.Checked)
            {
                transportType = TRANSPORT_TYPE.TRAIN;
            }

            setAddedCompany(true);

            transportCompany = new TransportCompany(txtTransportCompanyName.Text, transportType);
        }

        private void setAddedCompany(bool added)
        {
            lblAddConnection.Visible = added;
            lblConnections.Visible = added;
            lblFrom.Visible = added;
            lblTo.Visible = added;
            lblAvailableTickets.Visible = added;
            lblPrice.Visible = added;
            lblConnections.Visible = added;
            cbFromCity.Visible = added;
            cbToCity.Visible = added;
            txtAvailableTickets.Visible = added;
            txtPrice.Visible = added;
            lvConnections.Visible = added;
            btnAddConnection.Visible = added;
            btnRemoveConnection.Visible = added;

            lblNameOfCompany.Visible = !added;
            lblTypeOfCompany.Visible = !added;
            txtTransportCompanyName.Visible = !added;
            btnAddCompany.Visible = !added;
            rbTypeBus.Visible = !added;
            rbTypePlane.Visible = !added;
            rbTypeTrain.Visible = !added;
        }

        private async Task setCitiesAsync()
        {
            cityDB.Insert(new CityDBModel("Berlin"));
            List<CityDBModel> cities = await cityDB.GetAll();
            foreach(CityDBModel city in cities)
            {
                cbFromCity.Items.Add(city.Name);
                cbToCity.Items.Add(city.Name);
            }
        }

        private void btnAddConnection_Click(object sender, System.EventArgs e)
        {
            string cityFrom = cbFromCity.SelectedText.ToString();
            string cityTo = cbToCity.SelectedText.ToString();
            int price = 0;
            int ticketsAvailable = 0;
            if (int.TryParse(txtPrice.Text.ToString(), out price) && int.TryParse(txtAvailableTickets.Text.ToString(), out ticketsAvailable)
                && !string.IsNullOrEmpty(cityFrom) && !string.IsNullOrEmpty(cityTo))
            {
                transportCompany.AddConnection(new ConnectionDBModel(cityFrom, cityTo, ticketsAvailable, price));
                lvConnections.Items.Add(new ConnectionDBModel(cityFrom, cityTo, ticketsAvailable, price).ToString());
            }
        }
    }
}
