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
	partial class FormClientes
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormClientes));
			this.tabControl1 = new DevComponents.DotNetBar.TabControl();
			this.tabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.txt_localizar = new System.Windows.Forms.TextBox();
			this.dgv_clientes = new System.Windows.Forms.DataGridView();
			this.tab1 = new DevComponents.DotNetBar.TabItem(this.components);
			this.tabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
			this.superTabControl1 = new DevComponents.DotNetBar.SuperTabControl();
			this.superTabControlPanel2 = new DevComponents.DotNetBar.SuperTabControlPanel();
			this.pnl_cidade = new DevComponents.DotNetBar.PanelEx();
			this.dgv_cidade = new System.Windows.Forms.DataGridView();
			this.txt_LocalizaCidade = new DevComponents.DotNetBar.Controls.TextBoxX();
			this.bt_fechar = new DevComponents.DotNetBar.ButtonX();
			this.bt_salvar = new DevComponents.DotNetBar.ButtonX();
			this.bt_excluir = new DevComponents.DotNetBar.ButtonX();
			this.bt_Editar = new DevComponents.DotNetBar.ButtonX();
			this.bt_adicionar = new DevComponents.DotNetBar.ButtonX();
			this.panel2 = new System.Windows.Forms.Panel();
			this.gb_contatos = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.txt_fone1 = new System.Windows.Forms.MaskedTextBox();
			this.txt_fone2 = new System.Windows.Forms.MaskedTextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.txt_site = new System.Windows.Forms.TextBox();
			this.txt_fone3 = new System.Windows.Forms.MaskedTextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.txt_email = new System.Windows.Forms.TextBox();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.label13 = new System.Windows.Forms.Label();
			this.txt_fone4 = new System.Windows.Forms.MaskedTextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.gb_dados = new System.Windows.Forms.GroupBox();
			this.txt_cnpj = new System.Windows.Forms.MaskedTextBox();
			this.txt_cpf = new System.Windows.Forms.MaskedTextBox();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.rbt_Pfisica = new System.Windows.Forms.RadioButton();
			this.rbt_Pjuridica = new System.Windows.Forms.RadioButton();
			this.lbl_cpfcnpj = new System.Windows.Forms.Label();
			this.txt_NomeCliente = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.gb_endereco = new System.Windows.Forms.GroupBox();
			this.txt_uf = new System.Windows.Forms.TextBox();
			this.txt_endereco = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.txt_complemento = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txt_bairro = new System.Windows.Forms.TextBox();
			this.txt_cidade = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.txt_cep = new System.Windows.Forms.MaskedTextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.superTabItem1 = new DevComponents.DotNetBar.SuperTabItem();
			this.tab2 = new DevComponents.DotNetBar.TabItem(this.components);
			((System.ComponentModel.ISupportInitialize)(this.tabControl1)).BeginInit();
			this.tabControl1.SuspendLayout();
			this.tabControlPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).BeginInit();
			this.tabControlPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).BeginInit();
			this.superTabControl1.SuspendLayout();
			this.superTabControlPanel2.SuspendLayout();
			this.pnl_cidade.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_cidade)).BeginInit();
			this.gb_contatos.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.gb_dados.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.gb_endereco.SuspendLayout();
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
			this.tabControl1.Size = new System.Drawing.Size(959, 536);
			this.tabControl1.TabIndex = 0;
			this.tabControl1.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
			this.tabControl1.Tabs.Add(this.tab1);
			this.tabControl1.Tabs.Add(this.tab2);
			// 
			// tabControlPanel1
			// 
			this.tabControlPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.tabControlPanel1.Controls.Add(this.splitContainer1);
			this.tabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlPanel1.Location = new System.Drawing.Point(0, 26);
			this.tabControlPanel1.Name = "tabControlPanel1";
			this.tabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
			this.tabControlPanel1.Size = new System.Drawing.Size(959, 510);
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
			this.splitContainer1.Panel2.Controls.Add(this.dgv_clientes);
			this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.splitContainer1.Size = new System.Drawing.Size(957, 508);
			this.splitContainer1.SplitterDistance = 60;
			this.splitContainer1.SplitterWidth = 6;
			this.splitContainer1.TabIndex = 3;
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Transparent;
			this.groupBox1.Controls.Add(this.txt_localizar);
			this.groupBox1.Location = new System.Drawing.Point(3, 3);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(572, 48);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "DIGITE O NOME DO CLIENTE";
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
			// dgv_clientes
			// 
			this.dgv_clientes.AllowUserToAddRows = false;
			this.dgv_clientes.AllowUserToOrderColumns = true;
			this.dgv_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgv_clientes.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_clientes.Location = new System.Drawing.Point(0, 0);
			this.dgv_clientes.MultiSelect = false;
			this.dgv_clientes.Name = "dgv_clientes";
			this.dgv_clientes.ReadOnly = true;
			this.dgv_clientes.RowHeadersVisible = false;
			this.dgv_clientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_clientes.Size = new System.Drawing.Size(957, 442);
			this.dgv_clientes.TabIndex = 1;
			this.dgv_clientes.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgv_clientesKeyDown);
			// 
			// tab1
			// 
			this.tab1.AttachedControl = this.tabControlPanel1;
			this.tab1.Name = "tab1";
			this.tab1.Text = "L O C A L I Z A R - F2   ";
			// 
			// tabControlPanel2
			// 
			this.tabControlPanel2.Controls.Add(this.superTabControl1);
			this.tabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControlPanel2.Location = new System.Drawing.Point(0, 26);
			this.tabControlPanel2.Name = "tabControlPanel2";
			this.tabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
			this.tabControlPanel2.Size = new System.Drawing.Size(959, 510);
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
			this.superTabControl1.Size = new System.Drawing.Size(957, 508);
			this.superTabControl1.TabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.superTabControl1.TabIndex = 4;
			this.superTabControl1.Tabs.AddRange(new DevComponents.DotNetBar.BaseItem[] {
									this.superTabItem1});
			this.superTabControl1.TabStyle = DevComponents.DotNetBar.eSuperTabStyle.OneNote2007;
			this.superTabControl1.Text = "superTabControl1";
			// 
			// superTabControlPanel2
			// 
			this.superTabControlPanel2.Controls.Add(this.pnl_cidade);
			this.superTabControlPanel2.Controls.Add(this.bt_fechar);
			this.superTabControlPanel2.Controls.Add(this.bt_salvar);
			this.superTabControlPanel2.Controls.Add(this.bt_excluir);
			this.superTabControlPanel2.Controls.Add(this.bt_Editar);
			this.superTabControlPanel2.Controls.Add(this.bt_adicionar);
			this.superTabControlPanel2.Controls.Add(this.panel2);
			this.superTabControlPanel2.Controls.Add(this.gb_contatos);
			this.superTabControlPanel2.Controls.Add(this.gb_dados);
			this.superTabControlPanel2.Controls.Add(this.gb_endereco);
			this.superTabControlPanel2.Controls.Add(this.panel1);
			this.superTabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.superTabControlPanel2.Location = new System.Drawing.Point(0, 23);
			this.superTabControlPanel2.Name = "superTabControlPanel2";
			this.superTabControlPanel2.Size = new System.Drawing.Size(957, 485);
			this.superTabControlPanel2.TabIndex = 1;
			this.superTabControlPanel2.TabItem = this.superTabItem1;
			// 
			// pnl_cidade
			// 
			this.pnl_cidade.CanvasColor = System.Drawing.SystemColors.Control;
			this.pnl_cidade.Controls.Add(this.dgv_cidade);
			this.pnl_cidade.Controls.Add(this.txt_LocalizaCidade);
			this.pnl_cidade.Location = new System.Drawing.Point(716, 150);
			this.pnl_cidade.Name = "pnl_cidade";
			this.pnl_cidade.Size = new System.Drawing.Size(78, 42);
			this.pnl_cidade.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.pnl_cidade.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.pnl_cidade.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.pnl_cidade.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.pnl_cidade.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.pnl_cidade.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.pnl_cidade.Style.GradientAngle = 90;
			this.pnl_cidade.TabIndex = 37;
			this.pnl_cidade.Visible = false;
			// 
			// dgv_cidade
			// 
			this.dgv_cidade.AllowUserToAddRows = false;
			this.dgv_cidade.AllowUserToDeleteRows = false;
			this.dgv_cidade.AllowUserToOrderColumns = true;
			this.dgv_cidade.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.RoyalBlue;
			dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
			dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_cidade.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_cidade.EnableHeadersVisualStyles = false;
			this.dgv_cidade.Location = new System.Drawing.Point(4, 32);
			this.dgv_cidade.MultiSelect = false;
			this.dgv_cidade.Name = "dgv_cidade";
			this.dgv_cidade.ReadOnly = true;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.RoyalBlue;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.InactiveBorder;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_cidade.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_cidade.RowHeadersVisible = false;
			this.dgv_cidade.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_cidade.Size = new System.Drawing.Size(299, 219);
			this.dgv_cidade.TabIndex = 11;
			this.dgv_cidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Dgv_cidadeKeyDown);
			// 
			// txt_LocalizaCidade
			// 
			// 
			// 
			// 
			this.txt_LocalizaCidade.Border.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Double;
			this.txt_LocalizaCidade.Border.BorderColor = System.Drawing.Color.Blue;
			this.txt_LocalizaCidade.Border.BorderColor2 = System.Drawing.SystemColors.HotTrack;
			this.txt_LocalizaCidade.Border.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Double;
			this.txt_LocalizaCidade.Border.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Double;
			this.txt_LocalizaCidade.Border.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Double;
			this.txt_LocalizaCidade.Border.Class = "TextBoxBorder";
			this.txt_LocalizaCidade.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.txt_LocalizaCidade.Font = new System.Drawing.Font("Futura Md BT", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_LocalizaCidade.Location = new System.Drawing.Point(5, 6);
			this.txt_LocalizaCidade.Name = "txt_LocalizaCidade";
			this.txt_LocalizaCidade.Size = new System.Drawing.Size(298, 23);
			this.txt_LocalizaCidade.TabIndex = 10;
			this.txt_LocalizaCidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_LocalizaCidadeKeyDown);
			// 
			// bt_fechar
			// 
			this.bt_fechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.bt_fechar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
			this.bt_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bt_fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_fechar.Location = new System.Drawing.Point(719, 419);
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
			this.bt_salvar.Location = new System.Drawing.Point(322, 419);
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
			this.bt_excluir.Location = new System.Drawing.Point(218, 419);
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
			this.bt_Editar.Location = new System.Drawing.Point(114, 419);
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
			this.bt_adicionar.Location = new System.Drawing.Point(12, 419);
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
			this.panel2.Location = new System.Drawing.Point(12, 410);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(805, 3);
			this.panel2.TabIndex = 36;
			// 
			// gb_contatos
			// 
			this.gb_contatos.AutoSize = true;
			this.gb_contatos.BackColor = System.Drawing.Color.Transparent;
			this.gb_contatos.Controls.Add(this.label9);
			this.gb_contatos.Controls.Add(this.txt_fone1);
			this.gb_contatos.Controls.Add(this.txt_fone2);
			this.gb_contatos.Controls.Add(this.label10);
			this.gb_contatos.Controls.Add(this.txt_site);
			this.gb_contatos.Controls.Add(this.txt_fone3);
			this.gb_contatos.Controls.Add(this.label14);
			this.gb_contatos.Controls.Add(this.label11);
			this.gb_contatos.Controls.Add(this.txt_email);
			this.gb_contatos.Controls.Add(this.pictureBox1);
			this.gb_contatos.Controls.Add(this.label13);
			this.gb_contatos.Controls.Add(this.txt_fone4);
			this.gb_contatos.Controls.Add(this.label12);
			this.gb_contatos.Enabled = false;
			this.gb_contatos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gb_contatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gb_contatos.ForeColor = System.Drawing.Color.White;
			this.gb_contatos.Location = new System.Drawing.Point(11, 280);
			this.gb_contatos.Name = "gb_contatos";
			this.gb_contatos.Size = new System.Drawing.Size(806, 121);
			this.gb_contatos.TabIndex = 39;
			this.gb_contatos.TabStop = false;
			this.gb_contatos.Text = "CONTATOS";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.BackColor = System.Drawing.Color.Transparent;
			this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.Location = new System.Drawing.Point(41, 36);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(42, 13);
			this.label9.TabIndex = 23;
			this.label9.Text = "FONE1";
			// 
			// txt_fone1
			// 
			this.txt_fone1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_fone1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_fone1.Location = new System.Drawing.Point(87, 33);
			this.txt_fone1.Mask = "(99) 00000-0000";
			this.txt_fone1.Name = "txt_fone1";
			this.txt_fone1.Size = new System.Drawing.Size(120, 20);
			this.txt_fone1.SkipLiterals = false;
			this.txt_fone1.TabIndex = 22;
			this.txt_fone1.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.txt_fone1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_fone1KeyDown);
			// 
			// txt_fone2
			// 
			this.txt_fone2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_fone2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_fone2.Location = new System.Drawing.Point(277, 33);
			this.txt_fone2.Mask = "(99) 00000-0000";
			this.txt_fone2.Name = "txt_fone2";
			this.txt_fone2.Size = new System.Drawing.Size(120, 20);
			this.txt_fone2.SkipLiterals = false;
			this.txt_fone2.TabIndex = 27;
			this.txt_fone2.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.txt_fone2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_fone2KeyDown);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.BackColor = System.Drawing.Color.Transparent;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label10.ForeColor = System.Drawing.Color.Black;
			this.label10.Location = new System.Drawing.Point(231, 37);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(42, 13);
			this.label10.TabIndex = 24;
			this.label10.Text = "FONE2";
			// 
			// txt_site
			// 
			this.txt_site.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_site.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_site.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_site.Location = new System.Drawing.Point(475, 78);
			this.txt_site.Name = "txt_site";
			this.txt_site.Size = new System.Drawing.Size(310, 20);
			this.txt_site.TabIndex = 34;
			this.txt_site.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_siteKeyDown);
			// 
			// txt_fone3
			// 
			this.txt_fone3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_fone3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_fone3.Location = new System.Drawing.Point(475, 35);
			this.txt_fone3.Mask = "(99) 00000-0000";
			this.txt_fone3.Name = "txt_fone3";
			this.txt_fone3.Size = new System.Drawing.Size(120, 20);
			this.txt_fone3.SkipLiterals = false;
			this.txt_fone3.TabIndex = 28;
			this.txt_fone3.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.txt_fone3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_fone3KeyDown);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.BackColor = System.Drawing.Color.Transparent;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.ForeColor = System.Drawing.Color.Black;
			this.label14.Location = new System.Drawing.Point(437, 82);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(31, 13);
			this.label14.TabIndex = 33;
			this.label14.Text = "SITE";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.BackColor = System.Drawing.Color.Transparent;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label11.ForeColor = System.Drawing.Color.Black;
			this.label11.Location = new System.Drawing.Point(428, 39);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(42, 13);
			this.label11.TabIndex = 25;
			this.label11.Text = "FONE3";
			// 
			// txt_email
			// 
			this.txt_email.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_email.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_email.Location = new System.Drawing.Point(87, 79);
			this.txt_email.Name = "txt_email";
			this.txt_email.Size = new System.Drawing.Size(311, 20);
			this.txt_email.TabIndex = 32;
			this.txt_email.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_emailKeyDown);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(8, 27);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(30, 28);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 30;
			this.pictureBox1.TabStop = false;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.BackColor = System.Drawing.Color.Transparent;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.ForeColor = System.Drawing.Color.Black;
			this.label13.Location = new System.Drawing.Point(40, 83);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(42, 13);
			this.label13.TabIndex = 31;
			this.label13.Text = "E-MAIL";
			// 
			// txt_fone4
			// 
			this.txt_fone4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_fone4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_fone4.Location = new System.Drawing.Point(665, 35);
			this.txt_fone4.Mask = "(99) 00000-0000";
			this.txt_fone4.Name = "txt_fone4";
			this.txt_fone4.Size = new System.Drawing.Size(120, 20);
			this.txt_fone4.SkipLiterals = false;
			this.txt_fone4.TabIndex = 29;
			this.txt_fone4.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.txt_fone4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_fone4KeyDown);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.BackColor = System.Drawing.Color.Transparent;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.ForeColor = System.Drawing.Color.Black;
			this.label12.Location = new System.Drawing.Point(619, 39);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(42, 13);
			this.label12.TabIndex = 26;
			this.label12.Text = "FONE4";
			// 
			// gb_dados
			// 
			this.gb_dados.AutoSize = true;
			this.gb_dados.BackColor = System.Drawing.Color.Transparent;
			this.gb_dados.Controls.Add(this.txt_cnpj);
			this.gb_dados.Controls.Add(this.txt_cpf);
			this.gb_dados.Controls.Add(this.groupBox2);
			this.gb_dados.Controls.Add(this.lbl_cpfcnpj);
			this.gb_dados.Controls.Add(this.txt_NomeCliente);
			this.gb_dados.Controls.Add(this.label2);
			this.gb_dados.Enabled = false;
			this.gb_dados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gb_dados.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gb_dados.ForeColor = System.Drawing.Color.White;
			this.gb_dados.Location = new System.Drawing.Point(11, 24);
			this.gb_dados.Name = "gb_dados";
			this.gb_dados.Size = new System.Drawing.Size(804, 109);
			this.gb_dados.TabIndex = 37;
			this.gb_dados.TabStop = false;
			this.gb_dados.Text = "DADOS";
			// 
			// txt_cnpj
			// 
			this.txt_cnpj.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_cnpj.Enabled = false;
			this.txt_cnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_cnpj.Location = new System.Drawing.Point(428, 33);
			this.txt_cnpj.Mask = "99,999,999/9999-99";
			this.txt_cnpj.Name = "txt_cnpj";
			this.txt_cnpj.Size = new System.Drawing.Size(341, 20);
			this.txt_cnpj.SkipLiterals = false;
			this.txt_cnpj.TabIndex = 19;
			this.txt_cnpj.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.txt_cnpj.Visible = false;
			this.txt_cnpj.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_cnpjKeyDown);
			// 
			// txt_cpf
			// 
			this.txt_cpf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_cpf.Enabled = false;
			this.txt_cpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_cpf.Location = new System.Drawing.Point(428, 33);
			this.txt_cpf.Mask = "999,999,999-99";
			this.txt_cpf.Name = "txt_cpf";
			this.txt_cpf.Size = new System.Drawing.Size(341, 20);
			this.txt_cpf.SkipLiterals = false;
			this.txt_cpf.TabIndex = 18;
			this.txt_cpf.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.txt_cpf.Visible = false;
			this.txt_cpf.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_cpfKeyDown);
			// 
			// groupBox2
			// 
			this.groupBox2.AutoSize = true;
			this.groupBox2.BackColor = System.Drawing.Color.Transparent;
			this.groupBox2.Controls.Add(this.rbt_Pfisica);
			this.groupBox2.Controls.Add(this.rbt_Pjuridica);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox2.Location = new System.Drawing.Point(11, 28);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(297, 62);
			this.groupBox2.TabIndex = 4;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "PESSOA";
			// 
			// rbt_Pfisica
			// 
			this.rbt_Pfisica.AutoSize = true;
			this.rbt_Pfisica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rbt_Pfisica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbt_Pfisica.ForeColor = System.Drawing.Color.Black;
			this.rbt_Pfisica.Location = new System.Drawing.Point(6, 23);
			this.rbt_Pfisica.Name = "rbt_Pfisica";
			this.rbt_Pfisica.Size = new System.Drawing.Size(111, 20);
			this.rbt_Pfisica.TabIndex = 2;
			this.rbt_Pfisica.Text = "Pessoa Física";
			this.rbt_Pfisica.UseVisualStyleBackColor = true;
			this.rbt_Pfisica.Click += new System.EventHandler(this.Rbt_PfisicaClick);
			// 
			// rbt_Pjuridica
			// 
			this.rbt_Pjuridica.AutoSize = true;
			this.rbt_Pjuridica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.rbt_Pjuridica.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.rbt_Pjuridica.ForeColor = System.Drawing.Color.Black;
			this.rbt_Pjuridica.Location = new System.Drawing.Point(153, 23);
			this.rbt_Pjuridica.Name = "rbt_Pjuridica";
			this.rbt_Pjuridica.Size = new System.Drawing.Size(122, 20);
			this.rbt_Pjuridica.TabIndex = 3;
			this.rbt_Pjuridica.Text = "Pessoa Jurídica";
			this.rbt_Pjuridica.UseVisualStyleBackColor = true;
			this.rbt_Pjuridica.Click += new System.EventHandler(this.Rbt_PjuridicaClick);
			// 
			// lbl_cpfcnpj
			// 
			this.lbl_cpfcnpj.AutoSize = true;
			this.lbl_cpfcnpj.BackColor = System.Drawing.Color.Transparent;
			this.lbl_cpfcnpj.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_cpfcnpj.ForeColor = System.Drawing.Color.Black;
			this.lbl_cpfcnpj.Location = new System.Drawing.Point(358, 36);
			this.lbl_cpfcnpj.Name = "lbl_cpfcnpj";
			this.lbl_cpfcnpj.Size = new System.Drawing.Size(65, 13);
			this.lbl_cpfcnpj.TabIndex = 1;
			this.lbl_cpfcnpj.Text = "CPF / CNPJ";
			// 
			// txt_NomeCliente
			// 
			this.txt_NomeCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_NomeCliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_NomeCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_NomeCliente.Location = new System.Drawing.Point(428, 69);
			this.txt_NomeCliente.Name = "txt_NomeCliente";
			this.txt_NomeCliente.Size = new System.Drawing.Size(341, 20);
			this.txt_NomeCliente.TabIndex = 6;
			this.txt_NomeCliente.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_NomeClienteKeyDown);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.ForeColor = System.Drawing.Color.Black;
			this.label2.Location = new System.Drawing.Point(336, 73);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(87, 13);
			this.label2.TabIndex = 5;
			this.label2.Text = "NOME CLIENTE";
			// 
			// gb_endereco
			// 
			this.gb_endereco.AutoSize = true;
			this.gb_endereco.BackColor = System.Drawing.Color.Transparent;
			this.gb_endereco.Controls.Add(this.txt_uf);
			this.gb_endereco.Controls.Add(this.txt_endereco);
			this.gb_endereco.Controls.Add(this.label3);
			this.gb_endereco.Controls.Add(this.label4);
			this.gb_endereco.Controls.Add(this.txt_complemento);
			this.gb_endereco.Controls.Add(this.label5);
			this.gb_endereco.Controls.Add(this.txt_bairro);
			this.gb_endereco.Controls.Add(this.txt_cidade);
			this.gb_endereco.Controls.Add(this.label6);
			this.gb_endereco.Controls.Add(this.label7);
			this.gb_endereco.Controls.Add(this.txt_cep);
			this.gb_endereco.Controls.Add(this.label8);
			this.gb_endereco.Enabled = false;
			this.gb_endereco.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.gb_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.gb_endereco.ForeColor = System.Drawing.Color.White;
			this.gb_endereco.Location = new System.Drawing.Point(11, 140);
			this.gb_endereco.Name = "gb_endereco";
			this.gb_endereco.Size = new System.Drawing.Size(804, 134);
			this.gb_endereco.TabIndex = 36;
			this.gb_endereco.TabStop = false;
			this.gb_endereco.Text = "ENDEREÇO";
			// 
			// txt_uf
			// 
			this.txt_uf.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_uf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_uf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_uf.Location = new System.Drawing.Point(486, 57);
			this.txt_uf.Name = "txt_uf";
			this.txt_uf.ReadOnly = true;
			this.txt_uf.Size = new System.Drawing.Size(291, 20);
			this.txt_uf.TabIndex = 21;
			// 
			// txt_endereco
			// 
			this.txt_endereco.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_endereco.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_endereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_endereco.Location = new System.Drawing.Point(103, 23);
			this.txt_endereco.Name = "txt_endereco";
			this.txt_endereco.Size = new System.Drawing.Size(295, 20);
			this.txt_endereco.TabIndex = 8;
			this.txt_endereco.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_enderecoKeyDown);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.ForeColor = System.Drawing.Color.Black;
			this.label3.Location = new System.Drawing.Point(32, 24);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(67, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "ENDEREÇO";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.ForeColor = System.Drawing.Color.Black;
			this.label4.Location = new System.Drawing.Point(9, 59);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 13);
			this.label4.TabIndex = 9;
			this.label4.Text = "COMPLEMENTO";
			// 
			// txt_complemento
			// 
			this.txt_complemento.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_complemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_complemento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_complemento.Location = new System.Drawing.Point(103, 55);
			this.txt_complemento.Name = "txt_complemento";
			this.txt_complemento.Size = new System.Drawing.Size(292, 20);
			this.txt_complemento.TabIndex = 10;
			this.txt_complemento.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_complementoKeyDown);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.ForeColor = System.Drawing.Color.Black;
			this.label5.Location = new System.Drawing.Point(51, 92);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(48, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "BAIRRO";
			// 
			// txt_bairro
			// 
			this.txt_bairro.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_bairro.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_bairro.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_bairro.Location = new System.Drawing.Point(103, 88);
			this.txt_bairro.Name = "txt_bairro";
			this.txt_bairro.Size = new System.Drawing.Size(292, 20);
			this.txt_bairro.TabIndex = 12;
			this.txt_bairro.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_bairroKeyDown);
			// 
			// txt_cidade
			// 
			this.txt_cidade.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_cidade.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txt_cidade.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_cidade.Location = new System.Drawing.Point(486, 23);
			this.txt_cidade.Name = "txt_cidade";
			this.txt_cidade.ReadOnly = true;
			this.txt_cidade.Size = new System.Drawing.Size(292, 20);
			this.txt_cidade.TabIndex = 14;
			this.txt_cidade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_cidadeKeyDown);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.BackColor = System.Drawing.Color.Transparent;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.ForeColor = System.Drawing.Color.Black;
			this.label6.Location = new System.Drawing.Point(435, 27);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(47, 13);
			this.label6.TabIndex = 13;
			this.label6.Text = "CIDADE";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.BackColor = System.Drawing.Color.Transparent;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.ForeColor = System.Drawing.Color.Black;
			this.label7.Location = new System.Drawing.Point(461, 59);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(21, 13);
			this.label7.TabIndex = 16;
			this.label7.Text = "UF";
			// 
			// txt_cep
			// 
			this.txt_cep.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.txt_cep.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_cep.Location = new System.Drawing.Point(486, 89);
			this.txt_cep.Mask = "00000-000";
			this.txt_cep.Name = "txt_cep";
			this.txt_cep.Size = new System.Drawing.Size(291, 20);
			this.txt_cep.SkipLiterals = false;
			this.txt_cep.TabIndex = 17;
			this.txt_cep.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
			this.txt_cep.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Txt_cepKeyDown);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.BackColor = System.Drawing.Color.Transparent;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.ForeColor = System.Drawing.Color.Black;
			this.label8.Location = new System.Drawing.Point(454, 93);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(28, 13);
			this.label8.TabIndex = 18;
			this.label8.Text = "CEP";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.RoyalBlue;
			this.panel1.Location = new System.Drawing.Point(12, 16);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(805, 3);
			this.panel1.TabIndex = 35;
			// 
			// superTabItem1
			// 
			this.superTabItem1.AttachedControl = this.superTabControlPanel2;
			this.superTabItem1.GlobalItem = false;
			this.superTabItem1.Name = "superTabItem1";
			this.superTabItem1.Text = "CLIENTE";
			// 
			// tab2
			// 
			this.tab2.AttachedControl = this.tabControlPanel2;
			this.tab2.Name = "tab2";
			this.tab2.Text = "C A D A S T R O - F3";
			// 
			// FormClientes
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.ClientSize = new System.Drawing.Size(959, 536);
			this.Controls.Add(this.tabControl1);
			this.KeyPreview = true;
			this.Name = "FormClientes";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "CADASTRO DE CLIENTES";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Shown += new System.EventHandler(this.FormClientesShown);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormClientesKeyDown);
			((System.ComponentModel.ISupportInitialize)(this.tabControl1)).EndInit();
			this.tabControl1.ResumeLayout(false);
			this.tabControlPanel1.ResumeLayout(false);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_clientes)).EndInit();
			this.tabControlPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.superTabControl1)).EndInit();
			this.superTabControl1.ResumeLayout(false);
			this.superTabControlPanel2.ResumeLayout(false);
			this.superTabControlPanel2.PerformLayout();
			this.pnl_cidade.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_cidade)).EndInit();
			this.gb_contatos.ResumeLayout(false);
			this.gb_contatos.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.gb_dados.ResumeLayout(false);
			this.gb_dados.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.gb_endereco.ResumeLayout(false);
			this.gb_endereco.PerformLayout();
			this.ResumeLayout(false);
		}
		private DevComponents.DotNetBar.Controls.TextBoxX txt_LocalizaCidade;
		private System.Windows.Forms.DataGridView dgv_cidade;
		private DevComponents.DotNetBar.PanelEx pnl_cidade;
		private System.Windows.Forms.TextBox txt_uf;
		private System.Windows.Forms.MaskedTextBox txt_cnpj;
		private System.Windows.Forms.SplitContainer splitContainer1;
		private DevComponents.DotNetBar.ButtonX bt_adicionar;
		private DevComponents.DotNetBar.ButtonX bt_Editar;
		private DevComponents.DotNetBar.ButtonX bt_excluir;
		private DevComponents.DotNetBar.ButtonX bt_salvar;
		private DevComponents.DotNetBar.ButtonX bt_fechar;
		private System.Windows.Forms.MaskedTextBox txt_cpf;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.GroupBox gb_contatos;
		private System.Windows.Forms.GroupBox gb_endereco;
		private System.Windows.Forms.GroupBox gb_dados;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.TextBox txt_email;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.TextBox txt_site;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.MaskedTextBox txt_fone2;
		private System.Windows.Forms.MaskedTextBox txt_fone3;
		private System.Windows.Forms.MaskedTextBox txt_fone4;
		private System.Windows.Forms.MaskedTextBox txt_fone1;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_endereco;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txt_complemento;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox txt_bairro;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox txt_cidade;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.MaskedTextBox txt_cep;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label lbl_cpfcnpj;
		private System.Windows.Forms.RadioButton rbt_Pjuridica;
		private System.Windows.Forms.RadioButton rbt_Pfisica;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_NomeCliente;
		private DevComponents.DotNetBar.SuperTabItem superTabItem1;
		private DevComponents.DotNetBar.SuperTabControlPanel superTabControlPanel2;
		private DevComponents.DotNetBar.SuperTabControl superTabControl1;
		private DevComponents.DotNetBar.TabItem tab2;
		private DevComponents.DotNetBar.TabControlPanel tabControlPanel2;
		private DevComponents.DotNetBar.TabItem tab1;
		private System.Windows.Forms.TextBox txt_localizar;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.DataGridView dgv_clientes;
		private DevComponents.DotNetBar.TabControlPanel tabControlPanel1;
		private DevComponents.DotNetBar.TabControl tabControl1;
	}
}
