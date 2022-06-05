namespace Tracker
{
    public partial class Main : Form
    {
        private List<Panel> _panels;
        private List<Form> _childForms;
        
        public Main()
        {
            InitializeComponent();
            _panels = new List<Panel>()
            {
                trackerMenu,
                aboutMenu
            };
            _childForms = new List<Form>()
            {
                SetupChildForm(new Tracker()),
                SetupChildForm(new Jobs()),
            };
            HideMenus();
        }

        private Form SetupChildForm(Form form)
        {
            form.Dock = DockStyle.Fill;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.BringToFront();
            childDisplay.Controls.Add(form);
            return form;
        }

        private void HideMenus()
        {
            _panels.ForEach(panel => panel.Visible = false);
        }

        private void ToggleMenu(Panel menu)
        {
            if (menu.Visible)
            {
                menu.Visible = false;
            }
            else
            {
                HideMenus();
                menu.Visible = true;
            }
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void trackerMenuButton_Click(object sender, EventArgs e)
        {
            ToggleMenu(trackerMenu);
        }

        private void DisplayChild(Type childType)
        {
            var form = _childForms.Where(e => e.GetType() == childType).First();
            DisableOtherChildren(form);
            form.Show();
        }

        private void DisableOtherChildren(Form except)
        {
            _childForms
                .Where(child => child != except)
                .ToList()
                .ForEach(child => child.Hide());
        }

        private void aboutMenuButton_Click(object sender, EventArgs e)
        {
            ToggleMenu(aboutMenu);
        }

        private void workProcessButton_Click(object sender, EventArgs e)
        {
            DisplayChild(typeof(Tracker));
        }

        private void jobsButton_Click(object sender, EventArgs e)
        {
            DisplayChild(typeof(Jobs));
        }
    }
}