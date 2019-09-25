namespace Json_Database_Creator
{
    partial class JSonManager
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
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.descLabel = new System.Windows.Forms.Label();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.tipoLabel = new System.Windows.Forms.Label();
            this.itemStackBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.stackNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.raridadeComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.stackNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 13);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Name";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(54, 10);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(100, 20);
            this.nameText.TabIndex = 0;
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(13, 39);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(38, 13);
            this.descLabel.TabIndex = 0;
            this.descLabel.Text = "Desc.:";
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Location = new System.Drawing.Point(54, 36);
            this.descricaoTextBox.Multiline = true;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(169, 60);
            this.descricaoTextBox.TabIndex = 1;
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Consumable",
            "Armor",
            "Weapon",
            "Quest",
            "Junk",
            "Ingredient",
            "Placeable",
            "None",
            "Ammo"});
            this.typeComboBox.Location = new System.Drawing.Point(54, 102);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(100, 21);
            this.typeComboBox.TabIndex = 2;
            // 
            // tipoLabel
            // 
            this.tipoLabel.AutoSize = true;
            this.tipoLabel.Location = new System.Drawing.Point(12, 105);
            this.tipoLabel.Name = "tipoLabel";
            this.tipoLabel.Size = new System.Drawing.Size(31, 13);
            this.tipoLabel.TabIndex = 0;
            this.tipoLabel.Text = "Type";
            // 
            // itemStackBox
            // 
            this.itemStackBox.AutoSize = true;
            this.itemStackBox.Location = new System.Drawing.Point(15, 129);
            this.itemStackBox.Name = "itemStackBox";
            this.itemStackBox.Size = new System.Drawing.Size(85, 17);
            this.itemStackBox.TabIndex = 3;
            this.itemStackBox.Text = "Is Stackable";
            this.itemStackBox.UseVisualStyleBackColor = true;
            this.itemStackBox.CheckedChanged += new System.EventHandler(this.ItemStackBox_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stack Size";
            // 
            // stackNumericUpDown
            // 
            this.stackNumericUpDown.Enabled = false;
            this.stackNumericUpDown.Location = new System.Drawing.Point(77, 154);
            this.stackNumericUpDown.Name = "stackNumericUpDown";
            this.stackNumericUpDown.Size = new System.Drawing.Size(46, 20);
            this.stackNumericUpDown.TabIndex = 4;
            this.stackNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 183);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Raridade";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(148, 230);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 48);
            this.Submit.TabIndex = 6;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 230);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 48);
            this.button1.TabIndex = 7;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // raridadeComboBox
            // 
            this.raridadeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.raridadeComboBox.FormattingEnabled = true;
            this.raridadeComboBox.Items.AddRange(new object[] {
            "Comum",
            "Incomum",
            "Raro",
            "Muito Raro",
            "Lendário",
            "Indropavel"});
            this.raridadeComboBox.Location = new System.Drawing.Point(68, 180);
            this.raridadeComboBox.Name = "raridadeComboBox";
            this.raridadeComboBox.Size = new System.Drawing.Size(86, 21);
            this.raridadeComboBox.TabIndex = 19;
            // 
            // JSonManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(235, 290);
            this.Controls.Add(this.raridadeComboBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.stackNumericUpDown);
            this.Controls.Add(this.itemStackBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tipoLabel);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.nameLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "JSonManager";
            this.Text = "JSon Manager";
            this.Load += new System.EventHandler(this.JSonManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stackNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label tipoLabel;
        private System.Windows.Forms.CheckBox itemStackBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown stackNumericUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox raridadeComboBox;
    }
}

