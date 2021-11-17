
namespace SaintAlbert
{
    partial class ResearchTopicAddForm
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
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.nudLevel = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddResearchTopic = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(171, 191);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(109, 24);
            this.lblDescription.TabIndex = 0;
            this.lblDescription.Text = "Description:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Location = new System.Drawing.Point(220, 232);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(60, 24);
            this.lblLevel.TabIndex = 1;
            this.lblLevel.Text = "Level:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(286, 191);
            this.txtDescription.MaxLength = 50;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(506, 29);
            this.txtDescription.TabIndex = 2;
            // 
            // nudLevel
            // 
            this.nudLevel.Location = new System.Drawing.Point(286, 232);
            this.nudLevel.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudLevel.Name = "nudLevel";
            this.nudLevel.Size = new System.Drawing.Size(60, 29);
            this.nudLevel.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(255, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(460, 55);
            this.label3.TabIndex = 4;
            this.label3.Text = "Add Research Topic";
            // 
            // btnAddResearchTopic
            // 
            this.btnAddResearchTopic.Location = new System.Drawing.Point(208, 373);
            this.btnAddResearchTopic.Name = "btnAddResearchTopic";
            this.btnAddResearchTopic.Size = new System.Drawing.Size(206, 57);
            this.btnAddResearchTopic.TabIndex = 5;
            this.btnAddResearchTopic.Text = "Add Research Topic";
            this.btnAddResearchTopic.UseVisualStyleBackColor = true;
            this.btnAddResearchTopic.Click += new System.EventHandler(this.btnAddResearchTopic_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(550, 373);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(174, 57);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // ResearchTopicAddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(984, 524);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAddResearchTopic);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudLevel);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblDescription);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ResearchTopicAddForm";
            this.Text = "Add Research Topics";
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.NumericUpDown nudLevel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddResearchTopic;
        private System.Windows.Forms.Button btnReturn;
    }
}