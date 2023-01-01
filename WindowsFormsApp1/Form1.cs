using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.drugstoreDataSet1TableAdapters;
using WindowsFormsApp1.drugstoreDataSetTableAdapters;
using System.Threading;

namespace WindowsFormsApp1
{
    
    public partial class Doctor_Form : Form
    {
        bool sabte_daro = false;
        bool hazfe_daro = false;
        bool moshahede_gheimat = false;
        bool moshahede_nam = false;
        bool eslah_daro_gheimat=false;
        bool eslah_daro_tarighe=false;
        bool eslah_daro_name = false;
        bool eslah_shakhs_name = false;
        bool eslah_shakhs_familyname = false;
        bool eslah_shakhs_id = false;
        bool eslah_shakhs_mobile = false;
        bool moshahede_factor_personelId = false;
        bool moshahede_factor_name = false;
        bool moshahede_karmand_personelId = false;
        bool moshahede_karmand_famname = false;
        bool eslah_karmand_famname=false;
        bool eslah_karmand_id = false;
        bool eslah_karmand_mobile = false;
        bool sabte_karmand = false;
        bool sell_drug = false;



        public Doctor_Form()
        {
            InitializeComponent();
                
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'drugstoreDataSet.sell' table. You can move, or remove it, as needed.
            this.sellTableAdapter.Fill(this.drugstoreDataSet.sell);
            // TODO: This line of code loads data into the 'drugstoreDataSet.employe' table. You can move, or remove it, as needed.
            this.employeTableAdapter.Fill(this.drugstoreDataSet.employe);
            // TODO: This line of code loads data into the 'drugstoreDataSet.drug' table. You can move, or remove it, as needed.
            this.drugTableAdapter.Fill(this.drugstoreDataSet.drug);
           
        }

        private void unvisible_all()
        {
            moshahede_nam = false;
            button1.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox7.Visible = false;
            maskedTextBox1.Visible = false;
            dateTimePicker1.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            button1.Visible = false;
        }

        private void ثبتدارویجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unvisible_all();    
            button1.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            dateTimePicker1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label9.Visible = true;
            label1.Text = "نام دارو";
            label2.Text = "قیمت";
            label3.Text = "طریقه مصرف";
            label4.Text = "تعداد";
            label9.Text = "تاریخ انقضا";
            button1.Text = "Enter";
            sabte_daro=true;
            dataGridView1.Visible = true;
            dataGridView1.DataSource = drugBindingSource;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            






        }

        private void حذفداروToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unvisible_all();
            textBox1.Visible = true;
            label1.Visible = true;
            label1.Text = "نام دارو";
            button1.Visible = true;
            hazfe_daro = true;
            dataGridView1.Visible = true;
            dataGridView1.DataSource = drugBindingSource;



        }

        private void براساسنامداروToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            unvisible_all();
            dataGridView1.Visible= true;
            drugBindingSource.DataSource = drugTableAdapter.GetData();
            dataGridView1.DataSource = drugBindingSource;


            



        }

        private void براساسقیمتداروToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unvisible_all();
            moshahede_gheimat = true;
            textBox1.Visible = true;
            label1.Visible = true;
            label1.Text = "قیمت دارو";
            button1.Visible = true;


        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (sabte_daro == true)
            {
                if (textBox1.TextLength > 0 && textBox2.TextLength > 0 && textBox3.TextLength > 0 && textBox4.TextLength > 0)
                {
                    try
                    {
                        drugTableAdapter.Insert_Drug_Query(Decimal.Parse(textBox4.Text), textBox3.Text, dateTimePicker1.Value.Date, textBox1.Text, decimal.Parse(textBox2.Text));
                        drugTableAdapter.Fill(drugstoreDataSet.drug);
                        dataGridView1.DataSource = drugBindingSource;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }
            
            if (hazfe_daro == true)
            {
                if (textBox1.TextLength > 0)
                {
                    try
                    {
                        drugTableAdapter.Delete_Drug_Query(textBox1.Text);
                        drugTableAdapter.Fill(drugstoreDataSet.drug);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }

            if (moshahede_gheimat == true)
            {
                if (textBox1.TextLength > 0 )
                {
                    try
                    {
                        drugBindingSource.DataSource = drugTableAdapter.GetDataBycost(decimal.Parse(textBox1.Text));
                        dataGridView1.Visible = true;
                        dataGridView1.DataSource = drugBindingSource;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    

                }

            }

            if (eslah_daro_gheimat==true)
            {
                if (textBox1.TextLength > 0 && textBox2.TextLength > 0 && textBox3.TextLength > 0 && textBox4.TextLength > 0 && textBox5.TextLength>0)
                {
                    try
                    {
                        drugTableAdapter.Update_drug_cost_Query(decimal.Parse(textBox4.Text),textBox3.Text,dateTimePicker1.Value.Date,textBox1.Text,decimal.Parse(textBox5.Text),decimal.Parse( textBox2.Text));
                        drugTableAdapter.Fill(drugstoreDataSet.drug);
                        dataGridView1.DataSource = drugBindingSource;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }

            if (eslah_daro_tarighe == true)
            {
                if (textBox1.TextLength > 0 && textBox2.TextLength > 0 && textBox3.TextLength > 0 && textBox4.TextLength > 0 && textBox5.TextLength > 0)
                {
                    try
                    {
                        drugTableAdapter.Update_drug_howtouse_Query(decimal.Parse(textBox4.Text), textBox3.Text, dateTimePicker1.Value.Date, textBox1.Text, decimal.Parse(textBox5.Text), textBox2.Text);
                        drugTableAdapter.Fill(drugstoreDataSet.drug);
                        dataGridView1.DataSource = drugBindingSource;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }

            if (eslah_daro_name == true)
            {
                if (textBox1.TextLength > 0 && textBox2.TextLength > 0 && textBox3.TextLength > 0 && textBox4.TextLength > 0 && textBox5.TextLength > 0)
                {
                    try
                    {
                        drugTableAdapter.Update_drug_name_Query(decimal.Parse(textBox4.Text), textBox3.Text, dateTimePicker1.Value.Date, textBox1.Text, decimal.Parse(textBox5.Text), textBox2.Text);
                        drugTableAdapter.Fill(drugstoreDataSet.drug);
                        dataGridView1.DataSource = drugBindingSource;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                
            }

            if (eslah_shakhs_name==true)
            {
                
                if(textBox1.TextLength>0)
                {
                    
                    try
                    {
                        employeTableAdapter.Update_employe_name_Query(textBox1.Text, Application.OpenForms["login_form"].Controls["textBox2"].Text);
                        employeTableAdapter.Fill(drugstoreDataSet.employe);
                        dataGridView1.Visible = true;
                        dataGridView1.DataSource = employeBindingSource;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
                    
                
            }

            if (eslah_shakhs_familyname==true)
            {
                if (textBox1.TextLength > 0)
                {

                    try
                    {
                        employeTableAdapter.Update_employe_familynameQuery(textBox1.Text, Application.OpenForms["login_form"].Controls["textBox2"].Text);
                        employeTableAdapter.Fill(drugstoreDataSet.employe);
                        dataGridView1.Visible = true;
                        dataGridView1.DataSource = employeBindingSource;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }

            if (eslah_shakhs_id == true)
            {
                if (textBox1.TextLength > 0)
                {

                    try
                    {
                        employeTableAdapter.Update_employe_id_Query(textBox1.Text, Application.OpenForms["login_form"].Controls["textBox2"].Text);
                        employeTableAdapter.Fill(drugstoreDataSet.employe);
                        dataGridView1.Visible = true;
                        dataGridView1.DataSource = employeBindingSource;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }

            if (eslah_shakhs_mobile == true)
            {
                if (textBox1.TextLength > 0)
                {

                    try
                    {
                        employeTableAdapter.Update_employe_mobile_Query(textBox1.Text, Application.OpenForms["login_form"].Controls["textBox2"].Text);
                        employeTableAdapter.Fill(drugstoreDataSet.employe);
                        dataGridView1.Visible = true;
                        dataGridView1.DataSource = employeBindingSource;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }

            if (moshahede_factor_personelId == true)
            {
                if (textBox1.TextLength > 0)
                {
                    try
                    {
                        sellBindingSource.DataSource = sellTableAdapter.GetDataBy_pesonal_id(textBox1.Text);
                        dataGridView1.Visible = true;
                        dataGridView1.DataSource = sellBindingSource;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }

            }

            if (moshahede_factor_name ==true)
            {
                if (textBox1.TextLength > 0)
                {
                    try
                    {
                        sellBindingSource.DataSource = sellTableAdapter.GetDataBy_name(textBox1.Text);
                        dataGridView1.Visible = true;
                        dataGridView1.DataSource = sellBindingSource;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }

            if (moshahede_karmand_personelId==true)
            {
                if (textBox1.TextLength > 0)
                {
                    try
                    {
                        employeBindingSource.DataSource = employeTableAdapter.GetDataBy_karmand_personelid(textBox1.Text);
                        dataGridView1.Visible = true;
                        dataGridView1.DataSource = drugBindingSource;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }

            if (eslah_karmand_famname==true)
            {
                if (textBox1.TextLength > 0 && textBox2.TextLength >0)
                {
                    try
                    {
                        employeTableAdapter.Update_karmand_famname_Query(textBox2.Text,textBox1.Text);
                        employeTableAdapter.Fill(drugstoreDataSet.employe);
                        dataGridView1.DataSource = employeBindingSource;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (eslah_karmand_id == true)
            {
                if (textBox1.TextLength > 0 && textBox2.TextLength > 0)
                {
                    try
                    {
                        employeTableAdapter.Update_employe_id_Query(textBox2.Text, textBox1.Text);
                        employeTableAdapter.Fill(drugstoreDataSet.employe);
                        dataGridView1.DataSource = employeBindingSource;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }

            if (eslah_karmand_mobile == true)
            {
                if (textBox1.TextLength > 0)
                {

                    try
                    {
                        employeTableAdapter.Update_employe_mobile_Query(textBox2.Text,textBox1.Text );
                        employeTableAdapter.Fill(drugstoreDataSet.employe);
                        dataGridView1.Visible = true;
                        dataGridView1.DataSource = employeBindingSource;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
            }

            if (sabte_karmand == true)
            {
                if (textBox1.TextLength > 0 && textBox2.TextLength > 0 && textBox3.TextLength > 0 && textBox4.TextLength > 0 && textBox5.TextLength > 0 && textBox6.TextLength > 0 && textBox9.TextLength > 0 && textBox8.TextLength > 0 && maskedTextBox1.TextLength > 0)
                {
                    try
                    {
                        dataGridView1.Visible = true;
                        employeTableAdapter.Insert_karmand_Query(textBox2.Text,maskedTextBox1.Text,decimal.Parse(textBox8.Text),decimal.Parse(textBox5.Text),textBox6.Text,textBox1.Text,textBox3.Text,textBox4.Text,textBox9.Text);
                        employeTableAdapter.Fill(drugstoreDataSet.employe);
                        dataGridView1.DataSource = employeBindingSource;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }

            if (sell_drug == true)
            {
                
                if (textBox1.TextLength > 0 && textBox2.TextLength > 0 && textBox3.TextLength > 0 )
                {
                    try
                    {
                        sellTableAdapter.FillBy_id_pid(drugstoreDataSet.sell, Application.OpenForms["login_form"].Controls["textBox2"].Text, textBox1.Text);
                        if (drugstoreDataSet.sell.Rows.Count > 0)
                        {
                            drugTableAdapter.Update_inventory_mines_Query(decimal.Parse(textBox2.Text), textBox1.Text);
                            drugTableAdapter.Fill(drugstoreDataSet.drug);

                            sellTableAdapter.Update_sell_num_Query(decimal.Parse(textBox2.Text),decimal.Parse(textBox3.Text),textBox1.Text, Application.OpenForms["login_form"].Controls["textBox2"].Text);
                            sellTableAdapter.Fill(drugstoreDataSet.sell);
                            dataGridView1.Visible = true;
                            dataGridView1.DataSource = sellBindingSource;
                        }
                        else
                        {
                            drugTableAdapter.Update_inventory_mines_Query(decimal.Parse(textBox2.Text), textBox1.Text);
                            drugTableAdapter.Fill(drugstoreDataSet.drug);

                            sellTableAdapter.Insert_sell_Query(Application.OpenForms["login_form"].Controls["textBox2"].Text, textBox1.Text, DateTime.Now, decimal.Parse(textBox2.Text), decimal.Parse(textBox3.Text));
                            sellTableAdapter.Fill(drugstoreDataSet.sell);
                            dataGridView1.Visible = true;
                            dataGridView1.DataSource = sellBindingSource;
                        }
                        MessageBox.Show(" Drug Sold Successfully", "Succed", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    
                }

            }



            sabte_daro = false;
            hazfe_daro = false;
            moshahede_gheimat = false;
            moshahede_nam = false;
            eslah_daro_gheimat = false;
            eslah_daro_tarighe = false;
            eslah_shakhs_name = false;
            eslah_shakhs_familyname = false;
            eslah_shakhs_mobile = false;
            moshahede_factor_personelId = false;
            moshahede_factor_name = false;
            moshahede_karmand_personelId = false;
            moshahede_karmand_famname = false;
            eslah_karmand_id = false;
            eslah_karmand_mobile = false;
            sabte_karmand = false;
            sell_drug = false;



        }

        private void براساسنامداروToolStripMenuItem5_Click(object sender, EventArgs e)
        {
            unvisible_all();
            moshahede_nam = true;
            textBox1.Visible = true;
            label1.Visible = true;
            label1.Text = "نام دارو";
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (moshahede_nam == true)
            {
                if (textBox1.TextLength > 0)
                {
                    try
                    {
                        drugBindingSource.DataSource = drugTableAdapter.GetDataBy_name(textBox1.Text);
                        dataGridView1.Visible = true;
                        dataGridView1.DataSource = drugBindingSource;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }

            if (moshahede_karmand_famname == true)
            {
                if (textBox1.TextLength > 0)
                {
                    try
                    {
                        employeBindingSource.DataSource = employeTableAdapter.GetDataBy_karmand_famname(textBox1.Text);
                        dataGridView1.Visible = true;
                        dataGridView1.DataSource = employeBindingSource;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }


                }
            }


        }

        private void اصلاحقیمتToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unvisible_all();
            eslah_daro_gheimat = true;
            button1.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            dataGridView1.Visible = true;
            
            dateTimePicker1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label9.Visible = true;
            label1.Text = "نام دارو";
            label2.Text = "قیمت قدیم";
            label3.Text = "طریقه مصرف";
            label4.Text = "تعداد";
            label5.Text = "قیمت جدید";
            label9.Text = "تاریخ انقضا";
            button1.Text = "Enter";
            dataGridView1.DataSource = drugBindingSource;
        }

        private void اصلاحطریقهمصرفToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unvisible_all();
            eslah_daro_tarighe = true;
            button1.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            dataGridView1.Visible = true;

            dateTimePicker1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label9.Visible = true;
            label1.Text = "نام دارو";
            label2.Text = "طریقه مصرف قدیم";
            label3.Text = "طریقه مصرف جدید";
            label4.Text = "تعداد";
            label5.Text = "قیمت";
            label9.Text = "تاریخ انقضا";
            button1.Text = "Enter";
            dataGridView1.DataSource = drugBindingSource;
        }

        private void اصلاحToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unvisible_all();
            eslah_daro_name = true;
            button1.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            dataGridView1.Visible = true;

            dateTimePicker1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label9.Visible = true;
            label1.Text = "نام دارو جدید";
            label2.Text = "نام دارو قدیم";
            label3.Text = "طریقه مصرف";
            label4.Text = "تعداد";
            label5.Text = "قیمت";
            label9.Text = "تاریخ انقضا";
            button1.Text = "Enter";
            dataGridView1.DataSource = drugBindingSource;
        }

        private void اصلاحنامToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            unvisible_all();
            button1.Visible = true;
            textBox1.Visible = true;
            eslah_shakhs_name = true;
            label1.Visible = true;
            label1.Text = "نام جدید";

        }

        private void اصلاحنامخوانوادگیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unvisible_all();
            button1.Visible = true;
            textBox1.Visible = true;
            eslah_shakhs_familyname = true;
            label1.Visible = true;
            label1.Text = "نام خوانوادگی جدید";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void اصلاحکدملیToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            unvisible_all();
            button1.Visible = true;
            textBox1.Visible = true;
            eslah_shakhs_id = true;
            label1.Visible = true;
            label1.Text = "کد ملی جدید";
        }

        private void Doctor_Form_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 27)
            {
                this.Close();
            }
        }

        private void براساسنامداروToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            unvisible_all();
            
            dataGridView1.Visible = true;
            sellBindingSource.DataSource = sellTableAdapter.GetData();
            dataGridView1.DataSource = sellBindingSource;
        }

        private void اصلاحشمارهتماسToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            unvisible_all();
            button1.Visible = true;
            textBox1.Visible = true;
            eslah_shakhs_mobile = true;
            label1.Visible = true;
            label1.Text = "شماره تماس جدید";
        }

        private void براساسکدپرسنلیToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            unvisible_all();
            moshahede_factor_personelId = true;
            button1.Visible = true;
            textBox1.Visible = true;
            label1.Visible = true;
            label1.Text = "کد پرسنلی";
        }

        private void براساسنامداروToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            unvisible_all();
            moshahede_factor_name = true;
            button1.Visible = true;
            textBox1.Visible = true;
            label1.Visible = true;
            label1.Text = "نام دارو";
        }

        private void مشاهدهاطلاعاتتمامکارمندانToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unvisible_all();

            dataGridView1.Visible = true;
            employeBindingSource.DataSource = employeTableAdapter.GetData();
            dataGridView1.DataSource = employeBindingSource;
        }

        private void براساسکدپرسنلیToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            unvisible_all();
            moshahede_karmand_personelId = true;
            button1.Visible = true;
            textBox1.Visible = true;
            label1.Visible = true;
            label1.Text = "کد پرسنلی";
        }

        private void براساسنامخوانوادگیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unvisible_all();
            moshahede_karmand_famname = true;
            textBox1.Visible = true;
            label1.Visible = true;
            label1.Text = "نام";
        }

        private void اصلاحنامToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unvisible_all();
            eslah_karmand_famname = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label1.Text = "کد پرسنلی";
            label2.Text = "نام خوانوادگی جدید";
            dataGridView1.Visible = true;
            dataGridView1.DataSource = employeBindingSource;
            button1.Visible = true;
        }

        private void اصلاحکدملیToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unvisible_all();
            eslah_karmand_famname = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label1.Text = "کد پرسنلی";
            label2.Text = "کد ملی جدید";
            dataGridView1.Visible = true;
            dataGridView1.DataSource = employeBindingSource;
            button1.Visible = true;
        }

        private void اصلاحشمارهتماسToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unvisible_all();
            button1.Visible = true;
            textBox1.Visible = true;
            eslah_karmand_mobile = true;
            label1.Visible = true;
            label1.Text = "شماره تماس جدید";
        }

        private void ثیتکارمندجدیدToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unvisible_all();
            sabte_karmand = true;
            button1.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            
            textBox8.Visible = true;
            textBox9.Visible = true;
            maskedTextBox1.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label1.Text = "کد پرسنلی";
            label2.Text = "کد ملی";
            label3.Text = "نام";
            label4.Text = "نام خوانوادگی";
            label5.Text = "ساعت کاری";
            label6.Text = "ادرس";
            label7.Text = "موبایل";
            label8.Text = "حقوق";
            label9.Text = "سمت";

        }

        private void فروشداروToolStripMenuItem_Click(object sender, EventArgs e)
        {
            unvisible_all();
            sell_drug = true;
            button1.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label1.Text = "نام دارو";
            label2.Text = "تعداد";
            label3.Text = "قیمت کل";
        }
    }
}
