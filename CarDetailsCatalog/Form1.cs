using System.Windows.Forms;

namespace CarDetailsCatalog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            using (var context = new AppDbContext())
            {
                context.Database.CreateIfNotExists();
            }
        }
    }
}