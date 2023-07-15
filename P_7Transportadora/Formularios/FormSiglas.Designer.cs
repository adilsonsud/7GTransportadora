/*
 * Criado por SharpDevelop.
 * Usuário: adilson
 * Data: 2017-01-05
 * Hora: 16:06
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace P_7Transportadora.Formularios
{
	partial class FormSiglas
	{
		
		private System.ComponentModel.IContainer components = null;
		
		
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.tabControl1 = new DevComponents.DotNetBar.TabControl();
			this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
			this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
			this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
			this.bt_fechar = new DevComponents.DotNetBar.ButtonX();
			this.bt_salvar = new DevComponents.DotNetBar.ButtonX();
			this.bt_excluir = new DevComponents.DotNetBar.ButtonX();
			this.bt_Editar = new DevComponents.DotNetBar.ButtonX();
			this.bt_adicionar = new DevComponents.DotNetBar.ButtonX();
			this.panel2 = new System.Windows.Forms.Panel();
			this.gb_dados = new System.Windows.Forms.GroupBox();
			this.cb_uf = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.txt_cidade = new System.Windows.Forms.TextBox();
			this.txt_Idsigla = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_sigla = new System.Windows.Forms.TextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
			this.tab2 = new DevComponents.DotNetBar.TabItem(this.components);
			this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txt_localizar = new System.Windows.Forms.TextBox();
			this.dgv_siglas = new System.Windows.Forms.DataGridView();
			this.tab1 = new DevComponents.DotNetBar.TabItem(this.components);
			((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabControlPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
			this.superTabControl1.SuspendLayout();
			this.superTabControlPanel2.SuspendLayout();
			this.gb_dados.SuspendLayout();
			this.tabControlPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_siglas)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.tabControl1.CanReorderTabs = true;
			this.tabControl1.Controls.Add(this.tabControlPanel2);
			this.tabControl1.Controls.Add(this.tabControlPanel1);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.tabControl1.SelectedTabIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(1020, 536);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
			this.tabControl1.Tabs.Add(this.tab1);
			this.tabControl1.Tabs.Add(this.tab2);
			// 
			// tabControlPanel2
			// 
			this.tabControlPanel2.Controls.Add(this.superTabControl1);
			this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlPanel2.Location = new System.Drawing.Point(0, 26);
			this.tabControlPanel2.Name = "tabControlPanel2";
			this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
			this.tabControlPanel2.Size = new System.Drawing.Size(1020, 510);
			this.tabControlPanel2.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
			this.tabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
			this.tabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.tabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
			this.tabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
									| DevComponents.DotNetBar.eBorderSide.Bottom)));
			this.tabControlPanel2.Style.GradientAngle = 90;
			this.tabControlPanel2.TabIndex = 2;
			this.tabControlPanel2.TabItem = this.tab2;
			// 
			// superTabControl1
			// 
			// 
			// 
			// 
			// 
			// 
			// 
			this.superTabControl1.ControlBox.CloseBox.Name = "";
			// 
			// 
			// 
			this.superTabControl1.ControlBox.MenuBox.Name = "";
			this.superTabControl1.ControlBox.Name = "";
			this.superTabControl1.ControlBox.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
									this.superTabControl1.ControlBox.MenuBox,
									this.superTabControl1.ControlBox.CloseBox});
			this.superTabControl1.Controls.Add(this.superTabControlPanel2);
			this.superTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.superTabControl1.Location = new System.Drawing.Point(1, 1);
			this.superTabControl1.Name = "superTabControl1";
			this.superTabControl1.ReorderTabsEnabled = true;
			this.superTabControl1.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
			this.superTabControl1.SelectedTabIndex = 0;
			this.superTabControl1.Size = new System.Drawing.Size(1018, 508);
			this.superTabControl1.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.superTabControl1.TabIndex = 4;
			this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
									this.superTabItem1});
			this.superTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.OneNote2007;
			this.superTabControl1.Text = "superTabControl1";
			// 
			// superTabControlPanel2
			// 
			this.superTabControlPanel2.Controls.Add(this.bt_fechar);
			this.superTabControlPanel2.Controls.Add(this.bt_salvar);
			this.superTabControlPanel2.Controls.Add(this.bt_excluir);
			this.superTabControlPanel2.Controls.Add(this.bt_Editar);
			this.superTabControlPanel2.Controls.Add(this.bt_adicionar);
			this.superTabControlPanel2.Controls.Add(this.panel2);
			this.superTabControlPanel2.Controls.Add(this.gb_dados);
			this.superTabControlPanel2.Controls.Add(this.panel1);
			this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.superTabControlPanel2.Location = new System.Drawing.Point(0, 23);
			this.superTabControlPanel2.Name = "superTabControlPanel2";
			this.superTabControlPanel2.Size = new System.Drawing.Size(1018, 485);
			this.superTabControlPanel2.TabIndex = 1;
			this.superTabControlPanel2.TabItem = this.superTabItem1;
			// 
			// bt_fechar
			// 
			this.bt_fechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.bt_fechar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
			this.bt_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bt_fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_fechar.Location = new System.Drawing.Point(719, 204);
			this.bt_fechar.Name = "bt_fechar";
			this.bt_fechar.Size = new System.Drawing.Size(98, 33);
			this.bt_fechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bt_fechar.TabIndex = 44;
			this.bt_fechar.Text = "&Fechar";
			this.bt_fechar.TextColor = System.Drawing.Color.Yellow;
			this.bt_fechar.Click += new System.EventHandler(this.Bt_fecharClick);
			// 
			// bt_salvar
			// 
			this.bt_salvar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.bt_salvar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
			this.bt_salvar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bt_salvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_salvar.Location = new System.Drawing.Point(322, 204);
			this.bt_salvar.Name = "bt_salvar";
			this.bt_salvar.Size = new System.Drawing.Size(98, 33);
			this.bt_salvar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bt_salvar.TabIndex = 43;
			this.bt_salvar.Text = "&Salvar";
			this.bt_salvar.TextColor = System.Drawing.Color.White;
			this.bt_salvar.Visible = false;
			this.bt_salvar.Click += new System.EventHandler(this.Bt_salvarClick);
			this.bt_salvar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Bt_salvarKeyDown);
			// 
			// bt_excluir
			// 
			this.bt_excluir.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.bt_excluir.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
			this.bt_excluir.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bt_excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_excluir.Location = new System.Drawing.Point(218, 204);
			this.bt_excluir.Name = "bt_excluir";
			this.bt_excluir.Size = new System.Drawing.Size(98, 33);
			this.bt_excluir.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bt_excluir.TabIndex = 42;
			this.bt_excluir.Text = "E&xcluir";
			this.bt_excluir.TextColor = System.Drawing.Color.White;
			this.bt_excluir.Click += new System.EventHandler(this.Bt_excluirClick);
			// 
			// bt_Editar
			// 
			this.bt_Editar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.bt_Editar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
			this.bt_Editar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bt_Editar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_Editar.Location = new System.Drawing.Point(114, 204);
			this.bt_Editar.Name = "bt_Editar";
			this.bt_Editar.Size = new System.Drawing.Size(98, 33);
			this.bt_Editar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bt_Editar.TabIndex = 41;
			this.bt_Editar.Text = "&Editar";
			this.bt_Editar.TextColor = System.Drawing.Color.White;
			this.bt_Editar.Click += new System.EventHandler(this.Bt_EditarClick);
			// 
			// bt_adicionar
			// 
			this.bt_adicionar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.bt_adicionar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
			this.bt_adicionar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bt_adicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_adicionar.Location = new System.Drawing.Point(12, 204);
			this.bt_adicionar.Name = "bt_adicionar";
			this.bt_adicionar.Size = new System.Drawing.Size(98, 33);
			this.bt_adicionar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bt_adicionar.TabIndex = 40;
			this.bt_adicionar.Text = "&Adicionar";
			this.bt_adicionar.TextColor = System.Drawing.Color.White;
			this.bt_adicionar.Click += new System.EventHandler(this.Bt_adicionarClick);
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.RoyalBlue;
			this.panel2.Location = new System.Drawing.Point(13, 194);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(805, 3);
			this.panel2.TabIndex = 36;
			// 
			// gb_dados
			// 
			this.gb_dados.AutoSize = true;
			this.gb_dados.BackColor = System.Drawing.Color.Transparent;
			this.gb_dados.Controls.Add(this.cb_uf);
			this.gb_dados.Controls.Add(this.label2);
			this.gb_dados.Controls.Add(this.label1);
			this.gb_dados.Controls.Add(this.txt_cidade);
			this.gb_dados.Controls.Add(this.txt_Idsigla);
			this.gb_dados.Controls.Add(this.label3);
			this.gb_dados.Controls.Add(this.label4);
			this.gb_dados.Controls.Add(this.txt_sigla);
			this.gb_dados.Enabled = false;
			this.gb_dados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gb_dados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gb_dados.ForeColor = System.Drawing.Color.White;
			this.gb_dados.Location = new System.Drawing.Point(13, 25);
			this.gb_dados.Name = "gb_dados";
			this.gb_dados.Size = new System.Drawing.Size(804, 165);
			this.gb_dados.TabIndex = 36;
			this.gb_dados.TabStop = false;
			this.gb_dados.Text = "DADOS";
			// 
			// cb_uf
			// 
			this.cb_uf.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_uf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cb_uf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_uf.FormattingEnabled = true;
			this.cb_uf.Items.AddRange(new object[] {
									"",
									"AC",
									"AL",
									"AP",
									"AM",
									"BA",
									"CE",
									"DF",
									"ES",
									"GO",
									"MA",
									"MT",
									"MS",
									"MG",
									"PR",
									"PB",
									"PA",
									"PE",
									"PI",
									"RJ",
									"RN",
									"RS",
									"RO",
									"RR",
									"SC",
									"SE",
									"SP",
									"TO"});
			this.cb_uf.Location = new System.Drawing.Point(88, 125);
			this.cb_uf.Name = "cb_uf";
			this.cb_uf.Size = new System.Drawing.Size(292, 21);
			this.cb_uf.TabIndex = 16;
			this.cb_uf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Cb_ufKeyDown);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(62, 129);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(21, 13);
			this.label2.TabIndex = 13;
			this.label2.Text = "UF";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.Black;
			this.label1.Location = new System.Drawing.Point(37, 97);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(47, 13);
			this.label1.TabIndex = 12;
			this.label1.Text = "CIDADE";
			// 
			// txt_cidade
			// 
			this.txt_cidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_cidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_cidade.Location = new System.Drawing.Point(88, 93);
			this.txt_cidade.Name = "txt_cidade";
			this.txt_cidade.Size = new System.Drawing.Size(292, 20);
			this.txt_cidade.TabIndex = 11;
			this.txt_cidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_cidadeKeyDown);
			// 
			// txt_Idsigla
			// 
			this.txt_Idsigla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_Idsigla.Enabled = false;
			this.txt_Idsigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Idsigla.Location = new System.Drawing.Point(88, 19);
			this.txt_Idsigla.Name = "txt_Idsigla";
			this.txt_Idsigla.ReadOnly = true;
			this.txt_Idsigla.Size = new System.Drawing.Size(292, 20);
			this.txt_Idsigla.TabIndex = 8;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(32, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(52, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "ID SIGLA";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(46, 60);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "SIGLA";
			// 
			// txt_sigla
			// 
			this.txt_sigla.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_sigla.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_sigla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_sigla.Location = new System.Drawing.Point(88, 57);
			this.txt_sigla.Name = "txt_sigla";
			this.txt_sigla.Size = new System.Drawing.Size(292, 20);
			this.txt_sigla.TabIndex = 10;
			this.txt_sigla.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_siglaKeyDown);
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
			this.panel1.Location = new System.Drawing.Point(12, 15);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(805, 3);
			this.panel1.TabIndex = 35;
			// 
			// superTabItem1
			// 
			this.superTabItem1.AttachedControl = this.superTabControlPanel2;
			this.superTabItem1.GlobalItem = false;
			this.superTabItem1.Name = "superTabItem1";
			this.superTabItem1.Text = "SIGLAS";
			// 
			// tab2
			// 
			this.tab2.AttachedControl = this.tabControlPanel2;
			this.tab2.Name = "tab2";
			this.tab2.Text = "C A D A S T R O - F3";
			// 
			// tabControlPanel1
			// 
			this.tabControlPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.tabControlPanel1.Controls.Add(this.splitContainer1);
			this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlPanel1.Location = new System.Drawing.Point(0, 26);
			this.tabControlPanel1.Name = "tabControlPanel1";
			this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
			this.tabControlPanel1.Size = new System.Drawing.Size(1020, 510);
			this.tabControlPanel1.Style.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(179)))), ((int)(((byte)(231)))));
			this.tabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(237)))), ((int)(((byte)(254)))));
			this.tabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.tabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(97)))), ((int)(((byte)(156)))));
			this.tabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
									| DevComponents.DotNetBar.eBorderSide.Bottom)));
			this.tabControlPanel1.Style.GradientAngle = 90;
			this.tabControlPanel1.TabIndex = 1;
			this.tabControlPanel1.TabItem = this.tab1;
			// 
			// splitContainer1
			// 
			this.splitContainer1.BackColor = System.Drawing.Color.Transparent;
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(1, 1);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.groupBox1);
			this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.dgv_siglas);
			this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.splitContainer1.Size = new System.Drawing.Size(1018, 508);
			this.splitContainer1.SplitterDistance = 60;
			this.splitContainer1.SplitterWidth = 6;
			this.splitContainer1.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.txt_localizar);
			this.groupBox1.Location = new System.Drawing.Point(6, 7);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(572, 48);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "DIGITE A SIGLA";
			// 
			// txt_localizar
			// 
			this.txt_localizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_localizar.Location = new System.Drawing.Point(6, 19);
			this.txt_localizar.Name = "txt_localizar";
			this.txt_localizar.Size = new System.Drawing.Size(560, 22);
			this.txt_localizar.TabIndex = 0;
			this.txt_localizar.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_localizarKeyDown);
			// 
			// dgv_siglas
			// 
			this.dgv_siglas.AllowUserToAddRows = false;
			this.dgv_siglas.AllowUserToOrderColumns = true;
			this.dgv_siglas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgv_siglas.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_siglas.Location = new System.Drawing.Point(0, 0);
			this.dgv_siglas.MultiSelect = false;
			this.dgv_siglas.Name = "dgv_siglas";
			this.dgv_siglas.ReadOnly = true;
			this.dgv_siglas.RowHeadersVisible = false;
			this.dgv_siglas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_siglas.Size = new System.Drawing.Size(1018, 442);
			this.dgv_siglas.TabIndex = 1;
			this.dgv_siglas.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgv_siglasKeyDown);
			// 
			// tab1
			// 
			this.tab1.AttachedControl = this.tabControlPanel1;
			this.tab1.Name = "tab1";
			this.tab1.Text = "L O C A L I Z A R - F2   ";
			// 
			// FormSiglas
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(1020, 536);
			this.Controls.Add(this.tabControl1);
			this.KeyPreview = true;
			this.Name = "FormSiglas";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CADASTRO DE SIGLAS";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Shown += new System.EventHandler(this.FormSiglasShown);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormSiglasKeyDown);
			((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabControlPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
			this.superTabControl1.ResumeLayout(false);
			this.superTabControlPanel2.ResumeLayout(false);
			this.superTabControlPanel2.PerformLayout();
			this.gb_dados.ResumeLayout(false);
			this.gb_dados.PerformLayout();
			this.tabControlPanel1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_siglas)).EndInit();
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.ComboBox cb_uf;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_cidade;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private DevComponents.DotNetBar.ButtonX bt_adicionar;
		private DevComponents.DotNetBar.ButtonX bt_Editar;
		private DevComponents.DotNetBar.ButtonX bt_excluir;
		private DevComponents.DotNetBar.ButtonX bt_salvar;
		private DevComponents.DotNetBar.ButtonX bt_fechar;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.GroupBox gb_dados;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_Idsigla;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_sigla;
		private DevComponents.DotNetBar.SuperTabItem superTabItem1;
		private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
		private DevComponents.DotNetBar.SuperTabControl superTabControl1;
		private DevComponents.DotNetBar.TabItem tab2;
		private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
		private DevComponents.DotNetBar.TabItem tab1;
		private System.Windows.Forms.TextBox txt_localizar;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dgv_siglas;
		private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
		private DevComponents.DotNetBar.TabControl tabControl1;
		
	}
}
