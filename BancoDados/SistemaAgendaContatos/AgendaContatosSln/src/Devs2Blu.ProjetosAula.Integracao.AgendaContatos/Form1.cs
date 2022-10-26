using Devs2Blu.ProjetosAula.Integracao.AgendaContatos.Data;
using Devs2Blu.ProjetosAula.Integracao.AgendaContatos.Model.Enum;
using Devs2Blu.ProjetosAula.Integracao.AgendaContatos.Model.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Contracts;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Devs2Blu.ProjetosAula.Integracao.AgendaContatos
{
    public partial class Form1 : Form
    {
        public StatesRepository StatesRepository { get; set; }
        public ContactRepository ContactRepository { get; set; }
        public Contact Contact { get; set; }
        /*public AppointmentRepository AppointmentRepository { get; set; }
        public Appointment Appointment { get; set; }*/
        public Form1()
        {
            InitializeComponent();
        }

        #region Methods

        private void FillComboStates()
        {
            MySqlDataReader rdrStates = StatesRepository.GetAll();

            cbState.DataSource = new BindingSource(rdrStates, null);
            cbState.DisplayMember = "state";
            cbState.ValueMember = "state";
        }

        private void FillGridContacts()
        {
            MySqlDataReader rdrContacts = ContactRepository.GetAll();
            gridContacts.DataSource = new BindingSource(rdrContacts, null);
        }

        private bool ValidateForm()
        {
            if (txtName.Text.Equals(""))
            {
                MessageBox.Show("Favor informar um Nome!", "Validação de Campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return false;
            }
            if (cbState.SelectedIndex.Equals(-1))
            {
                MessageBox.Show("Favor informar um Estado!", "Validação de Campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cbState.Focus();
                return false;
            }
            return true;
        }

        private void SaveContact()
        {
            string columns, values;
            columns = "name, phone, email, street, number, district, city, state";
            values = $"'{Contact.Name}','{Contact.Phone}','{Contact.Email}','{Contact.Street}',{Contact.Number},'{Contact.District}','{Contact.City}','{Contact.State}'";

            try
            {
                int idInsert = ContactRepository.Insert(columns, values);
                if (idInsert > 0)
                {
                    MessageBox.Show($"Contato {idInsert} - {txtName.Text} salvo com sucesso!");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

      /*  private void AddAppointment()
        {
            string columns, values;
            columns = "id, contact, title, description, iniDate, finDate, status";
            values = $"'{Appointment.Id}','{Appointment.Contacts}','{Appointment.Title}','{Appointment.Description}',{Appointment.InitialDate},'{Appointment.FinalDate}','{Appointment.Status}'";

            try
            {
                int idInsert = AppointmentRepository.Insert(columns, values);
                if (idInsert > 0)
                {
                    MessageBox.Show($"Compromisso {idInsert} inserido com sucesso!");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }*/

        private void UpdateContact()
        {
            string columns;
            columns = $@"name = '{Contact.Name}', 
phone = '{Contact.Phone}',
email = '{Contact.Email}', 
street = '{Contact.Street}', 
number = {Contact.Number}, 
district = '{Contact.District}', 
city = '{Contact.City}', 
state = '{Contact.State}'";

            try
            {
                int idUpdate = ContactRepository.Update(columns, Contact.Id);
                if (idUpdate > 0)
                {
                    MessageBox.Show($"Contato {Contact.Id} - {Contact.Name} atualizado com sucesso!");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void FillClassContact()
        {
            Contact.Name = txtName.Text;
            Contact.Street = txtStreet.Text;
            Contact.Email = txtEmail.Text;
            Contact.Phone = mskPhone.Text;
            Contact.Number = Int32.Parse(txtNumber.Text);
            Contact.District = txtDistrict.Text;
            Contact.City = txtCity.Text;
            Contact.State = cbState.SelectedValue.ToString();
        }


        private void ClearFields()
        {
            txtName.Text = "";
            txtStreet.Text = "";
            txtEmail.Text = "";
            mskPhone.Text = "";
            txtNumber.Text = "";
            txtDistrict.Text = "";
            txtCity.Text = "";
            cbState.SelectedIndex = -1;
        }

        private void FillFieldsForm()
        {
            txtName.Text = Contact.Name;
            txtStreet.Text = Contact.Street;
            txtEmail.Text = Contact.Email;
            mskPhone.Text = Contact.Phone;
            txtNumber.Text = Contact.Number.ToString();
            txtDistrict.Text = Contact.District;
            txtCity.Text = Contact.City;
            cbState.SelectedValue = Contact.State;
        }

        /*private void FillClassAppoitments()
        {
            Appointment.Title = txtTitle.Text;
            Appointment.Description = txtDescription.Text;
            Appointment.InitialDate = dtpIniDate;
            Appointment.FinalDate = dtpFinDate;
            Appointment.Status = status;
        }*/
        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            StatesRepository = new StatesRepository();
            ContactRepository = new ContactRepository();
            FillComboStates();
            FillGridContacts();
            Contact = new Contact();
        }
        private void Form1_Activated(object sender, EventArgs e)
        {
            FillGridContacts();
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            
            if (ValidateForm())
            {
                FillClassContact();
                if (Contact.Id > 0)
                {
                    UpdateContact();
                }
                else
                {
                    SaveContact();
                }
                ClearFields();
            }
            FillGridContacts();
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void btChange_Click(object sender, EventArgs e)
        {

        }

        private void gridContacts_DoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int idContact = (int)gridContacts.Rows[e.RowIndex].Cells["id"].Value;
            Contact = ContactRepository.FindById(idContact);
            FillFieldsForm();
        }

    }
}
