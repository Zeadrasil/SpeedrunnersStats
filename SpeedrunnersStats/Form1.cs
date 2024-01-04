namespace SpeedrunnersStats
{
    public partial class Form1 : Form
    {
        Controller controller;
        List<Form> activeForms;
        public Form1()
        {
            InitializeComponent();
            controller = new Controller();
            activeForms = new List<Form>();
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            new SettingsPage(ref controller, ref activeForms).ShowDialog();
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            controller.onKill();
            base.OnFormClosing(e);
        }
    }
}