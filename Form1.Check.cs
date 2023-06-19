using System.Text.RegularExpressions;

namespace cs_form_mtn_012_vs2022
{
    partial class Form1
    {
        // *****************************************
        // リアルタイム入力チェック
        // *****************************************
        private void 社員コード_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.ActiveControl != this.社員コード)
            {
                // 数字チェック
                if (!Regex.IsMatch(this.社員コード.Text, @"^[0-9]+$"))
                {
                    e.Cancel = true;
                    MessageBox.Show("数字を入力してください");
                    this.社員コード.SelectAll();
                    return;
                }

                // 文字列長チェック
                if (this.社員コード.Text.Length > 4)
                {
                    e.Cancel = true;
                    MessageBox.Show("4桁以内で入力してください");
                    this.社員コード.SelectAll();
                    return;
                }
            }
        }

        private void 社員コード_Validated(object sender, EventArgs e)
        {
            // 入力チェック終了後の処理
            this.社員コード.Text = $"{Int32.Parse(this.社員コード.Text):0000}";

        }

        // 氏名の必須チェック
        private void 氏名_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.ActiveControl != this.氏名)
            {
                if (this.ActiveControl == this.キャンセル)
                {
                    return;
                }

                if (this.氏名.Text.Trim().Length == 0)
                {
                    e.Cancel = true;
                    MessageBox.Show("必須入力です");
                    this.氏名.SelectAll();
                    return;

                }
            }

        }

        private void 給与_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (this.ActiveControl != this.給与)
            {
                if (this.ActiveControl == this.キャンセル)
                {
                    return;
                }

                // 数字チェック
                if (!Regex.IsMatch(this.給与.Text, @"^[0-9]*$"))
                {
                    e.Cancel = true;
                    MessageBox.Show("数字を入力してください");
                    this.給与.SelectAll();
                    return;
                }

            }

        }

        private void 給与_Validated(object sender, EventArgs e)
        {
            if (this.給与.Text.Trim().Length == 0)
            {
                this.給与.Text = "0";
            }

        }

    }
}
