namespace FugyunFolderCreator
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.PathClearButton = new System.Windows.Forms.Button();
            this.FolderAllDeleteButton = new System.Windows.Forms.Button();
            this.FolderDeleteButton = new System.Windows.Forms.Button();
            this.FolderCreateButton = new System.Windows.Forms.Button();
            this.PathTextBox = new System.Windows.Forms.TextBox();
            this.PathContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.UndoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RedoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.CutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.RowSelectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SelectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.FolderOpenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip = new System.Windows.Forms.MenuStrip();
            this.FolderCreateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FolderDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FolderAllDeleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PathClearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainPanel.SuspendLayout();
            this.PathContextMenuStrip.SuspendLayout();
            this.MenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(564, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "フォルダを作成したい場合、フォルダパス入力後、【フォルダ作成】ボタンを押下して下さい。";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label2.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(564, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "フォルダを削除したい場合、フォルダパス入力後、【フォルダ削除】ボタンを押下して下さい。";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label3.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(625, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "複数のフォルダを削除したい場合、フォルダパス入力後、【フォルダ全削除】ボタンを押下して下さい。";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.label4.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(729, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "１行最大２４０文字がパスとして入力可能で、１パスとします。（改行することで、複数のパスを入力出来ます。）";
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.MainPanel.Controls.Add(this.label4);
            this.MainPanel.Controls.Add(this.PathClearButton);
            this.MainPanel.Controls.Add(this.label3);
            this.MainPanel.Controls.Add(this.FolderAllDeleteButton);
            this.MainPanel.Controls.Add(this.label2);
            this.MainPanel.Controls.Add(this.FolderDeleteButton);
            this.MainPanel.Controls.Add(this.label1);
            this.MainPanel.Controls.Add(this.FolderCreateButton);
            this.MainPanel.Controls.Add(this.PathTextBox);
            this.MainPanel.Controls.Add(this.MenuStrip);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1084, 561);
            this.MainPanel.TabIndex = 0;
            // 
            // PathClearButton
            // 
            this.PathClearButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.PathClearButton.Location = new System.Drawing.Point(724, 146);
            this.PathClearButton.Name = "PathClearButton";
            this.PathClearButton.Size = new System.Drawing.Size(200, 60);
            this.PathClearButton.TabIndex = 3;
            this.PathClearButton.Text = "入力したパスをクリア\r\n（Ｆ４）";
            this.PathClearButton.UseVisualStyleBackColor = true;
            this.PathClearButton.Click += new System.EventHandler(this.PathClearButton_Click);
            // 
            // FolderAllDeleteButton
            // 
            this.FolderAllDeleteButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.FolderAllDeleteButton.Location = new System.Drawing.Point(488, 146);
            this.FolderAllDeleteButton.Name = "FolderAllDeleteButton";
            this.FolderAllDeleteButton.Size = new System.Drawing.Size(200, 60);
            this.FolderAllDeleteButton.TabIndex = 2;
            this.FolderAllDeleteButton.Text = "フォルダ全削除\r\n（Ｆ３）";
            this.FolderAllDeleteButton.UseVisualStyleBackColor = true;
            this.FolderAllDeleteButton.Click += new System.EventHandler(this.FolderAllDeleteButton_Click);
            // 
            // FolderDeleteButton
            // 
            this.FolderDeleteButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.FolderDeleteButton.Location = new System.Drawing.Point(252, 146);
            this.FolderDeleteButton.Name = "FolderDeleteButton";
            this.FolderDeleteButton.Size = new System.Drawing.Size(200, 60);
            this.FolderDeleteButton.TabIndex = 1;
            this.FolderDeleteButton.Text = "フォルダ削除\r\n（Ｆ２）";
            this.FolderDeleteButton.UseVisualStyleBackColor = true;
            this.FolderDeleteButton.Click += new System.EventHandler(this.FolderDeleteButton_Click);
            // 
            // FolderCreateButton
            // 
            this.FolderCreateButton.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Bold);
            this.FolderCreateButton.Location = new System.Drawing.Point(16, 146);
            this.FolderCreateButton.Name = "FolderCreateButton";
            this.FolderCreateButton.Size = new System.Drawing.Size(200, 60);
            this.FolderCreateButton.TabIndex = 0;
            this.FolderCreateButton.Text = "フォルダ作成\r\n（Ｆ１）";
            this.FolderCreateButton.UseVisualStyleBackColor = true;
            this.FolderCreateButton.Click += new System.EventHandler(this.FolderCreateButton_Click);
            // 
            // PathTextBox
            // 
            this.PathTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PathTextBox.BackColor = System.Drawing.Color.Lavender;
            this.PathTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PathTextBox.ContextMenuStrip = this.PathContextMenuStrip;
            this.PathTextBox.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.PathTextBox.ForeColor = System.Drawing.Color.Black;
            this.PathTextBox.HideSelection = false;
            this.PathTextBox.Location = new System.Drawing.Point(16, 232);
            this.PathTextBox.MaxLength = 0;
            this.PathTextBox.Multiline = true;
            this.PathTextBox.Name = "PathTextBox";
            this.PathTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.PathTextBox.Size = new System.Drawing.Size(1052, 309);
            this.PathTextBox.TabIndex = 4;
            this.PathTextBox.WordWrap = false;
            this.PathTextBox.TextChanged += new System.EventHandler(this.PathTextBox_TextChanged);
            // 
            // PathContextMenuStrip
            // 
            this.PathContextMenuStrip.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.PathContextMenuStrip.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.PathContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.UndoToolStripMenuItem,
            this.RedoToolStripMenuItem,
            this.ToolStripSeparator1,
            this.CutToolStripMenuItem,
            this.CopyToolStripMenuItem,
            this.PasteToolStripMenuItem,
            this.DelToolStripMenuItem,
            this.ToolStripSeparator2,
            this.RowSelectToolStripMenuItem,
            this.SelectAllToolStripMenuItem,
            this.ToolStripSeparator3,
            this.FolderOpenToolStripMenuItem});
            this.PathContextMenuStrip.Name = "PathContextMenuStrip";
            this.PathContextMenuStrip.ShowImageMargin = false;
            this.PathContextMenuStrip.Size = new System.Drawing.Size(261, 256);
            this.PathContextMenuStrip.Opening += new System.ComponentModel.CancelEventHandler(this.PathContextMenuStrip_Opening);
            // 
            // UndoToolStripMenuItem
            // 
            this.UndoToolStripMenuItem.Name = "UndoToolStripMenuItem";
            this.UndoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.UndoToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.UndoToolStripMenuItem.Text = "元に戻す";
            this.UndoToolStripMenuItem.Click += new System.EventHandler(this.UndoToolStripMenuItem_Click);
            // 
            // RedoToolStripMenuItem
            // 
            this.RedoToolStripMenuItem.Name = "RedoToolStripMenuItem";
            this.RedoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.RedoToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.RedoToolStripMenuItem.Text = "やり直し";
            this.RedoToolStripMenuItem.Click += new System.EventHandler(this.RedoToolStripMenuItem_Click);
            // 
            // ToolStripSeparator1
            // 
            this.ToolStripSeparator1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ToolStripSeparator1.Name = "ToolStripSeparator1";
            this.ToolStripSeparator1.Size = new System.Drawing.Size(257, 6);
            // 
            // CutToolStripMenuItem
            // 
            this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
            this.CutToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.CutToolStripMenuItem.Text = "切り取り";
            this.CutToolStripMenuItem.Click += new System.EventHandler(this.CutToolStripMenuItem_Click);
            // 
            // CopyToolStripMenuItem
            // 
            this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
            this.CopyToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.CopyToolStripMenuItem.Text = "コピー";
            this.CopyToolStripMenuItem.Click += new System.EventHandler(this.CopyToolStripMenuItem_Click);
            // 
            // PasteToolStripMenuItem
            // 
            this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
            this.PasteToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.PasteToolStripMenuItem.Text = "貼り付け";
            this.PasteToolStripMenuItem.Click += new System.EventHandler(this.PasteToolStripMenuItem_Click);
            // 
            // DelToolStripMenuItem
            // 
            this.DelToolStripMenuItem.Name = "DelToolStripMenuItem";
            this.DelToolStripMenuItem.ShortcutKeyDisplayString = "Del";
            this.DelToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.DelToolStripMenuItem.Text = "削除";
            this.DelToolStripMenuItem.Click += new System.EventHandler(this.DelToolStripMenuItem_Click);
            // 
            // ToolStripSeparator2
            // 
            this.ToolStripSeparator2.Name = "ToolStripSeparator2";
            this.ToolStripSeparator2.Size = new System.Drawing.Size(257, 6);
            // 
            // RowSelectToolStripMenuItem
            // 
            this.RowSelectToolStripMenuItem.Name = "RowSelectToolStripMenuItem";
            this.RowSelectToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.RowSelectToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.RowSelectToolStripMenuItem.Text = "行選択";
            this.RowSelectToolStripMenuItem.Click += new System.EventHandler(this.RowSelectToolStripMenuItem_Click);
            // 
            // SelectAllToolStripMenuItem
            // 
            this.SelectAllToolStripMenuItem.Name = "SelectAllToolStripMenuItem";
            this.SelectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.SelectAllToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.SelectAllToolStripMenuItem.Text = "全選択";
            this.SelectAllToolStripMenuItem.Click += new System.EventHandler(this.SelectAllToolStripMenuItem_Click);
            // 
            // ToolStripSeparator3
            // 
            this.ToolStripSeparator3.Name = "ToolStripSeparator3";
            this.ToolStripSeparator3.Size = new System.Drawing.Size(257, 6);
            // 
            // FolderOpenToolStripMenuItem
            // 
            this.FolderOpenToolStripMenuItem.Name = "FolderOpenToolStripMenuItem";
            this.FolderOpenToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.FolderOpenToolStripMenuItem.Size = new System.Drawing.Size(260, 26);
            this.FolderOpenToolStripMenuItem.Text = "選択行のフォルダを開く";
            this.FolderOpenToolStripMenuItem.Click += new System.EventHandler(this.FolderOpenToolStripMenuItem_Click);
            // 
            // MenuStrip
            // 
            this.MenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FolderCreateToolStripMenuItem,
            this.FolderDeleteToolStripMenuItem,
            this.FolderAllDeleteToolStripMenuItem,
            this.PathClearToolStripMenuItem});
            this.MenuStrip.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip.Name = "MenuStrip";
            this.MenuStrip.Size = new System.Drawing.Size(1084, 24);
            this.MenuStrip.TabIndex = 5;
            this.MenuStrip.Text = "MenuStrip";
            this.MenuStrip.Visible = false;
            // 
            // FolderCreateToolStripMenuItem
            // 
            this.FolderCreateToolStripMenuItem.Name = "FolderCreateToolStripMenuItem";
            this.FolderCreateToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.FolderCreateToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.FolderCreateToolStripMenuItem.Text = "フォルダ作成";
            this.FolderCreateToolStripMenuItem.Click += new System.EventHandler(this.FolderCreateToolStripMenuItem_Click);
            // 
            // FolderDeleteToolStripMenuItem
            // 
            this.FolderDeleteToolStripMenuItem.Name = "FolderDeleteToolStripMenuItem";
            this.FolderDeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.FolderDeleteToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.FolderDeleteToolStripMenuItem.Text = "フォルダ削除";
            this.FolderDeleteToolStripMenuItem.Click += new System.EventHandler(this.FolderDeleteToolStripMenuItem_Click);
            // 
            // FolderAllDeleteToolStripMenuItem
            // 
            this.FolderAllDeleteToolStripMenuItem.Name = "FolderAllDeleteToolStripMenuItem";
            this.FolderAllDeleteToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.FolderAllDeleteToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.FolderAllDeleteToolStripMenuItem.Text = "フォルダ全削除";
            this.FolderAllDeleteToolStripMenuItem.Click += new System.EventHandler(this.FolderAllDeleteToolStripMenuItem_Click);
            // 
            // PathClearToolStripMenuItem
            // 
            this.PathClearToolStripMenuItem.Name = "PathClearToolStripMenuItem";
            this.PathClearToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.PathClearToolStripMenuItem.Size = new System.Drawing.Size(114, 20);
            this.PathClearToolStripMenuItem.Text = "入力したパスをクリア";
            this.PathClearToolStripMenuItem.Click += new System.EventHandler(this.PathClearToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1084, 561);
            this.Controls.Add(this.MainPanel);
            this.Font = new System.Drawing.Font("Yu Gothic UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MenuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ふぎゅんフォルダ作成";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.MainPanel.ResumeLayout(false);
            this.MainPanel.PerformLayout();
            this.PathContextMenuStrip.ResumeLayout(false);
            this.MenuStrip.ResumeLayout(false);
            this.MenuStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Button FolderCreateButton;
        private System.Windows.Forms.TextBox PathTextBox;
        private System.Windows.Forms.Button FolderDeleteButton;
        private System.Windows.Forms.Button FolderAllDeleteButton;
        private System.Windows.Forms.Button PathClearButton;
        private System.Windows.Forms.ContextMenuStrip PathContextMenuStrip;
        private System.Windows.Forms.MenuStrip MenuStrip;
        private System.Windows.Forms.ToolStripMenuItem FolderCreateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FolderDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FolderAllDeleteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PathClearToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UndoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RedoToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem CutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DelToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem RowSelectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SelectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator ToolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem FolderOpenToolStripMenuItem;
    }
}

