namespace TransportApp
{
    partial class frmMain
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.lblShow = new System.Windows.Forms.Label();
            this.lblFrom = new System.Windows.Forms.Label();
            this.lblTo = new System.Windows.Forms.Label();
            this.grpShow = new System.Windows.Forms.GroupBox();
            this.rdbDepatureBoard = new System.Windows.Forms.RadioButton();
            this.rdbConnections = new System.Windows.Forms.RadioButton();
            this.cboFromLocation = new System.Windows.Forms.ComboBox();
            this.cboToLocation = new System.Windows.Forms.ComboBox();
            this.btnMapFrom = new System.Windows.Forms.Button();
            this.btnMapTo = new System.Windows.Forms.Button();
            this.SearchButton = new System.Windows.Forms.Button();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.Depature = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.From = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.To = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Plattform = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Arrival = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblTime = new System.Windows.Forms.Label();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.btnEmail = new System.Windows.Forms.Button();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.grpHeader = new System.Windows.Forms.GroupBox();
            this.picHeader = new System.Windows.Forms.PictureBox();
            this.lblHeaderText = new System.Windows.Forms.Label();
            this.lblHeaderTitel = new System.Windows.Forms.Label();
            this.grpShow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.grpHeader.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).BeginInit();
            this.SuspendLayout();
            // 
            // lblShow
            // 
            this.lblShow.AutoSize = true;
            this.lblShow.Location = new System.Drawing.Point(12, 125);
            this.lblShow.Name = "lblShow";
            this.lblShow.Size = new System.Drawing.Size(46, 17);
            this.lblShow.TabIndex = 0;
            this.lblShow.Text = "Show:";
            // 
            // lblFrom
            // 
            this.lblFrom.AutoSize = true;
            this.lblFrom.Location = new System.Drawing.Point(13, 162);
            this.lblFrom.Name = "lblFrom";
            this.lblFrom.Size = new System.Drawing.Size(44, 17);
            this.lblFrom.TabIndex = 0;
            this.lblFrom.Text = "From:";
            // 
            // lblTo
            // 
            this.lblTo.AutoSize = true;
            this.lblTo.Location = new System.Drawing.Point(453, 162);
            this.lblTo.Name = "lblTo";
            this.lblTo.Size = new System.Drawing.Size(29, 17);
            this.lblTo.TabIndex = 0;
            this.lblTo.Text = "To:";
            // 
            // grpShow
            // 
            this.grpShow.Controls.Add(this.rdbDepatureBoard);
            this.grpShow.Controls.Add(this.rdbConnections);
            this.grpShow.Location = new System.Drawing.Point(61, 109);
            this.grpShow.Name = "grpShow";
            this.grpShow.Size = new System.Drawing.Size(810, 39);
            this.grpShow.TabIndex = 0;
            this.grpShow.TabStop = false;
            // 
            // rdbDepatureBoard
            // 
            this.rdbDepatureBoard.AutoSize = true;
            this.rdbDepatureBoard.Location = new System.Drawing.Point(131, 12);
            this.rdbDepatureBoard.Name = "rdbDepatureBoard";
            this.rdbDepatureBoard.Size = new System.Drawing.Size(127, 21);
            this.rdbDepatureBoard.TabIndex = 1;
            this.rdbDepatureBoard.TabStop = true;
            this.rdbDepatureBoard.Text = "depature board";
            this.rdbDepatureBoard.UseVisualStyleBackColor = true;
            this.rdbDepatureBoard.Click += new System.EventHandler(this.RadioButtonsShow);
            // 
            // rdbConnections
            // 
            this.rdbConnections.AutoSize = true;
            this.rdbConnections.Checked = true;
            this.rdbConnections.Location = new System.Drawing.Point(6, 12);
            this.rdbConnections.Name = "rdbConnections";
            this.rdbConnections.Size = new System.Drawing.Size(105, 21);
            this.rdbConnections.TabIndex = 0;
            this.rdbConnections.TabStop = true;
            this.rdbConnections.Text = "connections";
            this.rdbConnections.UseVisualStyleBackColor = true;
            this.rdbConnections.Click += new System.EventHandler(this.RadioButtonsShow);
            // 
            // cboFromLocation
            // 
            this.cboFromLocation.FormattingEnabled = true;
            this.cboFromLocation.Location = new System.Drawing.Point(61, 159);
            this.cboFromLocation.Name = "cboFromLocation";
            this.cboFromLocation.Size = new System.Drawing.Size(353, 24);
            this.cboFromLocation.TabIndex = 2;
            this.cboFromLocation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboKeyUp);
            // 
            // cboToLocation
            // 
            this.cboToLocation.FormattingEnabled = true;
            this.cboToLocation.Location = new System.Drawing.Point(485, 159);
            this.cboToLocation.Name = "cboToLocation";
            this.cboToLocation.Size = new System.Drawing.Size(353, 24);
            this.cboToLocation.TabIndex = 3;
            this.cboToLocation.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cboKeyUp);
            // 
            // btnMapFrom
            // 
            this.btnMapFrom.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMapFrom.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMapFrom.BackgroundImage")));
            this.btnMapFrom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMapFrom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMapFrom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMapFrom.Location = new System.Drawing.Point(420, 159);
            this.btnMapFrom.Name = "btnMapFrom";
            this.btnMapFrom.Size = new System.Drawing.Size(27, 24);
            this.btnMapFrom.TabIndex = 0;
            this.btnMapFrom.TabStop = false;
            this.btnMapFrom.UseVisualStyleBackColor = false;
            this.btnMapFrom.Click += new System.EventHandler(this.notInplemented);
            // 
            // btnMapTo
            // 
            this.btnMapTo.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnMapTo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnMapTo.BackgroundImage")));
            this.btnMapTo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMapTo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMapTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMapTo.Location = new System.Drawing.Point(844, 159);
            this.btnMapTo.Name = "btnMapTo";
            this.btnMapTo.Size = new System.Drawing.Size(27, 24);
            this.btnMapTo.TabIndex = 0;
            this.btnMapTo.TabStop = false;
            this.btnMapTo.UseVisualStyleBackColor = false;
            this.btnMapTo.Click += new System.EventHandler(this.notInplemented);
            // 
            // SearchButton
            // 
            this.SearchButton.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.SearchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchButton.Location = new System.Drawing.Point(796, 244);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(75, 31);
            this.SearchButton.TabIndex = 8;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = false;
            this.SearchButton.Click += new System.EventHandler(this.SearchButton_Click);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Depature,
            this.From,
            this.To,
            this.Plattform,
            this.Duration,
            this.Arrival});
            this.dataGridView.Location = new System.Drawing.Point(16, 281);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.RowTemplate.Height = 24;
            this.dataGridView.Size = new System.Drawing.Size(855, 304);
            this.dataGridView.TabIndex = 9;
            // 
            // Depature
            // 
            this.Depature.HeaderText = "Depature";
            this.Depature.MinimumWidth = 6;
            this.Depature.Name = "Depature";
            this.Depature.Width = 125;
            // 
            // From
            // 
            this.From.HeaderText = "From";
            this.From.MinimumWidth = 6;
            this.From.Name = "From";
            this.From.Width = 125;
            // 
            // To
            // 
            this.To.HeaderText = "To";
            this.To.MinimumWidth = 6;
            this.To.Name = "To";
            this.To.Width = 125;
            // 
            // Plattform
            // 
            this.Plattform.HeaderText = "Plattform";
            this.Plattform.MinimumWidth = 6;
            this.Plattform.Name = "Plattform";
            this.Plattform.Width = 125;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Duration";
            this.Duration.MinimumWidth = 6;
            this.Duration.Name = "Duration";
            this.Duration.Width = 125;
            // 
            // Arrival
            // 
            this.Arrival.HeaderText = "Arrival";
            this.Arrival.MinimumWidth = 6;
            this.Arrival.Name = "Arrival";
            this.Arrival.Width = 125;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(13, 205);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(43, 17);
            this.lblTime.TabIndex = 0;
            this.lblTime.Text = "Time:";
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "";
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(238, 203);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(209, 22);
            this.dtpDate.TabIndex = 5;
            this.dtpDate.Value = new System.DateTime(2020, 12, 15, 15, 42, 59, 0);
            // 
            // tbxEmail
            // 
            this.tbxEmail.AccessibleDescription = "email";
            this.tbxEmail.Location = new System.Drawing.Point(16, 616);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(741, 22);
            this.tbxEmail.TabIndex = 10;
            this.tbxEmail.Text = "example@email.com";
            // 
            // btnEmail
            // 
            this.btnEmail.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.btnEmail.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmail.Location = new System.Drawing.Point(763, 610);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(108, 35);
            this.btnEmail.TabIndex = 11;
            this.btnEmail.Text = "send Email";
            this.btnEmail.UseVisualStyleBackColor = false;
            this.btnEmail.Click += new System.EventHandler(this.notInplemented);
            // 
            // dtpTime
            // 
            this.dtpTime.Checked = false;
            this.dtpTime.CustomFormat = "HH:mm";
            this.dtpTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTime.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dtpTime.Location = new System.Drawing.Point(61, 203);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.ShowUpDown = true;
            this.dtpTime.Size = new System.Drawing.Size(171, 22);
            this.dtpTime.TabIndex = 4;
            // 
            // grpHeader
            // 
            this.grpHeader.BackColor = System.Drawing.SystemColors.Desktop;
            this.grpHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.grpHeader.Controls.Add(this.picHeader);
            this.grpHeader.Controls.Add(this.lblHeaderText);
            this.grpHeader.Controls.Add(this.lblHeaderTitel);
            this.grpHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpHeader.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpHeader.Location = new System.Drawing.Point(0, 0);
            this.grpHeader.Name = "grpHeader";
            this.grpHeader.Size = new System.Drawing.Size(886, 103);
            this.grpHeader.TabIndex = 13;
            this.grpHeader.TabStop = false;
            // 
            // picHeader
            // 
            this.picHeader.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picHeader.BackgroundImage")));
            this.picHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picHeader.Location = new System.Drawing.Point(16, 21);
            this.picHeader.Name = "picHeader";
            this.picHeader.Size = new System.Drawing.Size(81, 69);
            this.picHeader.TabIndex = 16;
            this.picHeader.TabStop = false;
            // 
            // lblHeaderText
            // 
            this.lblHeaderText.AutoSize = true;
            this.lblHeaderText.Font = new System.Drawing.Font("Arial", 8.2F);
            this.lblHeaderText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHeaderText.Location = new System.Drawing.Point(656, 84);
            this.lblHeaderText.Name = "lblHeaderText";
            this.lblHeaderText.Size = new System.Drawing.Size(197, 16);
            this.lblHeaderText.TabIndex = 15;
            this.lblHeaderText.Text = "powerd by SwissTransport API";
            // 
            // lblHeaderTitel
            // 
            this.lblHeaderTitel.AutoSize = true;
            this.lblHeaderTitel.Font = new System.Drawing.Font("Arial Black", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTitel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblHeaderTitel.Location = new System.Drawing.Point(101, 40);
            this.lblHeaderTitel.Name = "lblHeaderTitel";
            this.lblHeaderTitel.Size = new System.Drawing.Size(195, 33);
            this.lblHeaderTitel.TabIndex = 14;
            this.lblHeaderTitel.Text = "TransportApp";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(886, 766);
            this.Controls.Add(this.grpHeader);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.btnEmail);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.btnMapTo);
            this.Controls.Add(this.btnMapFrom);
            this.Controls.Add(this.cboToLocation);
            this.Controls.Add(this.cboFromLocation);
            this.Controls.Add(this.grpShow);
            this.Controls.Add(this.lblTo);
            this.Controls.Add(this.lblFrom);
            this.Controls.Add(this.lblShow);
            this.MaximumSize = new System.Drawing.Size(904, 813);
            this.MinimumSize = new System.Drawing.Size(904, 813);
            this.Name = "frmMain";
            this.Text = "TransportApp";
            this.grpShow.ResumeLayout(false);
            this.grpShow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.grpHeader.ResumeLayout(false);
            this.grpHeader.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picHeader)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShow;
        private System.Windows.Forms.Label lblFrom;
        private System.Windows.Forms.Label lblTo;
        private System.Windows.Forms.GroupBox grpShow;
        private System.Windows.Forms.RadioButton rdbDepatureBoard;
        private System.Windows.Forms.RadioButton rdbConnections;
        private System.Windows.Forms.ComboBox cboFromLocation;
        private System.Windows.Forms.ComboBox cboToLocation;
        private System.Windows.Forms.Button btnMapFrom;
        private System.Windows.Forms.Button btnMapTo;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn Depature;
        private System.Windows.Forms.DataGridViewTextBoxColumn From;
        private System.Windows.Forms.DataGridViewTextBoxColumn To;
        private System.Windows.Forms.DataGridViewTextBoxColumn Plattform;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn Arrival;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.GroupBox grpHeader;
        private System.Windows.Forms.PictureBox picHeader;
        private System.Windows.Forms.Label lblHeaderText;
        private System.Windows.Forms.Label lblHeaderTitel;
    }
}

