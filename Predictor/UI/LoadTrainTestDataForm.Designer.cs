namespace FinanceAI.UI
{
    partial class LoadTrainTestDataForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if (disposing && (components != null))
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent( )
        {
            this.label1 = new System.Windows.Forms.Label( );
            this.label2 = new System.Windows.Forms.Label( );
            this.noTestSplitRadioButton = new System.Windows.Forms.RadioButton( );
            this.randomTestSplitRadioButton = new System.Windows.Forms.RadioButton( );
            this.dateTestSplitRadioButton = new System.Windows.Forms.RadioButton( );
            this.companyTestSplitRadioButton = new System.Windows.Forms.RadioButton( );
            this.randomPercentageTextBox = new System.Windows.Forms.TextBox( );
            this.label3 = new System.Windows.Forms.Label( );
            this.label4 = new System.Windows.Forms.Label( );
            this.companyTrainingCheckedBox = new System.Windows.Forms.CheckedListBox( );
            this.loadButton = new System.Windows.Forms.Button( );
            this.cancelButton = new System.Windows.Forms.Button( );
            this.dateSplitPicker = new System.Windows.Forms.DateTimePicker( );
            this.useQDataCheckBox = new System.Windows.Forms.CheckBox( );
            this.useYDataCheckBox = new System.Windows.Forms.CheckBox( );
            this.SuspendLayout( );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 12, 60 );
            this.label1.MaximumSize = new System.Drawing.Size( 300, 0 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 256, 13 );
            this.label1.TabIndex = 0;
            this.label1.Text = "By default all labeled data is taken for Training / Test";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point( 12, 83 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 316, 13 );
            this.label2.TabIndex = 1;
            this.label2.Text = "Please indicate how you wish to split the Training / Test datasets:";
            // 
            // noTestSplitRadioButton
            // 
            this.noTestSplitRadioButton.AutoSize = true;
            this.noTestSplitRadioButton.Location = new System.Drawing.Point( 15, 110 );
            this.noTestSplitRadioButton.Name = "noTestSplitRadioButton";
            this.noTestSplitRadioButton.Size = new System.Drawing.Size( 299, 17 );
            this.noTestSplitRadioButton.TabIndex = 2;
            this.noTestSplitRadioButton.TabStop = true;
            this.noTestSplitRadioButton.Text = "No Separate Test Split (Performance given on training set)";
            this.noTestSplitRadioButton.UseVisualStyleBackColor = true;
            this.noTestSplitRadioButton.CheckedChanged += new System.EventHandler( this.noTestSplitRadioButton_CheckedChanged );
            // 
            // randomTestSplitRadioButton
            // 
            this.randomTestSplitRadioButton.AutoSize = true;
            this.randomTestSplitRadioButton.Location = new System.Drawing.Point( 15, 134 );
            this.randomTestSplitRadioButton.Name = "randomTestSplitRadioButton";
            this.randomTestSplitRadioButton.Size = new System.Drawing.Size( 91, 17 );
            this.randomTestSplitRadioButton.TabIndex = 3;
            this.randomTestSplitRadioButton.TabStop = true;
            this.randomTestSplitRadioButton.Text = "Random Split.";
            this.randomTestSplitRadioButton.UseVisualStyleBackColor = true;
            this.randomTestSplitRadioButton.CheckedChanged += new System.EventHandler( this.randomTestSplitRadioButton_CheckedChanged );
            // 
            // dateTestSplitRadioButton
            // 
            this.dateTestSplitRadioButton.AutoSize = true;
            this.dateTestSplitRadioButton.Location = new System.Drawing.Point( 15, 158 );
            this.dateTestSplitRadioButton.Name = "dateTestSplitRadioButton";
            this.dateTestSplitRadioButton.Size = new System.Drawing.Size( 108, 17 );
            this.dateTestSplitRadioButton.TabIndex = 4;
            this.dateTestSplitRadioButton.TabStop = true;
            this.dateTestSplitRadioButton.Text = "Date Split. Before";
            this.dateTestSplitRadioButton.UseVisualStyleBackColor = true;
            this.dateTestSplitRadioButton.CheckedChanged += new System.EventHandler( this.dateTestSplitRadioButton_CheckedChanged );
            // 
            // companyTestSplitRadioButton
            // 
            this.companyTestSplitRadioButton.AutoSize = true;
            this.companyTestSplitRadioButton.Location = new System.Drawing.Point( 15, 181 );
            this.companyTestSplitRadioButton.Name = "companyTestSplitRadioButton";
            this.companyTestSplitRadioButton.Size = new System.Drawing.Size( 270, 17 );
            this.companyTestSplitRadioButton.TabIndex = 5;
            this.companyTestSplitRadioButton.TabStop = true;
            this.companyTestSplitRadioButton.Text = "Company Split. Please select companies for training:";
            this.companyTestSplitRadioButton.UseVisualStyleBackColor = true;
            this.companyTestSplitRadioButton.CheckedChanged += new System.EventHandler( this.companyTestSplitRadioButton_CheckedChanged );
            // 
            // randomPercentageTextBox
            // 
            this.randomPercentageTextBox.Location = new System.Drawing.Point( 110, 133 );
            this.randomPercentageTextBox.Name = "randomPercentageTextBox";
            this.randomPercentageTextBox.Size = new System.Drawing.Size( 21, 20 );
            this.randomPercentageTextBox.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point( 137, 136 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 67, 13 );
            this.label3.TabIndex = 8;
            this.label3.Text = "% for training";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point( 219, 160 );
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size( 56, 13 );
            this.label4.TabIndex = 9;
            this.label4.Text = "for training";
            // 
            // companyTrainingCheckedBox
            // 
            this.companyTrainingCheckedBox.FormattingEnabled = true;
            this.companyTrainingCheckedBox.Location = new System.Drawing.Point( 15, 204 );
            this.companyTrainingCheckedBox.Name = "companyTrainingCheckedBox";
            this.companyTrainingCheckedBox.ScrollAlwaysVisible = true;
            this.companyTrainingCheckedBox.Size = new System.Drawing.Size( 316, 109 );
            this.companyTrainingCheckedBox.TabIndex = 10;
            // 
            // loadButton
            // 
            this.loadButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.loadButton.Location = new System.Drawing.Point( 175, 319 );
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size( 75, 23 );
            this.loadButton.TabIndex = 11;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler( this.loadButton_Click );
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point( 256, 319 );
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size( 75, 23 );
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler( this.cancelButton_Click );
            // 
            // dateSplitPicker
            // 
            this.dateSplitPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateSplitPicker.Location = new System.Drawing.Point( 129, 156 );
            this.dateSplitPicker.Name = "dateSplitPicker";
            this.dateSplitPicker.Size = new System.Drawing.Size( 84, 20 );
            this.dateSplitPicker.TabIndex = 13;
            this.dateSplitPicker.Value = new System.DateTime( 2008, 3, 27, 0, 0, 0, 0 );
            // 
            // useQDataCheckBox
            // 
            this.useQDataCheckBox.AutoSize = true;
            this.useQDataCheckBox.Location = new System.Drawing.Point( 15, 13 );
            this.useQDataCheckBox.Name = "useQDataCheckBox";
            this.useQDataCheckBox.Size = new System.Drawing.Size( 116, 17 );
            this.useQDataCheckBox.TabIndex = 14;
            this.useQDataCheckBox.Text = "Use Quarterly Data";
            this.useQDataCheckBox.UseVisualStyleBackColor = true;
            this.useQDataCheckBox.CheckedChanged += new System.EventHandler( this.useQDataCheckBox_CheckedChanged );
            // 
            // useYDataCheckBox
            // 
            this.useYDataCheckBox.AutoSize = true;
            this.useYDataCheckBox.Location = new System.Drawing.Point( 15, 37 );
            this.useYDataCheckBox.Name = "useYDataCheckBox";
            this.useYDataCheckBox.Size = new System.Drawing.Size( 103, 17 );
            this.useYDataCheckBox.TabIndex = 15;
            this.useYDataCheckBox.Text = "Use Yearly Data";
            this.useYDataCheckBox.UseVisualStyleBackColor = true;
            this.useYDataCheckBox.CheckedChanged += new System.EventHandler( this.useYDataCheckBox_CheckedChanged );
            // 
            // LoadTrainTestDataForm
            // 
            this.AcceptButton = this.loadButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size( 343, 354 );
            this.Controls.Add( this.useYDataCheckBox );
            this.Controls.Add( this.useQDataCheckBox );
            this.Controls.Add( this.dateSplitPicker );
            this.Controls.Add( this.cancelButton );
            this.Controls.Add( this.loadButton );
            this.Controls.Add( this.companyTrainingCheckedBox );
            this.Controls.Add( this.label4 );
            this.Controls.Add( this.label3 );
            this.Controls.Add( this.randomPercentageTextBox );
            this.Controls.Add( this.companyTestSplitRadioButton );
            this.Controls.Add( this.dateTestSplitRadioButton );
            this.Controls.Add( this.randomTestSplitRadioButton );
            this.Controls.Add( this.noTestSplitRadioButton );
            this.Controls.Add( this.label2 );
            this.Controls.Add( this.label1 );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoadTrainTestDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Load Training Data";
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton noTestSplitRadioButton;
        private System.Windows.Forms.RadioButton randomTestSplitRadioButton;
        private System.Windows.Forms.RadioButton dateTestSplitRadioButton;
        private System.Windows.Forms.RadioButton companyTestSplitRadioButton;
        private System.Windows.Forms.TextBox randomPercentageTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckedListBox companyTrainingCheckedBox;
        private System.Windows.Forms.Button loadButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.DateTimePicker dateSplitPicker;
        private System.Windows.Forms.CheckBox useQDataCheckBox;
        private System.Windows.Forms.CheckBox useYDataCheckBox;
    }
}