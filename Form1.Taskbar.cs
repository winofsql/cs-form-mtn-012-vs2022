namespace cs_form_mtn_012_vs2022
{
    partial class Form1
    {
        // *****************************************
        // タスクバー(ステータスバー)
        // *****************************************
        private void 社員コード_Enter(object sender, EventArgs e)
        {
            this.ユーザへのメッセージ.Text = "社員コードは 0000 フォーマットで４桁以内で数字で入力します。1～3桁では自動的に 0000 フォーマットに変換します";
        }

        private void 社員コード_Leave(object sender, EventArgs e)
        {
            this.ユーザへのメッセージ.Text = "";
        }
    }
}
