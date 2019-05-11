namespace Movies_Reservation
{
    partial class addMovie
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addMovie));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.StateProperties();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bunifuImageButton1 = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel5 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuButton1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuTextBox1 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuTextBox2 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuTextBox3 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuTextBox4 = new Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox();
            this.bunifuDatePicker1 = new Bunifu.UI.WinForms.BunifuDatePicker();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(121, 268);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(119, 146);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 39;
            this.pictureBox1.TabStop = false;
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(246, 268);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(31, 35);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 38;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 10;
            this.bunifuImageButton1.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // bunifuCustomLabel5
            // 
            this.bunifuCustomLabel5.AutoSize = true;
            this.bunifuCustomLabel5.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel5.ForeColor = System.Drawing.Color.Black;
            this.bunifuCustomLabel5.Location = new System.Drawing.Point(118, 249);
            this.bunifuCustomLabel5.Name = "bunifuCustomLabel5";
            this.bunifuCustomLabel5.Size = new System.Drawing.Size(81, 16);
            this.bunifuCustomLabel5.TabIndex = 37;
            this.bunifuCustomLabel5.Text = "Movie Poster";
            this.bunifuCustomLabel5.Click += new System.EventHandler(this.bunifuCustomLabel5_Click);
            // 
            // bunifuButton1
            // 
            this.bunifuButton1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuButton1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuButton1.BackgroundImage")));
            this.bunifuButton1.ButtonText = "Add";
            this.bunifuButton1.ButtonTextMarginLeft = 0;
            this.bunifuButton1.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(161)))), ((int)(((byte)(161)))), ((int)(((byte)(161)))));
            this.bunifuButton1.DisabledFillColor = System.Drawing.Color.Gray;
            this.bunifuButton1.DisabledForecolor = System.Drawing.Color.White;
            this.bunifuButton1.ForeColor = System.Drawing.Color.White;
            this.bunifuButton1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IconPadding = 10;
            this.bunifuButton1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuButton1.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButton1.IdleBorderRadius = 40;
            this.bunifuButton1.IdleBorderThickness = 0;
            this.bunifuButton1.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.bunifuButton1.IdleIconLeftImage = null;
            this.bunifuButton1.IdleIconRightImage = null;
            this.bunifuButton1.Location = new System.Drawing.Point(351, 390);
            this.bunifuButton1.Name = "bunifuButton1";
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.BorderRadius = 1;
            stateProperties2.BorderThickness = 1;
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(96)))), ((int)(((byte)(144)))));
            stateProperties2.IconLeftImage = null;
            stateProperties2.IconRightImage = null;
            this.bunifuButton1.onHoverState = stateProperties2;
            this.bunifuButton1.Size = new System.Drawing.Size(135, 40);
            this.bunifuButton1.TabIndex = 40;
            this.bunifuButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuButton1.Click += new System.EventHandler(this.bunifuButton1_Click);
            // 
            // bunifuTextBox1
            // 
            this.bunifuTextBox1.AcceptsReturn = false;
            this.bunifuTextBox1.AcceptsTab = false;
            this.bunifuTextBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTextBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.BackgroundImage")));
            this.bunifuTextBox1.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(179)))), ((int)(((byte)(228)))));
            this.bunifuTextBox1.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.bunifuTextBox1.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(179)))), ((int)(((byte)(228)))));
            this.bunifuTextBox1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.bunifuTextBox1.BorderRadius = 35;
            this.bunifuTextBox1.BorderThickness = 2;
            this.bunifuTextBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox1.DefaultFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox1.DefaultText = "";
            this.bunifuTextBox1.FillColor = System.Drawing.Color.White;
            this.bunifuTextBox1.HideSelection = true;
            this.bunifuTextBox1.IconLeft = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox1.IconLeft")));
            this.bunifuTextBox1.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox1.IconPadding = 10;
            this.bunifuTextBox1.IconRight = null;
            this.bunifuTextBox1.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox1.Location = new System.Drawing.Point(104, 20);
            this.bunifuTextBox1.MaxLength = 32767;
            this.bunifuTextBox1.MinimumSize = new System.Drawing.Size(100, 35);
            this.bunifuTextBox1.Modified = false;
            this.bunifuTextBox1.Name = "bunifuTextBox1";
            this.bunifuTextBox1.PasswordChar = '\0';
            this.bunifuTextBox1.ReadOnly = false;
            this.bunifuTextBox1.SelectedText = "";
            this.bunifuTextBox1.SelectionLength = 0;
            this.bunifuTextBox1.SelectionStart = 0;
            this.bunifuTextBox1.ShortcutsEnabled = true;
            this.bunifuTextBox1.Size = new System.Drawing.Size(331, 40);
            this.bunifuTextBox1.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBox1.TabIndex = 41;
            this.bunifuTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox1.TextMarginLeft = 5;
            this.bunifuTextBox1.TextPlaceholder = "Enter Movie Name";
            this.bunifuTextBox1.UseSystemPasswordChar = false;
            // 
            // bunifuTextBox2
            // 
            this.bunifuTextBox2.AcceptsReturn = false;
            this.bunifuTextBox2.AcceptsTab = false;
            this.bunifuTextBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTextBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox2.BackgroundImage")));
            this.bunifuTextBox2.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(179)))), ((int)(((byte)(228)))));
            this.bunifuTextBox2.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.bunifuTextBox2.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(179)))), ((int)(((byte)(228)))));
            this.bunifuTextBox2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.bunifuTextBox2.BorderRadius = 35;
            this.bunifuTextBox2.BorderThickness = 2;
            this.bunifuTextBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox2.DefaultFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox2.DefaultText = "";
            this.bunifuTextBox2.FillColor = System.Drawing.Color.White;
            this.bunifuTextBox2.HideSelection = true;
            this.bunifuTextBox2.IconLeft = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox2.IconLeft")));
            this.bunifuTextBox2.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox2.IconPadding = 10;
            this.bunifuTextBox2.IconRight = null;
            this.bunifuTextBox2.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox2.Location = new System.Drawing.Point(104, 66);
            this.bunifuTextBox2.MaxLength = 32767;
            this.bunifuTextBox2.MinimumSize = new System.Drawing.Size(100, 35);
            this.bunifuTextBox2.Modified = false;
            this.bunifuTextBox2.Name = "bunifuTextBox2";
            this.bunifuTextBox2.PasswordChar = '\0';
            this.bunifuTextBox2.ReadOnly = false;
            this.bunifuTextBox2.SelectedText = "";
            this.bunifuTextBox2.SelectionLength = 0;
            this.bunifuTextBox2.SelectionStart = 0;
            this.bunifuTextBox2.ShortcutsEnabled = true;
            this.bunifuTextBox2.Size = new System.Drawing.Size(331, 40);
            this.bunifuTextBox2.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBox2.TabIndex = 42;
            this.bunifuTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox2.TextMarginLeft = 5;
            this.bunifuTextBox2.TextPlaceholder = "Enter Movie Category";
            this.bunifuTextBox2.UseSystemPasswordChar = false;
            // 
            // bunifuTextBox3
            // 
            this.bunifuTextBox3.AcceptsReturn = false;
            this.bunifuTextBox3.AcceptsTab = false;
            this.bunifuTextBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTextBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox3.BackgroundImage")));
            this.bunifuTextBox3.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(179)))), ((int)(((byte)(228)))));
            this.bunifuTextBox3.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.bunifuTextBox3.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(179)))), ((int)(((byte)(228)))));
            this.bunifuTextBox3.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.bunifuTextBox3.BorderRadius = 35;
            this.bunifuTextBox3.BorderThickness = 2;
            this.bunifuTextBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox3.DefaultFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox3.DefaultText = "";
            this.bunifuTextBox3.FillColor = System.Drawing.Color.White;
            this.bunifuTextBox3.HideSelection = true;
            this.bunifuTextBox3.IconLeft = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox3.IconLeft")));
            this.bunifuTextBox3.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox3.IconPadding = 10;
            this.bunifuTextBox3.IconRight = null;
            this.bunifuTextBox3.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox3.Location = new System.Drawing.Point(104, 112);
            this.bunifuTextBox3.MaxLength = 32767;
            this.bunifuTextBox3.MinimumSize = new System.Drawing.Size(100, 35);
            this.bunifuTextBox3.Modified = false;
            this.bunifuTextBox3.Name = "bunifuTextBox3";
            this.bunifuTextBox3.PasswordChar = '\0';
            this.bunifuTextBox3.ReadOnly = false;
            this.bunifuTextBox3.SelectedText = "";
            this.bunifuTextBox3.SelectionLength = 0;
            this.bunifuTextBox3.SelectionStart = 0;
            this.bunifuTextBox3.ShortcutsEnabled = true;
            this.bunifuTextBox3.Size = new System.Drawing.Size(331, 40);
            this.bunifuTextBox3.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBox3.TabIndex = 43;
            this.bunifuTextBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox3.TextMarginLeft = 5;
            this.bunifuTextBox3.TextPlaceholder = "Enter Price";
            this.bunifuTextBox3.UseSystemPasswordChar = false;
            // 
            // bunifuTextBox4
            // 
            this.bunifuTextBox4.AcceptsReturn = false;
            this.bunifuTextBox4.AcceptsTab = false;
            this.bunifuTextBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.bunifuTextBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.bunifuTextBox4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuTextBox4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox4.BackgroundImage")));
            this.bunifuTextBox4.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(179)))), ((int)(((byte)(228)))));
            this.bunifuTextBox4.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.bunifuTextBox4.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(179)))), ((int)(((byte)(228)))));
            this.bunifuTextBox4.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.bunifuTextBox4.BorderRadius = 35;
            this.bunifuTextBox4.BorderThickness = 2;
            this.bunifuTextBox4.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.bunifuTextBox4.DefaultFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuTextBox4.DefaultText = "";
            this.bunifuTextBox4.FillColor = System.Drawing.Color.White;
            this.bunifuTextBox4.HideSelection = true;
            this.bunifuTextBox4.IconLeft = ((System.Drawing.Image)(resources.GetObject("bunifuTextBox4.IconLeft")));
            this.bunifuTextBox4.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox4.IconPadding = 10;
            this.bunifuTextBox4.IconRight = null;
            this.bunifuTextBox4.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTextBox4.Location = new System.Drawing.Point(104, 158);
            this.bunifuTextBox4.MaxLength = 32767;
            this.bunifuTextBox4.MinimumSize = new System.Drawing.Size(100, 35);
            this.bunifuTextBox4.Modified = false;
            this.bunifuTextBox4.Name = "bunifuTextBox4";
            this.bunifuTextBox4.PasswordChar = '\0';
            this.bunifuTextBox4.ReadOnly = false;
            this.bunifuTextBox4.SelectedText = "";
            this.bunifuTextBox4.SelectionLength = 0;
            this.bunifuTextBox4.SelectionStart = 0;
            this.bunifuTextBox4.ShortcutsEnabled = true;
            this.bunifuTextBox4.Size = new System.Drawing.Size(331, 40);
            this.bunifuTextBox4.Style = Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox._Style.Bunifu;
            this.bunifuTextBox4.TabIndex = 44;
            this.bunifuTextBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.bunifuTextBox4.TextMarginLeft = 5;
            this.bunifuTextBox4.TextPlaceholder = "Enter RunTime";
            this.bunifuTextBox4.UseSystemPasswordChar = false;
            // 
            // bunifuDatePicker1
            // 
            this.bunifuDatePicker1.BorderRadius = 13;
            this.bunifuDatePicker1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.bunifuDatePicker1.DateBorderThickness = Bunifu.UI.WinForms.BunifuDatePicker.BorderThickness.Thick;
            this.bunifuDatePicker1.DateTextAlign = Bunifu.UI.WinForms.BunifuDatePicker.TextAlign.Left;
            this.bunifuDatePicker1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuDatePicker1.DisplayWeekNumbers = false;
            this.bunifuDatePicker1.DPHeight = 0;
            this.bunifuDatePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.bunifuDatePicker1.FillDatePicker = false;
            this.bunifuDatePicker1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.bunifuDatePicker1.Icon = ((System.Drawing.Image)(resources.GetObject("bunifuDatePicker1.Icon")));
            this.bunifuDatePicker1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(49)))), ((int)(((byte)(60)))));
            this.bunifuDatePicker1.IconLocation = Bunifu.UI.WinForms.BunifuDatePicker.Indicator.Right;
            this.bunifuDatePicker1.Location = new System.Drawing.Point(104, 204);
            this.bunifuDatePicker1.MinimumSize = new System.Drawing.Size(331, 32);
            this.bunifuDatePicker1.Name = "bunifuDatePicker1";
            this.bunifuDatePicker1.Size = new System.Drawing.Size(331, 32);
            this.bunifuDatePicker1.TabIndex = 46;
            // 
            // addMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.bunifuDatePicker1);
            this.Controls.Add(this.bunifuTextBox4);
            this.Controls.Add(this.bunifuTextBox3);
            this.Controls.Add(this.bunifuTextBox2);
            this.Controls.Add(this.bunifuTextBox1);
            this.Controls.Add(this.bunifuButton1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.bunifuImageButton1);
            this.Controls.Add(this.bunifuCustomLabel5);
            this.Name = "addMovie";
            this.Size = new System.Drawing.Size(523, 452);
            this.Load += new System.EventHandler(this.addMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel5;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton bunifuButton1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox bunifuTextBox1;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox bunifuTextBox2;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox bunifuTextBox3;
        private Bunifu.UI.WinForms.BunifuTextbox.BunifuTextBox bunifuTextBox4;
        private Bunifu.UI.WinForms.BunifuDatePicker bunifuDatePicker1;
    }
}
