namespace Lab8_Diego_Pinochet
{
    partial class Form1
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
            this.InitializePanel = new System.Windows.Forms.Panel();
            this.InitializeLabel = new System.Windows.Forms.Label();
            this.InitializeAllLocalsButton = new System.Windows.Forms.Button();
            this.InitializeInfoButton = new System.Windows.Forms.Button();
            this.InitializeAddLocalButton = new System.Windows.Forms.Button();
            this.AddLocalPanel = new System.Windows.Forms.Panel();
            this.DisplayListGoBackButton = new System.Windows.Forms.Button();
            this.DisplayListLocalsTextbox = new System.Windows.Forms.TextBox();
            this.DisplayLocalesLocalesExistentesLabel = new System.Windows.Forms.Label();
            this.InfoPanel = new System.Windows.Forms.Panel();
            this.InfoPanelGoBackButton = new System.Windows.Forms.Button();
            this.InfoPanelChooseButton = new System.Windows.Forms.Button();
            this.InfoPanelDisplayInfoTextBox = new System.Windows.Forms.TextBox();
            this.InfoPanelIdentNumTextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.InfoPanelLabel = new System.Windows.Forms.Label();
            this.DisplayListPanel = new System.Windows.Forms.Panel();
            this.AddLocalChooseButton = new System.Windows.Forms.Button();
            this.AddLocalInvalidCredentialsTextBox = new System.Windows.Forms.TextBox();
            this.AddLocalCreateLocalButton = new System.Windows.Forms.Button();
            this.AddLocalVipTablesCheckBox = new System.Windows.Forms.CheckBox();
            this.AddLocalNumSalaTextBox = new System.Windows.Forms.TextBox();
            this.AddLocalVipTablesLabel = new System.Windows.Forms.Label();
            this.AddLocalNumSalaLabel = new System.Windows.Forms.Label();
            this.AddLocalStoreCatTextBox = new System.Windows.Forms.TextBox();
            this.AddLocalAttentionHourTextbox = new System.Windows.Forms.TextBox();
            this.AddLocalIdentNumTextbox = new System.Windows.Forms.TextBox();
            this.AddLocalOwnerNameTextBox = new System.Windows.Forms.TextBox();
            this.AddLocalStoreCatLabel = new System.Windows.Forms.Label();
            this.AddLocalAttentionHourLabel = new System.Windows.Forms.Label();
            this.AddLocalIdentNumLabel = new System.Windows.Forms.Label();
            this.AddLocalOwnerNameLabel = new System.Windows.Forms.Label();
            this.AddLocalLocalTypeLabel = new System.Windows.Forms.Label();
            this.AddLocalDomainUp = new System.Windows.Forms.DomainUpDown();
            this.AddLocalLabel = new System.Windows.Forms.Label();
            this.InitializePanel.SuspendLayout();
            this.AddLocalPanel.SuspendLayout();
            this.InfoPanel.SuspendLayout();
            this.DisplayListPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // InitializePanel
            // 
            this.InitializePanel.BackColor = System.Drawing.Color.Salmon;
            this.InitializePanel.Controls.Add(this.InitializeLabel);
            this.InitializePanel.Controls.Add(this.InitializeAllLocalsButton);
            this.InitializePanel.Controls.Add(this.InitializeInfoButton);
            this.InitializePanel.Controls.Add(this.InitializeAddLocalButton);
            this.InitializePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InitializePanel.Location = new System.Drawing.Point(0, 0);
            this.InitializePanel.Name = "InitializePanel";
            this.InitializePanel.Size = new System.Drawing.Size(630, 698);
            this.InitializePanel.TabIndex = 0;
            // 
            // InitializeLabel
            // 
            this.InitializeLabel.AutoSize = true;
            this.InitializeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InitializeLabel.Location = new System.Drawing.Point(17, 50);
            this.InitializeLabel.Name = "InitializeLabel";
            this.InitializeLabel.Size = new System.Drawing.Size(601, 58);
            this.InitializeLabel.TabIndex = 3;
            this.InitializeLabel.Text = "Gestión Centro Comercial";
            // 
            // InitializeAllLocalsButton
            // 
            this.InitializeAllLocalsButton.Location = new System.Drawing.Point(220, 521);
            this.InitializeAllLocalsButton.Name = "InitializeAllLocalsButton";
            this.InitializeAllLocalsButton.Size = new System.Drawing.Size(187, 53);
            this.InitializeAllLocalsButton.TabIndex = 2;
            this.InitializeAllLocalsButton.Text = "Todos los Locales";
            this.InitializeAllLocalsButton.UseVisualStyleBackColor = true;
            this.InitializeAllLocalsButton.Click += new System.EventHandler(this.InitializeAllLocalsButton_Click);
            // 
            // InitializeInfoButton
            // 
            this.InitializeInfoButton.Location = new System.Drawing.Point(220, 404);
            this.InitializeInfoButton.Name = "InitializeInfoButton";
            this.InitializeInfoButton.Size = new System.Drawing.Size(187, 53);
            this.InitializeInfoButton.TabIndex = 1;
            this.InitializeInfoButton.Text = "Revisar Información";
            this.InitializeInfoButton.UseVisualStyleBackColor = true;
            this.InitializeInfoButton.Click += new System.EventHandler(this.InitializeInfoButton_Click);
            // 
            // InitializeAddLocalButton
            // 
            this.InitializeAddLocalButton.Location = new System.Drawing.Point(220, 287);
            this.InitializeAddLocalButton.Name = "InitializeAddLocalButton";
            this.InitializeAddLocalButton.Size = new System.Drawing.Size(187, 53);
            this.InitializeAddLocalButton.TabIndex = 0;
            this.InitializeAddLocalButton.Text = "Agregar Local";
            this.InitializeAddLocalButton.UseVisualStyleBackColor = true;
            this.InitializeAddLocalButton.Click += new System.EventHandler(this.InitializeAddLocalButton_Click);
            // 
            // AddLocalPanel
            // 
            this.AddLocalPanel.BackColor = System.Drawing.Color.Salmon;
            this.AddLocalPanel.Controls.Add(this.DisplayListGoBackButton);
            this.AddLocalPanel.Controls.Add(this.DisplayListLocalsTextbox);
            this.AddLocalPanel.Controls.Add(this.DisplayLocalesLocalesExistentesLabel);
            this.AddLocalPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddLocalPanel.Location = new System.Drawing.Point(0, 0);
            this.AddLocalPanel.Name = "AddLocalPanel";
            this.AddLocalPanel.Size = new System.Drawing.Size(630, 698);
            this.AddLocalPanel.TabIndex = 1;
            // 
            // DisplayListGoBackButton
            // 
            this.DisplayListGoBackButton.Location = new System.Drawing.Point(20, 17);
            this.DisplayListGoBackButton.Name = "DisplayListGoBackButton";
            this.DisplayListGoBackButton.Size = new System.Drawing.Size(95, 41);
            this.DisplayListGoBackButton.TabIndex = 2;
            this.DisplayListGoBackButton.Text = "Go Back";
            this.DisplayListGoBackButton.UseVisualStyleBackColor = true;
            this.DisplayListGoBackButton.Click += new System.EventHandler(this.DisplayListGoBackButton_Click);
            // 
            // DisplayListLocalsTextbox
            // 
            this.DisplayListLocalsTextbox.AcceptsReturn = true;
            this.DisplayListLocalsTextbox.AcceptsTab = true;
            this.DisplayListLocalsTextbox.BackColor = System.Drawing.Color.Salmon;
            this.DisplayListLocalsTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayListLocalsTextbox.Location = new System.Drawing.Point(103, 177);
            this.DisplayListLocalsTextbox.Multiline = true;
            this.DisplayListLocalsTextbox.Name = "DisplayListLocalsTextbox";
            this.DisplayListLocalsTextbox.ReadOnly = true;
            this.DisplayListLocalsTextbox.Size = new System.Drawing.Size(435, 396);
            this.DisplayListLocalsTextbox.TabIndex = 100;
            // 
            // DisplayLocalesLocalesExistentesLabel
            // 
            this.DisplayLocalesLocalesExistentesLabel.AutoSize = true;
            this.DisplayLocalesLocalesExistentesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisplayLocalesLocalesExistentesLabel.Location = new System.Drawing.Point(96, 69);
            this.DisplayLocalesLocalesExistentesLabel.Name = "DisplayLocalesLocalesExistentesLabel";
            this.DisplayLocalesLocalesExistentesLabel.Size = new System.Drawing.Size(442, 58);
            this.DisplayLocalesLocalesExistentesLabel.TabIndex = 0;
            this.DisplayLocalesLocalesExistentesLabel.Text = "Locales Existentes";
            // 
            // InfoPanel
            // 
            this.InfoPanel.BackColor = System.Drawing.Color.Salmon;
            this.InfoPanel.Controls.Add(this.InfoPanelGoBackButton);
            this.InfoPanel.Controls.Add(this.InfoPanelChooseButton);
            this.InfoPanel.Controls.Add(this.InfoPanelDisplayInfoTextBox);
            this.InfoPanel.Controls.Add(this.InfoPanelIdentNumTextbox);
            this.InfoPanel.Controls.Add(this.label1);
            this.InfoPanel.Controls.Add(this.InfoPanelLabel);
            this.InfoPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InfoPanel.Location = new System.Drawing.Point(0, 0);
            this.InfoPanel.Name = "InfoPanel";
            this.InfoPanel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.InfoPanel.Size = new System.Drawing.Size(630, 698);
            this.InfoPanel.TabIndex = 2;
            // 
            // InfoPanelGoBackButton
            // 
            this.InfoPanelGoBackButton.Location = new System.Drawing.Point(12, 17);
            this.InfoPanelGoBackButton.Name = "InfoPanelGoBackButton";
            this.InfoPanelGoBackButton.Size = new System.Drawing.Size(103, 38);
            this.InfoPanelGoBackButton.TabIndex = 5;
            this.InfoPanelGoBackButton.Text = "Volver";
            this.InfoPanelGoBackButton.UseVisualStyleBackColor = true;
            this.InfoPanelGoBackButton.Click += new System.EventHandler(this.InfoPanelGoBackButton_Click);
            // 
            // InfoPanelChooseButton
            // 
            this.InfoPanelChooseButton.Location = new System.Drawing.Point(349, 234);
            this.InfoPanelChooseButton.Name = "InfoPanelChooseButton";
            this.InfoPanelChooseButton.Size = new System.Drawing.Size(73, 36);
            this.InfoPanelChooseButton.TabIndex = 4;
            this.InfoPanelChooseButton.Text = "Elegir";
            this.InfoPanelChooseButton.UseVisualStyleBackColor = true;
            this.InfoPanelChooseButton.Click += new System.EventHandler(this.InfoPanelChooseButton_Click);
            // 
            // InfoPanelDisplayInfoTextBox
            // 
            this.InfoPanelDisplayInfoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoPanelDisplayInfoTextBox.Location = new System.Drawing.Point(39, 338);
            this.InfoPanelDisplayInfoTextBox.Multiline = true;
            this.InfoPanelDisplayInfoTextBox.Name = "InfoPanelDisplayInfoTextBox";
            this.InfoPanelDisplayInfoTextBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.InfoPanelDisplayInfoTextBox.Size = new System.Drawing.Size(572, 53);
            this.InfoPanelDisplayInfoTextBox.TabIndex = 3;
            this.InfoPanelDisplayInfoTextBox.Visible = false;
            // 
            // InfoPanelIdentNumTextbox
            // 
            this.InfoPanelIdentNumTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoPanelIdentNumTextbox.Location = new System.Drawing.Point(260, 234);
            this.InfoPanelIdentNumTextbox.Name = "InfoPanelIdentNumTextbox";
            this.InfoPanelIdentNumTextbox.Size = new System.Drawing.Size(83, 36);
            this.InfoPanelIdentNumTextbox.TabIndex = 2;
            this.InfoPanelIdentNumTextbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(91, 180);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(463, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Escribe el numero identificador del local";
            // 
            // InfoPanelLabel
            // 
            this.InfoPanelLabel.AutoSize = true;
            this.InfoPanelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InfoPanelLabel.Location = new System.Drawing.Point(67, 80);
            this.InfoPanelLabel.Name = "InfoPanelLabel";
            this.InfoPanelLabel.Size = new System.Drawing.Size(529, 58);
            this.InfoPanelLabel.TabIndex = 0;
            this.InfoPanelLabel.Text = "Información Específica";
            // 
            // DisplayListPanel
            // 
            this.DisplayListPanel.BackColor = System.Drawing.Color.Salmon;
            this.DisplayListPanel.Controls.Add(this.AddLocalChooseButton);
            this.DisplayListPanel.Controls.Add(this.AddLocalInvalidCredentialsTextBox);
            this.DisplayListPanel.Controls.Add(this.AddLocalCreateLocalButton);
            this.DisplayListPanel.Controls.Add(this.AddLocalVipTablesCheckBox);
            this.DisplayListPanel.Controls.Add(this.AddLocalNumSalaTextBox);
            this.DisplayListPanel.Controls.Add(this.AddLocalVipTablesLabel);
            this.DisplayListPanel.Controls.Add(this.AddLocalNumSalaLabel);
            this.DisplayListPanel.Controls.Add(this.AddLocalStoreCatTextBox);
            this.DisplayListPanel.Controls.Add(this.AddLocalAttentionHourTextbox);
            this.DisplayListPanel.Controls.Add(this.AddLocalIdentNumTextbox);
            this.DisplayListPanel.Controls.Add(this.AddLocalOwnerNameTextBox);
            this.DisplayListPanel.Controls.Add(this.AddLocalStoreCatLabel);
            this.DisplayListPanel.Controls.Add(this.AddLocalAttentionHourLabel);
            this.DisplayListPanel.Controls.Add(this.AddLocalIdentNumLabel);
            this.DisplayListPanel.Controls.Add(this.AddLocalOwnerNameLabel);
            this.DisplayListPanel.Controls.Add(this.AddLocalLocalTypeLabel);
            this.DisplayListPanel.Controls.Add(this.AddLocalDomainUp);
            this.DisplayListPanel.Controls.Add(this.AddLocalLabel);
            this.DisplayListPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DisplayListPanel.Location = new System.Drawing.Point(0, 0);
            this.DisplayListPanel.Name = "DisplayListPanel";
            this.DisplayListPanel.Size = new System.Drawing.Size(630, 698);
            this.DisplayListPanel.TabIndex = 3;
            // 
            // AddLocalChooseButton
            // 
            this.AddLocalChooseButton.Location = new System.Drawing.Point(503, 373);
            this.AddLocalChooseButton.Name = "AddLocalChooseButton";
            this.AddLocalChooseButton.Size = new System.Drawing.Size(59, 36);
            this.AddLocalChooseButton.TabIndex = 20;
            this.AddLocalChooseButton.Text = "Elegir";
            this.AddLocalChooseButton.UseVisualStyleBackColor = true;
            this.AddLocalChooseButton.Click += new System.EventHandler(this.AddLocalChooseButton_Click);
            // 
            // AddLocalInvalidCredentialsTextBox
            // 
            this.AddLocalInvalidCredentialsTextBox.BackColor = System.Drawing.Color.Salmon;
            this.AddLocalInvalidCredentialsTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AddLocalInvalidCredentialsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLocalInvalidCredentialsTextBox.Location = new System.Drawing.Point(39, 642);
            this.AddLocalInvalidCredentialsTextBox.Name = "AddLocalInvalidCredentialsTextBox";
            this.AddLocalInvalidCredentialsTextBox.Size = new System.Drawing.Size(350, 20);
            this.AddLocalInvalidCredentialsTextBox.TabIndex = 19;
            // 
            // AddLocalCreateLocalButton
            // 
            this.AddLocalCreateLocalButton.Location = new System.Drawing.Point(418, 637);
            this.AddLocalCreateLocalButton.Name = "AddLocalCreateLocalButton";
            this.AddLocalCreateLocalButton.Size = new System.Drawing.Size(193, 33);
            this.AddLocalCreateLocalButton.TabIndex = 18;
            this.AddLocalCreateLocalButton.Text = "Agregar Local";
            this.AddLocalCreateLocalButton.UseVisualStyleBackColor = true;
            this.AddLocalCreateLocalButton.Click += new System.EventHandler(this.AddLocalCreateLocalButton_Click);
            // 
            // AddLocalVipTablesCheckBox
            // 
            this.AddLocalVipTablesCheckBox.AutoSize = true;
            this.AddLocalVipTablesCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLocalVipTablesCheckBox.Location = new System.Drawing.Point(301, 477);
            this.AddLocalVipTablesCheckBox.Name = "AddLocalVipTablesCheckBox";
            this.AddLocalVipTablesCheckBox.Size = new System.Drawing.Size(238, 33);
            this.AddLocalVipTablesCheckBox.TabIndex = 17;
            this.AddLocalVipTablesCheckBox.Text = "Mesas Exclusivas";
            this.AddLocalVipTablesCheckBox.UseVisualStyleBackColor = true;
            this.AddLocalVipTablesCheckBox.Visible = false;
            // 
            // AddLocalNumSalaTextBox
            // 
            this.AddLocalNumSalaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLocalNumSalaTextBox.Location = new System.Drawing.Point(315, 478);
            this.AddLocalNumSalaTextBox.Name = "AddLocalNumSalaTextBox";
            this.AddLocalNumSalaTextBox.Size = new System.Drawing.Size(45, 36);
            this.AddLocalNumSalaTextBox.TabIndex = 16;
            this.AddLocalNumSalaTextBox.Visible = false;
            // 
            // AddLocalVipTablesLabel
            // 
            this.AddLocalVipTablesLabel.AutoSize = true;
            this.AddLocalVipTablesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLocalVipTablesLabel.Location = new System.Drawing.Point(39, 477);
            this.AddLocalVipTablesLabel.Name = "AddLocalVipTablesLabel";
            this.AddLocalVipTablesLabel.Size = new System.Drawing.Size(223, 29);
            this.AddLocalVipTablesLabel.TabIndex = 15;
            this.AddLocalVipTablesLabel.Text = "Mesas Exclusivas:";
            this.AddLocalVipTablesLabel.Visible = false;
            // 
            // AddLocalNumSalaLabel
            // 
            this.AddLocalNumSalaLabel.AutoSize = true;
            this.AddLocalNumSalaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLocalNumSalaLabel.Location = new System.Drawing.Point(34, 478);
            this.AddLocalNumSalaLabel.Name = "AddLocalNumSalaLabel";
            this.AddLocalNumSalaLabel.Size = new System.Drawing.Size(203, 29);
            this.AddLocalNumSalaLabel.TabIndex = 14;
            this.AddLocalNumSalaLabel.Text = "Número de Sala:";
            this.AddLocalNumSalaLabel.Visible = false;
            // 
            // AddLocalStoreCatTextBox
            // 
            this.AddLocalStoreCatTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLocalStoreCatTextBox.Location = new System.Drawing.Point(315, 475);
            this.AddLocalStoreCatTextBox.Name = "AddLocalStoreCatTextBox";
            this.AddLocalStoreCatTextBox.Size = new System.Drawing.Size(234, 36);
            this.AddLocalStoreCatTextBox.TabIndex = 13;
            this.AddLocalStoreCatTextBox.Visible = false;
            // 
            // AddLocalAttentionHourTextbox
            // 
            this.AddLocalAttentionHourTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLocalAttentionHourTextbox.Location = new System.Drawing.Point(315, 295);
            this.AddLocalAttentionHourTextbox.Name = "AddLocalAttentionHourTextbox";
            this.AddLocalAttentionHourTextbox.Size = new System.Drawing.Size(247, 36);
            this.AddLocalAttentionHourTextbox.TabIndex = 12;
            // 
            // AddLocalIdentNumTextbox
            // 
            this.AddLocalIdentNumTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLocalIdentNumTextbox.Location = new System.Drawing.Point(315, 220);
            this.AddLocalIdentNumTextbox.Name = "AddLocalIdentNumTextbox";
            this.AddLocalIdentNumTextbox.Size = new System.Drawing.Size(247, 36);
            this.AddLocalIdentNumTextbox.TabIndex = 11;
            // 
            // AddLocalOwnerNameTextBox
            // 
            this.AddLocalOwnerNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLocalOwnerNameTextBox.Location = new System.Drawing.Point(315, 141);
            this.AddLocalOwnerNameTextBox.Name = "AddLocalOwnerNameTextBox";
            this.AddLocalOwnerNameTextBox.Size = new System.Drawing.Size(247, 36);
            this.AddLocalOwnerNameTextBox.TabIndex = 10;
            // 
            // AddLocalStoreCatLabel
            // 
            this.AddLocalStoreCatLabel.AutoSize = true;
            this.AddLocalStoreCatLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLocalStoreCatLabel.Location = new System.Drawing.Point(34, 478);
            this.AddLocalStoreCatLabel.Name = "AddLocalStoreCatLabel";
            this.AddLocalStoreCatLabel.Size = new System.Drawing.Size(275, 29);
            this.AddLocalStoreCatLabel.TabIndex = 9;
            this.AddLocalStoreCatLabel.Text = "Categoría de la Tienda:";
            this.AddLocalStoreCatLabel.Visible = false;
            // 
            // AddLocalAttentionHourLabel
            // 
            this.AddLocalAttentionHourLabel.AutoSize = true;
            this.AddLocalAttentionHourLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLocalAttentionHourLabel.Location = new System.Drawing.Point(34, 298);
            this.AddLocalAttentionHourLabel.Name = "AddLocalAttentionHourLabel";
            this.AddLocalAttentionHourLabel.Size = new System.Drawing.Size(240, 29);
            this.AddLocalAttentionHourLabel.TabIndex = 6;
            this.AddLocalAttentionHourLabel.Text = "Horario de atención:";
            // 
            // AddLocalIdentNumLabel
            // 
            this.AddLocalIdentNumLabel.AutoSize = true;
            this.AddLocalIdentNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLocalIdentNumLabel.Location = new System.Drawing.Point(34, 223);
            this.AddLocalIdentNumLabel.Name = "AddLocalIdentNumLabel";
            this.AddLocalIdentNumLabel.Size = new System.Drawing.Size(254, 29);
            this.AddLocalIdentNumLabel.TabIndex = 5;
            this.AddLocalIdentNumLabel.Text = "Número identificador:";
            // 
            // AddLocalOwnerNameLabel
            // 
            this.AddLocalOwnerNameLabel.AutoSize = true;
            this.AddLocalOwnerNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLocalOwnerNameLabel.Location = new System.Drawing.Point(34, 144);
            this.AddLocalOwnerNameLabel.Name = "AddLocalOwnerNameLabel";
            this.AddLocalOwnerNameLabel.Size = new System.Drawing.Size(232, 29);
            this.AddLocalOwnerNameLabel.TabIndex = 4;
            this.AddLocalOwnerNameLabel.Text = "Nombre del Dueño:";
            // 
            // AddLocalLocalTypeLabel
            // 
            this.AddLocalLocalTypeLabel.AutoSize = true;
            this.AddLocalLocalTypeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLocalLocalTypeLabel.Location = new System.Drawing.Point(34, 375);
            this.AddLocalLocalTypeLabel.Name = "AddLocalLocalTypeLabel";
            this.AddLocalLocalTypeLabel.Size = new System.Drawing.Size(247, 29);
            this.AddLocalLocalTypeLabel.TabIndex = 3;
            this.AddLocalLocalTypeLabel.Text = "Elige el tipo de local:";
            // 
            // AddLocalDomainUp
            // 
            this.AddLocalDomainUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLocalDomainUp.Items.Add("Tienda");
            this.AddLocalDomainUp.Items.Add("Cine");
            this.AddLocalDomainUp.Items.Add("Restaurant");
            this.AddLocalDomainUp.Location = new System.Drawing.Point(315, 373);
            this.AddLocalDomainUp.Name = "AddLocalDomainUp";
            this.AddLocalDomainUp.Size = new System.Drawing.Size(189, 36);
            this.AddLocalDomainUp.TabIndex = 2;
            this.AddLocalDomainUp.Text = "Tipo de Local:";
            // 
            // AddLocalLabel
            // 
            this.AddLocalLabel.AutoSize = true;
            this.AddLocalLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddLocalLabel.Location = new System.Drawing.Point(167, 44);
            this.AddLocalLabel.Name = "AddLocalLabel";
            this.AddLocalLabel.Size = new System.Drawing.Size(337, 58);
            this.AddLocalLabel.TabIndex = 1;
            this.AddLocalLabel.Text = "Agregar Local";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(630, 698);
            this.Controls.Add(this.InitializePanel);
            this.Controls.Add(this.AddLocalPanel);
            this.Controls.Add(this.DisplayListPanel);
            this.Controls.Add(this.InfoPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.InitializePanel.ResumeLayout(false);
            this.InitializePanel.PerformLayout();
            this.AddLocalPanel.ResumeLayout(false);
            this.AddLocalPanel.PerformLayout();
            this.InfoPanel.ResumeLayout(false);
            this.InfoPanel.PerformLayout();
            this.DisplayListPanel.ResumeLayout(false);
            this.DisplayListPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel InitializePanel;
        private System.Windows.Forms.Label InitializeLabel;
        private System.Windows.Forms.Button InitializeAllLocalsButton;
        private System.Windows.Forms.Button InitializeInfoButton;
        private System.Windows.Forms.Button InitializeAddLocalButton;
        private System.Windows.Forms.Panel AddLocalPanel;
        private System.Windows.Forms.Panel InfoPanel;
        private System.Windows.Forms.Panel DisplayListPanel;
        private System.Windows.Forms.Label AddLocalLocalTypeLabel;
        private System.Windows.Forms.DomainUpDown AddLocalDomainUp;
        private System.Windows.Forms.Label AddLocalLabel;
        private System.Windows.Forms.Label AddLocalStoreCatLabel;
        private System.Windows.Forms.Label AddLocalAttentionHourLabel;
        private System.Windows.Forms.Label AddLocalIdentNumLabel;
        private System.Windows.Forms.Label AddLocalOwnerNameLabel;
        private System.Windows.Forms.TextBox AddLocalStoreCatTextBox;
        private System.Windows.Forms.TextBox AddLocalAttentionHourTextbox;
        private System.Windows.Forms.TextBox AddLocalIdentNumTextbox;
        private System.Windows.Forms.TextBox AddLocalOwnerNameTextBox;
        private System.Windows.Forms.CheckBox AddLocalVipTablesCheckBox;
        private System.Windows.Forms.TextBox AddLocalNumSalaTextBox;
        private System.Windows.Forms.Label AddLocalVipTablesLabel;
        private System.Windows.Forms.Label AddLocalNumSalaLabel;
        private System.Windows.Forms.Button AddLocalCreateLocalButton;
        private System.Windows.Forms.TextBox AddLocalInvalidCredentialsTextBox;
        private System.Windows.Forms.Button AddLocalChooseButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label InfoPanelLabel;
        private System.Windows.Forms.Button InfoPanelGoBackButton;
        private System.Windows.Forms.Button InfoPanelChooseButton;
        private System.Windows.Forms.TextBox InfoPanelDisplayInfoTextBox;
        private System.Windows.Forms.TextBox InfoPanelIdentNumTextbox;
        private System.Windows.Forms.TextBox DisplayListLocalsTextbox;
        private System.Windows.Forms.Label DisplayLocalesLocalesExistentesLabel;
        private System.Windows.Forms.Button DisplayListGoBackButton;
    }
}

