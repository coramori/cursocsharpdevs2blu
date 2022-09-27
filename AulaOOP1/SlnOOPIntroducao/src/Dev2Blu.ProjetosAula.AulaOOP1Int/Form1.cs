using Devs2Blu.ProjetosAula.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dev2Blu.ProjetosAula.AulaOOP1Int
{
    public partial class Form1 : Form
    {
        public List<Recepcionista> RecepcionistsList { get; set; }
        public List<Diretor> DirectorsList { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RecepcionistsList = new List<Recepcionista>();
            DirectorsList = new List<Diretor>();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (rdDiretor.Checked)
            {
                SalvarDiretor();
            }
        }

        #region Metodos
        private void SalvarRecepcionista(Recepcionista recepcionista)
        {
            RecepcionistsList.Add(recepcionista);
        }

        private void SalvarDiretor(Diretor diretor)
        {
            DirectorsList.Add(diretor);
        }
        #endregion
    }
}
