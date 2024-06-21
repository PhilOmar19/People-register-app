using System.Data;
using System.Windows.Forms;
using Cp_Entidad;
using Cp_Logica_Negocio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class P_Agenda : Form
    {
        public P_Agenda()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = true;
            ShowRecord();
        }
        E_Agenda E_datos = new E_Agenda();
        LN_Agenda LN_Agenda = new LN_Agenda();

        void ShowRecord()
        {
            DataTable dt = LN_Agenda.LN_ShowRecord();
            dataGridView1.DataSource = dt;
        }

        void DeleteRecord()
        {
            if (int.TryParse(textBox6.Text, out int id))
            {
                LN_Agenda Delete = new LN_Agenda();
                Delete.LN_DeleteRecord(id);
            }
        }
        void GetRecord()
        {
            if (int.TryParse(textBox6.Text, out int id))
            {
                DataTable dt = LN_Agenda.LN_GetRecord(id);
                dataGridView1.DataSource = dt;
            }
        }
        void AddRecord()
        {
            string Nombre = textBox5.Text;
            string Apellido = textBox4.Text;
            string Dirección = textBox3.Text;
            DateTime Fecha_nacimiento;
            string Celular = textBox2.Text;
            if (DateTime.TryParse(textBox1.Text, out Fecha_nacimiento))
            {
                LN_Agenda Add = new LN_Agenda();
                Add.LN_AddRecord(Nombre, Apellido, Dirección, Fecha_nacimiento, Celular);
            }
        }
        void UpdateRecord()
        {
            string Nombre = textBox5.Text;
            string Apellido = textBox4.Text;
            string Dirección = textBox3.Text;
            DateTime Fecha_nacimiento;
            string Celular = textBox2.Text;
            if (DateTime.TryParse(textBox1.Text, out Fecha_nacimiento))
            {
                if (int.TryParse(textBox6.Text, out int id))
                {
                    LN_Agenda Update = new LN_Agenda();
                    Update.LN_UpdateRecord(id, Nombre, Apellido, Dirección, Fecha_nacimiento, Celular);
                }

            }
        }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox6.Text) && int.TryParse(textBox6.Text, out int result))
            {
                button1.Enabled = true;
                button3.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                button3.Enabled = false;
            }

            if (textBox6.Text == "")
            {
                ShowRecord();
            }

            bool allFieldsFilled = new[] { textBox6, textBox5, textBox4, textBox3, textBox1, textBox2 }
            .All(textBox => !string.IsNullOrWhiteSpace(textBox.Text));

            button2.Enabled = allFieldsFilled;

        }


        private void button3_Click(object sender, EventArgs e)
        {
            DeleteRecord();
            ShowRecord();
            textBox6.Text = "";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            AddRecord();
            ShowRecord();
            textBox5.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetRecord();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UpdateRecord();
            GetRecord();
            textBox5.Text = "";
            textBox4.Text = "";
            textBox3.Text = "";
            textBox1.Text = "";
            textBox2.Text = "";
        }
    }
}