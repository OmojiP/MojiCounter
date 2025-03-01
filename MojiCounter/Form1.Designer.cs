namespace MojiCounter
{
    partial class 就活生の味方
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
            this.counterBox = new System.Windows.Forms.TextBox();
            this.counterLabel = new System.Windows.Forms.Label();
            this.spaceEnterExceptedCounterLabel = new System.Windows.Forms.Label();
            this.statementMeanLengthLabel = new System.Windows.Forms.Label();
            this.emojiLabel = new System.Windows.Forms.Label();
            this.Paste = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // counterBox
            // 
            this.counterBox.Location = new System.Drawing.Point(40, 29);
            this.counterBox.Multiline = true;
            this.counterBox.Name = "counterBox";
            this.counterBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.counterBox.Size = new System.Drawing.Size(250, 71);
            this.counterBox.TabIndex = 0;
            this.counterBox.Text = "ここにテキストを入力";
            this.counterBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // counterLabel
            // 
            this.counterLabel.AutoSize = true;
            this.counterLabel.Location = new System.Drawing.Point(38, 178);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(99, 12);
            this.counterLabel.TabIndex = 1;
            this.counterLabel.Text = "現在の文字数：0字";
            this.counterLabel.Click += new System.EventHandler(this.counterLabel_Click);
            // 
            // spaceEnterExceptedCounterLabel
            // 
            this.spaceEnterExceptedCounterLabel.AutoSize = true;
            this.spaceEnterExceptedCounterLabel.Location = new System.Drawing.Point(38, 238);
            this.spaceEnterExceptedCounterLabel.Name = "spaceEnterExceptedCounterLabel";
            this.spaceEnterExceptedCounterLabel.Size = new System.Drawing.Size(188, 12);
            this.spaceEnterExceptedCounterLabel.TabIndex = 2;
            this.spaceEnterExceptedCounterLabel.Text = "現在の文字数(空白・改行を除く)：0字";
            // 
            // statementMeanLengthLabel
            // 
            this.statementMeanLengthLabel.AutoSize = true;
            this.statementMeanLengthLabel.Location = new System.Drawing.Point(38, 270);
            this.statementMeanLengthLabel.Name = "statementMeanLengthLabel";
            this.statementMeanLengthLabel.Size = new System.Drawing.Size(101, 12);
            this.statementMeanLengthLabel.TabIndex = 3;
            this.statementMeanLengthLabel.Text = "1文の平均長さ：0字";
            this.statementMeanLengthLabel.Click += new System.EventHandler(this.statementMeanLengthLabel_Click);
            // 
            // emojiLabel
            // 
            this.emojiLabel.AutoSize = true;
            this.emojiLabel.Location = new System.Drawing.Point(38, 208);
            this.emojiLabel.Name = "emojiLabel";
            this.emojiLabel.Size = new System.Drawing.Size(243, 12);
            this.emojiLabel.TabIndex = 4;
            this.emojiLabel.Text = "現在の文字数(絵文字を1文字としてカウント)：0字";
            this.emojiLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Paste
            // 
            this.Paste.BackColor = System.Drawing.Color.Cornsilk;
            this.Paste.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Paste.Location = new System.Drawing.Point(102, 119);
            this.Paste.Name = "Paste";
            this.Paste.Size = new System.Drawing.Size(124, 35);
            this.Paste.TabIndex = 5;
            this.Paste.Text = "貼り付け";
            this.Paste.UseVisualStyleBackColor = false;
            this.Paste.Click += new System.EventHandler(this.Paste_Click);
            // 
            // 就活生の味方
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 310);
            this.Controls.Add(this.Paste);
            this.Controls.Add(this.emojiLabel);
            this.Controls.Add(this.statementMeanLengthLabel);
            this.Controls.Add(this.spaceEnterExceptedCounterLabel);
            this.Controls.Add(this.counterLabel);
            this.Controls.Add(this.counterBox);
            this.Name = "就活生の味方";
            this.Text = "就活生の味方";
            this.Load += new System.EventHandler(this.就活生の味方_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox counterBox;
        private System.Windows.Forms.Label counterLabel;
        private System.Windows.Forms.Label spaceEnterExceptedCounterLabel;
        private System.Windows.Forms.Label statementMeanLengthLabel;
        private System.Windows.Forms.Label emojiLabel;
        private System.Windows.Forms.Button Paste;
    }
}

