
namespace AdamMatthew.TeaRoundPicket.UI
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonRandom = new System.Windows.Forms.RadioButton();
            this.radioButtonNextInOrder = new System.Windows.Forms.RadioButton();
            this.radioButtonManual = new System.Windows.Forms.RadioButton();
            this.radioButtonNextStatistically = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxParticipants = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.labelParticipant = new System.Windows.Forms.Label();
            this.labelTeaBrand = new System.Windows.Forms.Label();
            this.comboBoxTeaBrands = new System.Windows.Forms.ComboBox();
            this.checkBoxAddMilk = new System.Windows.Forms.CheckBox();
            this.checkBoxAddSugar = new System.Windows.Forms.CheckBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxParticipants = new System.Windows.Forms.ListBox();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Selection criterion:";
            // 
            // radioButtonRandom
            // 
            this.radioButtonRandom.AutoSize = true;
            this.radioButtonRandom.Checked = true;
            this.radioButtonRandom.Location = new System.Drawing.Point(132, 88);
            this.radioButtonRandom.Name = "radioButtonRandom";
            this.radioButtonRandom.Size = new System.Drawing.Size(70, 19);
            this.radioButtonRandom.TabIndex = 1;
            this.radioButtonRandom.TabStop = true;
            this.radioButtonRandom.Text = "Random";
            this.radioButtonRandom.UseVisualStyleBackColor = true;
            this.radioButtonRandom.Click += new System.EventHandler(this.radioButtonRandom_Click);
            // 
            // radioButtonNextInOrder
            // 
            this.radioButtonNextInOrder.AutoSize = true;
            this.radioButtonNextInOrder.Location = new System.Drawing.Point(208, 90);
            this.radioButtonNextInOrder.Name = "radioButtonNextInOrder";
            this.radioButtonNextInOrder.Size = new System.Drawing.Size(96, 19);
            this.radioButtonNextInOrder.TabIndex = 2;
            this.radioButtonNextInOrder.Text = "Next in Order";
            this.radioButtonNextInOrder.UseVisualStyleBackColor = true;
            this.radioButtonNextInOrder.Click += new System.EventHandler(this.radioButtonNextInOrder_Click);
            // 
            // radioButtonManual
            // 
            this.radioButtonManual.AutoSize = true;
            this.radioButtonManual.Location = new System.Drawing.Point(427, 90);
            this.radioButtonManual.Name = "radioButtonManual";
            this.radioButtonManual.Size = new System.Drawing.Size(65, 19);
            this.radioButtonManual.TabIndex = 3;
            this.radioButtonManual.Text = "Manual";
            this.radioButtonManual.UseVisualStyleBackColor = true;
            this.radioButtonManual.Click += new System.EventHandler(this.radioButtonManual_Click);
            // 
            // radioButtonNextStatistically
            // 
            this.radioButtonNextStatistically.AutoSize = true;
            this.radioButtonNextStatistically.Location = new System.Drawing.Point(311, 90);
            this.radioButtonNextStatistically.Name = "radioButtonNextStatistically";
            this.radioButtonNextStatistically.Size = new System.Drawing.Size(112, 19);
            this.radioButtonNextStatistically.TabIndex = 4;
            this.radioButtonNextStatistically.Text = "Next Statistically";
            this.radioButtonNextStatistically.UseVisualStyleBackColor = true;
            this.radioButtonNextStatistically.Click += new System.EventHandler(this.radioButtonNextStatistically_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Proposed tea maker:";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(512, 264);
            this.tabControl.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonAccept);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.comboBoxParticipants);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.radioButtonRandom);
            this.tabPage1.Controls.Add(this.radioButtonNextStatistically);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.radioButtonManual);
            this.tabPage1.Controls.Add(this.radioButtonNextInOrder);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(504, 236);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Tea Maker";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonAccept
            // 
            this.buttonAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAccept.Location = new System.Drawing.Point(417, 119);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(75, 23);
            this.buttonAccept.TabIndex = 9;
            this.buttonAccept.Text = "Accept";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(21, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(351, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Welcome to the AM Tea Round Picker!";
            // 
            // comboBoxParticipants
            // 
            this.comboBoxParticipants.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxParticipants.FormattingEnabled = true;
            this.comboBoxParticipants.Location = new System.Drawing.Point(147, 119);
            this.comboBoxParticipants.Name = "comboBoxParticipants";
            this.comboBoxParticipants.Size = new System.Drawing.Size(255, 23);
            this.comboBoxParticipants.TabIndex = 7;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.labelParticipant);
            this.tabPage2.Controls.Add(this.labelTeaBrand);
            this.tabPage2.Controls.Add(this.comboBoxTeaBrands);
            this.tabPage2.Controls.Add(this.checkBoxAddMilk);
            this.tabPage2.Controls.Add(this.checkBoxAddSugar);
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.listBoxParticipants);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(504, 236);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Participants";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button3.Location = new System.Drawing.Point(274, 199);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(214, 23);
            this.button3.TabIndex = 14;
            this.button3.Text = "Update";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // labelParticipant
            // 
            this.labelParticipant.AutoSize = true;
            this.labelParticipant.Location = new System.Drawing.Point(240, 54);
            this.labelParticipant.Name = "labelParticipant";
            this.labelParticipant.Size = new System.Drawing.Size(124, 15);
            this.labelParticipant.TabIndex = 13;
            this.labelParticipant.Text = "Tea drink preferences :";
            // 
            // labelTeaBrand
            // 
            this.labelTeaBrand.AutoSize = true;
            this.labelTeaBrand.Location = new System.Drawing.Point(274, 143);
            this.labelTeaBrand.Name = "labelTeaBrand";
            this.labelTeaBrand.Size = new System.Drawing.Size(61, 15);
            this.labelTeaBrand.TabIndex = 12;
            this.labelTeaBrand.Text = "Tea brand:";
            // 
            // comboBoxTeaBrands
            // 
            this.comboBoxTeaBrands.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxTeaBrands.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTeaBrands.FormattingEnabled = true;
            this.comboBoxTeaBrands.Items.AddRange(new object[] {
            "Tetley",
            "Twinnings",
            "Lipton",
            "Decaf (Knightsbridge)"});
            this.comboBoxTeaBrands.Location = new System.Drawing.Point(341, 140);
            this.comboBoxTeaBrands.Name = "comboBoxTeaBrands";
            this.comboBoxTeaBrands.Size = new System.Drawing.Size(147, 23);
            this.comboBoxTeaBrands.TabIndex = 11;
            // 
            // checkBoxAddMilk
            // 
            this.checkBoxAddMilk.AutoSize = true;
            this.checkBoxAddMilk.Location = new System.Drawing.Point(274, 108);
            this.checkBoxAddMilk.Name = "checkBoxAddMilk";
            this.checkBoxAddMilk.Size = new System.Drawing.Size(74, 19);
            this.checkBoxAddMilk.TabIndex = 10;
            this.checkBoxAddMilk.Text = "Add milk";
            this.checkBoxAddMilk.UseVisualStyleBackColor = true;
            // 
            // checkBoxAddSugar
            // 
            this.checkBoxAddSugar.AutoSize = true;
            this.checkBoxAddSugar.Location = new System.Drawing.Point(274, 83);
            this.checkBoxAddSugar.Name = "checkBoxAddSugar";
            this.checkBoxAddSugar.Size = new System.Drawing.Size(80, 19);
            this.checkBoxAddSugar.TabIndex = 9;
            this.checkBoxAddSugar.Text = "Add sugar";
            this.checkBoxAddSugar.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(138, 199);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Remove";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(8, 199);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Add";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 15);
            this.label4.TabIndex = 1;
            this.label4.Text = "Participants";
            // 
            // listBoxParticipants
            // 
            this.listBoxParticipants.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxParticipants.FormattingEnabled = true;
            this.listBoxParticipants.ItemHeight = 15;
            this.listBoxParticipants.Location = new System.Drawing.Point(8, 39);
            this.listBoxParticipants.Name = "listBoxParticipants";
            this.listBoxParticipants.ScrollAlwaysVisible = true;
            this.listBoxParticipants.Size = new System.Drawing.Size(205, 154);
            this.listBoxParticipants.TabIndex = 0;
            this.listBoxParticipants.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 264);
            this.Controls.Add(this.tabControl);
            this.Name = "MainForm";
            this.Text = "Adam Matthew Tea Round Picker";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonRandom;
        private System.Windows.Forms.RadioButton radioButtonNextInOrder;
        private System.Windows.Forms.RadioButton radioButtonManual;
        private System.Windows.Forms.RadioButton radioButtonNextStatistically;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxParticipants;
        private System.Windows.Forms.ComboBox comboBoxParticipants;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelParticipant;
        private System.Windows.Forms.Label labelTeaBrand;
        private System.Windows.Forms.ComboBox comboBoxTeaBrands;
        private System.Windows.Forms.CheckBox checkBoxAddMilk;
        private System.Windows.Forms.CheckBox checkBoxAddSugar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonAccept;
    }
}

