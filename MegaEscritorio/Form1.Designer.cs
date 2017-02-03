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
            this.selDays = new System.Windows.Forms.ComboBox();
            this.selDrawers = new System.Windows.Forms.ComboBox();
            this.deskWidth = new System.Windows.Forms.TextBox();
            this.deskLength = new System.Windows.Forms.TextBox();
            this.lblWidth = new System.Windows.Forms.Label();
            this.lblLength = new System.Windows.Forms.Label();
            this.lblDrawers = new System.Windows.Forms.Label();
            this.lblMaterial = new System.Windows.Forms.Label();
            this.selMaterial = new System.Windows.Forms.ComboBox();
            this.lblDays = new System.Windows.Forms.Label();
            this.displayTotal = new System.Windows.Forms.Label();
            this.runProgram = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // selDays
            // 
            this.selDays.FormattingEnabled = true;
            this.selDays.Items.AddRange(new object[] {
            "3 Days",
            "5 Days",
            "7 Days"});
            this.selDays.Location = new System.Drawing.Point(181, 212);
            this.selDays.Name = "selDays";
            this.selDays.Size = new System.Drawing.Size(121, 21);
            this.selDays.TabIndex = 5;
            // 
            // selDrawers
            // 
            this.selDrawers.FormattingEnabled = true;
            this.selDrawers.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7"});
            this.selDrawers.Location = new System.Drawing.Point(181, 145);
            this.selDrawers.Name = "selDrawers";
            this.selDrawers.Size = new System.Drawing.Size(121, 21);
            this.selDrawers.TabIndex = 3;
            // 
            // deskWidth
            // 
            this.deskWidth.Location = new System.Drawing.Point(181, 53);
            this.deskWidth.Name = "deskWidth";
            this.deskWidth.Size = new System.Drawing.Size(100, 20);
            this.deskWidth.TabIndex = 1;
            // 
            // deskLength
            // 
            this.deskLength.Location = new System.Drawing.Point(181, 86);
            this.deskLength.Name = "deskLength";
            this.deskLength.Size = new System.Drawing.Size(100, 20);
            this.deskLength.TabIndex = 2;
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
            // selMaterial
            // 
            this.selMaterial.FormattingEnabled = true;
            this.selMaterial.Items.AddRange(new object[] {
            "Oak",
            "Laminate",
            "Pine"});
            this.selMaterial.Location = new System.Drawing.Point(181, 179);
            this.selMaterial.Name = "selMaterial";
            this.selMaterial.Size = new System.Drawing.Size(121, 21);
            this.selMaterial.TabIndex = 4;
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
            // displayTotal
            // 
            this.displayTotal.AutoSize = true;
            this.displayTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayTotal.Location = new System.Drawing.Point(34, 287);
            this.displayTotal.Name = "displayTotal";
            this.displayTotal.Size = new System.Drawing.Size(296, 33);
            this.displayTotal.TabIndex = 12;
            this.displayTotal.Text = "Total will display here";
            // 
            // runProgram
            // 
            this.runProgram.BackColor = System.Drawing.SystemColors.Highlight;
            this.runProgram.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.runProgram.Location = new System.Drawing.Point(107, 257);
            this.runProgram.Name = "runProgram";
            this.runProgram.Size = new System.Drawing.Size(130, 23);
            this.runProgram.TabIndex = 6;
            this.runProgram.Text = "Click for Price Estimate";
            this.runProgram.UseVisualStyleBackColor = false;
            this.runProgram.Click += new System.EventHandler(this.runProgram_Click);
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
            this.Controls.Add(this.runProgram);
            this.Controls.Add(this.displayTotal);
            this.Controls.Add(this.lblDays);
            this.Controls.Add(this.selMaterial);
            this.Controls.Add(this.lblMaterial);
            this.Controls.Add(this.lblDrawers);
            this.Controls.Add(this.lblLength);
            this.Controls.Add(this.lblWidth);
            this.Controls.Add(this.deskLength);
            this.Controls.Add(this.deskWidth);
            this.Controls.Add(this.selDrawers);
            this.Controls.Add(this.selDays);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox selDays;
        private System.Windows.Forms.ComboBox selDrawers;
        private System.Windows.Forms.TextBox deskWidth;
        private System.Windows.Forms.TextBox deskLength;
        private System.Windows.Forms.Label lblWidth;
        private System.Windows.Forms.Label lblLength;
        private System.Windows.Forms.Label lblDrawers;
        private System.Windows.Forms.Label lblMaterial;
        private System.Windows.Forms.ComboBox selMaterial;
        private System.Windows.Forms.Label lblDays;
        private System.Windows.Forms.Label displayTotal;
        private System.Windows.Forms.Button runProgram;
        private System.Windows.Forms.Label label6;
    }
}