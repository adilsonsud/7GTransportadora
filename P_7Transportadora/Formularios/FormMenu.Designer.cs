/*
 * Criado por SharpDevelop.
 * Usuário: adilson
 * Data: 2017-01-05
 * Hora: 16:45
 * 
 * Para alterar este modelo use Ferramentas | Opções | Codificação | Editar Cabeçalhos Padrão.
 */
namespace P_7Transportadora.Formularios
{
	partial class FormMenu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMenu));
			this.BarraMenu = new DevComponents.DotNetBar.ExpandablePanel();
			this.bt_relatorios = new DevComponents.DotNetBar.ButtonX();
			this.btItem_admin = new DevComponents.DotNetBar.ButtonItem();
			this.btItem_Financeiro = new DevComponents.DotNetBar.ButtonItem();
			this.buttonX2 = new DevComponents.DotNetBar.ButtonX();
			this.buttonItem1 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem2 = new DevComponents.DotNetBar.ButtonItem();
			this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
			this.buttonItem3 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem5 = new DevComponents.DotNetBar.ButtonItem();
			this.galleryContainer1 = new DevComponents.DotNetBar.GalleryContainer();
			this.buttonItem6 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonItem7 = new DevComponents.DotNetBar.ButtonItem();
			this.buttonX1 = new DevComponents.DotNetBar.ButtonX();
			this.bt_minuta = new DevComponents.DotNetBar.ButtonX();
			this.bt_conteudo = new DevComponents.DotNetBar.ButtonX();
			this.bt_fechar = new DevComponents.DotNetBar.ButtonX();
			this.bt_compania = new DevComponents.DotNetBar.ButtonX();
			this.bt_embalagem = new DevComponents.DotNetBar.ButtonX();
			this.bt_cliente = new DevComponents.DotNetBar.ButtonX();
			this.BarraMenu.SuspendLayout();
			this.SuspendLayout();
			// 
			// BarraMenu
			// 
			this.BarraMenu.CanvasColor = System.Drawing.SystemColors.ButtonShadow;
			this.BarraMenu.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.OfficeXP;
			this.BarraMenu.Controls.Add(this.bt_relatorios);
			this.BarraMenu.Controls.Add(this.buttonX2);
			this.BarraMenu.Controls.Add(this.buttonX1);
			this.BarraMenu.Controls.Add(this.bt_minuta);
			this.BarraMenu.Controls.Add(this.bt_conteudo);
			this.BarraMenu.Controls.Add(this.bt_fechar);
			this.BarraMenu.Controls.Add(this.bt_compania);
			this.BarraMenu.Controls.Add(this.bt_embalagem);
			this.BarraMenu.Controls.Add(this.bt_cliente);
			this.BarraMenu.Dock = System.Windows.Forms.DockStyle.Top;
			this.BarraMenu.ExpandOnTitleClick = true;
			this.BarraMenu.Location = new System.Drawing.Point(0, 0);
			this.BarraMenu.Name = "BarraMenu";
			this.BarraMenu.Size = new System.Drawing.Size(1236, 98);
			this.BarraMenu.Style.Alignment = System.Drawing.StringAlignment.Center;
			this.BarraMenu.Style.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.BarraMenu.Style.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.BarraMenu.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.BarraMenu.Style.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ItemText;
			this.BarraMenu.Style.GradientAngle = 90;
			this.BarraMenu.StyleMouseDown.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(152)))), ((int)(((byte)(181)))), ((int)(((byte)(226)))));
			this.BarraMenu.StyleMouseDown.BorderColor.Color = System.Drawing.SystemColors.Highlight;
			this.BarraMenu.StyleMouseDown.ForeColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(73)))), ((int)(((byte)(73)))));
			this.BarraMenu.StyleMouseOver.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(193)))), ((int)(((byte)(210)))), ((int)(((byte)(238)))));
			this.BarraMenu.StyleMouseOver.BorderColor.Color = System.Drawing.SystemColors.Highlight;
			this.BarraMenu.StyleMouseOver.ForeColor.Color = System.Drawing.SystemColors.ControlText;
			this.BarraMenu.TabIndex = 1;
			this.BarraMenu.TitleStyle.Alignment = System.Drawing.StringAlignment.Center;
			this.BarraMenu.TitleStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
			this.BarraMenu.TitleStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
			this.BarraMenu.TitleStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
			this.BarraMenu.TitleStyle.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
			this.BarraMenu.TitleStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BarraMenu.TitleStyle.ForeColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
			this.BarraMenu.TitleStyle.GradientAngle = 90;
			this.BarraMenu.TitleText = "M E N U - F1";
			// 
			// bt_relatorios
			// 
			this.bt_relatorios.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.bt_relatorios.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
			this.bt_relatorios.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bt_relatorios.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_relatorios.Image = ((System.Drawing.Image)(resources.GetObject("bt_relatorios.Image")));
			this.bt_relatorios.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.bt_relatorios.Location = new System.Drawing.Point(597, 28);
			this.bt_relatorios.Name = "bt_relatorios";
			this.bt_relatorios.ShowSubItems = false;
			this.bt_relatorios.Size = new System.Drawing.Size(93, 67);
			this.bt_relatorios.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bt_relatorios.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
									this.btItem_admin,
									this.btItem_Financeiro});
			this.bt_relatorios.TabIndex = 9;
			this.bt_relatorios.Text = "&RELATORIOS";
			this.bt_relatorios.Click += new System.EventHandler(this.Bt_relatoriosClick);
			// 
			// btItem_admin
			// 
			this.btItem_admin.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btItem_admin.GlobalItem = false;
			this.btItem_admin.Name = "btItem_admin";
			this.btItem_admin.Symbol = "";
			this.btItem_admin.Text = "ADMINISTRATIVO";
			// 
			// btItem_Financeiro
			// 
			this.btItem_Financeiro.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btItem_Financeiro.GlobalItem = false;
			this.btItem_Financeiro.Name = "btItem_Financeiro";
			this.btItem_Financeiro.Symbol = "";
			this.btItem_Financeiro.Text = "FINANCEIRO";
			// 
			// buttonX2
			// 
			this.buttonX2.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonX2.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
			this.buttonX2.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonX2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonX2.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.buttonX2.Location = new System.Drawing.Point(818, 28);
			this.buttonX2.Name = "buttonX2";
			this.buttonX2.Size = new System.Drawing.Size(93, 67);
			this.buttonX2.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.buttonX2.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
									this.buttonItem1,
									this.buttonItem2,
									this.itemContainer1,
									this.galleryContainer1});
			this.buttonX2.TabIndex = 8;
			this.buttonX2.Text = "TESTE";
			this.buttonX2.Visible = false;
			this.buttonX2.Click += new System.EventHandler(this.ButtonX2Click);
			// 
			// buttonItem1
			// 
			this.buttonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
			this.buttonItem1.Checked = true;
			this.buttonItem1.ColorTable = DevComponents.DotNetBar.eButtonColor.Flat;
			this.buttonItem1.GlobalItem = false;
			this.buttonItem1.Name = "buttonItem1";
			this.buttonItem1.Text = "buttonItem1";
			// 
			// buttonItem2
			// 
			this.buttonItem2.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueWithBackground;
			this.buttonItem2.GlobalItem = false;
			this.buttonItem2.Name = "buttonItem2";
			this.buttonItem2.Text = "buttonItem2";
			// 
			// itemContainer1
			// 
			// 
			// 
			// 
			this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.itemContainer1.Name = "itemContainer1";
			this.itemContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
									this.buttonItem3,
									this.buttonItem5});
			// 
			// 
			// 
			this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// buttonItem3
			// 
			this.buttonItem3.ColorTable = DevComponents.DotNetBar.eButtonColor.Magenta;
			this.buttonItem3.Name = "buttonItem3";
			this.buttonItem3.Text = "buttonItem3";
			// 
			// buttonItem5
			// 
			this.buttonItem5.Name = "buttonItem5";
			this.buttonItem5.Text = "buttonItem5";
			// 
			// galleryContainer1
			// 
			// 
			// 
			// 
			this.galleryContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			this.galleryContainer1.GlobalItem = false;
			this.galleryContainer1.MinimumSize = new System.Drawing.Size(58, 58);
			this.galleryContainer1.Name = "galleryContainer1";
			this.galleryContainer1.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
									this.buttonItem6,
									this.buttonItem7});
			// 
			// 
			// 
			this.galleryContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
			// 
			// buttonItem6
			// 
			this.buttonItem6.Name = "buttonItem6";
			this.buttonItem6.Text = "buttonItem6";
			// 
			// buttonItem7
			// 
			this.buttonItem7.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
			this.buttonItem7.Name = "buttonItem7";
			this.buttonItem7.Text = "buttonItem7";
			// 
			// buttonX1
			// 
			this.buttonX1.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.buttonX1.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
			this.buttonX1.Cursor = System.Windows.Forms.Cursors.Hand;
			this.buttonX1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.buttonX1.Image = ((System.Drawing.Image)(resources.GetObject("buttonX1.Image")));
			this.buttonX1.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.buttonX1.Location = new System.Drawing.Point(399, 28);
			this.buttonX1.Name = "buttonX1";
			this.buttonX1.Size = new System.Drawing.Size(93, 67);
			this.buttonX1.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.buttonX1.TabIndex = 7;
			this.buttonX1.Text = "&SIGLAS";
			this.buttonX1.Click += new System.EventHandler(this.ButtonX1Click);
			// 
			// bt_minuta
			// 
			this.bt_minuta.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.bt_minuta.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
			this.bt_minuta.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bt_minuta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_minuta.Image = ((System.Drawing.Image)(resources.GetObject("bt_minuta.Image")));
			this.bt_minuta.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.bt_minuta.Location = new System.Drawing.Point(498, 28);
			this.bt_minuta.Name = "bt_minuta";
			this.bt_minuta.Size = new System.Drawing.Size(93, 67);
			this.bt_minuta.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bt_minuta.TabIndex = 6;
			this.bt_minuta.Text = "MI&NUTAS";
			this.bt_minuta.Click += new System.EventHandler(this.Bt_minutaClick);
			// 
			// bt_conteudo
			// 
			this.bt_conteudo.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.bt_conteudo.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
			this.bt_conteudo.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bt_conteudo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_conteudo.Image = ((System.Drawing.Image)(resources.GetObject("bt_conteudo.Image")));
			this.bt_conteudo.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.bt_conteudo.Location = new System.Drawing.Point(300, 28);
			this.bt_conteudo.Name = "bt_conteudo";
			this.bt_conteudo.Size = new System.Drawing.Size(93, 67);
			this.bt_conteudo.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bt_conteudo.TabIndex = 5;
			this.bt_conteudo.Text = "CON&TEÚDOS";
			this.bt_conteudo.Click += new System.EventHandler(this.Bt_conteudoClick);
			// 
			// bt_fechar
			// 
			this.bt_fechar.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.bt_fechar.ColorTable = DevComponents.DotNetBar.eButtonColor.BlueOrb;
			this.bt_fechar.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bt_fechar.Dock = System.Windows.Forms.DockStyle.Right;
			this.bt_fechar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_fechar.Image = ((System.Drawing.Image)(resources.GetObject("bt_fechar.Image")));
			this.bt_fechar.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.bt_fechar.Location = new System.Drawing.Point(1145, 26);
			this.bt_fechar.Name = "bt_fechar";
			this.bt_fechar.Size = new System.Drawing.Size(91, 72);
			this.bt_fechar.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bt_fechar.TabIndex = 4;
			this.bt_fechar.Text = "FEC&HAR";
			this.bt_fechar.Click += new System.EventHandler(this.Bt_fecharClick);
			// 
			// bt_compania
			// 
			this.bt_compania.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.bt_compania.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
			this.bt_compania.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bt_compania.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_compania.Image = ((System.Drawing.Image)(resources.GetObject("bt_compania.Image")));
			this.bt_compania.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.bt_compania.Location = new System.Drawing.Point(201, 28);
			this.bt_compania.Name = "bt_compania";
			this.bt_compania.Size = new System.Drawing.Size(93, 67);
			this.bt_compania.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bt_compania.TabIndex = 3;
			this.bt_compania.Text = "COM&PANIAS";
			this.bt_compania.Click += new System.EventHandler(this.Bt_companiaClick);
			// 
			// bt_embalagem
			// 
			this.bt_embalagem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.bt_embalagem.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
			this.bt_embalagem.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bt_embalagem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_embalagem.Image = ((System.Drawing.Image)(resources.GetObject("bt_embalagem.Image")));
			this.bt_embalagem.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.bt_embalagem.Location = new System.Drawing.Point(102, 28);
			this.bt_embalagem.Name = "bt_embalagem";
			this.bt_embalagem.Size = new System.Drawing.Size(93, 67);
			this.bt_embalagem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
			this.bt_embalagem.TabIndex = 2;
			this.bt_embalagem.Text = "E&MBALAGENS";
			this.bt_embalagem.Click += new System.EventHandler(this.Bt_embalagemClick);
			// 
			// bt_cliente
			// 
			this.bt_cliente.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
			this.bt_cliente.ColorTable = DevComponents.DotNetBar.eButtonColor.Office2007WithBackground;
			this.bt_cliente.Cursor = System.Windows.Forms.Cursors.Hand;
			this.bt_cliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bt_cliente.Image = ((System.Drawing.Image)(resources.GetObject("bt_cliente.Image")));
			this.bt_cliente.ImagePosition = DevComponents.DotNetBar.eImagePosition.Top;
			this.bt_cliente.Location = new System.Drawing.Point(3, 28);
			this.bt_cliente.Name = "bt_cliente";
			this.bt_cliente.Size = new System.Drawing.Size(93, 67);
			this.bt_cliente.Style = DevComponents.DotNetBar.eDotNetBarStyle.Windows7;
			this.bt_cliente.TabIndex = 1;
			this.bt_cliente.Text = "&CLIENTES";
			this.bt_cliente.Click += new System.EventHandler(this.Bt_clienteClick);
			// 
			// FormMenu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1236, 397);
			this.Controls.Add(this.BarraMenu);
			this.IsMdiContainer = true;
			this.KeyPreview = true;
			this.Name = "FormMenu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "7 - TRANSPORTADORA";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormMenuKeyDown);
			this.BarraMenu.ResumeLayout(false);
			this.ResumeLayout(false);
		}
		private DevComponents.DotNetBar.ButtonItem buttonItem7;
		private DevComponents.DotNetBar.ButtonItem buttonItem6;
		private DevComponents.DotNetBar.GalleryContainer galleryContainer1;
		private DevComponents.DotNetBar.ButtonItem buttonItem5;
		private DevComponents.DotNetBar.ButtonItem buttonItem3;
		private DevComponents.DotNetBar.ItemContainer itemContainer1;
		private DevComponents.DotNetBar.ButtonItem buttonItem2;
		private DevComponents.DotNetBar.ButtonItem buttonItem1;
		private DevComponents.DotNetBar.ButtonItem btItem_Financeiro;
		private DevComponents.DotNetBar.ButtonItem btItem_admin;
		private DevComponents.DotNetBar.ButtonX bt_relatorios;
		private DevComponents.DotNetBar.ButtonX buttonX2;
		private DevComponents.DotNetBar.ButtonX buttonX1;
		private DevComponents.DotNetBar.ButtonX bt_minuta;
		private DevComponents.DotNetBar.ButtonX bt_conteudo;
		private DevComponents.DotNetBar.ButtonX bt_embalagem;
		private DevComponents.DotNetBar.ButtonX bt_compania;
		private DevComponents.DotNetBar.ButtonX bt_fechar;
		private DevComponents.DotNetBar.ButtonX bt_cliente;
		private DevComponents.DotNetBar.ExpandablePanel BarraMenu;
	}
}
