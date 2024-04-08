namespace LajesCA
{
    partial class formPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formPrincipal));
            this.labelTitulo = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.grauEngasteFundo = new System.Windows.Forms.NumericUpDown();
            this.label14 = new System.Windows.Forms.Label();
            this.grauEngasteEsquerda = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.grauEngasteDireita = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.grauEngasteTopo = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.comboEsquerda = new System.Windows.Forms.ComboBox();
            this.comboFundo = new System.Windows.Forms.ComboBox();
            this.comboDireita = new System.Windows.Forms.ComboBox();
            this.comboTopo = new System.Windows.Forms.ComboBox();
            this.imgEsquerda = new System.Windows.Forms.PictureBox();
            this.imgDireita = new System.Windows.Forms.PictureBox();
            this.imgFundo = new System.Windows.Forms.PictureBox();
            this.imgTopo = new System.Windows.Forms.PictureBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboTipoAco = new System.Windows.Forms.ComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.comboClasseConcreto = new System.Windows.Forms.ComboBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtHInicial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtVaoVertical = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVaoHorizontal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtPsi2 = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCargaVariavel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCargaPermanente = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtBoxResultados = new System.Windows.Forms.RichTextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.comboCAA = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCobrimento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.chkCobrimento = new System.Windows.Forms.CheckBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.comboRigidez = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grauEngasteFundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grauEngasteEsquerda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grauEngasteDireita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grauEngasteTopo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEsquerda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDireita)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFundo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTopo)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.Location = new System.Drawing.Point(47, 16);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(974, 31);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "PROJETO DE LAJES RETANGULARES MACIÇAS DE CONCRETO ARMADO";
            this.labelTitulo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTitulo.Click += new System.EventHandler(this.labelTitulo_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelTitulo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1060, 60);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox2.Controls.Add(this.grauEngasteFundo);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.grauEngasteEsquerda);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.grauEngasteDireita);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.grauEngasteTopo);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.comboEsquerda);
            this.groupBox2.Controls.Add(this.comboFundo);
            this.groupBox2.Controls.Add(this.comboDireita);
            this.groupBox2.Controls.Add(this.comboTopo);
            this.groupBox2.Controls.Add(this.imgEsquerda);
            this.groupBox2.Controls.Add(this.imgDireita);
            this.groupBox2.Controls.Add(this.imgFundo);
            this.groupBox2.Controls.Add(this.imgTopo);
            this.groupBox2.Location = new System.Drawing.Point(13, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(565, 427);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Vinculação:";
            // 
            // grauEngasteFundo
            // 
            this.grauEngasteFundo.DecimalPlaces = 1;
            this.grauEngasteFundo.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.grauEngasteFundo.Location = new System.Drawing.Point(294, 392);
            this.grauEngasteFundo.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.grauEngasteFundo.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            65536});
            this.grauEngasteFundo.Name = "grauEngasteFundo";
            this.grauEngasteFundo.Size = new System.Drawing.Size(41, 20);
            this.grauEngasteFundo.TabIndex = 20;
            this.grauEngasteFundo.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(270, 394);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(18, 13);
            this.label14.TabIndex = 19;
            this.label14.Text = "i =";
            // 
            // grauEngasteEsquerda
            // 
            this.grauEngasteEsquerda.DecimalPlaces = 1;
            this.grauEngasteEsquerda.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.grauEngasteEsquerda.Location = new System.Drawing.Point(66, 196);
            this.grauEngasteEsquerda.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.grauEngasteEsquerda.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            65536});
            this.grauEngasteEsquerda.Name = "grauEngasteEsquerda";
            this.grauEngasteEsquerda.Size = new System.Drawing.Size(41, 20);
            this.grauEngasteEsquerda.TabIndex = 18;
            this.grauEngasteEsquerda.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(42, 198);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(18, 13);
            this.label13.TabIndex = 17;
            this.label13.Text = "i =";
            // 
            // grauEngasteDireita
            // 
            this.grauEngasteDireita.DecimalPlaces = 1;
            this.grauEngasteDireita.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.grauEngasteDireita.Location = new System.Drawing.Point(480, 194);
            this.grauEngasteDireita.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.grauEngasteDireita.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            65536});
            this.grauEngasteDireita.Name = "grauEngasteDireita";
            this.grauEngasteDireita.Size = new System.Drawing.Size(41, 20);
            this.grauEngasteDireita.TabIndex = 16;
            this.grauEngasteDireita.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(456, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(18, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "i =";
            // 
            // grauEngasteTopo
            // 
            this.grauEngasteTopo.DecimalPlaces = 1;
            this.grauEngasteTopo.Increment = new decimal(new int[] {
            1,
            0,
            0,
            65536});
            this.grauEngasteTopo.Location = new System.Drawing.Point(315, 25);
            this.grauEngasteTopo.Maximum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.grauEngasteTopo.Minimum = new decimal(new int[] {
            7,
            0,
            0,
            65536});
            this.grauEngasteTopo.Name = "grauEngasteTopo";
            this.grauEngasteTopo.Size = new System.Drawing.Size(41, 20);
            this.grauEngasteTopo.TabIndex = 14;
            this.grauEngasteTopo.Value = new decimal(new int[] {
            15,
            0,
            0,
            65536});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(291, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(18, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "i =";
            // 
            // comboEsquerda
            // 
            this.comboEsquerda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboEsquerda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboEsquerda.FormattingEnabled = true;
            this.comboEsquerda.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboEsquerda.Items.AddRange(new object[] {
            "Apoio",
            "Engaste"});
            this.comboEsquerda.Location = new System.Drawing.Point(43, 167);
            this.comboEsquerda.MaxDropDownItems = 3;
            this.comboEsquerda.Name = "comboEsquerda";
            this.comboEsquerda.Size = new System.Drawing.Size(64, 21);
            this.comboEsquerda.TabIndex = 12;
            this.comboEsquerda.SelectedIndexChanged += new System.EventHandler(this.comboEsquerda_SelectedIndexChanged);
            // 
            // comboFundo
            // 
            this.comboFundo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboFundo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboFundo.FormattingEnabled = true;
            this.comboFundo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboFundo.Items.AddRange(new object[] {
            "Apoio",
            "Engaste"});
            this.comboFundo.Location = new System.Drawing.Point(201, 391);
            this.comboFundo.MaxDropDownItems = 3;
            this.comboFundo.Name = "comboFundo";
            this.comboFundo.Size = new System.Drawing.Size(64, 21);
            this.comboFundo.TabIndex = 11;
            this.comboFundo.SelectedIndexChanged += new System.EventHandler(this.comboFundo_SelectedIndexChanged);
            // 
            // comboDireita
            // 
            this.comboDireita.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboDireita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboDireita.FormattingEnabled = true;
            this.comboDireita.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboDireita.Items.AddRange(new object[] {
            "Apoio",
            "Engaste"});
            this.comboDireita.Location = new System.Drawing.Point(457, 167);
            this.comboDireita.MaxDropDownItems = 3;
            this.comboDireita.Name = "comboDireita";
            this.comboDireita.Size = new System.Drawing.Size(64, 21);
            this.comboDireita.TabIndex = 10;
            this.comboDireita.SelectedIndexChanged += new System.EventHandler(this.comboDireita_SelectedIndexChanged);
            // 
            // comboTopo
            // 
            this.comboTopo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboTopo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTopo.FormattingEnabled = true;
            this.comboTopo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboTopo.Items.AddRange(new object[] {
            "Apoio",
            "Engaste"});
            this.comboTopo.Location = new System.Drawing.Point(201, 22);
            this.comboTopo.MaxDropDownItems = 3;
            this.comboTopo.Name = "comboTopo";
            this.comboTopo.Size = new System.Drawing.Size(64, 21);
            this.comboTopo.TabIndex = 9;
            this.comboTopo.SelectedIndexChanged += new System.EventHandler(this.comboTopo_SelectedIndexChanged);
            // 
            // imgEsquerda
            // 
            this.imgEsquerda.Image = global::LajesCA.Properties.Resources.Esquerda_apoio;
            this.imgEsquerda.Location = new System.Drawing.Point(113, 66);
            this.imgEsquerda.Name = "imgEsquerda";
            this.imgEsquerda.Size = new System.Drawing.Size(25, 300);
            this.imgEsquerda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgEsquerda.TabIndex = 3;
            this.imgEsquerda.TabStop = false;
            // 
            // imgDireita
            // 
            this.imgDireita.Image = global::LajesCA.Properties.Resources.Direita_apoio;
            this.imgDireita.Location = new System.Drawing.Point(426, 66);
            this.imgDireita.Name = "imgDireita";
            this.imgDireita.Size = new System.Drawing.Size(25, 300);
            this.imgDireita.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgDireita.TabIndex = 2;
            this.imgDireita.TabStop = false;
            // 
            // imgFundo
            // 
            this.imgFundo.Image = global::LajesCA.Properties.Resources.Fundo_apoio;
            this.imgFundo.Location = new System.Drawing.Point(133, 360);
            this.imgFundo.Name = "imgFundo";
            this.imgFundo.Size = new System.Drawing.Size(300, 25);
            this.imgFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgFundo.TabIndex = 1;
            this.imgFundo.TabStop = false;
            // 
            // imgTopo
            // 
            this.imgTopo.Image = global::LajesCA.Properties.Resources.Topo_apoio;
            this.imgTopo.Location = new System.Drawing.Point(133, 47);
            this.imgTopo.Name = "imgTopo";
            this.imgTopo.Size = new System.Drawing.Size(300, 25);
            this.imgTopo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgTopo.TabIndex = 0;
            this.imgTopo.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox3.Controls.Add(this.comboTipoAco);
            this.groupBox3.Location = new System.Drawing.Point(584, 79);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(119, 51);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Tipo de Aço:";
            // 
            // comboTipoAco
            // 
            this.comboTipoAco.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboTipoAco.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoAco.FormattingEnabled = true;
            this.comboTipoAco.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboTipoAco.Items.AddRange(new object[] {
            "CA-50",
            "CA-60"});
            this.comboTipoAco.Location = new System.Drawing.Point(12, 19);
            this.comboTipoAco.MaxDropDownItems = 3;
            this.comboTipoAco.Name = "comboTipoAco";
            this.comboTipoAco.Size = new System.Drawing.Size(93, 21);
            this.comboTipoAco.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox4.Controls.Add(this.comboClasseConcreto);
            this.groupBox4.Location = new System.Drawing.Point(584, 136);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(119, 51);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Classe de Concreto:";
            // 
            // comboClasseConcreto
            // 
            this.comboClasseConcreto.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboClasseConcreto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboClasseConcreto.FormattingEnabled = true;
            this.comboClasseConcreto.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboClasseConcreto.Items.AddRange(new object[] {
            "C20",
            "C25",
            "C30",
            "C35",
            "C40",
            "C45",
            "C50",
            "C55",
            "C60",
            "C65",
            "C70",
            "C75",
            "C80",
            "C85",
            "C90"});
            this.comboClasseConcreto.Location = new System.Drawing.Point(12, 19);
            this.comboClasseConcreto.MaxDropDownItems = 3;
            this.comboClasseConcreto.Name = "comboClasseConcreto";
            this.comboClasseConcreto.Size = new System.Drawing.Size(93, 21);
            this.comboClasseConcreto.TabIndex = 4;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Controls.Add(this.txtHInicial);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.txtVaoVertical);
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.label2);
            this.groupBox5.Controls.Add(this.txtVaoHorizontal);
            this.groupBox5.Controls.Add(this.label1);
            this.groupBox5.Location = new System.Drawing.Point(709, 79);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(167, 108);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Vãos:";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(18, 85);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(45, 13);
            this.label17.TabIndex = 8;
            this.label17.Text = "h inicial:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(140, 85);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(21, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "cm";
            // 
            // txtHInicial
            // 
            this.txtHInicial.Location = new System.Drawing.Point(69, 82);
            this.txtHInicial.Name = "txtHInicial";
            this.txtHInicial.Size = new System.Drawing.Size(65, 20);
            this.txtHInicial.TabIndex = 6;
            this.txtHInicial.Text = "8";
            this.txtHInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(140, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "cm";
            // 
            // txtVaoVertical
            // 
            this.txtVaoVertical.Location = new System.Drawing.Point(69, 52);
            this.txtVaoVertical.Name = "txtVaoVertical";
            this.txtVaoVertical.Size = new System.Drawing.Size(65, 20);
            this.txtVaoVertical.TabIndex = 4;
            this.txtVaoVertical.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Vertical:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(140, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "cm";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtVaoHorizontal
            // 
            this.txtVaoHorizontal.Location = new System.Drawing.Point(69, 19);
            this.txtVaoHorizontal.Name = "txtVaoHorizontal";
            this.txtVaoHorizontal.Size = new System.Drawing.Size(65, 20);
            this.txtVaoHorizontal.TabIndex = 1;
            this.txtVaoHorizontal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Horizontal:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtPsi2);
            this.groupBox6.Controls.Add(this.label15);
            this.groupBox6.Controls.Add(this.label5);
            this.groupBox6.Controls.Add(this.txtCargaVariavel);
            this.groupBox6.Controls.Add(this.label6);
            this.groupBox6.Controls.Add(this.label7);
            this.groupBox6.Controls.Add(this.txtCargaPermanente);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Location = new System.Drawing.Point(882, 79);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(190, 108);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Carregamento:";
            // 
            // txtPsi2
            // 
            this.txtPsi2.Location = new System.Drawing.Point(86, 82);
            this.txtPsi2.Name = "txtPsi2";
            this.txtPsi2.Size = new System.Drawing.Size(55, 20);
            this.txtPsi2.TabIndex = 7;
            this.txtPsi2.Text = "0.3";
            this.txtPsi2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(58, 85);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(22, 13);
            this.label15.TabIndex = 6;
            this.label15.Text = "Ψ₂:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(147, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "kN/m²";
            // 
            // txtCargaVariavel
            // 
            this.txtCargaVariavel.Location = new System.Drawing.Point(86, 52);
            this.txtCargaVariavel.Name = "txtCargaVariavel";
            this.txtCargaVariavel.Size = new System.Drawing.Size(55, 20);
            this.txtCargaVariavel.TabIndex = 4;
            this.txtCargaVariavel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(32, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Variável:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(147, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "kN/m²";
            // 
            // txtCargaPermanente
            // 
            this.txtCargaPermanente.Location = new System.Drawing.Point(86, 19);
            this.txtCargaPermanente.Name = "txtCargaPermanente";
            this.txtCargaPermanente.Size = new System.Drawing.Size(55, 20);
            this.txtCargaPermanente.TabIndex = 1;
            this.txtCargaPermanente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(1, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Adicional perm:";
            // 
            // groupBox7
            // 
            this.groupBox7.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox7.Controls.Add(this.txtBoxResultados);
            this.groupBox7.Location = new System.Drawing.Point(584, 246);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(488, 403);
            this.groupBox7.TabIndex = 3;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Resultados:";
            // 
            // txtBoxResultados
            // 
            this.txtBoxResultados.AcceptsTab = true;
            this.txtBoxResultados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxResultados.Location = new System.Drawing.Point(7, 19);
            this.txtBoxResultados.Name = "txtBoxResultados";
            this.txtBoxResultados.ReadOnly = true;
            this.txtBoxResultados.Size = new System.Drawing.Size(475, 378);
            this.txtBoxResultados.TabIndex = 0;
            this.txtBoxResultados.Text = "";
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(430, 573);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(148, 35);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(431, 614);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(147, 35);
            this.btnSair.TabIndex = 9;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // comboCAA
            // 
            this.comboCAA.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboCAA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboCAA.FormattingEnabled = true;
            this.comboCAA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboCAA.Items.AddRange(new object[] {
            "CAA-I",
            "CAA-II",
            "CAA-III",
            "CAA-IV"});
            this.comboCAA.Location = new System.Drawing.Point(12, 19);
            this.comboCAA.MaxDropDownItems = 3;
            this.comboCAA.Name = "comboCAA";
            this.comboCAA.Size = new System.Drawing.Size(149, 21);
            this.comboCAA.TabIndex = 4;
            this.comboCAA.SelectedIndexChanged += new System.EventHandler(this.comboCAA_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(167, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 13);
            this.label9.TabIndex = 5;
            this.label9.Text = "Cobrimento:";
            // 
            // txtCobrimento
            // 
            this.txtCobrimento.Location = new System.Drawing.Point(230, 19);
            this.txtCobrimento.Name = "txtCobrimento";
            this.txtCobrimento.ReadOnly = true;
            this.txtCobrimento.Size = new System.Drawing.Size(56, 20);
            this.txtCobrimento.TabIndex = 6;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(292, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(21, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "cm";
            // 
            // chkCobrimento
            // 
            this.chkCobrimento.AutoSize = true;
            this.chkCobrimento.Location = new System.Drawing.Point(325, 22);
            this.chkCobrimento.Name = "chkCobrimento";
            this.chkCobrimento.Size = new System.Drawing.Size(157, 17);
            this.chkCobrimento.TabIndex = 8;
            this.chkCobrimento.Text = "Ignorar cobrimento sugerido";
            this.chkCobrimento.UseVisualStyleBackColor = true;
            this.chkCobrimento.CheckedChanged += new System.EventHandler(this.chkCobrimento_CheckedChanged);
            // 
            // groupBox9
            // 
            this.groupBox9.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox9.Controls.Add(this.chkCobrimento);
            this.groupBox9.Controls.Add(this.label10);
            this.groupBox9.Controls.Add(this.txtCobrimento);
            this.groupBox9.Controls.Add(this.label9);
            this.groupBox9.Controls.Add(this.comboCAA);
            this.groupBox9.Location = new System.Drawing.Point(584, 193);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(488, 47);
            this.groupBox9.TabIndex = 6;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Classe de Agressividade Ambiental:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::LajesCA.Properties.Resources.deciv;
            this.pictureBox1.Location = new System.Drawing.Point(13, 513);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(410, 136);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.SystemColors.Control;
            this.groupBox8.Controls.Add(this.comboRigidez);
            this.groupBox8.Location = new System.Drawing.Point(431, 513);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(147, 52);
            this.groupBox8.TabIndex = 5;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Inércia no estádio II:";
            // 
            // comboRigidez
            // 
            this.comboRigidez.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.comboRigidez.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboRigidez.Enabled = false;
            this.comboRigidez.FormattingEnabled = true;
            this.comboRigidez.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comboRigidez.Items.AddRange(new object[] {
            "0.30 Ic",
            "Fórmula de Branson"});
            this.comboRigidez.Location = new System.Drawing.Point(12, 19);
            this.comboRigidez.MaxDropDownItems = 3;
            this.comboRigidez.Name = "comboRigidez";
            this.comboRigidez.Size = new System.Drawing.Size(121, 21);
            this.comboRigidez.TabIndex = 4;
            // 
            // formPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 661);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "formPrincipal";
            this.Text = "Calculadora de Lajes";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grauEngasteFundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grauEngasteEsquerda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grauEngasteDireita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grauEngasteTopo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgEsquerda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgDireita)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgFundo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgTopo)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboTipoAco;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox comboClasseConcreto;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVaoHorizontal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtVaoVertical;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCargaVariavel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCargaPermanente;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RichTextBox txtBoxResultados;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.ComboBox comboCAA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtCobrimento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox chkCobrimento;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox imgTopo;
        private System.Windows.Forms.PictureBox imgEsquerda;
        private System.Windows.Forms.PictureBox imgDireita;
        private System.Windows.Forms.PictureBox imgFundo;
        private System.Windows.Forms.ComboBox comboTopo;
        private System.Windows.Forms.ComboBox comboEsquerda;
        private System.Windows.Forms.ComboBox comboFundo;
        private System.Windows.Forms.ComboBox comboDireita;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.NumericUpDown grauEngasteTopo;
        private System.Windows.Forms.NumericUpDown grauEngasteFundo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.NumericUpDown grauEngasteEsquerda;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown grauEngasteDireita;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtPsi2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtHInicial;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ComboBox comboRigidez;
    }
}

