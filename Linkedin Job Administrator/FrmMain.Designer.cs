namespace Linkedin_Job_Administrator
{
    partial class FrmMain
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.btCheck = new System.Windows.Forms.Button();
            this._dataTable = new System.Windows.Forms.DataGridView();
            this.udMaxCheck = new System.Windows.Forms.NumericUpDown();
            this.lbMax = new System.Windows.Forms.Label();
            this.btSearch = new System.Windows.Forms.Button();
            this.tbNombreEmpresa = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbNombrePuesto = new System.Windows.Forms.TextBox();
            this.cbEstadoPuesto = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeGmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToTXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importTXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stadistics = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tpBefore = new System.Windows.Forms.DateTimePicker();
            this.tpAfter = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this._dataTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMaxCheck)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btCheck
            // 
            this.btCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(118)))), ((int)(((byte)(168)))));
            this.btCheck.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btCheck.FlatAppearance.BorderSize = 0;
            this.btCheck.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(89)))), ((int)(((byte)(102)))));
            this.btCheck.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(134)))), ((int)(((byte)(151)))));
            this.btCheck.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCheck.Location = new System.Drawing.Point(578, 12);
            this.btCheck.Name = "btCheck";
            this.btCheck.Size = new System.Drawing.Size(117, 47);
            this.btCheck.TabIndex = 0;
            this.btCheck.Text = "Check Mail";
            this.btCheck.UseVisualStyleBackColor = false;
            this.btCheck.Click += new System.EventHandler(this.ObtenerCorreosButton_Click);
            // 
            // _dataTable
            // 
            this._dataTable.AllowUserToAddRows = false;
            this._dataTable.AllowUserToDeleteRows = false;
            this._dataTable.AllowUserToOrderColumns = true;
            this._dataTable.AllowUserToResizeRows = false;
            this._dataTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._dataTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dataTable.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(133)))), ((int)(((byte)(187)))));
            this._dataTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this._dataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(189)))), ((int)(((byte)(236)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this._dataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this._dataTable.ColumnHeadersHeight = 40;
            this._dataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this._dataTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this._dataTable.EnableHeadersVisualStyles = false;
            this._dataTable.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(231)))), ((int)(((byte)(249)))));
            this._dataTable.Location = new System.Drawing.Point(12, 103);
            this._dataTable.Name = "_dataTable";
            this._dataTable.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this._dataTable.RowHeadersVisible = false;
            this._dataTable.RowHeadersWidth = 80;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._dataTable.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this._dataTable.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(190)))), ((int)(((byte)(231)))), ((int)(((byte)(249)))));
            this._dataTable.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this._dataTable.RowTemplate.Height = 24;
            this._dataTable.ShowCellErrors = false;
            this._dataTable.ShowRowErrors = false;
            this._dataTable.Size = new System.Drawing.Size(1490, 584);
            this._dataTable.TabIndex = 1;
            // 
            // udMaxCheck
            // 
            this.udMaxCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.udMaxCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(133)))), ((int)(((byte)(187)))));
            this.udMaxCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.udMaxCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.udMaxCheck.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.udMaxCheck.Location = new System.Drawing.Point(6, 32);
            this.udMaxCheck.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.udMaxCheck.Name = "udMaxCheck";
            this.udMaxCheck.Size = new System.Drawing.Size(125, 27);
            this.udMaxCheck.TabIndex = 3;
            this.udMaxCheck.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // lbMax
            // 
            this.lbMax.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lbMax.AutoSize = true;
            this.lbMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMax.Location = new System.Drawing.Point(5, 9);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(128, 20);
            this.lbMax.TabIndex = 4;
            this.lbMax.Text = "Max Mail Check";
            // 
            // btSearch
            // 
            this.btSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(118)))), ((int)(((byte)(168)))));
            this.btSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btSearch.FlatAppearance.BorderSize = 0;
            this.btSearch.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(89)))), ((int)(((byte)(102)))));
            this.btSearch.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(134)))), ((int)(((byte)(151)))));
            this.btSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.Location = new System.Drawing.Point(645, 12);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(119, 46);
            this.btSearch.TabIndex = 6;
            this.btSearch.Text = "Search";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // tbNombreEmpresa
            // 
            this.tbNombreEmpresa.Location = new System.Drawing.Point(6, 37);
            this.tbNombreEmpresa.Name = "tbNombreEmpresa";
            this.tbNombreEmpresa.Size = new System.Drawing.Size(185, 22);
            this.tbNombreEmpresa.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name Busines";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(221, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Name Job";
            // 
            // tbNombrePuesto
            // 
            this.tbNombrePuesto.Location = new System.Drawing.Point(225, 37);
            this.tbNombrePuesto.Name = "tbNombrePuesto";
            this.tbNombrePuesto.Size = new System.Drawing.Size(185, 22);
            this.tbNombrePuesto.TabIndex = 8;
            // 
            // cbEstadoPuesto
            // 
            this.cbEstadoPuesto.FormattingEnabled = true;
            this.cbEstadoPuesto.Items.AddRange(new object[] {
            "Inscrito",
            "Rechazado",
            "Leido"});
            this.cbEstadoPuesto.Location = new System.Drawing.Point(438, 35);
            this.cbEstadoPuesto.Name = "cbEstadoPuesto";
            this.cbEstadoPuesto.Size = new System.Drawing.Size(150, 24);
            this.cbEstadoPuesto.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(434, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Job State";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.importToolStripMenuItem,
            this.stadistics});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1514, 30);
            this.menuStrip1.TabIndex = 7;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeGmailToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.archivoToolStripMenuItem.Text = "File";
            // 
            // changeGmailToolStripMenuItem
            // 
            this.changeGmailToolStripMenuItem.Name = "changeGmailToolStripMenuItem";
            this.changeGmailToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.changeGmailToolStripMenuItem.Text = "Change Gmail";
            this.changeGmailToolStripMenuItem.Click += new System.EventHandler(this.ResetGmailChecking);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToXMLToolStripMenuItem,
            this.exportToTXTToolStripMenuItem,
            this.exportToCSVToolStripMenuItem,
            this.exportToJSONToolStripMenuItem});
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(66, 26);
            this.exportToolStripMenuItem.Text = "Export";
            // 
            // exportToXMLToolStripMenuItem
            // 
            this.exportToXMLToolStripMenuItem.Name = "exportToXMLToolStripMenuItem";
            this.exportToXMLToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exportToXMLToolStripMenuItem.Text = "Export to XML";
            this.exportToXMLToolStripMenuItem.Click += new System.EventHandler(this.btXML_Click);
            // 
            // exportToTXTToolStripMenuItem
            // 
            this.exportToTXTToolStripMenuItem.Name = "exportToTXTToolStripMenuItem";
            this.exportToTXTToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exportToTXTToolStripMenuItem.Text = "Export to TXT";
            this.exportToTXTToolStripMenuItem.Click += new System.EventHandler(this.btTXT_Click);
            // 
            // exportToCSVToolStripMenuItem
            // 
            this.exportToCSVToolStripMenuItem.Name = "exportToCSVToolStripMenuItem";
            this.exportToCSVToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exportToCSVToolStripMenuItem.Text = "Export to CSV";
            this.exportToCSVToolStripMenuItem.Click += new System.EventHandler(this.btCSV_Click);
            // 
            // exportToJSONToolStripMenuItem
            // 
            this.exportToJSONToolStripMenuItem.Name = "exportToJSONToolStripMenuItem";
            this.exportToJSONToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exportToJSONToolStripMenuItem.Text = "Export to JSON";
            this.exportToJSONToolStripMenuItem.Click += new System.EventHandler(this.btJSON_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importXMLToolStripMenuItem,
            this.importTXTToolStripMenuItem,
            this.importCSVToolStripMenuItem,
            this.importJSONToolStripMenuItem});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(68, 26);
            this.importToolStripMenuItem.Text = "Import";
            // 
            // importXMLToolStripMenuItem
            // 
            this.importXMLToolStripMenuItem.Name = "importXMLToolStripMenuItem";
            this.importXMLToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.importXMLToolStripMenuItem.Text = "Import XML";
            this.importXMLToolStripMenuItem.Click += new System.EventHandler(this.ImportXML_Click);
            // 
            // importTXTToolStripMenuItem
            // 
            this.importTXTToolStripMenuItem.Name = "importTXTToolStripMenuItem";
            this.importTXTToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.importTXTToolStripMenuItem.Text = "Import TXT";
            this.importTXTToolStripMenuItem.Click += new System.EventHandler(this.ImportTXT_Click);
            // 
            // importCSVToolStripMenuItem
            // 
            this.importCSVToolStripMenuItem.Name = "importCSVToolStripMenuItem";
            this.importCSVToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.importCSVToolStripMenuItem.Text = "Import CSV";
            this.importCSVToolStripMenuItem.Click += new System.EventHandler(this.ImportCSV_Click);
            // 
            // importJSONToolStripMenuItem
            // 
            this.importJSONToolStripMenuItem.Name = "importJSONToolStripMenuItem";
            this.importJSONToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.importJSONToolStripMenuItem.Text = "Import JSON";
            this.importJSONToolStripMenuItem.Click += new System.EventHandler(this.ImportJSON_Click);
            // 
            // stadistics
            // 
            this.stadistics.Name = "stadistics";
            this.stadistics.Size = new System.Drawing.Size(85, 26);
            this.stadistics.Text = "Stadistics";
            this.stadistics.Click += new System.EventHandler(this.stadistics_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tpBefore);
            this.groupBox1.Controls.Add(this.btCheck);
            this.groupBox1.Controls.Add(this.tpAfter);
            this.groupBox1.Controls.Add(this.lbMax);
            this.groupBox1.Controls.Add(this.udMaxCheck);
            this.groupBox1.Location = new System.Drawing.Point(16, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(701, 66);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(229, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(122, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "-- Time Limit --";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(369, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Before";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(158, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "After";
            // 
            // tpBefore
            // 
            this.tpBefore.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tpBefore.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpBefore.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tpBefore.Location = new System.Drawing.Point(373, 32);
            this.tpBefore.Name = "tpBefore";
            this.tpBefore.Size = new System.Drawing.Size(140, 27);
            this.tpBefore.TabIndex = 10;
            this.tpBefore.Value = new System.DateTime(2024, 3, 14, 0, 0, 0, 0);
            // 
            // tpAfter
            // 
            this.tpAfter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tpAfter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tpAfter.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.tpAfter.Location = new System.Drawing.Point(162, 32);
            this.tpAfter.Name = "tpAfter";
            this.tpAfter.Size = new System.Drawing.Size(140, 27);
            this.tpAfter.TabIndex = 9;
            this.tpAfter.Value = new System.DateTime(2024, 1, 1, 0, 0, 0, 0);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.btSearch);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.tbNombrePuesto);
            this.groupBox2.Controls.Add(this.cbEstadoPuesto);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbNombreEmpresa);
            this.groupBox2.Location = new System.Drawing.Point(723, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(776, 66);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(16, 651);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(1483, 31);
            this.progressBar.TabIndex = 10;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(48)))), ((int)(((byte)(69)))));
            this.ClientSize = new System.Drawing.Size(1514, 694);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this._dataTable);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            ((System.ComponentModel.ISupportInitialize)(this._dataTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.udMaxCheck)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btCheck;
        private System.Windows.Forms.DataGridView _dataTable;
        private System.Windows.Forms.NumericUpDown udMaxCheck;
        private System.Windows.Forms.Label lbMax;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.TextBox tbNombreEmpresa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbNombrePuesto;
        private System.Windows.Forms.ComboBox cbEstadoPuesto;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToTXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker tpAfter;
        private System.Windows.Forms.DateTimePicker tpBefore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStripMenuItem importXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importTXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stadistics;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ToolStripMenuItem exportToCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importCSVToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeGmailToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportToJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importJSONToolStripMenuItem;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}

