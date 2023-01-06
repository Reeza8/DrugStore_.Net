using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.drugstoreDataSet1TableAdapters;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class login_Form : Form
    {
        public bool doctor_succed_login = false;
        bool cashier_succed_login = false;
        
        Doctor_Form doc_form=new Doctor_Form();
        Cashier_Form cash_form=new Cashier_Form();
        
        int counter = 0;
        int counter2 = 0;
        public login_Form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            employeTableAdapter.FillBy(drugstoreDataSet.employe,textBox2.Text, textBox1.Text);
            if (drugstoreDataSet.employe.Rows.Count > 0)
            {


                if (doctor.Checked == true && dataGridView1.Rows[0].Cells[8].Value.ToString() == "دکتر")
                {
                    doctor_succed_login = true;
                    doc_form.ShowDialog();
                    this.Close();
                }
                else if (cashier.Checked == true && dataGridView1.Rows[0].Cells[8].Value.ToString() == "صندوقدار")
                {
                    cashier_succed_login = true;
                    cash_form.ShowDialog();
                    this.Close();
                }
                else
                {
                    this.employeTableAdapter.Fill(this.drugstoreDataSet.employe);
                    MessageBox.Show("Wrong Post", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            
            }
            else
            {
                MessageBox.Show("Invalid Username Or Password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.employeTableAdapter.Fill(this.drugstoreDataSet.employe);
            }
                

        }

        private void login_Form_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'drugstoreDataSet.employe' table. You can move, or remove it, as needed.
            this.employeTableAdapter.Fill(this.drugstoreDataSet.employe);

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Font = new Font(textBox2.Font.FontFamily, 16);
            textBox2.PasswordChar = '*';
        }

        private void login_Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
            else if (e.KeyChar == 10)
            {
                button1_Click(this, e);
            }
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (counter == 0)
                textBox2.Text = "";
            counter++;
            textBox2.Font = new Font(textBox2.Font.FontFamily, 16);
            textBox2.PasswordChar = '*';
        }

        private void textBox1_MouseClick(object sender, MouseEventArgs e)
        {
            if (counter2 == 0)
                textBox1.Text = "";
            counter2++;
            textBox2.Font = new Font(textBox2.Font.FontFamily, 16);
            textBox2.PasswordChar = '*';
        }
    }
}
