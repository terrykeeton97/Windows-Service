
namespace Support_Tool
{
    partial class Login_Form
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.BorderlessForm = new Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm(this.components);
            this.main_Panel = new Siticone.Desktop.UI.WinForms.SiticonePanel();
            this.remember_checkBox = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.autoLogin_checkBox = new Siticone.Desktop.UI.WinForms.SiticoneCheckBox();
            this.label_Git = new Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel();
            this.register_Btn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.Sperator = new Siticone.Desktop.UI.WinForms.SiticoneSeparator();
            this.login_Btn = new Siticone.Desktop.UI.WinForms.SiticoneButton();
            this.password_textBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.username_textBox = new Siticone.Desktop.UI.WinForms.SiticoneTextBox();
            this.logo_Box = new Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox();
            this.control_closeBox = new Siticone.Desktop.UI.WinForms.SiticoneControlBox();
            this.dragControl = new Siticone.Desktop.UI.WinForms.SiticoneDragControl(this.components);
            this.panel_Elipse = new Siticone.Desktop.UI.WinForms.SiticoneElipse(this.components);
            this.main_Panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_Box)).BeginInit();
            this.SuspendLayout();
            // 
            // BorderlessForm
            // 
            this.BorderlessForm.AnimateWindow = true;
            this.BorderlessForm.BorderRadius = 10;
            this.BorderlessForm.ContainerControl = this;
            this.BorderlessForm.TransparentWhileDrag = true;
            // 
            // main_Panel
            // 
            this.main_Panel.AutoRoundedCorners = true;
            this.main_Panel.BackColor = System.Drawing.Color.White;
            this.main_Panel.BorderColor = System.Drawing.Color.Black;
            this.main_Panel.BorderRadius = 151;
            this.main_Panel.Controls.Add(this.remember_checkBox);
            this.main_Panel.Controls.Add(this.autoLogin_checkBox);
            this.main_Panel.Controls.Add(this.label_Git);
            this.main_Panel.Controls.Add(this.register_Btn);
            this.main_Panel.Controls.Add(this.Sperator);
            this.main_Panel.Controls.Add(this.login_Btn);
            this.main_Panel.Controls.Add(this.password_textBox);
            this.main_Panel.Controls.Add(this.username_textBox);
            this.main_Panel.Controls.Add(this.logo_Box);
            this.main_Panel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.main_Panel.FillColor = System.Drawing.Color.White;
            this.main_Panel.Font = new System.Drawing.Font("Calibri Light", 11.25F);
            this.main_Panel.Location = new System.Drawing.Point(43, 37);
            this.main_Panel.Name = "main_Panel";
            this.main_Panel.ShadowDecoration.Parent = this.main_Panel;
            this.main_Panel.Size = new System.Drawing.Size(377, 304);
            this.main_Panel.TabIndex = 0;
            // 
            // remember_checkBox
            // 
            this.remember_checkBox.Animated = true;
            this.remember_checkBox.AutoSize = true;
            this.remember_checkBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(67)))), ((int)(((byte)(163)))));
            this.remember_checkBox.CheckedState.BorderRadius = 0;
            this.remember_checkBox.CheckedState.BorderThickness = 0;
            this.remember_checkBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(67)))), ((int)(((byte)(163)))));
            this.remember_checkBox.Font = new System.Drawing.Font("Calibri Light", 11.25F);
            this.remember_checkBox.Location = new System.Drawing.Point(59, 201);
            this.remember_checkBox.Name = "remember_checkBox";
            this.remember_checkBox.Size = new System.Drawing.Size(116, 22);
            this.remember_checkBox.TabIndex = 11;
            this.remember_checkBox.TabStop = false;
            this.remember_checkBox.Text = "Remember Me";
            this.remember_checkBox.UncheckedState.BorderColor = System.Drawing.SystemColors.Control;
            this.remember_checkBox.UncheckedState.BorderRadius = 0;
            this.remember_checkBox.UncheckedState.BorderThickness = 0;
            this.remember_checkBox.UncheckedState.FillColor = System.Drawing.SystemColors.Control;
            // 
            // autoLogin_checkBox
            // 
            this.autoLogin_checkBox.Animated = true;
            this.autoLogin_checkBox.AutoSize = true;
            this.autoLogin_checkBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(67)))), ((int)(((byte)(163)))));
            this.autoLogin_checkBox.CheckedState.BorderRadius = 0;
            this.autoLogin_checkBox.CheckedState.BorderThickness = 0;
            this.autoLogin_checkBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(67)))), ((int)(((byte)(163)))));
            this.autoLogin_checkBox.Font = new System.Drawing.Font("Calibri Light", 11.25F);
            this.autoLogin_checkBox.Location = new System.Drawing.Point(179, 201);
            this.autoLogin_checkBox.Name = "autoLogin_checkBox";
            this.autoLogin_checkBox.Size = new System.Drawing.Size(144, 22);
            this.autoLogin_checkBox.TabIndex = 10;
            this.autoLogin_checkBox.TabStop = false;
            this.autoLogin_checkBox.Text = "Automatically Login";
            this.autoLogin_checkBox.UncheckedState.BorderColor = System.Drawing.SystemColors.Control;
            this.autoLogin_checkBox.UncheckedState.BorderRadius = 0;
            this.autoLogin_checkBox.UncheckedState.BorderThickness = 0;
            this.autoLogin_checkBox.UncheckedState.FillColor = System.Drawing.SystemColors.Control;
            // 
            // label_Git
            // 
            this.label_Git.BackColor = System.Drawing.Color.Transparent;
            this.label_Git.Font = new System.Drawing.Font("Calibri Light", 11.25F);
            this.label_Git.ForeColor = System.Drawing.Color.DimGray;
            this.label_Git.Location = new System.Drawing.Point(105, 275);
            this.label_Git.Name = "label_Git";
            this.label_Git.Size = new System.Drawing.Size(167, 20);
            this.label_Git.TabIndex = 9;
            this.label_Git.TabStop = false;
            this.label_Git.Text = "https://github.com/tezkidd";
            // 
            // register_Btn
            // 
            this.register_Btn.Animated = true;
            this.register_Btn.CheckedState.Parent = this.register_Btn;
            this.register_Btn.CustomImages.Parent = this.register_Btn;
            this.register_Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.register_Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.register_Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.register_Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.register_Btn.DisabledState.Parent = this.register_Btn;
            this.register_Btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(67)))), ((int)(((byte)(163)))));
            this.register_Btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.register_Btn.ForeColor = System.Drawing.Color.White;
            this.register_Btn.HoverState.Parent = this.register_Btn;
            this.register_Btn.Location = new System.Drawing.Point(190, 229);
            this.register_Btn.Name = "register_Btn";
            this.register_Btn.ShadowDecoration.Parent = this.register_Btn;
            this.register_Btn.Size = new System.Drawing.Size(128, 33);
            this.register_Btn.TabIndex = 8;
            this.register_Btn.TabStop = false;
            this.register_Btn.Text = "Register";
            // 
            // Sperator
            // 
            this.Sperator.Location = new System.Drawing.Point(59, 263);
            this.Sperator.Name = "Sperator";
            this.Sperator.Size = new System.Drawing.Size(259, 12);
            this.Sperator.TabIndex = 5;
            this.Sperator.TabStop = false;
            // 
            // login_Btn
            // 
            this.login_Btn.Animated = true;
            this.login_Btn.CheckedState.Parent = this.login_Btn;
            this.login_Btn.CustomImages.Parent = this.login_Btn;
            this.login_Btn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.login_Btn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.login_Btn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.login_Btn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.login_Btn.DisabledState.Parent = this.login_Btn;
            this.login_Btn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(67)))), ((int)(((byte)(163)))));
            this.login_Btn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.login_Btn.ForeColor = System.Drawing.Color.White;
            this.login_Btn.HoverState.Parent = this.login_Btn;
            this.login_Btn.Location = new System.Drawing.Point(59, 229);
            this.login_Btn.Name = "login_Btn";
            this.login_Btn.ShadowDecoration.Parent = this.login_Btn;
            this.login_Btn.Size = new System.Drawing.Size(128, 33);
            this.login_Btn.TabIndex = 4;
            this.login_Btn.TabStop = false;
            this.login_Btn.Text = "Login";
            // 
            // password_textBox
            // 
            this.password_textBox.Animated = true;
            this.password_textBox.BorderColor = System.Drawing.SystemColors.Control;
            this.password_textBox.BorderThickness = 2;
            this.password_textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.password_textBox.DefaultText = "";
            this.password_textBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.password_textBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.password_textBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_textBox.DisabledState.Parent = this.password_textBox;
            this.password_textBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.password_textBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(67)))), ((int)(((byte)(163)))));
            this.password_textBox.FocusedState.Parent = this.password_textBox;
            this.password_textBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.password_textBox.ForeColor = System.Drawing.Color.Black;
            this.password_textBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.password_textBox.HoverState.ForeColor = System.Drawing.Color.Black;
            this.password_textBox.HoverState.Parent = this.password_textBox;
            this.password_textBox.HoverState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.password_textBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("password_textBox.IconLeft")));
            this.password_textBox.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.password_textBox.IconLeftSize = new System.Drawing.Size(16, 18);
            this.password_textBox.Location = new System.Drawing.Point(59, 159);
            this.password_textBox.Name = "password_textBox";
            this.password_textBox.PasswordChar = '\0';
            this.password_textBox.PlaceholderText = "Password";
            this.password_textBox.SelectedText = "";
            this.password_textBox.ShadowDecoration.Parent = this.password_textBox;
            this.password_textBox.Size = new System.Drawing.Size(259, 36);
            this.password_textBox.TabIndex = 2;
            this.password_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.password_textBox.UseSystemPasswordChar = true;
            // 
            // username_textBox
            // 
            this.username_textBox.Animated = true;
            this.username_textBox.BorderColor = System.Drawing.SystemColors.Control;
            this.username_textBox.BorderThickness = 2;
            this.username_textBox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.username_textBox.DefaultText = "";
            this.username_textBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.username_textBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.username_textBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username_textBox.DisabledState.Parent = this.username_textBox;
            this.username_textBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.username_textBox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(67)))), ((int)(((byte)(163)))));
            this.username_textBox.FocusedState.Parent = this.username_textBox;
            this.username_textBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.username_textBox.ForeColor = System.Drawing.Color.Black;
            this.username_textBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.username_textBox.HoverState.ForeColor = System.Drawing.Color.Black;
            this.username_textBox.HoverState.Parent = this.username_textBox;
            this.username_textBox.HoverState.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.username_textBox.IconLeft = ((System.Drawing.Image)(resources.GetObject("username_textBox.IconLeft")));
            this.username_textBox.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.username_textBox.IconLeftSize = new System.Drawing.Size(16, 18);
            this.username_textBox.Location = new System.Drawing.Point(59, 117);
            this.username_textBox.Name = "username_textBox";
            this.username_textBox.PasswordChar = '\0';
            this.username_textBox.PlaceholderText = "Username";
            this.username_textBox.SelectedText = "";
            this.username_textBox.ShadowDecoration.Parent = this.username_textBox;
            this.username_textBox.Size = new System.Drawing.Size(259, 36);
            this.username_textBox.TabIndex = 1;
            this.username_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // logo_Box
            // 
            this.logo_Box.Image = ((System.Drawing.Image)(resources.GetObject("logo_Box.Image")));
            this.logo_Box.ImageRotate = 0F;
            this.logo_Box.Location = new System.Drawing.Point(139, 9);
            this.logo_Box.Name = "logo_Box";
            this.logo_Box.ShadowDecoration.Mode = Siticone.Desktop.UI.WinForms.Enums.ShadowMode.Circle;
            this.logo_Box.ShadowDecoration.Parent = this.logo_Box;
            this.logo_Box.Size = new System.Drawing.Size(98, 99);
            this.logo_Box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logo_Box.TabIndex = 0;
            this.logo_Box.TabStop = false;
            // 
            // control_closeBox
            // 
            this.control_closeBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.control_closeBox.Animated = true;
            this.control_closeBox.BackColor = System.Drawing.Color.Transparent;
            this.control_closeBox.BorderColor = System.Drawing.Color.Transparent;
            this.control_closeBox.BorderRadius = 4;
            this.control_closeBox.CustomIconSize = 5F;
            this.control_closeBox.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.control_closeBox.HoverState.Parent = this.control_closeBox;
            this.control_closeBox.IconColor = System.Drawing.Color.Black;
            this.control_closeBox.Location = new System.Drawing.Point(425, 2);
            this.control_closeBox.Name = "control_closeBox";
            this.control_closeBox.ShadowDecoration.Parent = this.control_closeBox;
            this.control_closeBox.Size = new System.Drawing.Size(34, 30);
            this.control_closeBox.TabIndex = 3;
            this.control_closeBox.TabStop = false;
            // 
            // dragControl
            // 
            this.dragControl.TargetControl = this.main_Panel;
            this.dragControl.TransparentWhileDrag = true;
            this.dragControl.UseTransparentDrag = true;
            // 
            // panel_Elipse
            // 
            this.panel_Elipse.TargetControl = this.main_Panel;
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(243)))), ((int)(((byte)(246)))));
            this.ClientSize = new System.Drawing.Size(462, 378);
            this.Controls.Add(this.control_closeBox);
            this.Controls.Add(this.main_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.main_Panel.ResumeLayout(false);
            this.main_Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logo_Box)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Siticone.Desktop.UI.WinForms.SiticoneBorderlessForm BorderlessForm;
        private Siticone.Desktop.UI.WinForms.SiticonePanel main_Panel;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox password_textBox;
        private Siticone.Desktop.UI.WinForms.SiticoneTextBox username_textBox;
        private Siticone.Desktop.UI.WinForms.SiticoneCirclePictureBox logo_Box;
        private Siticone.Desktop.UI.WinForms.SiticoneControlBox control_closeBox;
        private Siticone.Desktop.UI.WinForms.SiticoneDragControl dragControl;
        private Siticone.Desktop.UI.WinForms.SiticoneButton login_Btn;
        private Siticone.Desktop.UI.WinForms.SiticoneSeparator Sperator;
        private Siticone.Desktop.UI.WinForms.SiticoneElipse panel_Elipse;
        private Siticone.Desktop.UI.WinForms.SiticoneButton register_Btn;
        private Siticone.Desktop.UI.WinForms.SiticoneHtmlLabel label_Git;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox remember_checkBox;
        private Siticone.Desktop.UI.WinForms.SiticoneCheckBox autoLogin_checkBox;
    }
}

