namespace LW31
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
            this.processListView = new System.Windows.Forms.ListView();
            this.processStopButton = new System.Windows.Forms.Button();
            this.processListRefreshButton = new System.Windows.Forms.Button();
            this.processGetDetailsButton = new System.Windows.Forms.Button();
            this.processListExportButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // processListView
            // 
            this.processListView.HideSelection = false;
            this.processListView.Location = new System.Drawing.Point(13, 13);
            this.processListView.Name = "processListView";
            this.processListView.Size = new System.Drawing.Size(576, 425);
            this.processListView.TabIndex = 0;
            this.processListView.UseCompatibleStateImageBehavior = false;
            this.processListView.View = System.Windows.Forms.View.Details;
            // 
            // processStopButton
            // 
            this.processStopButton.Location = new System.Drawing.Point(624, 57);
            this.processStopButton.Name = "processStopButton";
            this.processStopButton.Size = new System.Drawing.Size(140, 41);
            this.processStopButton.TabIndex = 1;
            this.processStopButton.Text = "Зупинити процес";
            this.processStopButton.UseVisualStyleBackColor = true;
            this.processStopButton.Click += new System.EventHandler(this.processStopButton_Click);
            // 
            // processListRefreshButton
            // 
            this.processListRefreshButton.Location = new System.Drawing.Point(624, 225);
            this.processListRefreshButton.Name = "processListRefreshButton";
            this.processListRefreshButton.Size = new System.Drawing.Size(140, 41);
            this.processListRefreshButton.TabIndex = 2;
            this.processListRefreshButton.Text = "Оновити список";
            this.processListRefreshButton.UseVisualStyleBackColor = true;
            this.processListRefreshButton.Click += new System.EventHandler(this.processListRefreshButton_Click);
            // 
            // processGetDetailsButton
            // 
            this.processGetDetailsButton.Location = new System.Drawing.Point(624, 104);
            this.processGetDetailsButton.Name = "processGetDetailsButton";
            this.processGetDetailsButton.Size = new System.Drawing.Size(140, 41);
            this.processGetDetailsButton.TabIndex = 3;
            this.processGetDetailsButton.Text = "Деталі процесу";
            this.processGetDetailsButton.UseVisualStyleBackColor = true;
            this.processGetDetailsButton.Click += new System.EventHandler(this.processGetDetailsButton_Click);
            // 
            // processListExportButton
            // 
            this.processListExportButton.Location = new System.Drawing.Point(624, 272);
            this.processListExportButton.Name = "processListExportButton";
            this.processListExportButton.Size = new System.Drawing.Size(140, 41);
            this.processListExportButton.TabIndex = 4;
            this.processListExportButton.Text = "Експортувати список";
            this.processListExportButton.UseVisualStyleBackColor = true;
            this.processListExportButton.Click += new System.EventHandler(this.processListExportButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label1.Location = new System.Drawing.Point(621, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Робота з процесом:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(254)));
            this.label2.Location = new System.Drawing.Point(621, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Робота зі списком:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.processListExportButton);
            this.Controls.Add(this.processGetDetailsButton);
            this.Controls.Add(this.processListRefreshButton);
            this.Controls.Add(this.processStopButton);
            this.Controls.Add(this.processListView);
            this.Name = "Form1";
            this.Text = "Переглядач процесів";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView processListView;
        private System.Windows.Forms.Button processStopButton;
        private System.Windows.Forms.Button processListRefreshButton;
        private System.Windows.Forms.Button processGetDetailsButton;
        private System.Windows.Forms.Button processListExportButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

