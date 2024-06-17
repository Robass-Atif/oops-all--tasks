
namespace project_with_window_form
{
    partial class signIn
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
            this.txtname = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.front = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(362, 288);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(149, 20);
            this.txtname.TabIndex = 1;
          //  this.txtname.TextChanged += new System.EventHandler(this.txtname_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.Location = new System.Drawing.Point(238, 288);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(102, 20);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Enter Name :";
           // this.labelName.Click += new System.EventHandler(this.labelName_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPassword.Location = new System.Drawing.Point(211, 337);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(129, 20);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Enter Password :";
         //   this.labelPassword.Click += new System.EventHandler(this.labelPassword_Click);
            // 
            // Password
            // 
            this.Password.Location = new System.Drawing.Point(362, 337);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(149, 20);
            this.Password.TabIndex = 3;
         //   this.Password.TextChanged += new System.EventHandler(this.Password_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(249, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 73);
            this.label1.TabIndex = 5;
            this.label1.Text = "Sign In";
          //  this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(391, 396);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(0, 13);
            this.result.TabIndex = 8;
          //  this.result.Click += new System.EventHandler(this.result_Click);
            // 
            // front
            // 
            this.front.BackgroundImage = global::project_with_window_form.Properties.Resources.front_button;
            this.front.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.front.Location = new System.Drawing.Point(686, 396);
            this.front.Name = "front";
            this.front.Size = new System.Drawing.Size(56, 42);
            this.front.TabIndex = 7;
            this.front.UseVisualStyleBackColor = true;
            this.front.Click += new System.EventHandler(this.front_Click);
            // 
            // button1
            // 
            this.button1.BackgroundImage = global::project_with_window_form.Properties.Resources.back_button;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 42);
            this.button1.TabIndex = 6;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::project_with_window_form.Properties.Resources.user_interface;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(262, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(192, 122);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
          //  this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // signIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
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
            this.Name = "signIn";
            this.Load += new System.EventHandler(this.signIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
       private  System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button front;
        private System.Windows.Forms.Label result;
    }
}