using Cp_Entidad;
using Cp_Logica_Negocio;
namespace C_Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        E_Agenda E_Datos = new E_Agenda();
        LN_Agenda LN_Agenda = new LN_Agenda();
    }
}