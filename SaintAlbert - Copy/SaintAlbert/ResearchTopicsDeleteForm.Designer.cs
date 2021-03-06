
namespace SaintAlbert
{
    partial class ResearchTopicDeleteForm
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
            this.lblDeleteResearchTopic = new System.Windows.Forms.Label();
            this.lblResearchTopics = new System.Windows.Forms.Label();
            this.lblResearchTopicID = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblLevel = new System.Windows.Forms.Label();
            this.btnDeleteResearchTopic = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.cboResearchTopics = new System.Windows.Forms.ComboBox();
            this.txtResearchTopicID = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblDeleteResearchTopic
            // 
            this.lblDeleteResearchTopic.AutoSize = true;
            this.lblDeleteResearchTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeleteResearchTopic.Location = new System.Drawing.Point(274, 50);
            this.lblDeleteResearchTopic.Name = "lblDeleteResearchTopic";
            this.lblDeleteResearchTopic.Size = new System.Drawing.Size(513, 55);
            this.lblDeleteResearchTopic.TabIndex = 0;
            this.lblDeleteResearchTopic.Text = "Delete Research Topic";
            // 
            // lblResearchTopics
            // 
            this.lblResearchTopics.AutoSize = true;
            this.lblResearchTopics.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResearchTopics.Location = new System.Drawing.Point(42, 211);
            this.lblResearchTopics.Name = "lblResearchTopics";
            this.lblResearchTopics.Size = new System.Drawing.Size(180, 25);
            this.lblResearchTopics.TabIndex = 1;
            this.lblResearchTopics.Text = "Research Topics:";
            // 
            // lblResearchTopicID
            // 
            this.lblResearchTopicID.AutoSize = true;
            this.lblResearchTopicID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResearchTopicID.Location = new System.Drawing.Point(27, 248);
            this.lblResearchTopicID.Name = "lblResearchTopicID";
            this.lblResearchTopicID.Size = new System.Drawing.Size(195, 25);
            this.lblResearchTopicID.TabIndex = 2;
            this.lblResearchTopicID.Text = "Research Topic ID:";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(95, 283);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(126, 25);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "Description:";
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(151, 320);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(70, 25);
            this.lblLevel.TabIndex = 4;
            this.lblLevel.Text = "Level:";
            // 
            // btnDeleteResearchTopic
            // 
            this.btnDeleteResearchTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteResearchTopic.Location = new System.Drawing.Point(148, 432);
            this.btnDeleteResearchTopic.Name = "btnDeleteResearchTopic";
            this.btnDeleteResearchTopic.Size = new System.Drawing.Size(275, 50);
            this.btnDeleteResearchTopic.TabIndex = 5;
            this.btnDeleteResearchTopic.Text = "Delete Research Topic";
            this.btnDeleteResearchTopic.UseVisualStyleBackColor = true;
            this.btnDeleteResearchTopic.Click += new System.EventHandler(this.btnDeleteResearchTopic_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(559, 432);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(238, 50);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // cboResearchTopics
            // 
            this.cboResearchTopics.FormattingEnabled = true;
            this.cboResearchTopics.Location = new System.Drawing.Point(217, 209);
            this.cboResearchTopics.Name = "cboResearchTopics";
            this.cboResearchTopics.Size = new System.Drawing.Size(534, 32);
            this.cboResearchTopics.TabIndex = 7;
            this.cboResearchTopics.SelectedIndexChanged += new System.EventHandler(this.cboResearchTopics_SelectedIndexChanged);
            // 
            // txtResearchTopicID
            // 
            this.txtResearchTopicID.Location = new System.Drawing.Point(217, 247);
            this.txtResearchTopicID.Name = "txtResearchTopicID";
            this.txtResearchTopicID.ReadOnly = true;
            this.txtResearchTopicID.Size = new System.Drawing.Size(100, 29);
            this.txtResearchTopicID.TabIndex = 8;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(216, 283);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.ReadOnly = true;
            this.txtDescription.Size = new System.Drawing.Size(389, 29);
            this.txtDescription.TabIndex = 9;
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(216, 318);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.ReadOnly = true;
            this.txtLevel.Size = new System.Drawing.Size(100, 29);
            this.txtLevel.TabIndex = 10;
            // 
            // ResearchTopicDeleteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(984, 565);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtResearchTopicID);
            this.Controls.Add(this.cboResearchTopics);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnDeleteResearchTopic);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblResearchTopicID);
            this.Controls.Add(this.lblResearchTopics);
            this.Controls.Add(this.lblDeleteResearchTopic);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ResearchTopicDeleteForm";
            this.Text = "Delete Research Topics";
            this.Load += new System.EventHandler(this.ResearchTopicDeleteForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeleteResearchTopic;
        private System.Windows.Forms.Label lblResearchTopics;
        private System.Windows.Forms.Label lblResearchTopicID;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.Button btnDeleteResearchTopic;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.ComboBox cboResearchTopics;
        private System.Windows.Forms.TextBox txtResearchTopicID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtLevel;
    }
}