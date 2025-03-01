using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MojiCounter
{
    public partial class 就活生の味方 : Form
    {
        public 就活生の味方()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string s = counterBox.Text;

            counterLabel.Text = "現在の文字数：" + s.Length + "字";


            // 空白と改行を除いた長さを計算
            int lengthWithoutSpacesAndNewlines = s.Replace(" ", "") // 空白を除去
                                                  .Replace("\n", "") // 改行を除去
                                                  .Replace("\r", "") // 改行を除去
                                                  .Length;

            // 絵文字を1文字としてカウント
            int graphemeCount = new StringInfo(s).LengthInTextElements;
            emojiLabel.Text = $"現在の文字数(絵文字を1文字としてカウント)：{graphemeCount}字";


            spaceEnterExceptedCounterLabel.Text = $"現在の文字数(空白・改行を除く)：{lengthWithoutSpacesAndNewlines}字";


            // 分割して空文字列を排除
            string[] result = s.Split(new[] { '\n', '。' }, StringSplitOptions.RemoveEmptyEntries)
                               .Select(str => str.Trim()) // 空白を取り除く
                               .Where(str => !string.IsNullOrWhiteSpace(str)) // 空文字列を排除
                               .ToArray();

            // 各要素の長さを取得して平均を計算
            double averageLength = result.Any() // 配列が空でないか確認
                ? result.Average(str => str.Length)
                : 0; // 空の場合は0を設定

            statementMeanLengthLabel.Text = $"1文の平均長さ：{averageLength:F2}字";
        }

        private void counterLabel_Click(object sender, EventArgs e)
        {

        }

        private void statementMeanLengthLabel_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void 就活生の味方_Load(object sender, EventArgs e)
        {

        }

        private void Paste_Click(object sender, EventArgs e)
        {
            // クリップボードにテキストがある場合のみ貼り付ける
            if (Clipboard.ContainsText())
            {
                counterBox.Text = Clipboard.GetText();
            }
        }
    }
}
