
namespace SaintAlbert
{
    partial class ResearchTopicUpdateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblResearchTopics = new System.Windows.Forms.Label();
            this.lblResearchTopicID = new System.Windows.Forms.Label();
            this.txtResearchTopicID = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.btnUpdateResearchTopic = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lstResearchTopics = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblLevel = new System.Windows.Forms.Label();
            this.nudLevel = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "Update Research Topic";
            // 
            // lblResearchTopics
            // 
            this.lblResearchTopics.AutoSize = true;
            this.lblResearchTopics.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResearchTopics.Location = new System.Drawing.Point(90, 297);
            this.lblResearchTopics.Name = "lblResearchTopics";
            this.lblResearchTopics.Size = new System.Drawing.Size(186, 25);
            this.lblResearchTopics.TabIndex = 1;
            this.lblResearchTopics.Text = "Research Topics: ";
            // 
            // lblResearchTopicID
            // 
            this.lblResearchTopicID.AutoSize = true;
            this.lblResearchTopicID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResearchTopicID.Location = new System.Drawing.Point(74, 528);
            this.lblResearchTopicID.Name = "lblResearchTopicID";
            this.lblResearchTopicID.Size = new System.Drawing.Size(195, 25);
            this.lblResearchTopicID.TabIndex = 2;
            this.lblResearchTopicID.Text = "Research Topic ID:";
            // 
            // txtResearchTopicID
            // 
            this.txtResearchTopicID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResearchTopicID.Location = new System.Drawing.Point(285, 523);
            this.txtResearchTopicID.Name = "txtResearchTopicID";
            this.txtResearchTopicID.ReadOnly = true;
            this.txtResearchTopicID.Size = new System.Drawing.Size(100, 31);
            this.txtResearchTopicID.TabIndex = 3;
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(285, 563);
            this.txtDescription.MaxLength = 50;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(652, 31);
            this.txtDescription.TabIndex = 4;
            // 
            // btnUpdateResearchTopic
            // 
            this.btnUpdateResearchTopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateResearchTopic.Location = new System.Drawing.Point(194, 727);
            this.btnUpdateResearchTopic.Name = "btnUpdateResearchTopic";
            this.btnUpdateResearchTopic.Size = new System.Drawing.Size(276, 59);
            this.btnUpdateResearchTopic.TabIndex = 5;
            this.btnUpdateResearchTopic.Text = "Update Research Topic";
            this.btnUpdateResearchTopic.UseVisualStyleBackColor = true;
            this.btnUpdateResearchTopic.Click += new System.EventHandler(this.btnUpdateResearchTopic_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(606, 727);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(153, 57);
            this.btnReturn.TabIndex = 6;
            this.btnReturn.Text = "Return";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(142, 567);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(126, 25);
            this.lblDescription.TabIndex = 7;
            this.lblDescription.Text = "Description:";
            // 
            // lstResearchTopics
            // 
            this.lstResearchTopics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lstResearchTopics.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstResearchTopics.FullRowSelect = true;
            this.lstResearchTopics.GridLines = true;
            this.lstResearchTopics.HideSelection = false;
            this.lstResearchTopics.Location = new System.Drawing.Point(285, 297);
            this.lstResearchTopics.MultiSelect = false;
            this.lstResearchTopics.Name = "lstResearchTopics";
            this.lstResearchTopics.Size = new System.Drawing.Size(409, 209);
            this.lstResearchTopics.TabIndex = 8;
            this.lstResearchTopics.UseCompatibleStateImageBehavior = false;
            this.lstResearchTopics.View = System.Windows.Forms.View.Details;
            this.lstResearchTopics.SelectedIndexChanged += new System.EventHandler(this.lstResearchTopics_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Research Topic ID";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Description";
            this.columnHeader2.Width = 200;
            // 
            // lblLevel
            // 
            this.lblLevel.AutoSize = true;
            this.lblLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLevel.Location = new System.Drawing.Point(197, 604);
            this.lblLevel.Name = "lblLevel";
            this.lblLevel.Size = new System.Drawing.Size(70, 25);
            this.lblLevel.TabIndex = 9;
            this.lblLevel.Text = "Level:";
            // 
            // nudLevel
            // 
            this.nudLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudLevel.Location = new System.Drawing.Point(284, 602);
            this.nudLevel.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.nudLevel.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudLevel.Name = "nudLevel";
            this.nudLevel.Size = new System.Drawing.Size(65, 31);
            this.nudLevel.TabIndex = 10;
            this.nudLevel.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(166, 662);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 24);
            this.label2.TabIndex = 11;
            this.label2.Text = "Required *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(262, 604);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 24);
            this.label3.TabIndex = 12;
            this.label3.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(262, 298);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(262, 569);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 24);
            this.label6.TabIndex = 15;
            this.label6.Text = "*";
            // 
            // ResearchTopicUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(984, 831);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudLevel);
            this.Controls.Add(this.lblLevel);
            this.Controls.Add(this.lstResearchTopics);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnUpdateResearchTopic);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtResearchTopicID);
            this.Controls.Add(this.lblResearchTopicID);
            this.Controls.Add(this.lblResearchTopics);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "ResearchTopicUpdateForm";
            this.Text = "Update Research Topics";
            ((System.ComponentModel.ISupportInitialize)(this.nudLevel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblResearchTopics;
        private System.Windows.Forms.Label lblResearchTopicID;
        private System.Windows.Forms.TextBox txtResearchTopicID;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button btnUpdateResearchTopic;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.ListView lstResearchTopics;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label lblLevel;
        private System.Windows.Forms.NumericUpDown nudLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}