namespace CadastroDeClientes.Views
{
    partial class FormPrincipal
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
            this.tbControl = new System.Windows.Forms.TabControl();
            this.tpCadastro = new System.Windows.Forms.TabPage();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.grpClientes = new System.Windows.Forms.GroupBox();
            this.lblCamposObrigatorios = new System.Windows.Forms.Label();
            this.txtCpf = new System.Windows.Forms.MaskedTextBox();
            this.btnDelTelefone = new System.Windows.Forms.Button();
            this.btnAddTelefone = new System.Windows.Forms.Button();
            this.txtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.txtRg = new System.Windows.Forms.TextBox();
            this.lblRg = new System.Windows.Forms.Label();
            this.cbAnoNascimento = new System.Windows.Forms.ComboBox();
            this.lblMesAno = new System.Windows.Forms.Label();
            this.cbMesNascimento = new System.Windows.Forms.ComboBox();
            this.lblDiaMes = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.cbDiaNascimento = new System.Windows.Forms.ComboBox();
            this.lblNomeCadastro = new System.Windows.Forms.Label();
            this.lbTelefones = new System.Windows.Forms.ListBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblCpfCadastro = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.tpListagem = new System.Windows.Forms.TabPage();
            this.grpEmpresa = new System.Windows.Forms.GroupBox();
            this.lblEnderecoEmpresa = new System.Windows.Forms.Label();
            this.txtEnderecoEmpresa = new System.Windows.Forms.TextBox();
            this.cbEmpresas = new System.Windows.Forms.ComboBox();
            this.lblEmpresa = new System.Windows.Forms.Label();
            this.gridListagem = new System.Windows.Forms.DataGridView();
            this.grpPesquisa = new System.Windows.Forms.GroupBox();
            this.txtNomePesquisa = new System.Windows.Forms.TextBox();
            this.lblNomePesquisa = new System.Windows.Forms.Label();
            this.lblCpfPesquisa = new System.Windows.Forms.Label();
            this.txtCpfPesquisa = new System.Windows.Forms.MaskedTextBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.tbControl.SuspendLayout();
            this.tpCadastro.SuspendLayout();
            this.grpClientes.SuspendLayout();
            this.tpListagem.SuspendLayout();
            this.grpEmpresa.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListagem)).BeginInit();
            this.grpPesquisa.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbControl
            // 
            this.tbControl.Controls.Add(this.tpCadastro);
            this.tbControl.Controls.Add(this.tpListagem);
            this.tbControl.Location = new System.Drawing.Point(3, 92);
            this.tbControl.Margin = new System.Windows.Forms.Padding(4);
            this.tbControl.Name = "tbControl";
            this.tbControl.SelectedIndex = 0;
            this.tbControl.Size = new System.Drawing.Size(624, 328);
            this.tbControl.TabIndex = 1;
            // 
            // tpCadastro
            // 
            this.tpCadastro.BackColor = System.Drawing.SystemColors.Control;
            this.tpCadastro.Controls.Add(this.btnCadastrar);
            this.tpCadastro.Controls.Add(this.grpClientes);
            this.tpCadastro.Location = new System.Drawing.Point(4, 25);
            this.tpCadastro.Margin = new System.Windows.Forms.Padding(4);
            this.tpCadastro.Name = "tpCadastro";
            this.tpCadastro.Padding = new System.Windows.Forms.Padding(4);
            this.tpCadastro.Size = new System.Drawing.Size(616, 299);
            this.tpCadastro.TabIndex = 0;
            this.tpCadastro.Text = "Cadastro";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCadastrar.Location = new System.Drawing.Point(4, 226);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(608, 69);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // grpClientes
            // 
            this.grpClientes.Controls.Add(this.lblCamposObrigatorios);
            this.grpClientes.Controls.Add(this.txtCpf);
            this.grpClientes.Controls.Add(this.btnDelTelefone);
            this.grpClientes.Controls.Add(this.btnAddTelefone);
            this.grpClientes.Controls.Add(this.txtTelefone);
            this.grpClientes.Controls.Add(this.txtRg);
            this.grpClientes.Controls.Add(this.lblRg);
            this.grpClientes.Controls.Add(this.cbAnoNascimento);
            this.grpClientes.Controls.Add(this.lblMesAno);
            this.grpClientes.Controls.Add(this.cbMesNascimento);
            this.grpClientes.Controls.Add(this.lblDiaMes);
            this.grpClientes.Controls.Add(this.lblDataNascimento);
            this.grpClientes.Controls.Add(this.cbDiaNascimento);
            this.grpClientes.Controls.Add(this.lblNomeCadastro);
            this.grpClientes.Controls.Add(this.lbTelefones);
            this.grpClientes.Controls.Add(this.txtNome);
            this.grpClientes.Controls.Add(this.lblCpfCadastro);
            this.grpClientes.Controls.Add(this.lblTelefone);
            this.grpClientes.Location = new System.Drawing.Point(7, 7);
            this.grpClientes.Name = "grpClientes";
            this.grpClientes.Size = new System.Drawing.Size(595, 209);
            this.grpClientes.TabIndex = 10;
            this.grpClientes.TabStop = false;
            this.grpClientes.Text = "Dados do Cliente";
            // 
            // lblCamposObrigatorios
            // 
            this.lblCamposObrigatorios.AutoSize = true;
            this.lblCamposObrigatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCamposObrigatorios.Location = new System.Drawing.Point(7, 191);
            this.lblCamposObrigatorios.Name = "lblCamposObrigatorios";
            this.lblCamposObrigatorios.Size = new System.Drawing.Size(109, 13);
            this.lblCamposObrigatorios.TabIndex = 19;
            this.lblCamposObrigatorios.Text = "* Campos obrigatórios";
            // 
            // txtCpf
            // 
            this.txtCpf.Location = new System.Drawing.Point(6, 105);
            this.txtCpf.Mask = "00000000000";
            this.txtCpf.Name = "txtCpf";
            this.txtCpf.Size = new System.Drawing.Size(169, 22);
            this.txtCpf.TabIndex = 18;
            // 
            // btnDelTelefone
            // 
            this.btnDelTelefone.Enabled = false;
            this.btnDelTelefone.Location = new System.Drawing.Point(564, 75);
            this.btnDelTelefone.Name = "btnDelTelefone";
            this.btnDelTelefone.Size = new System.Drawing.Size(22, 22);
            this.btnDelTelefone.TabIndex = 13;
            this.btnDelTelefone.Text = "-";
            this.btnDelTelefone.UseVisualStyleBackColor = true;
            this.btnDelTelefone.Click += new System.EventHandler(this.btnDelTelefone_Click);
            // 
            // btnAddTelefone
            // 
            this.btnAddTelefone.Location = new System.Drawing.Point(564, 47);
            this.btnAddTelefone.Name = "btnAddTelefone";
            this.btnAddTelefone.Size = new System.Drawing.Size(22, 22);
            this.btnAddTelefone.TabIndex = 12;
            this.btnAddTelefone.Text = "+";
            this.btnAddTelefone.UseVisualStyleBackColor = true;
            this.btnAddTelefone.Click += new System.EventHandler(this.btnAddTelefone_Click);
            // 
            // txtTelefone
            // 
            this.txtTelefone.Location = new System.Drawing.Point(422, 47);
            this.txtTelefone.Mask = "(00) 000000009";
            this.txtTelefone.Name = "txtTelefone";
            this.txtTelefone.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTelefone.Size = new System.Drawing.Size(136, 22);
            this.txtTelefone.TabIndex = 17;
            // 
            // txtRg
            // 
            this.txtRg.Location = new System.Drawing.Point(7, 162);
            this.txtRg.MaxLength = 13;
            this.txtRg.Name = "txtRg";
            this.txtRg.Size = new System.Drawing.Size(168, 22);
            this.txtRg.TabIndex = 16;
            // 
            // lblRg
            // 
            this.lblRg.AutoSize = true;
            this.lblRg.Location = new System.Drawing.Point(4, 143);
            this.lblRg.Name = "lblRg";
            this.lblRg.Size = new System.Drawing.Size(141, 16);
            this.lblRg.TabIndex = 15;
            this.lblRg.Text = "Rg (apenas números):";
            // 
            // cbAnoNascimento
            // 
            this.cbAnoNascimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbAnoNascimento.FormattingEnabled = true;
            this.cbAnoNascimento.Items.AddRange(new object[] {
            "2018",
            "2017",
            "2016",
            "2015",
            "2014",
            "2013",
            "2012",
            "2011",
            "2010",
            "2009",
            "2008",
            "2007",
            "2006",
            "2005",
            "2004",
            "2003",
            "2002",
            "2001",
            "2000",
            "1999",
            "1998",
            "1997",
            "1996",
            "1995",
            "1994",
            "1993",
            "1992",
            "1991",
            "1990",
            "1989",
            "1988",
            "1987",
            "1986",
            "1985",
            "1984",
            "1983",
            "1982",
            "1981",
            "1980",
            "1979",
            "1978",
            "1977",
            "1976",
            "1975",
            "1974",
            "1973",
            "1972",
            "1971",
            "1970",
            "1969",
            "1968",
            "1967",
            "1966",
            "1965",
            "1964",
            "1963",
            "1962",
            "1961",
            "1960",
            "1959",
            "1958",
            "1957",
            "1956",
            "1955",
            "1954",
            "1953",
            "1952",
            "1951",
            "1950",
            "1949",
            "1948",
            "1947",
            "1946",
            "1945",
            "1944",
            "1943",
            "1942",
            "1941",
            "1940",
            "1939",
            "1938",
            "1937",
            "1936",
            "1935",
            "1934",
            "1933",
            "1932",
            "1931",
            "1930",
            "1929",
            "1928",
            "1927",
            "1926",
            "1925",
            "1924",
            "1923",
            "1922",
            "1921",
            "1920",
            "1919",
            "1918",
            "1917",
            "1916",
            "1915",
            "1914",
            "1913",
            "1912",
            "1911",
            "1910",
            "1909",
            "1908",
            "1907",
            "1906",
            "1905",
            "1904",
            "1903",
            "1902",
            "1901",
            "1900"});
            this.cbAnoNascimento.Location = new System.Drawing.Point(331, 105);
            this.cbAnoNascimento.Name = "cbAnoNascimento";
            this.cbAnoNascimento.Size = new System.Drawing.Size(60, 24);
            this.cbAnoNascimento.TabIndex = 14;
            // 
            // lblMesAno
            // 
            this.lblMesAno.AutoSize = true;
            this.lblMesAno.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMesAno.Location = new System.Drawing.Point(313, 108);
            this.lblMesAno.Name = "lblMesAno";
            this.lblMesAno.Size = new System.Drawing.Size(12, 16);
            this.lblMesAno.TabIndex = 13;
            this.lblMesAno.Text = "/";
            // 
            // cbMesNascimento
            // 
            this.cbMesNascimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbMesNascimento.FormattingEnabled = true;
            this.cbMesNascimento.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12"});
            this.cbMesNascimento.Location = new System.Drawing.Point(268, 105);
            this.cbMesNascimento.Name = "cbMesNascimento";
            this.cbMesNascimento.Size = new System.Drawing.Size(39, 24);
            this.cbMesNascimento.TabIndex = 12;
            // 
            // lblDiaMes
            // 
            this.lblDiaMes.AutoSize = true;
            this.lblDiaMes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiaMes.Location = new System.Drawing.Point(250, 108);
            this.lblDiaMes.Name = "lblDiaMes";
            this.lblDiaMes.Size = new System.Drawing.Size(12, 16);
            this.lblDiaMes.TabIndex = 11;
            this.lblDiaMes.Text = "/";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Location = new System.Drawing.Point(202, 86);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(126, 16);
            this.lblDataNascimento.TabIndex = 10;
            this.lblDataNascimento.Text = "* Data Nascimento: ";
            // 
            // cbDiaNascimento
            // 
            this.cbDiaNascimento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDiaNascimento.FormattingEnabled = true;
            this.cbDiaNascimento.Items.AddRange(new object[] {
            "01",
            "02",
            "03",
            "04",
            "05",
            "06",
            "07",
            "08",
            "09",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
            this.cbDiaNascimento.Location = new System.Drawing.Point(205, 105);
            this.cbDiaNascimento.Name = "cbDiaNascimento";
            this.cbDiaNascimento.Size = new System.Drawing.Size(39, 24);
            this.cbDiaNascimento.TabIndex = 9;
            // 
            // lblNomeCadastro
            // 
            this.lblNomeCadastro.AutoSize = true;
            this.lblNomeCadastro.Location = new System.Drawing.Point(3, 27);
            this.lblNomeCadastro.Name = "lblNomeCadastro";
            this.lblNomeCadastro.Size = new System.Drawing.Size(59, 16);
            this.lblNomeCadastro.TabIndex = 2;
            this.lblNomeCadastro.Text = "* Nome: ";
            // 
            // lbTelefones
            // 
            this.lbTelefones.FormattingEnabled = true;
            this.lbTelefones.ItemHeight = 16;
            this.lbTelefones.Location = new System.Drawing.Point(422, 73);
            this.lbTelefones.Name = "lbTelefones";
            this.lbTelefones.Size = new System.Drawing.Size(136, 116);
            this.lbTelefones.TabIndex = 8;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(6, 47);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(385, 22);
            this.txtNome.TabIndex = 3;
            // 
            // lblCpfCadastro
            // 
            this.lblCpfCadastro.AutoSize = true;
            this.lblCpfCadastro.Location = new System.Drawing.Point(3, 86);
            this.lblCpfCadastro.Name = "lblCpfCadastro";
            this.lblCpfCadastro.Size = new System.Drawing.Size(160, 16);
            this.lblCpfCadastro.TabIndex = 4;
            this.lblCpfCadastro.Text = "* CPF (apenas números): ";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(419, 26);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(72, 16);
            this.lblTelefone.TabIndex = 6;
            this.lblTelefone.Text = "Telefones:";
            // 
            // tpListagem
            // 
            this.tpListagem.BackColor = System.Drawing.SystemColors.Control;
            this.tpListagem.Controls.Add(this.grpPesquisa);
            this.tpListagem.Controls.Add(this.gridListagem);
            this.tpListagem.Location = new System.Drawing.Point(4, 25);
            this.tpListagem.Margin = new System.Windows.Forms.Padding(4);
            this.tpListagem.Name = "tpListagem";
            this.tpListagem.Padding = new System.Windows.Forms.Padding(4);
            this.tpListagem.Size = new System.Drawing.Size(616, 299);
            this.tpListagem.TabIndex = 1;
            this.tpListagem.Text = "Listagem";
            // 
            // grpEmpresa
            // 
            this.grpEmpresa.Controls.Add(this.lblEnderecoEmpresa);
            this.grpEmpresa.Controls.Add(this.txtEnderecoEmpresa);
            this.grpEmpresa.Controls.Add(this.cbEmpresas);
            this.grpEmpresa.Controls.Add(this.lblEmpresa);
            this.grpEmpresa.Location = new System.Drawing.Point(3, 2);
            this.grpEmpresa.Name = "grpEmpresa";
            this.grpEmpresa.Size = new System.Drawing.Size(617, 90);
            this.grpEmpresa.TabIndex = 10;
            this.grpEmpresa.TabStop = false;
            this.grpEmpresa.Text = "Dados da Empresa";
            // 
            // lblEnderecoEmpresa
            // 
            this.lblEnderecoEmpresa.AutoSize = true;
            this.lblEnderecoEmpresa.Location = new System.Drawing.Point(202, 25);
            this.lblEnderecoEmpresa.Name = "lblEnderecoEmpresa";
            this.lblEnderecoEmpresa.Size = new System.Drawing.Size(73, 16);
            this.lblEnderecoEmpresa.TabIndex = 4;
            this.lblEnderecoEmpresa.Text = "Endereço: ";
            // 
            // txtEnderecoEmpresa
            // 
            this.txtEnderecoEmpresa.Location = new System.Drawing.Point(205, 44);
            this.txtEnderecoEmpresa.Name = "txtEnderecoEmpresa";
            this.txtEnderecoEmpresa.Size = new System.Drawing.Size(384, 22);
            this.txtEnderecoEmpresa.TabIndex = 5;
            // 
            // cbEmpresas
            // 
            this.cbEmpresas.DisplayMember = "Nome";
            this.cbEmpresas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbEmpresas.FormattingEnabled = true;
            this.cbEmpresas.Location = new System.Drawing.Point(7, 44);
            this.cbEmpresas.Margin = new System.Windows.Forms.Padding(4);
            this.cbEmpresas.Name = "cbEmpresas";
            this.cbEmpresas.Size = new System.Drawing.Size(168, 24);
            this.cbEmpresas.TabIndex = 0;
            this.cbEmpresas.SelectedIndexChanged += new System.EventHandler(this.cbEmpresas_SelectedIndexChanged);
            // 
            // lblEmpresa
            // 
            this.lblEmpresa.AutoSize = true;
            this.lblEmpresa.Location = new System.Drawing.Point(4, 24);
            this.lblEmpresa.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEmpresa.Name = "lblEmpresa";
            this.lblEmpresa.Size = new System.Drawing.Size(69, 16);
            this.lblEmpresa.TabIndex = 1;
            this.lblEmpresa.Text = "Empresa: ";
            // 
            // gridListagem
            // 
            this.gridListagem.AllowUserToAddRows = false;
            this.gridListagem.AllowUserToDeleteRows = false;
            this.gridListagem.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.gridListagem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListagem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridListagem.Location = new System.Drawing.Point(4, 62);
            this.gridListagem.Name = "gridListagem";
            this.gridListagem.RowHeadersVisible = false;
            this.gridListagem.Size = new System.Drawing.Size(608, 233);
            this.gridListagem.TabIndex = 0;
            // 
            // grpPesquisa
            // 
            this.grpPesquisa.Controls.Add(this.btnPesquisar);
            this.grpPesquisa.Controls.Add(this.txtCpfPesquisa);
            this.grpPesquisa.Controls.Add(this.lblCpfPesquisa);
            this.grpPesquisa.Controls.Add(this.lblNomePesquisa);
            this.grpPesquisa.Controls.Add(this.txtNomePesquisa);
            this.grpPesquisa.Location = new System.Drawing.Point(4, 3);
            this.grpPesquisa.Name = "grpPesquisa";
            this.grpPesquisa.Size = new System.Drawing.Size(601, 53);
            this.grpPesquisa.TabIndex = 1;
            this.grpPesquisa.TabStop = false;
            this.grpPesquisa.Text = "Dados Pesquisa";
            // 
            // txtNomePesquisa
            // 
            this.txtNomePesquisa.Location = new System.Drawing.Point(63, 21);
            this.txtNomePesquisa.Name = "txtNomePesquisa";
            this.txtNomePesquisa.Size = new System.Drawing.Size(256, 22);
            this.txtNomePesquisa.TabIndex = 0;
            // 
            // lblNomePesquisa
            // 
            this.lblNomePesquisa.AutoSize = true;
            this.lblNomePesquisa.Location = new System.Drawing.Point(6, 24);
            this.lblNomePesquisa.Name = "lblNomePesquisa";
            this.lblNomePesquisa.Size = new System.Drawing.Size(51, 16);
            this.lblNomePesquisa.TabIndex = 3;
            this.lblNomePesquisa.Text = "Nome: ";
            // 
            // lblCpfPesquisa
            // 
            this.lblCpfPesquisa.AutoSize = true;
            this.lblCpfPesquisa.Location = new System.Drawing.Point(340, 24);
            this.lblCpfPesquisa.Name = "lblCpfPesquisa";
            this.lblCpfPesquisa.Size = new System.Drawing.Size(34, 16);
            this.lblCpfPesquisa.TabIndex = 4;
            this.lblCpfPesquisa.Text = "Cpf: ";
            // 
            // txtCpfPesquisa
            // 
            this.txtCpfPesquisa.Location = new System.Drawing.Point(380, 21);
            this.txtCpfPesquisa.Mask = "00000000000";
            this.txtCpfPesquisa.Name = "txtCpfPesquisa";
            this.txtCpfPesquisa.Size = new System.Drawing.Size(92, 22);
            this.txtCpfPesquisa.TabIndex = 19;
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.Location = new System.Drawing.Point(503, 17);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(78, 30);
            this.btnPesquisar.TabIndex = 20;
            this.btnPesquisar.Text = "Pesquisar";
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 420);
            this.Controls.Add(this.grpEmpresa);
            this.Controls.Add(this.tbControl);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.Load += new System.EventHandler(this.FormPrincipal_Load);
            this.tbControl.ResumeLayout(false);
            this.tpCadastro.ResumeLayout(false);
            this.grpClientes.ResumeLayout(false);
            this.grpClientes.PerformLayout();
            this.tpListagem.ResumeLayout(false);
            this.grpEmpresa.ResumeLayout(false);
            this.grpEmpresa.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridListagem)).EndInit();
            this.grpPesquisa.ResumeLayout(false);
            this.grpPesquisa.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tbControl;
        private System.Windows.Forms.TabPage tpCadastro;
        private System.Windows.Forms.GroupBox grpClientes;
        private System.Windows.Forms.Label lblNomeCadastro;
        private System.Windows.Forms.ListBox lbTelefones;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblCpfCadastro;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.TabPage tpListagem;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.ComboBox cbDiaNascimento;
        private System.Windows.Forms.ComboBox cbAnoNascimento;
        private System.Windows.Forms.Label lblMesAno;
        private System.Windows.Forms.ComboBox cbMesNascimento;
        private System.Windows.Forms.Label lblDiaMes;
        private System.Windows.Forms.MaskedTextBox txtTelefone;
        private System.Windows.Forms.TextBox txtRg;
        private System.Windows.Forms.Label lblRg;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnDelTelefone;
        private System.Windows.Forms.Button btnAddTelefone;
        private System.Windows.Forms.MaskedTextBox txtCpf;
        private System.Windows.Forms.Label lblCamposObrigatorios;
        private System.Windows.Forms.GroupBox grpEmpresa;
        private System.Windows.Forms.Label lblEnderecoEmpresa;
        private System.Windows.Forms.TextBox txtEnderecoEmpresa;
        private System.Windows.Forms.ComboBox cbEmpresas;
        private System.Windows.Forms.Label lblEmpresa;
        private System.Windows.Forms.GroupBox grpPesquisa;
        private System.Windows.Forms.Label lblNomePesquisa;
        private System.Windows.Forms.TextBox txtNomePesquisa;
        private System.Windows.Forms.DataGridView gridListagem;
        private System.Windows.Forms.Button btnPesquisar;
        private System.Windows.Forms.MaskedTextBox txtCpfPesquisa;
        private System.Windows.Forms.Label lblCpfPesquisa;
    }
}

