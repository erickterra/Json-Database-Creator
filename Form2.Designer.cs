namespace Json_Database_Creator
{
    partial class Form2
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
            this.button1 = new System.Windows.Forms.Button();
            this.Submit = new System.Windows.Forms.Button();
            this.stackNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.itemStackBox = new System.Windows.Forms.CheckBox();
            this.raridadeComboBox = new System.Windows.Forms.ComboBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.descricaoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tipoLabel = new System.Windows.Forms.Label();
            this.descLabel = new System.Windows.Forms.Label();
            this.nameText = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.stackNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 48);
            this.button1.TabIndex = 20;
            this.button1.Text = "Limpar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(148, 252);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(75, 48);
            this.Submit.TabIndex = 19;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // stackNumericUpDown
            // 
            this.stackNumericUpDown.Enabled = false;
            this.stackNumericUpDown.Location = new System.Drawing.Point(77, 183);
            this.stackNumericUpDown.Name = "stackNumericUpDown";
            this.stackNumericUpDown.Size = new System.Drawing.Size(46, 20);
            this.stackNumericUpDown.TabIndex = 17;
            this.stackNumericUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // itemStackBox
            // 
            this.itemStackBox.AutoSize = true;
            this.itemStackBox.Location = new System.Drawing.Point(15, 158);
            this.itemStackBox.Name = "itemStackBox";
            this.itemStackBox.Size = new System.Drawing.Size(85, 17);
            this.itemStackBox.TabIndex = 16;
            this.itemStackBox.Text = "Is Stackable";
            this.itemStackBox.UseVisualStyleBackColor = true;
            this.itemStackBox.CheckedChanged += new System.EventHandler(this.ItemStackBox_CheckedChanged);
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
            this.raridadeComboBox.Location = new System.Drawing.Point(68, 209);
            this.raridadeComboBox.Name = "raridadeComboBox";
            this.raridadeComboBox.Size = new System.Drawing.Size(86, 21);
            this.raridadeComboBox.TabIndex = 18;
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
            this.typeComboBox.Location = new System.Drawing.Point(54, 131);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(100, 21);
            this.typeComboBox.TabIndex = 15;
            // 
            // descricaoTextBox
            // 
            this.descricaoTextBox.Location = new System.Drawing.Point(54, 65);
            this.descricaoTextBox.Multiline = true;
            this.descricaoTextBox.Name = "descricaoTextBox";
            this.descricaoTextBox.Size = new System.Drawing.Size(169, 60);
            this.descricaoTextBox.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Raridade";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 185);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Stack Size";
            // 
            // tipoLabel
            // 
            this.tipoLabel.AutoSize = true;
            this.tipoLabel.Location = new System.Drawing.Point(12, 134);
            this.tipoLabel.Name = "tipoLabel";
            this.tipoLabel.Size = new System.Drawing.Size(31, 13);
            this.tipoLabel.TabIndex = 10;
            this.tipoLabel.Text = "Type";
            // 
            // descLabel
            // 
            this.descLabel.AutoSize = true;
            this.descLabel.Location = new System.Drawing.Point(13, 68);
            this.descLabel.Name = "descLabel";
            this.descLabel.Size = new System.Drawing.Size(38, 13);
            this.descLabel.TabIndex = 11;
            this.descLabel.Text = "Desc.:";
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(54, 39);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(100, 20);
            this.nameText.TabIndex = 12;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(13, 42);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(35, 13);
            this.nameLabel.TabIndex = 13;
            this.nameLabel.Text = "Name";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(54, 12);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(69, 21);
            this.comboBox1.TabIndex = 21;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.ComboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(18, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "ID";
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(235, 312);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Submit);
            this.Controls.Add(this.stackNumericUpDown);
            this.Controls.Add(this.itemStackBox);
            this.Controls.Add(this.raridadeComboBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.descricaoTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tipoLabel);
            this.Controls.Add(this.descLabel);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nameLabel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form2";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Json Editor";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.stackNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.NumericUpDown stackNumericUpDown;
        private System.Windows.Forms.CheckBox itemStackBox;
        private System.Windows.Forms.ComboBox raridadeComboBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.TextBox descricaoTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tipoLabel;
        private System.Windows.Forms.Label descLabel;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
    }
}
