
using IFSPStore.app.Infra;
using IFSPStore.app.Register;
using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;

namespace IFSPStore.app
{
    public partial class MainForm : MaterialForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void categoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowForm<CategoryForm>();
        }

        private void ShowForm<TFormulario>() where TFormulario : Form
        {
            var cad= ConfigureDI.serviceProvider!.GetService<TFormulario>();
            if (cad!=null && !cad.IsDisposed)
            {
                cad.MdiParent = this;
                cad.Show();
            }
        }
    }
}
