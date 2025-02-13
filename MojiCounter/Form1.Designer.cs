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
            this.SuspendLayout();
            // 
            // counterBox
            // 
            this.counterBox.Location = new System.Drawing.Point(58, 49);
            this.counterBox.Multiline = true;
            this.counterBox.Name = "counterBox";
            this.counterBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.counterBox.Size = new System.Drawing.Size(250, 50);
            this.counterBox.TabIndex = 0;
            this.counterBox.Text = "ここにテキストを入力";
            this.counterBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // counterLabel
            // 
            this.counterLabel.AutoSize = true;
            this.counterLabel.Location = new System.Drawing.Point(56, 127);
            this.counterLabel.Name = "counterLabel";
            this.counterLabel.Size = new System.Drawing.Size(99, 12);
            this.counterLabel.TabIndex = 1;
            this.counterLabel.Text = "現在の文字数：0字";
            this.counterLabel.Click += new System.EventHandler(this.counterLabel_Click);
            // 
            // spaceEnterExceptedCounterLabel
            // 
            this.spaceEnterExceptedCounterLabel.AutoSize = true;
            this.spaceEnterExceptedCounterLabel.Location = new System.Drawing.Point(56, 187);
            this.spaceEnterExceptedCounterLabel.Name = "spaceEnterExceptedCounterLabel";
            this.spaceEnterExceptedCounterLabel.Size = new System.Drawing.Size(188, 12);
            this.spaceEnterExceptedCounterLabel.TabIndex = 2;
            this.spaceEnterExceptedCounterLabel.Text = "現在の文字数(空白・改行を除く)：0字";
            // 
            // statementMeanLengthLabel
            // 
            this.statementMeanLengthLabel.AutoSize = true;
            this.statementMeanLengthLabel.Location = new System.Drawing.Point(56, 219);
            this.statementMeanLengthLabel.Name = "statementMeanLengthLabel";
            this.statementMeanLengthLabel.Size = new System.Drawing.Size(101, 12);
            this.statementMeanLengthLabel.TabIndex = 3;
            this.statementMeanLengthLabel.Text = "1文の平均長さ：0字";
            this.statementMeanLengthLabel.Click += new System.EventHandler(this.statementMeanLengthLabel_Click);
            // 
            // emojiLabel
            // 
            this.emojiLabel.AutoSize = true;
            this.emojiLabel.Location = new System.Drawing.Point(56, 157);
            this.emojiLabel.Name = "emojiLabel";
            this.emojiLabel.Size = new System.Drawing.Size(243, 12);
            this.emojiLabel.TabIndex = 4;
            this.emojiLabel.Text = "現在の文字数(絵文字を1文字としてカウント)：0字";
            this.emojiLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // 就活生の味方
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 261);
            this.Controls.Add(this.emojiLabel);
            this.Controls.Add(this.statementMeanLengthLabel);
            this.Controls.Add(this.spaceEnterExceptedCounterLabel);
            this.Controls.Add(this.counterLabel);
            this.Controls.Add(this.counterBox);
            this.Name = "就活生の味方";
            this.Text = "就活生の味方";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox counterBox;
        private System.Windows.Forms.Label counterLabel;
        private System.Windows.Forms.Label spaceEnterExceptedCounterLabel;
        private System.Windows.Forms.Label statementMeanLengthLabel;
        private System.Windows.Forms.Label emojiLabel;
    }
}

