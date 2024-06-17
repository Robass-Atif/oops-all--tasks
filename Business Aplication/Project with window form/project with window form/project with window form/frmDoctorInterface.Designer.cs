
namespace project_with_window_form
{
    partial class frmDoctorInterface
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
            this.button9 = new System.Windows.Forms.Button();
            this.AdminViewPatient = new System.Windows.Forms.Button();
            this.AdminBillPAyment = new System.Windows.Forms.Button();
            this.AdminUpdateSalary = new System.Windows.Forms.Button();
            this.AddDoctor = new System.Windows.Forms.Button();
            this.AdminUpdateFee = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.viewRecordAdmin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.Transparent;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(578, 233);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(210, 91);
            this.button9.TabIndex = 26;
            this.button9.Text = "Add Prescription";
            this.button9.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // AdminViewPatient
            // 
            this.AdminViewPatient.BackColor = System.Drawing.Color.Transparent;
            this.AdminViewPatient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminViewPatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminViewPatient.Location = new System.Drawing.Point(33, 224);
            this.AdminViewPatient.Name = "AdminViewPatient";
            this.AdminViewPatient.Size = new System.Drawing.Size(224, 91);
            this.AdminViewPatient.TabIndex = 25;
            this.AdminViewPatient.Text = "Cancel Appointment";
            this.AdminViewPatient.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AdminViewPatient.UseVisualStyleBackColor = false;
            this.AdminViewPatient.Click += new System.EventHandler(this.AdminViewPatient_Click);
            // 
            // AdminBillPAyment
            // 
            this.AdminBillPAyment.BackColor = System.Drawing.Color.Transparent;
            this.AdminBillPAyment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminBillPAyment.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminBillPAyment.Location = new System.Drawing.Point(33, 342);
            this.AdminBillPAyment.Name = "AdminBillPAyment";
            this.AdminBillPAyment.Size = new System.Drawing.Size(161, 91);
            this.AdminBillPAyment.TabIndex = 24;
            this.AdminBillPAyment.Text = "Add Bill payment";
            this.AdminBillPAyment.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AdminBillPAyment.UseVisualStyleBackColor = false;
            this.AdminBillPAyment.Click += new System.EventHandler(this.AdminBillPAyment_Click);
            // 
            // AdminUpdateSalary
            // 
            this.AdminUpdateSalary.BackColor = System.Drawing.Color.Transparent;
            this.AdminUpdateSalary.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminUpdateSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminUpdateSalary.Location = new System.Drawing.Point(324, 342);
            this.AdminUpdateSalary.Name = "AdminUpdateSalary";
            this.AdminUpdateSalary.Size = new System.Drawing.Size(161, 91);
            this.AdminUpdateSalary.TabIndex = 23;
            this.AdminUpdateSalary.Text = "Test Report";
            this.AdminUpdateSalary.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AdminUpdateSalary.UseVisualStyleBackColor = false;
            this.AdminUpdateSalary.Click += new System.EventHandler(this.AdminUpdateSalary_Click);
            // 
            // AddDoctor
            // 
            this.AddDoctor.BackColor = System.Drawing.Color.Transparent;
            this.AddDoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddDoctor.Location = new System.Drawing.Point(549, 114);
            this.AddDoctor.Name = "AddDoctor";
            this.AddDoctor.Size = new System.Drawing.Size(239, 91);
            this.AddDoctor.TabIndex = 22;
            this.AddDoctor.Text = "View Appointment";
            this.AddDoctor.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AddDoctor.UseVisualStyleBackColor = false;
            this.AddDoctor.Click += new System.EventHandler(this.AddDoctor_Click);
            // 
            // AdminUpdateFee
            // 
            this.AdminUpdateFee.BackColor = System.Drawing.Color.Transparent;
            this.AdminUpdateFee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AdminUpdateFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminUpdateFee.Location = new System.Drawing.Point(324, 114);
            this.AdminUpdateFee.Name = "AdminUpdateFee";
            this.AdminUpdateFee.Size = new System.Drawing.Size(161, 91);
            this.AdminUpdateFee.TabIndex = 21;
            this.AdminUpdateFee.Text = "Delete Patient";
            this.AdminUpdateFee.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.AdminUpdateFee.UseVisualStyleBackColor = false;
            this.AdminUpdateFee.Click += new System.EventHandler(this.AdminUpdateFee_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(324, 233);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(225, 91);
            this.button3.TabIndex = 20;
            this.button3.Text = "Add Appointment";
            this.button3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // viewRecordAdmin
            // 
            this.viewRecordAdmin.BackColor = System.Drawing.Color.Transparent;
            this.viewRecordAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.viewRecordAdmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.viewRecordAdmin.Location = new System.Drawing.Point(33, 114);
            this.viewRecordAdmin.Name = "viewRecordAdmin";
            this.viewRecordAdmin.Size = new System.Drawing.Size(161, 91);
            this.viewRecordAdmin.TabIndex = 19;
            this.viewRecordAdmin.Text = "Add Patient";
            this.viewRecordAdmin.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.viewRecordAdmin.UseVisualStyleBackColor = false;
            this.viewRecordAdmin.Click += new System.EventHandler(this.viewRecordAdmin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label1.Location = new System.Drawing.Point(276, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(227, 73);
            this.label1.TabIndex = 17;
            this.label1.Text = "Doctor";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(578, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(161, 91);
            this.button2.TabIndex = 27;
            this.button2.Text = "View Records";
            this.button2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::project_with_window_form.Properties.Resources.back_button;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(33, 31);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 42);
            this.button1.TabIndex = 18;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDoctorInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.AdminViewPatient);
            this.Controls.Add(this.AdminBillPAyment);
            this.Controls.Add(this.AdminUpdateSalary);
            this.Controls.Add(this.AddDoctor);
            this.Controls.Add(this.AdminUpdateFee);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.viewRecordAdmin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "frmDoctorInterface";
            this.Text = "frmDoctorInterface";
            this.Load += new System.EventHandler(this.frmDoctorInterface_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button AdminViewPatient;
        private System.Windows.Forms.Button AdminBillPAyment;
        private System.Windows.Forms.Button AdminUpdateSalary;
        private System.Windows.Forms.Button AddDoctor;
        private System.Windows.Forms.Button AdminUpdateFee;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button viewRecordAdmin;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
    }
}