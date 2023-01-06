namespace WindowsFormsApp1
{
    partial class Cashier_Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.sellBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drugstoreDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drugstoreDataSet = new WindowsFormsApp1.drugstoreDataSet();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.مشاهدهفاکتورهاToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.براساسنامداروToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.براساسنامداروToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.براساسنامداروToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.براساسنامداروToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.براساسنامداروToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.براساسقیمتداروToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.براساسنامداروToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.براساسکدپرسنلیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اصلاحقیمتToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اصلاحطریقهمصرفToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اصلاحToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ثبتدارویجدیدToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.حذفداروToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اصلاحاطلاعاتشخصیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اصلاحنامToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.اصلاحنامخوانوادگیToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.اصلاحکدملیToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.اصلاحشمارهتماسToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.فروشداروToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.drugBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.drugTableAdapter = new WindowsFormsApp1.drugstoreDataSetTableAdapters.drugTableAdapter();
            this.employeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeTableAdapter = new WindowsFormsApp1.drugstoreDataSetTableAdapters.employeTableAdapter();
            this.sellTableAdapter = new WindowsFormsApp1.drugstoreDataSetTableAdapters.sellTableAdapter();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pay = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugstoreDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugstoreDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingSource)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(886, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 44;
            this.button1.Text = "Enter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(771, 214);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 27);
            this.dateTimePicker1.TabIndex = 43;
            this.dateTimePicker1.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(1007, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 37;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(1007, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 20);
            this.label3.TabIndex = 36;
            this.label3.Text = "label3";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1007, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "label2";
            this.label2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(1007, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 34;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(871, 142);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 27);
            this.textBox4.TabIndex = 29;
            this.textBox4.Visible = false;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(871, 107);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 27);
            this.textBox3.TabIndex = 28;
            this.textBox3.Visible = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(871, 74);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 27);
            this.textBox2.TabIndex = 27;
            this.textBox2.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(871, 42);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 27);
            this.textBox1.TabIndex = 26;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(689, 371);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.Visible = false;
            // 
            // sellBindingSource
            // 
            this.sellBindingSource.DataMember = "sell";
            this.sellBindingSource.DataSource = this.drugstoreDataSetBindingSource;
            // 
            // drugstoreDataSetBindingSource
            // 
            this.drugstoreDataSetBindingSource.DataSource = this.drugstoreDataSet;
            this.drugstoreDataSetBindingSource.Position = 0;
            // 
            // drugstoreDataSet
            // 
            this.drugstoreDataSet.DataSetName = "drugstoreDataSet";
            this.drugstoreDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.مشاهدهفاکتورهاToolStripMenuItem,
            this.اصلاحاطلاعاتشخصیToolStripMenuItem,
            this.فروشداروToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1126, 33);
            this.menuStrip1.TabIndex = 24;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // مشاهدهفاکتورهاToolStripMenuItem
            // 
            this.مشاهدهفاکتورهاToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.براساسنامداروToolStripMenuItem,
            this.براساسنامداروToolStripMenuItem1,
            this.براساسکدپرسنلیToolStripMenuItem,
            this.ثبتدارویجدیدToolStripMenuItem,
            this.حذفداروToolStripMenuItem});
            this.مشاهدهفاکتورهاToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.مشاهدهفاکتورهاToolStripMenuItem.Name = "مشاهدهفاکتورهاToolStripMenuItem";
            this.مشاهدهفاکتورهاToolStripMenuItem.Size = new System.Drawing.Size(72, 29);
            this.مشاهدهفاکتورهاToolStripMenuItem.Text = "دارو ها";
            // 
            // براساسنامداروToolStripMenuItem
            // 
            this.براساسنامداروToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.براساسنامداروToolStripMenuItem2,
            this.براساسنامداروToolStripMenuItem4});
            this.براساسنامداروToolStripMenuItem.Name = "براساسنامداروToolStripMenuItem";
            this.براساسنامداروToolStripMenuItem.Size = new System.Drawing.Size(249, 28);
            this.براساسنامداروToolStripMenuItem.Text = "مشاهده فاکتور فروش";
            // 
            // براساسنامداروToolStripMenuItem2
            // 
            this.براساسنامداروToolStripMenuItem2.Name = "براساسنامداروToolStripMenuItem2";
            this.براساسنامداروToolStripMenuItem2.Size = new System.Drawing.Size(255, 28);
            this.براساسنامداروToolStripMenuItem2.Text = "مشاهده تمام فاکتور ها";
            this.براساسنامداروToolStripMenuItem2.Click += new System.EventHandler(this.براساسنامداروToolStripMenuItem2_Click);
            // 
            // براساسنامداروToolStripMenuItem4
            // 
            this.براساسنامداروToolStripMenuItem4.Name = "براساسنامداروToolStripMenuItem4";
            this.براساسنامداروToolStripMenuItem4.Size = new System.Drawing.Size(255, 28);
            this.براساسنامداروToolStripMenuItem4.Text = "بر اساس نام دارو";
            this.براساسنامداروToolStripMenuItem4.Click += new System.EventHandler(this.براساسنامداروToolStripMenuItem4_Click);
            // 
            // براساسنامداروToolStripMenuItem1
            // 
            this.براساسنامداروToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.براساسنامداروToolStripMenuItem3,
            this.براساسقیمتداروToolStripMenuItem,
            this.براساسنامداروToolStripMenuItem5});
            this.براساسنامداروToolStripMenuItem1.Name = "براساسنامداروToolStripMenuItem1";
            this.براساسنامداروToolStripMenuItem1.Size = new System.Drawing.Size(249, 28);
            this.براساسنامداروToolStripMenuItem1.Text = "مشاهده دارو";
            // 
            // براساسنامداروToolStripMenuItem3
            // 
            this.براساسنامداروToolStripMenuItem3.Name = "براساسنامداروToolStripMenuItem3";
            this.براساسنامداروToolStripMenuItem3.Size = new System.Drawing.Size(233, 28);
            this.براساسنامداروToolStripMenuItem3.Text = "تمام دارو ";
            this.براساسنامداروToolStripMenuItem3.Click += new System.EventHandler(this.براساسنامداروToolStripMenuItem3_Click);
            // 
            // براساسقیمتداروToolStripMenuItem
            // 
            this.براساسقیمتداروToolStripMenuItem.Name = "براساسقیمتداروToolStripMenuItem";
            this.براساسقیمتداروToolStripMenuItem.Size = new System.Drawing.Size(233, 28);
            this.براساسقیمتداروToolStripMenuItem.Text = "بر اساس قیمت دارو";
            this.براساسقیمتداروToolStripMenuItem.Click += new System.EventHandler(this.براساسقیمتداروToolStripMenuItem_Click);
            // 
            // براساسنامداروToolStripMenuItem5
            // 
            this.براساسنامداروToolStripMenuItem5.Name = "براساسنامداروToolStripMenuItem5";
            this.براساسنامداروToolStripMenuItem5.Size = new System.Drawing.Size(233, 28);
            this.براساسنامداروToolStripMenuItem5.Text = "بر اساس نام دارو";
            this.براساسنامداروToolStripMenuItem5.Click += new System.EventHandler(this.براساسنامداروToolStripMenuItem5_Click);
            // 
            // براساسکدپرسنلیToolStripMenuItem
            // 
            this.براساسکدپرسنلیToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اصلاحقیمتToolStripMenuItem,
            this.اصلاحطریقهمصرفToolStripMenuItem,
            this.اصلاحToolStripMenuItem});
            this.براساسکدپرسنلیToolStripMenuItem.Name = "براساسکدپرسنلیToolStripMenuItem";
            this.براساسکدپرسنلیToolStripMenuItem.Size = new System.Drawing.Size(249, 28);
            this.براساسکدپرسنلیToolStripMenuItem.Text = "اصلاح اطلاعات داروها";
            // 
            // اصلاحقیمتToolStripMenuItem
            // 
            this.اصلاحقیمتToolStripMenuItem.Name = "اصلاحقیمتToolStripMenuItem";
            this.اصلاحقیمتToolStripMenuItem.Size = new System.Drawing.Size(259, 28);
            this.اصلاحقیمتToolStripMenuItem.Text = "بر اساس قیمت";
            this.اصلاحقیمتToolStripMenuItem.Click += new System.EventHandler(this.اصلاحقیمتToolStripMenuItem_Click);
            // 
            // اصلاحطریقهمصرفToolStripMenuItem
            // 
            this.اصلاحطریقهمصرفToolStripMenuItem.Name = "اصلاحطریقهمصرفToolStripMenuItem";
            this.اصلاحطریقهمصرفToolStripMenuItem.Size = new System.Drawing.Size(259, 28);
            this.اصلاحطریقهمصرفToolStripMenuItem.Text = "بر اساس طریقه مصرف";
            this.اصلاحطریقهمصرفToolStripMenuItem.Click += new System.EventHandler(this.اصلاحطریقهمصرفToolStripMenuItem_Click);
            // 
            // اصلاحToolStripMenuItem
            // 
            this.اصلاحToolStripMenuItem.Name = "اصلاحToolStripMenuItem";
            this.اصلاحToolStripMenuItem.Size = new System.Drawing.Size(259, 28);
            this.اصلاحToolStripMenuItem.Text = "بر اساس  نام";
            this.اصلاحToolStripMenuItem.Click += new System.EventHandler(this.اصلاحToolStripMenuItem_Click);
            // 
            // ثبتدارویجدیدToolStripMenuItem
            // 
            this.ثبتدارویجدیدToolStripMenuItem.Name = "ثبتدارویجدیدToolStripMenuItem";
            this.ثبتدارویجدیدToolStripMenuItem.Size = new System.Drawing.Size(249, 28);
            this.ثبتدارویجدیدToolStripMenuItem.Text = "ثبت داروی جدید";
            this.ثبتدارویجدیدToolStripMenuItem.Click += new System.EventHandler(this.ثبتدارویجدیدToolStripMenuItem_Click);
            // 
            // حذفداروToolStripMenuItem
            // 
            this.حذفداروToolStripMenuItem.Name = "حذفداروToolStripMenuItem";
            this.حذفداروToolStripMenuItem.Size = new System.Drawing.Size(249, 28);
            this.حذفداروToolStripMenuItem.Text = "حذف دارو";
            this.حذفداروToolStripMenuItem.Click += new System.EventHandler(this.حذفداروToolStripMenuItem_Click);
            // 
            // اصلاحاطلاعاتشخصیToolStripMenuItem
            // 
            this.اصلاحاطلاعاتشخصیToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.اصلاحنامToolStripMenuItem1,
            this.اصلاحنامخوانوادگیToolStripMenuItem,
            this.اصلاحکدملیToolStripMenuItem1,
            this.اصلاحشمارهتماسToolStripMenuItem1});
            this.اصلاحاطلاعاتشخصیToolStripMenuItem.Name = "اصلاحاطلاعاتشخصیToolStripMenuItem";
            this.اصلاحاطلاعاتشخصیToolStripMenuItem.Size = new System.Drawing.Size(200, 29);
            this.اصلاحاطلاعاتشخصیToolStripMenuItem.Text = "اصلاح اطلاعات شخصی";
            // 
            // اصلاحنامToolStripMenuItem1
            // 
            this.اصلاحنامToolStripMenuItem1.Name = "اصلاحنامToolStripMenuItem1";
            this.اصلاحنامToolStripMenuItem1.Size = new System.Drawing.Size(253, 30);
            this.اصلاحنامToolStripMenuItem1.Text = "اصلاح نام";
            this.اصلاحنامToolStripMenuItem1.Click += new System.EventHandler(this.اصلاحنامToolStripMenuItem1_Click);
            // 
            // اصلاحنامخوانوادگیToolStripMenuItem
            // 
            this.اصلاحنامخوانوادگیToolStripMenuItem.Name = "اصلاحنامخوانوادگیToolStripMenuItem";
            this.اصلاحنامخوانوادگیToolStripMenuItem.Size = new System.Drawing.Size(253, 30);
            this.اصلاحنامخوانوادگیToolStripMenuItem.Text = "اصلاح نام خوانوادگی";
            this.اصلاحنامخوانوادگیToolStripMenuItem.Click += new System.EventHandler(this.اصلاحنامخوانوادگیToolStripMenuItem_Click);
            // 
            // اصلاحکدملیToolStripMenuItem1
            // 
            this.اصلاحکدملیToolStripMenuItem1.Name = "اصلاحکدملیToolStripMenuItem1";
            this.اصلاحکدملیToolStripMenuItem1.Size = new System.Drawing.Size(253, 30);
            this.اصلاحکدملیToolStripMenuItem1.Text = "اصلاح کد ملی";
            this.اصلاحکدملیToolStripMenuItem1.Click += new System.EventHandler(this.اصلاحکدملیToolStripMenuItem1_Click);
            // 
            // اصلاحشمارهتماسToolStripMenuItem1
            // 
            this.اصلاحشمارهتماسToolStripMenuItem1.Name = "اصلاحشمارهتماسToolStripMenuItem1";
            this.اصلاحشمارهتماسToolStripMenuItem1.Size = new System.Drawing.Size(253, 30);
            this.اصلاحشمارهتماسToolStripMenuItem1.Text = "اصلاح شماره تماس";
            this.اصلاحشمارهتماسToolStripMenuItem1.Click += new System.EventHandler(this.اصلاحشمارهتماسToolStripMenuItem1_Click);
            // 
            // فروشداروToolStripMenuItem
            // 
            this.فروشداروToolStripMenuItem.Name = "فروشداروToolStripMenuItem";
            this.فروشداروToolStripMenuItem.Size = new System.Drawing.Size(105, 29);
            this.فروشداروToolStripMenuItem.Text = "فروش دارو";
            this.فروشداروToolStripMenuItem.Click += new System.EventHandler(this.فروشداروToolStripMenuItem_Click);
            // 
            // drugBindingSource
            // 
            this.drugBindingSource.DataMember = "drug";
            this.drugBindingSource.DataSource = this.drugstoreDataSetBindingSource;
            // 
            // drugTableAdapter
            // 
            this.drugTableAdapter.ClearBeforeFill = true;
            // 
            // employeBindingSource
            // 
            this.employeBindingSource.DataMember = "employe";
            this.employeBindingSource.DataSource = this.drugstoreDataSetBindingSource;
            // 
            // employeTableAdapter
            // 
            this.employeTableAdapter.ClearBeforeFill = true;
            // 
            // sellTableAdapter
            // 
            this.sellTableAdapter.ClearBeforeFill = true;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(871, 177);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 27);
            this.textBox5.TabIndex = 30;
            this.textBox5.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1007, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 38;
            this.label5.Text = "label5";
            this.label5.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 371);
            this.panel1.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(1007, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "label6";
            this.label6.Visible = false;
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(871, 216);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 27);
            this.textBox6.TabIndex = 46;
            this.textBox6.Visible = false;
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // pay
            // 
            this.pay.DataPropertyName = "pay";
            this.pay.HeaderText = "pay";
            this.pay.MinimumWidth = 6;
            this.pay.Name = "pay";
            this.pay.ReadOnly = true;
            this.pay.Width = 125;
            // 
            // Cashier_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1126, 398);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Cashier_Form";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Casheir Form";
            this.Load += new System.EventHandler(this.Cashier_Form_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Cashier_Form_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sellBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugstoreDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drugstoreDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.drugBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeBindingSource)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem مشاهدهفاکتورهاToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem براساسنامداروToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem براساسنامداروToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem براساسنامداروToolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem براساسنامداروToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem براساسنامداروToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem براساسقیمتداروToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem براساسنامداروToolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem براساسکدپرسنلیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اصلاحقیمتToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اصلاحطریقهمصرفToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اصلاحToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ثبتدارویجدیدToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem حذفداروToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اصلاحاطلاعاتشخصیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اصلاحنامToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem اصلاحنامخوانوادگیToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem اصلاحکدملیToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem اصلاحشمارهتماسToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem فروشداروToolStripMenuItem;
        private System.Windows.Forms.BindingSource drugstoreDataSetBindingSource;
        private drugstoreDataSet drugstoreDataSet;
        private System.Windows.Forms.BindingSource drugBindingSource;
        private drugstoreDataSetTableAdapters.drugTableAdapter drugTableAdapter;
        private System.Windows.Forms.BindingSource employeBindingSource;
        private drugstoreDataSetTableAdapters.employeTableAdapter employeTableAdapter;
        private System.Windows.Forms.BindingSource sellBindingSource;
        private drugstoreDataSetTableAdapters.sellTableAdapter sellTableAdapter;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pay;
    }
}