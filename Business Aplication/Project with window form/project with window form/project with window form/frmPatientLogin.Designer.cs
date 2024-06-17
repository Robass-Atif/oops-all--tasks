
namespace project_with_window_form
{
    partial class frmPatientLogin
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
            this.result = new System.Windows.Forms.Label();
            this.front = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(414, 396);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 13);
            this.result.TabIndex = 26;
            // 
            // front
            // 
            this.front.BackgroundImage = global::project_with_window_form.Properties.Resources.front_button;
            this.front.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.front.Location = new System.Drawing.Point(709, 396);
            this.front.Name = "front";
            this.front.Size = new System.Drawing.Size(56, 42);
            this.front.TabIndex = 25;
            this.front.UseVisualStyleBackColor = true;
            this.front.Click += new System.EventHandler(this.front_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::project_with_window_form.Properties.Resources.back_button;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(36, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 42);
            this.button1.TabIndex = 24;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 73);
            this.label1.TabIndex = 23;
            this.label1.Text = "Sign In";
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(234, 337);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(129, 20);
            this.labelPassword.TabIndex = 22;
            this.labelPassword.Text = "Enter Password :";
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(385, 337);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(149, 20);
            this.Password.TabIndex = 21;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(261, 288);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(102, 20);
            this.labelName.TabIndex = 20;
            this.labelName.Text = "Enter Name :";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(385, 288);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(149, 20);
            this.txtname.TabIndex = 19;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::project_with_window_form.Properties.Resources.pngtree_stethoscope_icon_vector_doctor_symbol_png_image_8207190;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(315, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(161, 156);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // frmPatientLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.front);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.pictureBox1);
            this.Name = "frmPatientLogin";
            this.Text = "frmPatientLogin";
            this.Load += new System.EventHandler(this.frmPatientLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button front;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}