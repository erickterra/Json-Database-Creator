namespace Json_Database_Creator
{
    partial class Consumables
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
            this.label1 = new System.Windows.Forms.Label();
            this.fomeUpDown = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.sedeUpDown = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.cansacoUpDown = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.saudeUpDown = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.cannedCheck = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.fomeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedeUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cansacoUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.saudeUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fome";
            // 
            // fomeUpDown
            // 
            this.fomeUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.fomeUpDown.Location = new System.Drawing.Point(69, 12);
            this.fomeUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.fomeUpDown.Name = "fomeUpDown";
            this.fomeUpDown.Size = new System.Drawing.Size(39, 20);
            this.fomeUpDown.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Sede";
            // 
            // sedeUpDown
            // 
            this.sedeUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.sedeUpDown.Location = new System.Drawing.Point(69, 38);
            this.sedeUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.sedeUpDown.Name = "sedeUpDown";
            this.sedeUpDown.Size = new System.Drawing.Size(39, 20);
            this.sedeUpDown.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cansaço";
            // 
            // cansacoUpDown
            // 
            this.cansacoUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.cansacoUpDown.Location = new System.Drawing.Point(69, 64);
            this.cansacoUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.cansacoUpDown.Name = "cansacoUpDown";
            this.cansacoUpDown.Size = new System.Drawing.Size(39, 20);
            this.cansacoUpDown.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Saude";
            // 
            // saudeUpDown
            // 
            this.saudeUpDown.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.saudeUpDown.Location = new System.Drawing.Point(69, 90);
            this.saudeUpDown.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.saudeUpDown.Name = "saudeUpDown";
            this.saudeUpDown.Size = new System.Drawing.Size(39, 20);
            this.saudeUpDown.TabIndex = 4;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 57);
            this.button1.TabIndex = 6;
            this.button1.Text = "Finalizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // cannedCheck
            // 
            this.cannedCheck.AutoSize = true;
            this.cannedCheck.Location = new System.Drawing.Point(16, 134);
            this.cannedCheck.Name = "cannedCheck";
            this.cannedCheck.Size = new System.Drawing.Size(63, 17);
            this.cannedCheck.TabIndex = 5;
            this.cannedCheck.Text = "Canned";
            this.cannedCheck.UseVisualStyleBackColor = true;
            // 
            // Consumables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 238);
            this.ControlBox = false;
            this.Controls.Add(this.cannedCheck);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.saudeUpDown);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cansacoUpDown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sedeUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.fomeUpDown);
            this.Controls.Add(this.label1);
            this.Name = "Consumables";
            this.Text = "Consumables";
            this.Load += new System.EventHandler(this.Consumables_Load);
            ((System.ComponentModel.ISupportInitialize)(this.fomeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sedeUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cansacoUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.saudeUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown fomeUpDown;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown sedeUpDown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown cansacoUpDown;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown saudeUpDown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cannedCheck;
    }
}