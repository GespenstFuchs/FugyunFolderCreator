using System;
using System.Collections.Generic;
using System.Media;
using System.Windows.Forms;

namespace FugyunFolderCreator
{
    /// <summary>
    /// カスタムメッセージボックス
    /// </summary>
    public partial class CustomMessageBox : Form
    {
        /// <summary>
        /// 戻り値：ボタン１
        /// </summary>
        public const string RETURN_BUTTON1 = "Button1";

        /// <summary>
        /// 戻り値：ボタン２
        /// </summary>
        public const string RETURN_BUTTON2 = "Button2";

        /// <summary>
        /// 戻り値：ボタン３
        /// </summary>
        public const string RETURN_BUTTON3 = "Button3";

        /// <summary>
        /// 戻り値
        /// </summary>
        public string MessageBoxResult { get; set; }

        /// <summary>
        /// ビープ音フラグ
        /// true：有り
        /// false：無し
        /// </summary>
        public bool BeepFlg { get; set; } = true;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public CustomMessageBox()
        {
            InitializeComponent();
        }

        /// <summary>
        /// フォーム表示後処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void CustomMessageBox_Shown(object sender, EventArgs e)
        {
            // ビープ音フラグを判定する。
            if (BeepFlg)
            {
                SystemSounds.Beep.Play();
            }
        }

        /// <summary>
        /// フォームキー押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void CustomMessageBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (Equals(e.KeyData, (Keys.Control | Keys.C)))
            {
                Clipboard.SetText(MessageLabel.Text);
            }
        }

        /// <summary>
        /// ボタン１押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void Button1_Click(object sender, EventArgs e)
        {
            MessageBoxResult = RETURN_BUTTON1;
            Close();
        }

        /// <summary>
        /// ボタン２押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void Button2_Click(object sender, EventArgs e)
        {
            MessageBoxResult = RETURN_BUTTON2;
            Close();
        }

        /// <summary>
        /// ボタン３押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void Button3_Click(object sender, EventArgs e)
        {
            MessageBoxResult = RETURN_BUTTON3;
            Close();
        }

        /// <summary>
        /// メッセージボックス設定処理
        /// </summary>
        /// <param name="title">タイトル</param>
        /// <param name="message">メッセージ</param>
        /// <param name="iconNo">アイコン番号（0：情報・1：エラー・2：警告・3：質問）</param>
        /// <param name="buttonTextList">ボタンテキストリスト</param>
        /// <param name="defaultButtonValue">デフォルトボタン値（0：Button1・1：Button2・3：Button3）</param>
        /// <param name="beepFlg">ビープ音フラグ（true：有り・false：無し）</param>
        /// <param name="autoWidthFlg">自動幅設定フラグ（true：自動で設定する・false：設定しない（デフォルト、もしくは手動で設定する））</param>
        /// <remarks>手動でメッセージボックスの幅を設定する場合、幅を基準にボタンの配置を設定するため、先に幅を設定する。</remarks>
        public void MessageBoxSetting(
            string title,
            string message,
            int iconNo,
            List<string> buttonTextList,
            int defaultButtonValue,
            bool beepFlg = true,
            bool autoWidthFlg = true)
        {
            // タイトル・メッセージを設定する。
            Text = title;
            MessageLabel.Text = message;

            // ボタンを非表示にする。
            Button2.Visible = false;
            Button3.Visible = false;

            // ボタンの余白を戻す。
            Button1.Margin = new Padding(0);
            Button2.Margin = new Padding(0);

            // アイコンを設定する。
            if (Equals(0, iconNo))
            {
                IconPictureBox.Image = InfomationPictureBox.Image;
            }
            else if (Equals(1, iconNo))
            {
                IconPictureBox.Image = ErrorPictureBox.Image;
            }
            else if (Equals(2, iconNo))
            {
                IconPictureBox.Image = WarningPictureBox.Image;
            }
            else
            {
                IconPictureBox.Image = QuestionPictureBox.Image;
            }

            // 自動幅設定フラグを判定する。
            if (autoWidthFlg)
            {
                // 自動で設定する場合
                Width = MessageLabel.Location.X + MessageLabel.Width + 100;

                // ボタンの設定などで、幅が狭すぎると、エラーになるので、最低500ピクセルに設定する。
                if (Width < 500)
                {
                    Width = 500;
                }
            }

            // フォームの横半分のサイズを取得・保持する。
            // （小数点になっても、勝手に計算される。）
            int halfWidth = ClientSize.Width / 2;

            // ボタンテキストリストの項目数を判定する。
            if (Equals(1, buttonTextList.Count))
            {
                Button1.Text = buttonTextList[0];

                // 計算式：フォーム横サイズ－（フォーム横半分のサイズ＋（ボタンサイズ÷２））
                BottomTableLayoutPanel.ColumnStyles[0].Width = ClientSize.Width - (halfWidth + (Button1.Width / 2));
            }
            else if (Equals(2, buttonTextList.Count))
            {
                Button2.Visible = true;
                Button1.Margin = new Padding(0, 0, 20, 0);
                Button1.Text = buttonTextList[0];
                Button2.Text = buttonTextList[1];

                // 計算式：フォーム横サイズ－（フォーム横半分のサイズ＋（ボタンサイズ＋ボタンの右余白の半分のサイズ））
                BottomTableLayoutPanel.ColumnStyles[0].Width = ClientSize.Width - (halfWidth + Button1.Width + 10);
            }
            else if (Equals(3, buttonTextList.Count))
            {
                Button2.Visible = true;
                Button3.Visible = true;
                Button1.Margin = new Padding(0, 0, 20, 0);
                Button2.Margin = new Padding(0, 0, 20, 0);
                Button1.Text = buttonTextList[0];
                Button2.Text = buttonTextList[1];
                Button3.Text = buttonTextList[2];

                // 計算式：フォーム横サイズ－（フォーム横半分のサイズ＋（ボタンサイズ＋ボタンの右余白の半分のサイズ））
                BottomTableLayoutPanel.ColumnStyles[0].Width = ClientSize.Width - (halfWidth + Button1.Width + 20 + (Button2.Width / 2));
            }

            // デフォルトボタンを設定する。
            if (Equals(2, defaultButtonValue))
            {
                ActiveControl = Button3;
                MessageBoxResult = RETURN_BUTTON3;
            }
            else if (Equals(1, defaultButtonValue))
            {
                ActiveControl = Button2;
                MessageBoxResult = RETURN_BUTTON2;
            }
            else
            {
                ActiveControl = Button1;
                MessageBoxResult = RETURN_BUTTON1;
            }

            // ビープ音フラグを設定する。
            BeepFlg = beepFlg;
        }
    }
}
