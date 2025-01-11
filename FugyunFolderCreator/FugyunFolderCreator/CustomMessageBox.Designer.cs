namespace FugyunFolderCreator
{
    partial class CustomMessageBox
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomMessageBox));
            this.MainPanel = new System.Windows.Forms.Panel();
            this.MainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.TopTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.MessageLabel = new System.Windows.Forms.Label();
            this.IconPictureBox = new System.Windows.Forms.PictureBox();
            this.BottomTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.BottomFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.Button1 = new System.Windows.Forms.Button();
            this.Button2 = new System.Windows.Forms.Button();
            this.Button3 = new System.Windows.Forms.Button();
            this.InfomationPictureBox = new System.Windows.Forms.PictureBox();
            this.ErrorPictureBox = new System.Windows.Forms.PictureBox();
            this.WarningPictureBox = new System.Windows.Forms.PictureBox();
            this.QuestionPictureBox = new System.Windows.Forms.PictureBox();
            this.MainPanel.SuspendLayout();
            this.MainTableLayoutPanel.SuspendLayout();
            this.TopTableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).BeginInit();
            this.BottomTableLayoutPanel.SuspendLayout();
            this.BottomFlowLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InfomationPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarningPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainPanel
            // 
            this.MainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MainPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.MainPanel.Controls.Add(this.MainTableLayoutPanel);
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(484, 181);
            this.MainPanel.TabIndex = 0;
            // 
            // MainTableLayoutPanel
            // 
            this.MainTableLayoutPanel.ColumnCount = 1;
            this.MainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.MainTableLayoutPanel.Controls.Add(this.TopTableLayoutPanel, 0, 0);
            this.MainTableLayoutPanel.Controls.Add(this.BottomTableLayoutPanel, 0, 1);
            this.MainTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.MainTableLayoutPanel.Name = "MainTableLayoutPanel";
            this.MainTableLayoutPanel.RowCount = 2;
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.MainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.MainTableLayoutPanel.Size = new System.Drawing.Size(484, 181);
            this.MainTableLayoutPanel.TabIndex = 0;
            // 
            // TopTableLayoutPanel
            // 
            this.TopTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TopTableLayoutPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.TopTableLayoutPanel.ColumnCount = 2;
            this.TopTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 110F));
            this.TopTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TopTableLayoutPanel.Controls.Add(this.MessageLabel, 1, 0);
            this.TopTableLayoutPanel.Controls.Add(this.IconPictureBox, 0, 0);
            this.TopTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.TopTableLayoutPanel.Name = "TopTableLayoutPanel";
            this.TopTableLayoutPanel.RowCount = 1;
            this.TopTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TopTableLayoutPanel.Size = new System.Drawing.Size(478, 102);
            this.TopTableLayoutPanel.TabIndex = 0;
            // 
            // MessageLabel
            // 
            this.MessageLabel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.MessageLabel.AutoSize = true;
            this.MessageLabel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.MessageLabel.Location = new System.Drawing.Point(113, 40);
            this.MessageLabel.Name = "MessageLabel";
            this.MessageLabel.Size = new System.Drawing.Size(52, 21);
            this.MessageLabel.TabIndex = 0;
            this.MessageLabel.Text = "label1";
            // 
            // IconPictureBox
            // 
            this.IconPictureBox.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.IconPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("IconPictureBox.Image")));
            this.IconPictureBox.Location = new System.Drawing.Point(35, 15);
            this.IconPictureBox.Name = "IconPictureBox";
            this.IconPictureBox.Size = new System.Drawing.Size(72, 72);
            this.IconPictureBox.TabIndex = 1;
            this.IconPictureBox.TabStop = false;
            // 
            // BottomTableLayoutPanel
            // 
            this.BottomTableLayoutPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BottomTableLayoutPanel.ColumnCount = 2;
            this.BottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.BottomTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.BottomTableLayoutPanel.Controls.Add(this.BottomFlowLayoutPanel, 1, 0);
            this.BottomTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomTableLayoutPanel.Location = new System.Drawing.Point(3, 111);
            this.BottomTableLayoutPanel.Name = "BottomTableLayoutPanel";
            this.BottomTableLayoutPanel.RowCount = 1;
            this.BottomTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.BottomTableLayoutPanel.Size = new System.Drawing.Size(478, 67);
            this.BottomTableLayoutPanel.TabIndex = 1;
            // 
            // BottomFlowLayoutPanel
            // 
            this.BottomFlowLayoutPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.BottomFlowLayoutPanel.Controls.Add(this.Button1);
            this.BottomFlowLayoutPanel.Controls.Add(this.Button2);
            this.BottomFlowLayoutPanel.Controls.Add(this.Button3);
            this.BottomFlowLayoutPanel.Controls.Add(this.InfomationPictureBox);
            this.BottomFlowLayoutPanel.Controls.Add(this.ErrorPictureBox);
            this.BottomFlowLayoutPanel.Controls.Add(this.WarningPictureBox);
            this.BottomFlowLayoutPanel.Controls.Add(this.QuestionPictureBox);
            this.BottomFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BottomFlowLayoutPanel.Location = new System.Drawing.Point(103, 3);
            this.BottomFlowLayoutPanel.Name = "BottomFlowLayoutPanel";
            this.BottomFlowLayoutPanel.Size = new System.Drawing.Size(372, 61);
            this.BottomFlowLayoutPanel.TabIndex = 0;
            // 
            // Button1
            // 
            this.Button1.Location = new System.Drawing.Point(0, 0);
            this.Button1.Margin = new System.Windows.Forms.Padding(0);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(100, 36);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "button1";
            this.Button1.UseVisualStyleBackColor = true;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Button2
            // 
            this.Button2.Location = new System.Drawing.Point(100, 0);
            this.Button2.Margin = new System.Windows.Forms.Padding(0);
            this.Button2.Name = "Button2";
            this.Button2.Size = new System.Drawing.Size(100, 36);
            this.Button2.TabIndex = 1;
            this.Button2.Text = "button2";
            this.Button2.UseVisualStyleBackColor = true;
            this.Button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(200, 0);
            this.Button3.Margin = new System.Windows.Forms.Padding(0);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(100, 36);
            this.Button3.TabIndex = 2;
            this.Button3.Text = "button3";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // InfomationPictureBox
            // 
            this.InfomationPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("InfomationPictureBox.Image")));
            this.InfomationPictureBox.Location = new System.Drawing.Point(3, 39);
            this.InfomationPictureBox.Name = "InfomationPictureBox";
            this.InfomationPictureBox.Size = new System.Drawing.Size(72, 72);
            this.InfomationPictureBox.TabIndex = 4;
            this.InfomationPictureBox.TabStop = false;
            this.InfomationPictureBox.Visible = false;
            // 
            // ErrorPictureBox
            // 
            this.ErrorPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("ErrorPictureBox.Image")));
            this.ErrorPictureBox.Location = new System.Drawing.Point(81, 39);
            this.ErrorPictureBox.Name = "ErrorPictureBox";
            this.ErrorPictureBox.Size = new System.Drawing.Size(72, 72);
            this.ErrorPictureBox.TabIndex = 3;
            this.ErrorPictureBox.TabStop = false;
            this.ErrorPictureBox.Visible = false;
            // 
            // WarningPictureBox
            // 
            this.WarningPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("WarningPictureBox.Image")));
            this.WarningPictureBox.Location = new System.Drawing.Point(159, 39);
            this.WarningPictureBox.Name = "WarningPictureBox";
            this.WarningPictureBox.Size = new System.Drawing.Size(72, 72);
            this.WarningPictureBox.TabIndex = 5;
            this.WarningPictureBox.TabStop = false;
            this.WarningPictureBox.Visible = false;
            // 
            // QuestionPictureBox
            // 
            this.QuestionPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("QuestionPictureBox.Image")));
            this.QuestionPictureBox.Location = new System.Drawing.Point(237, 39);
            this.QuestionPictureBox.Name = "QuestionPictureBox";
            this.QuestionPictureBox.Size = new System.Drawing.Size(72, 72);
            this.QuestionPictureBox.TabIndex = 6;
            this.QuestionPictureBox.TabStop = false;
            this.QuestionPictureBox.Visible = false;
            // 
            // CustomMessageBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(484, 181);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomMessageBox";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CustomMessageBox";
            this.Shown += new System.EventHandler(this.CustomMessageBox_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CustomMessageBox_KeyDown);
            this.MainPanel.ResumeLayout(false);
            this.MainTableLayoutPanel.ResumeLayout(false);
            this.TopTableLayoutPanel.ResumeLayout(false);
            this.TopTableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconPictureBox)).EndInit();
            this.BottomTableLayoutPanel.ResumeLayout(false);
            this.BottomFlowLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.InfomationPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WarningPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.QuestionPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.TableLayoutPanel MainTableLayoutPanel;
        private System.Windows.Forms.Button Button1;
        private System.Windows.Forms.Button Button2;
        private System.Windows.Forms.Button Button3;
        public System.Windows.Forms.TableLayoutPanel BottomTableLayoutPanel;
        public System.Windows.Forms.FlowLayoutPanel BottomFlowLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel TopTableLayoutPanel;
        private System.Windows.Forms.PictureBox IconPictureBox;
        private System.Windows.Forms.PictureBox ErrorPictureBox;
        private System.Windows.Forms.PictureBox InfomationPictureBox;
        private System.Windows.Forms.PictureBox WarningPictureBox;
        private System.Windows.Forms.PictureBox QuestionPictureBox;
        public System.Windows.Forms.Label MessageLabel;
    }
}