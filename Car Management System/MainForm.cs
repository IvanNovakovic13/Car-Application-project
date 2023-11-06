namespace Car_Management_System
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnDashboard.Height;
            panelSlide.Top = btnDashboard.Top;
        }

        private void btnZaposleni_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnZaposleni.Height;
            panelSlide.Top = btnZaposleni.Top;
        }
        private void btnKupci_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnKupci.Height;
            panelSlide.Top = btnKupci.Top;
        }

        private void btnServis_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnServis.Height;
            panelSlide.Top = btnServis.Top;
        }

        private void btnPlacanje_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnPlacanje.Height;
            panelSlide.Top = btnPlacanje.Top;
        }
        private void btnPrijava_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnPrijava.Height;
            panelSlide.Top = btnPrijava.Top;
        }
        private void btnPodesavanja_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnPodesavanja.Height;
            panelSlide.Top = btnPodesavanja.Top;
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            panelSlide.Height = btnLogout.Height;
            panelSlide.Top = btnLogout.Top;
        }
    }
}