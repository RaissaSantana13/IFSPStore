namespace IFSPStore.app.Register
{
    partial class UserForm
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
            txtName = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtEmail = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtLogin = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtPassword = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            chkActive = new ReaLTaiizor.Controls.MaterialCheckBox();
            txtId = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtRegistrationDate = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            txtLoginDate = new ReaLTaiizor.Controls.MaterialMaskedTextBox();
            tabPageRegister.SuspendLayout();
            tabControlRegister.SuspendLayout();
            SuspendLayout();
            // 
            // tabPageRegister
            // 
            tabPageRegister.Controls.Add(txtLoginDate);
            tabPageRegister.Controls.Add(txtRegistrationDate);
            tabPageRegister.Controls.Add(txtId);
            tabPageRegister.Controls.Add(chkActive);
            tabPageRegister.Controls.Add(txtPassword);
            tabPageRegister.Controls.Add(txtLogin);
            tabPageRegister.Controls.Add(txtEmail);
            tabPageRegister.Controls.Add(txtName);
            tabPageRegister.Size = new Size(832, 432);
            tabPageRegister.Controls.SetChildIndex(txtName, 0);
            tabPageRegister.Controls.SetChildIndex(txtEmail, 0);
            tabPageRegister.Controls.SetChildIndex(txtLogin, 0);
            tabPageRegister.Controls.SetChildIndex(txtPassword, 0);
            tabPageRegister.Controls.SetChildIndex(chkActive, 0);
            tabPageRegister.Controls.SetChildIndex(txtId, 0);
            tabPageRegister.Controls.SetChildIndex(txtRegistrationDate, 0);
            tabPageRegister.Controls.SetChildIndex(txtLoginDate, 0);
            // 
            // tabControlRegister
            // 
            tabControlRegister.Size = new Size(840, 467);
            // 
            // txtName
            // 
            txtName.AllowPromptAsInput = true;
            txtName.AnimateReadOnly = false;
            txtName.AsciiOnly = false;
            txtName.BackgroundImageLayout = ImageLayout.None;
            txtName.BeepOnError = false;
            txtName.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtName.Depth = 0;
            txtName.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtName.HidePromptOnLeave = false;
            txtName.HideSelection = true;
            txtName.Hint = "Name";
            txtName.InsertKeyMode = InsertKeyMode.Default;
            txtName.LeadingIcon = null;
            txtName.Location = new Point(29, 16);
            txtName.Mask = "";
            txtName.MaxLength = 32767;
            txtName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.PrefixSuffixText = null;
            txtName.PromptChar = '_';
            txtName.ReadOnly = false;
            txtName.RejectInputOnFirstFailure = false;
            txtName.ResetOnPrompt = true;
            txtName.ResetOnSpace = true;
            txtName.RightToLeft = RightToLeft.No;
            txtName.SelectedText = "";
            txtName.SelectionLength = 0;
            txtName.SelectionStart = 0;
            txtName.ShortcutsEnabled = true;
            txtName.Size = new Size(579, 48);
            txtName.SkipLiterals = true;
            txtName.TabIndex = 3;
            txtName.TabStop = false;
            txtName.TextAlign = HorizontalAlignment.Left;
            txtName.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtName.TrailingIcon = null;
            txtName.UseSystemPasswordChar = false;
            txtName.ValidatingType = null;
            // 
            // txtEmail
            // 
            txtEmail.AllowPromptAsInput = true;
            txtEmail.AnimateReadOnly = false;
            txtEmail.AsciiOnly = false;
            txtEmail.BackgroundImageLayout = ImageLayout.None;
            txtEmail.BeepOnError = false;
            txtEmail.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtEmail.Depth = 0;
            txtEmail.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtEmail.HidePromptOnLeave = false;
            txtEmail.HideSelection = true;
            txtEmail.Hint = "Email";
            txtEmail.InsertKeyMode = InsertKeyMode.Default;
            txtEmail.LeadingIcon = null;
            txtEmail.Location = new Point(460, 92);
            txtEmail.Mask = "";
            txtEmail.MaxLength = 32767;
            txtEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.PrefixSuffixText = null;
            txtEmail.PromptChar = '_';
            txtEmail.ReadOnly = false;
            txtEmail.RejectInputOnFirstFailure = false;
            txtEmail.ResetOnPrompt = true;
            txtEmail.ResetOnSpace = true;
            txtEmail.RightToLeft = RightToLeft.No;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.ShortcutsEnabled = true;
            txtEmail.Size = new Size(297, 48);
            txtEmail.SkipLiterals = true;
            txtEmail.TabIndex = 4;
            txtEmail.TabStop = false;
            txtEmail.TextAlign = HorizontalAlignment.Left;
            txtEmail.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtEmail.TrailingIcon = null;
            txtEmail.UseSystemPasswordChar = false;
            txtEmail.ValidatingType = null;
            // 
            // txtLogin
            // 
            txtLogin.AllowPromptAsInput = true;
            txtLogin.AnimateReadOnly = false;
            txtLogin.AsciiOnly = false;
            txtLogin.BackgroundImageLayout = ImageLayout.None;
            txtLogin.BeepOnError = false;
            txtLogin.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtLogin.Depth = 0;
            txtLogin.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLogin.HidePromptOnLeave = false;
            txtLogin.HideSelection = true;
            txtLogin.Hint = "Login";
            txtLogin.InsertKeyMode = InsertKeyMode.Default;
            txtLogin.LeadingIcon = null;
            txtLogin.Location = new Point(29, 92);
            txtLogin.Mask = "";
            txtLogin.MaxLength = 32767;
            txtLogin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtLogin.Name = "txtLogin";
            txtLogin.PasswordChar = '\0';
            txtLogin.PrefixSuffixText = null;
            txtLogin.PromptChar = '_';
            txtLogin.ReadOnly = false;
            txtLogin.RejectInputOnFirstFailure = false;
            txtLogin.ResetOnPrompt = true;
            txtLogin.ResetOnSpace = true;
            txtLogin.RightToLeft = RightToLeft.No;
            txtLogin.SelectedText = "";
            txtLogin.SelectionLength = 0;
            txtLogin.SelectionStart = 0;
            txtLogin.ShortcutsEnabled = true;
            txtLogin.Size = new Size(384, 48);
            txtLogin.SkipLiterals = true;
            txtLogin.TabIndex = 5;
            txtLogin.TabStop = false;
            txtLogin.TextAlign = HorizontalAlignment.Left;
            txtLogin.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtLogin.TrailingIcon = null;
            txtLogin.UseSystemPasswordChar = false;
            txtLogin.ValidatingType = null;
            // 
            // txtPassword
            // 
            txtPassword.AllowPromptAsInput = true;
            txtPassword.AnimateReadOnly = false;
            txtPassword.AsciiOnly = false;
            txtPassword.BackgroundImageLayout = ImageLayout.None;
            txtPassword.BeepOnError = false;
            txtPassword.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtPassword.Depth = 0;
            txtPassword.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtPassword.HidePromptOnLeave = false;
            txtPassword.HideSelection = true;
            txtPassword.Hint = "Password";
            txtPassword.InsertKeyMode = InsertKeyMode.Default;
            txtPassword.LeadingIcon = null;
            txtPassword.Location = new Point(29, 170);
            txtPassword.Mask = "";
            txtPassword.MaxLength = 32767;
            txtPassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '\0';
            txtPassword.PrefixSuffixText = null;
            txtPassword.PromptChar = '_';
            txtPassword.ReadOnly = false;
            txtPassword.RejectInputOnFirstFailure = false;
            txtPassword.ResetOnPrompt = true;
            txtPassword.ResetOnSpace = true;
            txtPassword.RightToLeft = RightToLeft.No;
            txtPassword.SelectedText = "";
            txtPassword.SelectionLength = 0;
            txtPassword.SelectionStart = 0;
            txtPassword.ShortcutsEnabled = true;
            txtPassword.Size = new Size(366, 48);
            txtPassword.SkipLiterals = true;
            txtPassword.TabIndex = 6;
            txtPassword.TabStop = false;
            txtPassword.TextAlign = HorizontalAlignment.Left;
            txtPassword.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtPassword.TrailingIcon = null;
            txtPassword.UseSystemPasswordChar = false;
            txtPassword.ValidatingType = null;
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Depth = 0;
            chkActive.Location = new Point(483, 181);
            chkActive.Margin = new Padding(0);
            chkActive.MouseLocation = new Point(-1, -1);
            chkActive.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            chkActive.Name = "chkActive";
            chkActive.ReadOnly = false;
            chkActive.Ripple = true;
            chkActive.Size = new Size(125, 37);
            chkActive.TabIndex = 7;
            chkActive.Text = "User Active ?";
            chkActive.UseAccentColor = false;
            chkActive.UseVisualStyleBackColor = true;
            // 
            // txtId
            // 
            txtId.AllowPromptAsInput = true;
            txtId.AnimateReadOnly = false;
            txtId.AsciiOnly = false;
            txtId.BackgroundImageLayout = ImageLayout.None;
            txtId.BeepOnError = false;
            txtId.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtId.Depth = 0;
            txtId.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtId.HidePromptOnLeave = false;
            txtId.HideSelection = true;
            txtId.Hint = "Id";
            txtId.InsertKeyMode = InsertKeyMode.Default;
            txtId.LeadingIcon = null;
            txtId.Location = new Point(620, 16);
            txtId.Mask = "";
            txtId.MaxLength = 32767;
            txtId.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtId.Name = "txtId";
            txtId.PasswordChar = '\0';
            txtId.PrefixSuffixText = null;
            txtId.PromptChar = '_';
            txtId.ReadOnly = false;
            txtId.RejectInputOnFirstFailure = false;
            txtId.ResetOnPrompt = true;
            txtId.ResetOnSpace = true;
            txtId.RightToLeft = RightToLeft.No;
            txtId.SelectedText = "";
            txtId.SelectionLength = 0;
            txtId.SelectionStart = 0;
            txtId.ShortcutsEnabled = true;
            txtId.Size = new Size(155, 48);
            txtId.SkipLiterals = true;
            txtId.TabIndex = 8;
            txtId.TabStop = false;
            txtId.TextAlign = HorizontalAlignment.Left;
            txtId.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtId.TrailingIcon = null;
            txtId.UseSystemPasswordChar = false;
            txtId.ValidatingType = null;
            // 
            // txtRegistrationDate
            // 
            txtRegistrationDate.AllowPromptAsInput = true;
            txtRegistrationDate.AnimateReadOnly = false;
            txtRegistrationDate.AsciiOnly = false;
            txtRegistrationDate.BackgroundImageLayout = ImageLayout.None;
            txtRegistrationDate.BeepOnError = false;
            txtRegistrationDate.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtRegistrationDate.Depth = 0;
            txtRegistrationDate.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtRegistrationDate.HidePromptOnLeave = false;
            txtRegistrationDate.HideSelection = true;
            txtRegistrationDate.Hint = "Registration Date";
            txtRegistrationDate.InsertKeyMode = InsertKeyMode.Default;
            txtRegistrationDate.LeadingIcon = null;
            txtRegistrationDate.Location = new Point(29, 259);
            txtRegistrationDate.Mask = "";
            txtRegistrationDate.MaxLength = 32767;
            txtRegistrationDate.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtRegistrationDate.Name = "txtRegistrationDate";
            txtRegistrationDate.PasswordChar = '\0';
            txtRegistrationDate.PrefixSuffixText = null;
            txtRegistrationDate.PromptChar = '_';
            txtRegistrationDate.ReadOnly = false;
            txtRegistrationDate.RejectInputOnFirstFailure = false;
            txtRegistrationDate.ResetOnPrompt = true;
            txtRegistrationDate.ResetOnSpace = true;
            txtRegistrationDate.RightToLeft = RightToLeft.No;
            txtRegistrationDate.SelectedText = "";
            txtRegistrationDate.SelectionLength = 0;
            txtRegistrationDate.SelectionStart = 0;
            txtRegistrationDate.ShortcutsEnabled = true;
            txtRegistrationDate.Size = new Size(250, 48);
            txtRegistrationDate.SkipLiterals = true;
            txtRegistrationDate.TabIndex = 9;
            txtRegistrationDate.TabStop = false;
            txtRegistrationDate.TextAlign = HorizontalAlignment.Left;
            txtRegistrationDate.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtRegistrationDate.TrailingIcon = null;
            txtRegistrationDate.UseSystemPasswordChar = false;
            txtRegistrationDate.ValidatingType = null;
            // 
            // txtLoginDate
            // 
            txtLoginDate.AllowPromptAsInput = true;
            txtLoginDate.AnimateReadOnly = false;
            txtLoginDate.AsciiOnly = false;
            txtLoginDate.BackgroundImageLayout = ImageLayout.None;
            txtLoginDate.BeepOnError = false;
            txtLoginDate.CutCopyMaskFormat = MaskFormat.IncludeLiterals;
            txtLoginDate.Depth = 0;
            txtLoginDate.Font = new Font("Roboto", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtLoginDate.HidePromptOnLeave = false;
            txtLoginDate.HideSelection = true;
            txtLoginDate.Hint = "Login Date";
            txtLoginDate.InsertKeyMode = InsertKeyMode.Default;
            txtLoginDate.LeadingIcon = null;
            txtLoginDate.Location = new Point(460, 259);
            txtLoginDate.Mask = "";
            txtLoginDate.MaxLength = 32767;
            txtLoginDate.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtLoginDate.Name = "txtLoginDate";
            txtLoginDate.PasswordChar = '\0';
            txtLoginDate.PrefixSuffixText = null;
            txtLoginDate.PromptChar = '_';
            txtLoginDate.ReadOnly = false;
            txtLoginDate.RejectInputOnFirstFailure = false;
            txtLoginDate.ResetOnPrompt = true;
            txtLoginDate.ResetOnSpace = true;
            txtLoginDate.RightToLeft = RightToLeft.No;
            txtLoginDate.SelectedText = "";
            txtLoginDate.SelectionLength = 0;
            txtLoginDate.SelectionStart = 0;
            txtLoginDate.ShortcutsEnabled = true;
            txtLoginDate.Size = new Size(250, 48);
            txtLoginDate.SkipLiterals = true;
            txtLoginDate.TabIndex = 10;
            txtLoginDate.TabStop = false;
            txtLoginDate.TextAlign = HorizontalAlignment.Left;
            txtLoginDate.TextMaskFormat = MaskFormat.IncludeLiterals;
            txtLoginDate.TrailingIcon = null;
            txtLoginDate.UseSystemPasswordChar = false;
            txtLoginDate.ValidatingType = null;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(846, 534);
            Location = new Point(0, 0);
            Name = "UserForm";
            Text = "User Register";
            tabPageRegister.ResumeLayout(false);
            tabPageRegister.PerformLayout();
            tabControlRegister.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtPassword;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtLogin;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtEmail;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtName;
        private ReaLTaiizor.Controls.MaterialCheckBox chkActive;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtId;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtLoginDate;
        private ReaLTaiizor.Controls.MaterialMaskedTextBox txtRegistrationDate;
    }
}