using System.Windows.Forms;
using GENERAL_DPI6.Enums;
using GENERAL_DPI6.JMS;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Transport_Company_Application
{
    public partial class Form1 : MaterialForm
    {
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
        }

        private void Form1_Load(object sender, System.EventArgs e)
        {
        }

        private void materialRaisedButton1_Click(object sender, System.EventArgs e)
        {
            TRANSPORT_TYPE transportType = TRANSPORT_TYPE.TRAIN;

            if (rbTypeBus.Checked)
            {
                transportType = TRANSPORT_TYPE.BUS;
            } else if (rbTypePlane.Checked)
            {
                transportType = TRANSPORT_TYPE.AIRPLANE;
            } else if (rbTypeTrain.Checked)
            {
                transportType = TRANSPORT_TYPE.TRAIN;
            }

            TransportCompany transportCompany = new TransportCompany(txtTransportCompanyName.Text, transportType);
        }
    }
}
