namespace MegaEscritorio
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.m_width = new System.Windows.Forms.TextBox();
            this.m_depth = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.drawers = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.standard = new System.Windows.Forms.RadioButton();
            this.day3 = new System.Windows.Forms.RadioButton();
            this.day5 = new System.Windows.Forms.RadioButton();
            this.day7 = new System.Windows.Forms.RadioButton();
            this.oak = new System.Windows.Forms.RadioButton();
            this.laminate = new System.Windows.Forms.RadioButton();
            this.pine = new System.Windows.Forms.RadioButton();
            this.Material = new System.Windows.Forms.GroupBox();
            this.Shipping = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.quoteBox = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.SeachByMaterial = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.search = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.NameCustomer = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.drawers)).BeginInit();
            this.Material.SuspendLayout();
            this.Shipping.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Width";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Depth";
            // 
            // m_width
            // 
            this.m_width.Location = new System.Drawing.Point(132, 44);
            this.m_width.Name = "m_width";
            this.m_width.Size = new System.Drawing.Size(98, 20);
            this.m_width.TabIndex = 1;
            this.m_width.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m_width_KeyDown);
            // 
            // m_depth
            // 
            this.m_depth.Enabled = false;
            this.m_depth.Location = new System.Drawing.Point(132, 75);
            this.m_depth.Name = "m_depth";
            this.m_depth.Size = new System.Drawing.Size(98, 20);
            this.m_depth.TabIndex = 2;
            this.m_depth.KeyDown += new System.Windows.Forms.KeyEventHandler(this.m_depth_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Number of drawers";
            // 
            // drawers
            // 
            this.drawers.Enabled = false;
            this.drawers.Location = new System.Drawing.Point(164, 180);
            this.drawers.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.drawers.Name = "drawers";
            this.drawers.Size = new System.Drawing.Size(113, 20);
            this.drawers.TabIndex = 7;
            this.drawers.ValueChanged += new System.EventHandler(this.drawers_ValueChanged);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(12, 442);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 36);
            this.button1.TabIndex = 13;
            this.button1.Text = "Get quote";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(230, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(80, 36);
            this.button2.TabIndex = 14;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // standard
            // 
            this.standard.AutoSize = true;
            this.standard.Location = new System.Drawing.Point(8, 29);
            this.standard.Name = "standard";
            this.standard.Size = new System.Drawing.Size(68, 17);
            this.standard.TabIndex = 9;
            this.standard.Text = "Standard";
            this.standard.UseVisualStyleBackColor = true;
            this.standard.CheckedChanged += new System.EventHandler(this.standard_CheckedChanged);
            // 
            // day3
            // 
            this.day3.AutoSize = true;
            this.day3.Location = new System.Drawing.Point(109, 29);
            this.day3.Name = "day3";
            this.day3.Size = new System.Drawing.Size(56, 17);
            this.day3.TabIndex = 10;
            this.day3.Text = "3 days";
            this.day3.UseVisualStyleBackColor = true;
            this.day3.CheckedChanged += new System.EventHandler(this.day3_CheckedChanged);
            // 
            // day5
            // 
            this.day5.AutoSize = true;
            this.day5.Location = new System.Drawing.Point(109, 61);
            this.day5.Name = "day5";
            this.day5.Size = new System.Drawing.Size(56, 17);
            this.day5.TabIndex = 12;
            this.day5.Text = "5 days";
            this.day5.UseVisualStyleBackColor = true;
            this.day5.CheckedChanged += new System.EventHandler(this.day5_CheckedChanged);
            // 
            // day7
            // 
            this.day7.AutoSize = true;
            this.day7.Location = new System.Drawing.Point(7, 61);
            this.day7.Name = "day7";
            this.day7.Size = new System.Drawing.Size(56, 17);
            this.day7.TabIndex = 11;
            this.day7.Text = "7 days";
            this.day7.UseVisualStyleBackColor = true;
            this.day7.CheckedChanged += new System.EventHandler(this.day7_CheckedChanged);
            // 
            // oak
            // 
            this.oak.AutoSize = true;
            this.oak.Location = new System.Drawing.Point(13, 19);
            this.oak.Name = "oak";
            this.oak.Size = new System.Drawing.Size(45, 17);
            this.oak.TabIndex = 4;
            this.oak.Text = "Oak";
            this.oak.UseVisualStyleBackColor = true;
            this.oak.CheckedChanged += new System.EventHandler(this.oak_CheckedChanged);
            // 
            // laminate
            // 
            this.laminate.AutoSize = true;
            this.laminate.Location = new System.Drawing.Point(165, 19);
            this.laminate.Name = "laminate";
            this.laminate.Size = new System.Drawing.Size(68, 17);
            this.laminate.TabIndex = 6;
            this.laminate.Text = "Laminate";
            this.laminate.UseVisualStyleBackColor = true;
            this.laminate.CheckedChanged += new System.EventHandler(this.laminate_CheckedChanged);
            // 
            // pine
            // 
            this.pine.AutoSize = true;
            this.pine.Location = new System.Drawing.Point(89, 19);
            this.pine.Name = "pine";
            this.pine.Size = new System.Drawing.Size(46, 17);
            this.pine.TabIndex = 5;
            this.pine.Text = "Pine";
            this.pine.UseVisualStyleBackColor = true;
            this.pine.CheckedChanged += new System.EventHandler(this.pine_CheckedChanged);
            // 
            // Material
            // 
            this.Material.Controls.Add(this.pine);
            this.Material.Controls.Add(this.oak);
            this.Material.Controls.Add(this.laminate);
            this.Material.Location = new System.Drawing.Point(38, 109);
            this.Material.Name = "Material";
            this.Material.Size = new System.Drawing.Size(239, 60);
            this.Material.TabIndex = 3;
            this.Material.TabStop = false;
            this.Material.Text = "Material";
            // 
            // Shipping
            // 
            this.Shipping.Controls.Add(this.day7);
            this.Shipping.Controls.Add(this.day5);
            this.Shipping.Controls.Add(this.day3);
            this.Shipping.Controls.Add(this.standard);
            this.Shipping.Location = new System.Drawing.Point(63, 217);
            this.Shipping.Name = "Shipping";
            this.Shipping.Size = new System.Drawing.Size(171, 99);
            this.Shipping.TabIndex = 8;
            this.Shipping.TabStop = false;
            this.Shipping.Text = "Shipping";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "in";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(236, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "in";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(90, 334);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Price";
            // 
            // quoteBox
            // 
            this.quoteBox.Location = new System.Drawing.Point(132, 331);
            this.quoteBox.Name = "quoteBox";
            this.quoteBox.ReadOnly = true;
            this.quoteBox.Size = new System.Drawing.Size(78, 20);
            this.quoteBox.TabIndex = 18;
            this.quoteBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(120, 442);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 36);
            this.button3.TabIndex = 19;
            this.button3.Text = "Save quote";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // SeachByMaterial
            // 
            this.SeachByMaterial.FormattingEnabled = true;
            this.SeachByMaterial.Items.AddRange(new object[] {
            "Oak",
            "Pine",
            "Laminate"});
            this.SeachByMaterial.Location = new System.Drawing.Point(132, 374);
            this.SeachByMaterial.Name = "SeachByMaterial";
            this.SeachByMaterial.Size = new System.Drawing.Size(78, 21);
            this.SeachByMaterial.TabIndex = 20;
            this.SeachByMaterial.SelectedIndexChanged += new System.EventHandler(this.SeachByMaterial_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 377);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Search by material";
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(230, 365);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(80, 36);
            this.search.TabIndex = 22;
            this.search.Text = "Search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(43, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Customer name:";
            // 
            // NameCustomer
            // 
            this.NameCustomer.Location = new System.Drawing.Point(132, 17);
            this.NameCustomer.Name = "NameCustomer";
            this.NameCustomer.Size = new System.Drawing.Size(98, 20);
            this.NameCustomer.TabIndex = 24;
            this.NameCustomer.TextChanged += new System.EventHandler(this.NameCustomer_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 502);
            this.Controls.Add(this.NameCustomer);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.search);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.SeachByMaterial);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.quoteBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Shipping);
            this.Controls.Add(this.Material);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.drawers);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.m_depth);
            this.Controls.Add(this.m_width);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Mega Escritorio - Carlos Ortiz";
            ((System.ComponentModel.ISupportInitialize)(this.drawers)).EndInit();
            this.Material.ResumeLayout(false);
            this.Material.PerformLayout();
            this.Shipping.ResumeLayout(false);
            this.Shipping.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_width;
        private System.Windows.Forms.TextBox m_depth;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown drawers;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RadioButton standard;
        private System.Windows.Forms.RadioButton day3;
        private System.Windows.Forms.RadioButton day5;
        private System.Windows.Forms.RadioButton day7;
        private System.Windows.Forms.RadioButton oak;
        private System.Windows.Forms.RadioButton laminate;
        private System.Windows.Forms.RadioButton pine;
        private System.Windows.Forms.GroupBox Material;
        private System.Windows.Forms.GroupBox Shipping;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox quoteBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox SeachByMaterial;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox NameCustomer;
    }
}

