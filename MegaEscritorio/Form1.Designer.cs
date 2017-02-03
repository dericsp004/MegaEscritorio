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
            this.comSelectDays = new System.Windows.Forms.ComboBox();
            this.comSelectDrawers = new System.Windows.Forms.ComboBox();
            this.txtEnterWidth = new System.Windows.Forms.TextBox();
            this.txtEnterLength = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblDrawers = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.comSelectMaterial = new System.Windows.Forms.ComboBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.buttonCalculate = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comSelectDays
            // 
            this.comSelectDays.FormattingEnabled = true;
            this.comSelectDays.Items.AddRange(new object[] {
            "3 Days",
            "5 Days",
            "7 Days"});
            this.comSelectDays.Location = new System.Drawing.Point(181, 212);
            this.comSelectDays.Name = "comSelectDays";
            this.comSelectDays.Size = new System.Drawing.Size(121, 21);
            this.comSelectDays.TabIndex = 5;
            // 
            // comSelectDrawers
            // 
            this.comSelectDrawers.FormattingEnabled = true;
            this.comSelectDrawers.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.comSelectDrawers.Location = new System.Drawing.Point(181, 145);
            this.comSelectDrawers.Name = "comSelectDrawers";
            this.comSelectDrawers.Size = new System.Drawing.Size(121, 21);
            this.comSelectDrawers.TabIndex = 3;
            // 
            // txtEnterWidth
            // 
            this.txtEnterWidth.Location = new System.Drawing.Point(181, 53);
            this.txtEnterWidth.Name = "txtEnterWidth";
            this.txtEnterWidth.Size = new System.Drawing.Size(100, 20);
            this.txtEnterWidth.TabIndex = 1;
            // 
            // txtEnterLength
            // 
            this.txtEnterLength.Location = new System.Drawing.Point(181, 86);
            this.txtEnterLength.Name = "txtEnterLength";
            this.txtEnterLength.Size = new System.Drawing.Size(100, 20);
            this.txtEnterLength.TabIndex = 2;
            // 
            // lblWidth
            // 
            this.lblWidth.AutoSize = true;
            this.lblWidth.Location = new System.Drawing.Point(66, 53);
            this.lblWidth.Name = "lblWidth";
            this.lblWidth.Size = new System.Drawing.Size(109, 13);
            this.lblWidth.TabIndex = 0;
            this.lblWidth.Text = "Enter Width in Inches";
            // 
            // lblLength
            // 
            this.lblLength.AutoSize = true;
            this.lblLength.Location = new System.Drawing.Point(61, 86);
            this.lblLength.Name = "lblLength";
            this.lblLength.Size = new System.Drawing.Size(114, 13);
            this.lblLength.TabIndex = 0;
            this.lblLength.Text = "Enter Length in Inches";
            // 
            // lblDrawers
            // 
            this.lblDrawers.AutoSize = true;
            this.lblDrawers.Location = new System.Drawing.Point(30, 145);
            this.lblDrawers.Name = "lblDrawers";
            this.lblDrawers.Size = new System.Drawing.Size(145, 13);
            this.lblDrawers.TabIndex = 0;
            this.lblDrawers.Text = "Select the number of drawers";
            // 
            // lblMaterial
            // 
            this.lblMaterial.AutoSize = true;
            this.lblMaterial.Location = new System.Drawing.Point(58, 179);
            this.lblMaterial.Name = "lblMaterial";
            this.lblMaterial.Size = new System.Drawing.Size(117, 13);
            this.lblMaterial.TabIndex = 0;
            this.lblMaterial.Text = "Select the material type";
            // 
            // comSelectMaterial
            // 
            this.comSelectMaterial.FormattingEnabled = true;
            this.comSelectMaterial.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine"});
            this.comSelectMaterial.Location = new System.Drawing.Point(181, 179);
            this.comSelectMaterial.Name = "comSelectMaterial";
            this.comSelectMaterial.Size = new System.Drawing.Size(121, 21);
            this.comSelectMaterial.TabIndex = 4;
            // 
            // lblDays
            // 
            this.lblDays.AutoSize = true;
            this.lblDays.Location = new System.Drawing.Point(73, 213);
            this.lblDays.Name = "lblDays";
            this.lblDays.Size = new System.Drawing.Size(101, 13);
            this.lblDays.TabIndex = 0;
            this.lblDays.Text = "Select delivery days";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 287);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(296, 33);
            this.label7.TabIndex = 12;
            this.label7.Text = "Total will display here";
            // 
            // buttonCalculate
            // 
            this.buttonCalculate.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonCalculate.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonCalculate.Location = new System.Drawing.Point(107, 257);
            this.buttonCalculate.Name = "buttonCalculate";
            this.buttonCalculate.Size = new System.Drawing.Size(130, 23);
            this.buttonCalculate.TabIndex = 6;
            this.buttonCalculate.Text = "Click for Price Estimate";
            this.buttonCalculate.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label6.Location = new System.Drawing.Point(105, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Desk Calculator";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 337);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonCalculate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.comSelectMaterial);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.lblDrawers);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.txtEnterLength);
            this.Controls.Add(this.txtEnterWidth);
            this.Controls.Add(this.comSelectDrawers);
            this.Controls.Add(this.comSelectDays);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comSelectDays;
        private System.Windows.Forms.ComboBox comSelectDrawers;
        private System.Windows.Forms.TextBox txtEnterWidth;
        private System.Windows.Forms.TextBox txtEnterLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblDrawers;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.ComboBox comSelectMaterial;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button buttonCalculate;
        private System.Windows.Forms.Label label6;
    }
}