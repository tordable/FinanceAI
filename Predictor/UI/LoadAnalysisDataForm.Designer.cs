namespace FinanceAI.UI
{
    partial class LoadAnalysisDataForm
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
            this.useYDataCheckBox = new System.Windows.Forms.CheckBox( );
            this.useQDataCheckBox = new System.Windows.Forms.CheckBox( );
            this.label1 = new System.Windows.Forms.Label( );
            this.cancelButton = new System.Windows.Forms.Button( );
            this.loadButton = new System.Windows.Forms.Button( );
            this.SuspendLayout( );
            // 
            // useYDataCheckBox
            // 
            this.useYDataCheckBox.AutoSize = true;
            this.useYDataCheckBox.Location = new System.Drawing.Point( 12, 36 );
            this.useYDataCheckBox.Name = "useYDataCheckBox";
            this.useYDataCheckBox.Size = new System.Drawing.Size( 103, 17 );
            this.useYDataCheckBox.TabIndex = 18;
            this.useYDataCheckBox.Text = "Use Yearly Data";
            this.useYDataCheckBox.UseVisualStyleBackColor = true;
            this.useYDataCheckBox.CheckedChanged += new System.EventHandler( this.useYDataCheckBox_CheckedChanged );
            // 
            // useQDataCheckBox
            // 
            this.useQDataCheckBox.AutoSize = true;
            this.useQDataCheckBox.Location = new System.Drawing.Point( 12, 12 );
            this.useQDataCheckBox.Name = "useQDataCheckBox";
            this.useQDataCheckBox.Size = new System.Drawing.Size( 116, 17 );
            this.useQDataCheckBox.TabIndex = 17;
            this.useQDataCheckBox.Text = "Use Quarterly Data";
            this.useQDataCheckBox.UseVisualStyleBackColor = true;
            this.useQDataCheckBox.CheckedChanged += new System.EventHandler( this.useQDataCheckBox_CheckedChanged );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 9, 59 );
            this.label1.MaximumSize = new System.Drawing.Size( 300, 0 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 245, 13 );
            this.label1.TabIndex = 16;
            this.label1.Text = "By default all non labeled data is taken for Analysis";
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point( 181, 91 );
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size( 75, 23 );
            this.cancelButton.TabIndex = 20;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler( this.cancelButton_Click );
            // 
            // loadButton
            // 
            this.loadButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.loadButton.Location = new System.Drawing.Point( 100, 91 );
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size( 75, 23 );
            this.loadButton.TabIndex = 19;
            this.loadButton.Text = "Load";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler( this.loadButton_Click );
            // 
            // LoadAnalysisDataForm
            // 
            this.AcceptButton = this.loadButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size( 268, 126 );
            this.Controls.Add( this.cancelButton );
            this.Controls.Add( this.loadButton );
            this.Controls.Add( this.useYDataCheckBox );
            this.Controls.Add( this.useQDataCheckBox );
            this.Controls.Add( this.label1 );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "LoadAnalysisDataForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Load Analysis Data";
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.CheckBox useYDataCheckBox;
        private System.Windows.Forms.CheckBox useQDataCheckBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button loadButton;
    }
}