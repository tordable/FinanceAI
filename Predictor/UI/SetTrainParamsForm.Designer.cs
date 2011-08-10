namespace FinanceAI.UI
{
    partial class SetTrainParamsForm
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
            this.cancelButton = new System.Windows.Forms.Button( );
            this.acceptButton = new System.Windows.Forms.Button( );
            this.label1 = new System.Windows.Forms.Label( );
            this.numHiddenNodesTextBox = new System.Windows.Forms.TextBox( );
            this.randomIniRadioButton = new System.Windows.Forms.RadioButton( );
            this.zeroIniRadioButton = new System.Windows.Forms.RadioButton( );
            this.label2 = new System.Windows.Forms.Label( );
            this.learningRateTextBox = new System.Windows.Forms.TextBox( );
            this.label3 = new System.Windows.Forms.Label( );
            this.maxRepetitionsTextBox = new System.Windows.Forms.TextBox( );
            this.SuspendLayout( );
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point( 147, 155 );
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size( 75, 23 );
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler( this.cancelButton_Click );
            // 
            // acceptButton
            // 
            this.acceptButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.acceptButton.Location = new System.Drawing.Point( 66, 155 );
            this.acceptButton.Name = "acceptButton";
            this.acceptButton.Size = new System.Drawing.Size( 75, 23 );
            this.acceptButton.TabIndex = 1;
            this.acceptButton.Text = "Accept";
            this.acceptButton.UseVisualStyleBackColor = true;
            this.acceptButton.Click += new System.EventHandler( this.acceptButton_Click );
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 12, 66 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 130, 13 );
            this.label1.TabIndex = 2;
            this.label1.Text = "Number of Hidden Nodes:";
            // 
            // numHiddenNodesTextBox
            // 
            this.numHiddenNodesTextBox.Location = new System.Drawing.Point( 176, 63 );
            this.numHiddenNodesTextBox.Name = "numHiddenNodesTextBox";
            this.numHiddenNodesTextBox.Size = new System.Drawing.Size( 46, 20 );
            this.numHiddenNodesTextBox.TabIndex = 3;
            this.numHiddenNodesTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // randomIniRadioButton
            // 
            this.randomIniRadioButton.AutoSize = true;
            this.randomIniRadioButton.Location = new System.Drawing.Point( 13, 13 );
            this.randomIniRadioButton.Name = "randomIniRadioButton";
            this.randomIniRadioButton.Size = new System.Drawing.Size( 156, 17 );
            this.randomIniRadioButton.TabIndex = 4;
            this.randomIniRadioButton.TabStop = true;
            this.randomIniRadioButton.Text = "Initialize with random values";
            this.randomIniRadioButton.UseVisualStyleBackColor = true;
            this.randomIniRadioButton.CheckedChanged += new System.EventHandler( this.randomIniRadioButton_CheckedChanged );
            // 
            // zeroIniRadioButton
            // 
            this.zeroIniRadioButton.AutoSize = true;
            this.zeroIniRadioButton.Location = new System.Drawing.Point( 13, 37 );
            this.zeroIniRadioButton.Name = "zeroIniRadioButton";
            this.zeroIniRadioButton.Size = new System.Drawing.Size( 83, 17 );
            this.zeroIniRadioButton.TabIndex = 5;
            this.zeroIniRadioButton.TabStop = true;
            this.zeroIniRadioButton.Text = "Initialize at 0";
            this.zeroIniRadioButton.UseVisualStyleBackColor = true;
            this.zeroIniRadioButton.CheckedChanged += new System.EventHandler( this.zeroIniRadioButton_CheckedChanged );
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point( 12, 92 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 77, 13 );
            this.label2.TabIndex = 6;
            this.label2.Text = "Learning Rate:";
            // 
            // learningRateTextBox
            // 
            this.learningRateTextBox.Location = new System.Drawing.Point( 176, 89 );
            this.learningRateTextBox.Name = "learningRateTextBox";
            this.learningRateTextBox.Size = new System.Drawing.Size( 46, 20 );
            this.learningRateTextBox.TabIndex = 7;
            this.learningRateTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point( 12, 118 );
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size( 138, 13 );
            this.label3.TabIndex = 8;
            this.label3.Text = "Max Number of Repetitions:";
            // 
            // maxRepetitionsTextBox
            // 
            this.maxRepetitionsTextBox.Location = new System.Drawing.Point( 176, 115 );
            this.maxRepetitionsTextBox.Name = "maxRepetitionsTextBox";
            this.maxRepetitionsTextBox.Size = new System.Drawing.Size( 46, 20 );
            this.maxRepetitionsTextBox.TabIndex = 9;
            this.maxRepetitionsTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // SetTrainParamsForm
            // 
            this.AcceptButton = this.acceptButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.ClientSize = new System.Drawing.Size( 234, 190 );
            this.Controls.Add( this.maxRepetitionsTextBox );
            this.Controls.Add( this.label3 );
            this.Controls.Add( this.learningRateTextBox );
            this.Controls.Add( this.label2 );
            this.Controls.Add( this.zeroIniRadioButton );
            this.Controls.Add( this.randomIniRadioButton );
            this.Controls.Add( this.numHiddenNodesTextBox );
            this.Controls.Add( this.label1 );
            this.Controls.Add( this.acceptButton );
            this.Controls.Add( this.cancelButton );
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SetTrainParamsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Set Training Parameters";
            this.ResumeLayout( false );
            this.PerformLayout( );

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button acceptButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numHiddenNodesTextBox;
        private System.Windows.Forms.RadioButton randomIniRadioButton;
        private System.Windows.Forms.RadioButton zeroIniRadioButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox learningRateTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox maxRepetitionsTextBox;
    }
}