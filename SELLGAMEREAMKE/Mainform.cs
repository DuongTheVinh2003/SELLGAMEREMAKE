namespace SELLGAMEREAMKE
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private Form currentChildForm;

        private void OpenChildForm(Form childForm)
        {
            // Đóng form con hiện tại nếu có
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            panelChildForm.Controls.Clear();
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TrangChu());
        }

        private void btnThuVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new ThuVien());
        }

        private void btnCaNhan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new CaNhan());
        }

        private void btnTKeND_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TKeND());
        }

        private void btnTKeSP_Click(object sender, EventArgs e)
        {
            OpenChildForm(new TKeSP());
        }
    }
}
