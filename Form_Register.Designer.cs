namespace Vaccine__final_project_
{
    partial class Form_Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Register));
            this.cmb_place = new System.Windows.Forms.ComboBox();
            this.cmb_vaccineBase = new System.Windows.Forms.ComboBox();
            this.cmb_viccineName = new System.Windows.Forms.ComboBox();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmb_time = new System.Windows.Forms.ComboBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lbl_Address = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numericUpDown_X = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown_Y = new System.Windows.Forms.NumericUpDown();
            this.ch_checkCoordinates = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_X)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Y)).BeginInit();
            this.SuspendLayout();
            // 
            // cmb_place
            // 
            this.cmb_place.FormattingEnabled = true;
            this.cmb_place.Location = new System.Drawing.Point(126, 56);
            this.cmb_place.Name = "cmb_place";
            this.cmb_place.Size = new System.Drawing.Size(243, 21);
            this.cmb_place.Sorted = true;
            this.cmb_place.TabIndex = 34;
            this.cmb_place.SelectedIndexChanged += new System.EventHandler(this.cmb_place_SelectedIndexChanged);
            // 
            // cmb_vaccineBase
            // 
            this.cmb_vaccineBase.FormattingEnabled = true;
            this.cmb_vaccineBase.Location = new System.Drawing.Point(126, 236);
            this.cmb_vaccineBase.Name = "cmb_vaccineBase";
            this.cmb_vaccineBase.Size = new System.Drawing.Size(243, 21);
            this.cmb_vaccineBase.TabIndex = 36;
            this.cmb_vaccineBase.SelectedIndexChanged += new System.EventHandler(this.cmb_vaccineBase_SelectedIndexChanged);
            // 
            // cmb_viccineName
            // 
            this.cmb_viccineName.FormattingEnabled = true;
            this.cmb_viccineName.Location = new System.Drawing.Point(216, 355);
            this.cmb_viccineName.Name = "cmb_viccineName";
            this.cmb_viccineName.Size = new System.Drawing.Size(153, 21);
            this.cmb_viccineName.TabIndex = 38;
            // 
            // btn_confirm
            // 
            this.btn_confirm.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_confirm.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_confirm.Font = new System.Drawing.Font("B Tabassom", 15.75F);
            this.btn_confirm.Location = new System.Drawing.Point(303, 462);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(155, 45);
            this.btn_confirm.TabIndex = 39;
            this.btn_confirm.Text = "تایید";
            this.btn_confirm.UseVisualStyleBackColor = false;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nazanin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label1.Location = new System.Drawing.Point(303, 198);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(161, 35);
            this.label1.TabIndex = 35;
            this.label1.Text = "پایگاه واکسیناسیون:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nazanin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label2.Location = new System.Drawing.Point(365, 315);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(99, 35);
            this.label2.TabIndex = 37;
            this.label2.Text = "نوع واکسن:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nazanin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label3.Location = new System.Drawing.Point(332, 18);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(132, 35);
            this.label3.TabIndex = 33;
            this.label3.Text = "مکان فعلی شما:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nazanin", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label4.Location = new System.Drawing.Point(338, 379);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(126, 35);
            this.label4.TabIndex = 40;
            this.label4.Text = "زمان مورد نظر:";
            // 
            // cmb_time
            // 
            this.cmb_time.FormattingEnabled = true;
            this.cmb_time.Location = new System.Drawing.Point(216, 417);
            this.cmb_time.Name = "cmb_time";
            this.cmb_time.Size = new System.Drawing.Size(153, 21);
            this.cmb_time.TabIndex = 41;
            // 
            // btn_cancel
            // 
            this.btn_cancel.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Font = new System.Drawing.Font("B Tabassom", 15.75F);
            this.btn_cancel.Location = new System.Drawing.Point(126, 462);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(155, 45);
            this.btn_cancel.TabIndex = 42;
            this.btn_cancel.Text = "لغو";
            this.btn_cancel.UseVisualStyleBackColor = false;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nazanin", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(414, 263);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(49, 28);
            this.label5.TabIndex = 43;
            this.label5.Text = "آدرس:";
            // 
            // lbl_Address
            // 
            this.lbl_Address.AutoSize = true;
            this.lbl_Address.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.lbl_Address.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Address.Location = new System.Drawing.Point(123, 289);
            this.lbl_Address.Name = "lbl_Address";
            this.lbl_Address.Size = new System.Drawing.Size(0, 15);
            this.lbl_Address.TabIndex = 44;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nazanin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label6.Location = new System.Drawing.Point(326, 129);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(138, 31);
            this.label6.TabIndex = 45;
            this.label6.Text = "مختصات فعلی شما:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(243, 136);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 20);
            this.label7.TabIndex = 47;
            this.label7.Text = ":X";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(243, 167);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(26, 20);
            this.label8.TabIndex = 48;
            this.label8.Text = ":Y";
            // 
            // numericUpDown_X
            // 
            this.numericUpDown_X.Enabled = false;
            this.numericUpDown_X.Location = new System.Drawing.Point(156, 136);
            this.numericUpDown_X.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_X.Name = "numericUpDown_X";
            this.numericUpDown_X.Size = new System.Drawing.Size(81, 20);
            this.numericUpDown_X.TabIndex = 49;
            this.numericUpDown_X.ValueChanged += new System.EventHandler(this.numericUpDown_X_ValueChanged);
            // 
            // numericUpDown_Y
            // 
            this.numericUpDown_Y.Enabled = false;
            this.numericUpDown_Y.Location = new System.Drawing.Point(156, 167);
            this.numericUpDown_Y.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numericUpDown_Y.Name = "numericUpDown_Y";
            this.numericUpDown_Y.Size = new System.Drawing.Size(81, 20);
            this.numericUpDown_Y.TabIndex = 50;
            this.numericUpDown_Y.ValueChanged += new System.EventHandler(this.numericUpDown_X_ValueChanged);
            // 
            // ch_checkCoordinates
            // 
            this.ch_checkCoordinates.AutoSize = true;
            this.ch_checkCoordinates.Font = new System.Drawing.Font("Nazanin", 9.75F, System.Drawing.FontStyle.Bold);
            this.ch_checkCoordinates.Location = new System.Drawing.Point(190, 102);
            this.ch_checkCoordinates.Name = "ch_checkCoordinates";
            this.ch_checkCoordinates.Size = new System.Drawing.Size(277, 24);
            this.ch_checkCoordinates.TabIndex = 51;
            this.ch_checkCoordinates.Text = "مرتب سازی پایگاه ها براسا فاصله با مختصات مکان شما";
            this.ch_checkCoordinates.UseVisualStyleBackColor = true;
            this.ch_checkCoordinates.CheckedChanged += new System.EventHandler(this.ch_checkCoordinates_CheckedChanged);
            // 
            // Form_Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(593, 511);
            this.ControlBox = false;
            this.Controls.Add(this.ch_checkCoordinates);
            this.Controls.Add(this.numericUpDown_Y);
            this.Controls.Add(this.numericUpDown_X);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbl_Address);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.cmb_time);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_confirm);
            this.Controls.Add(this.cmb_viccineName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmb_vaccineBase);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_place);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form_Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ثبت نام";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Form_Register_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_X)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_Y)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmb_place;
        private System.Windows.Forms.ComboBox cmb_vaccineBase;
        private System.Windows.Forms.ComboBox cmb_viccineName;
        private System.Windows.Forms.Button btn_confirm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmb_time;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbl_Address;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown numericUpDown_X;
        private System.Windows.Forms.NumericUpDown numericUpDown_Y;
        private System.Windows.Forms.CheckBox ch_checkCoordinates;
    }
}