namespace FinanceAI.UI
{
    partial class TestResultsForm
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
            this.resultsTextBox = new System.Windows.Forms.TextBox( );
            this.acceptButton = new System.Windows.Forms.Button( );
            this.SuspendLayout( );
            // 
            // resultsTextBox
            // 
            this.resultsTextBox.Location = new System.Drawing.Point( 12, 12 );
            this.resultsTextBox.Multiline = true;
            this.resultsTextBox.Name = "resultsTextBox";
            this.resultsTextBox.ReadOnly = true;
            this.resultsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.resultsTextBox.Size = new System.Drawing.Size( 268, 158 );
            this.resultsTextBox.TabIndex = 0;
            // 
            // acceptButton
            // 
            this.acceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptButton.Location = new System.Drawing.Point( 205, 183 );
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size( 75, 23 );
            this.acceptButton.TabIndex = 1;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler( this.acceptButton_Click );
            // 
            // TestResultsForm
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.acceptButton;
            this.ClientSize = new System.Drawing.Size( 292, 218 );
            this.Controls.Add( this.acceptButton );
            this.Controls.Add( this.resultsTextBox );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TestResultsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Test Results";
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.TextBox resultsTextBox;
        private System.Windows.Forms.Button acceptButton;
    }
}