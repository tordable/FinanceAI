namespace FinanceAI.Predictor
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager( typeof( MainForm ) );
            this.mainTab = new System.Windows.Forms.TabControl( );
            this.trainTab = new System.Windows.Forms.TabPage( );
            this.progressBar1 = new System.Windows.Forms.ProgressBar( );
            this.trainButton = new System.Windows.Forms.Button( );
            this.parametersButton = new System.Windows.Forms.Button( );
            this.trainingList = new System.Windows.Forms.ListBox( );
            this.loadTrainingButton = new System.Windows.Forms.Button( );
            this.analyzeTab = new System.Windows.Forms.TabPage( );
            this.loadAnalysisButton = new System.Windows.Forms.Button( );
            this.analysisList = new System.Windows.Forms.ListBox( );
            this.underweightList = new System.Windows.Forms.ListBox( );
            this.analyzeButton = new System.Windows.Forms.Button( );
            this.label1 = new System.Windows.Forms.Label( );
            this.label2 = new System.Windows.Forms.Label( );
            this.overweightList = new System.Windows.Forms.ListBox( );
            this.mainTab.SuspendLayout( );
            this.trainTab.SuspendLayout( );
            this.analyzeTab.SuspendLayout( );
            this.SuspendLayout( );
            // 
            // mainTab
            // 
            this.mainTab.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTab.Controls.Add( this.trainTab );
            this.mainTab.Controls.Add( this.analyzeTab );
            this.mainTab.Location = new System.Drawing.Point( 2, 4 );
            this.mainTab.Name = "mainTab";
            this.mainTab.SelectedIndex = 0;
            this.mainTab.Size = new System.Drawing.Size( 443, 377 );
            this.mainTab.TabIndex = 7;
            // 
            // trainTab
            // 
            this.trainTab.Controls.Add( this.progressBar1 );
            this.trainTab.Controls.Add( this.trainButton );
            this.trainTab.Controls.Add( this.parametersButton );
            this.trainTab.Controls.Add( this.trainingList );
            this.trainTab.Controls.Add( this.loadTrainingButton );
            this.trainTab.Location = new System.Drawing.Point( 4, 22 );
            this.trainTab.Name = "trainTab";
            this.trainTab.Padding = new System.Windows.Forms.Padding( 3 );
            this.trainTab.Size = new System.Drawing.Size( 435, 351 );
            this.trainTab.TabIndex = 0;
            this.trainTab.Text = "Train";
            this.trainTab.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar1.Location = new System.Drawing.Point( 6, 321 );
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size( 422, 23 );
            this.progressBar1.TabIndex = 4;
            // 
            // trainButton
            // 
            this.trainButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.trainButton.Location = new System.Drawing.Point( 127, 292 );
            this.trainButton.Name = "trainButton";
            this.trainButton.Size = new System.Drawing.Size( 75, 23 );
            this.trainButton.TabIndex = 3;
            this.trainButton.Text = "Train";
            this.trainButton.UseVisualStyleBackColor = true;
            // 
            // parametersButton
            // 
            this.parametersButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.parametersButton.Location = new System.Drawing.Point( 6, 292 );
            this.parametersButton.Name = "parametersButton";
            this.parametersButton.Size = new System.Drawing.Size( 115, 23 );
            this.parametersButton.TabIndex = 2;
            this.parametersButton.Text = "Training Parameters";
            this.parametersButton.UseVisualStyleBackColor = true;
            // 
            // trainingList
            // 
            this.trainingList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.trainingList.FormattingEnabled = true;
            this.trainingList.Location = new System.Drawing.Point( 6, 35 );
            this.trainingList.Name = "trainingList";
            this.trainingList.Size = new System.Drawing.Size( 422, 251 );
            this.trainingList.TabIndex = 1;
            // 
            // loadTrainingButton
            // 
            this.loadTrainingButton.Location = new System.Drawing.Point( 6, 6 );
            this.loadTrainingButton.Name = "loadTrainingButton";
            this.loadTrainingButton.Size = new System.Drawing.Size( 115, 23 );
            this.loadTrainingButton.TabIndex = 0;
            this.loadTrainingButton.Text = "Load Training Data";
            this.loadTrainingButton.UseVisualStyleBackColor = true;
            // 
            // analyzeTab
            // 
            this.analyzeTab.Controls.Add( this.loadAnalysisButton );
            this.analyzeTab.Controls.Add( this.analysisList );
            this.analyzeTab.Controls.Add( this.underweightList );
            this.analyzeTab.Controls.Add( this.analyzeButton );
            this.analyzeTab.Controls.Add( this.label1 );
            this.analyzeTab.Controls.Add( this.label2 );
            this.analyzeTab.Controls.Add( this.overweightList );
            this.analyzeTab.Location = new System.Drawing.Point( 4, 22 );
            this.analyzeTab.Name = "analyzeTab";
            this.analyzeTab.Padding = new System.Windows.Forms.Padding( 3 );
            this.analyzeTab.Size = new System.Drawing.Size( 435, 351 );
            this.analyzeTab.TabIndex = 1;
            this.analyzeTab.Text = "Analyze";
            this.analyzeTab.UseVisualStyleBackColor = true;
            // 
            // loadAnalysisButton
            // 
            this.loadAnalysisButton.Location = new System.Drawing.Point( 6, 6 );
            this.loadAnalysisButton.Name = "loadAnalysisButton";
            this.loadAnalysisButton.Size = new System.Drawing.Size( 115, 23 );
            this.loadAnalysisButton.TabIndex = 14;
            this.loadAnalysisButton.Text = "Load Analysis Data";
            this.loadAnalysisButton.UseVisualStyleBackColor = true;
            // 
            // analysisList
            // 
            this.analysisList.FormattingEnabled = true;
            this.analysisList.Location = new System.Drawing.Point( 6, 35 );
            this.analysisList.Name = "analysisList";
            this.analysisList.Size = new System.Drawing.Size( 422, 134 );
            this.analysisList.TabIndex = 15;
            // 
            // underweightList
            // 
            this.underweightList.FormattingEnabled = true;
            this.underweightList.Location = new System.Drawing.Point( 6, 224 );
            this.underweightList.Name = "underweightList";
            this.underweightList.Size = new System.Drawing.Size( 208, 121 );
            this.underweightList.TabIndex = 18;
            // 
            // analyzeButton
            // 
            this.analyzeButton.Location = new System.Drawing.Point( 6, 175 );
            this.analyzeButton.Name = "analyzeButton";
            this.analyzeButton.Size = new System.Drawing.Size( 115, 23 );
            this.analyzeButton.TabIndex = 16;
            this.analyzeButton.Text = "Analyze Data";
            this.analyzeButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point( 6, 208 );
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size( 70, 13 );
            this.label1.TabIndex = 17;
            this.label1.Text = "Underweight:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point( 219, 208 );
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size( 64, 13 );
            this.label2.TabIndex = 20;
            this.label2.Text = "Overweight:";
            // 
            // overweightList
            // 
            this.overweightList.FormattingEnabled = true;
            this.overweightList.Location = new System.Drawing.Point( 220, 224 );
            this.overweightList.Name = "overweightList";
            this.overweightList.Size = new System.Drawing.Size( 208, 121 );
            this.overweightList.TabIndex = 19;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF( 6F, 13F );
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size( 446, 383 );
            this.Controls.Add( this.mainTab );
            this.Icon = ((System.Drawing.Icon)(resources.GetObject( "$this.Icon" )));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Financial Neural Net Predictor";
            this.mainTab.ResumeLayout( false );
            this.trainTab.ResumeLayout( false );
            this.analyzeTab.ResumeLayout( false );
            this.analyzeTab.PerformLayout( );
            this.ResumeLayout( false );

        }

        #endregion

        private System.Windows.Forms.TabControl mainTab;
        private System.Windows.Forms.TabPage trainTab;
        private System.Windows.Forms.TabPage analyzeTab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox overweightList;
        private System.Windows.Forms.ListBox underweightList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button analyzeButton;
        private System.Windows.Forms.ListBox analysisList;
        private System.Windows.Forms.Button loadAnalysisButton;
        private System.Windows.Forms.Button loadTrainingButton;
        private System.Windows.Forms.ListBox trainingList;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button trainButton;
        private System.Windows.Forms.Button parametersButton;
    }
}

