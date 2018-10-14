namespace WForm___Group_Stage
{
    partial class Form1
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
            this.submitButton = new System.Windows.Forms.Button();
            this.inputTeamTextBox = new System.Windows.Forms.TextBox();
            this.teamListBox = new System.Windows.Forms.ListBox();
            this.removeButton = new System.Windows.Forms.Button();
            this.tableStandingDataGrid = new System.Windows.Forms.DataGridView();
            this.startButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tableStandingDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(156, 79);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 1;
            this.submitButton.Text = "Add";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // inputTeamTextBox
            // 
            this.inputTeamTextBox.Location = new System.Drawing.Point(50, 82);
            this.inputTeamTextBox.Name = "inputTeamTextBox";
            this.inputTeamTextBox.Size = new System.Drawing.Size(100, 20);
            this.inputTeamTextBox.TabIndex = 2;
            // 
            // teamListBox
            // 
            this.teamListBox.FormattingEnabled = true;
            this.teamListBox.Location = new System.Drawing.Point(276, 79);
            this.teamListBox.Name = "teamListBox";
            this.teamListBox.Size = new System.Drawing.Size(120, 95);
            this.teamListBox.TabIndex = 3;
            // 
            // removeButton
            // 
            this.removeButton.Location = new System.Drawing.Point(403, 79);
            this.removeButton.Name = "removeButton";
            this.removeButton.Size = new System.Drawing.Size(75, 23);
            this.removeButton.TabIndex = 4;
            this.removeButton.Text = "Remove";
            this.removeButton.UseVisualStyleBackColor = true;
            this.removeButton.Click += new System.EventHandler(this.removeButton_Click);
            // 
            // tableStandingDataGrid
            // 
            this.tableStandingDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableStandingDataGrid.Location = new System.Drawing.Point(50, 232);
            this.tableStandingDataGrid.Name = "tableStandingDataGrid";
            this.tableStandingDataGrid.Size = new System.Drawing.Size(314, 197);
            this.tableStandingDataGrid.TabIndex = 5;
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(370, 232);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.tableStandingDataGrid);
            this.Controls.Add(this.removeButton);
            this.Controls.Add(this.teamListBox);
            this.Controls.Add(this.inputTeamTextBox);
            this.Controls.Add(this.submitButton);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.tableStandingDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox inputTeamTextBox;
        private System.Windows.Forms.ListBox teamListBox;
        private System.Windows.Forms.Button removeButton;
        private System.Windows.Forms.DataGridView tableStandingDataGrid;
        private System.Windows.Forms.Button startButton;
    }
}

