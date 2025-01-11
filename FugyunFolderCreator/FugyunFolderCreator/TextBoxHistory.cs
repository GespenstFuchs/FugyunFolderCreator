using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FugyunFolderCreator
{
    /// <summary>
    /// テキストボックス履歴クラス
    /// </summary>
    internal class TextBoxHistory
    {
        #region プロパティ

        /// <summary>
        /// 対象テキストボックス
        /// </summary>
        private TextBox TargetTextBox { get; set; }

        /// <summary>
        /// 最大履歴数
        /// </summary>
        private int MaxHistoryCount { get; set; }

        /// <summary>
        /// 履歴情報リスト
        /// </summary>
        private List<TextBoxHistoryInfo> HistoryInfoList { get; set; }

        /// <summary>
        /// カレント履歴位置
        /// （０ＢＡＳＥ）
        /// </summary>
        private int CurrentHistoryIndex { get; set; } = 0;

        /// <summary>
        /// 履歴追加フラグ
        /// （true；追加可能・false：追加不可）
        /// </summary>
        private bool HistoryAddFlg { get; set; } = true;

        /// <summary>
        /// 元に戻す判定フラグ
        /// （true：可能・false：不可）
        /// </summary>
        public bool IsUndoFlg
        {
            get { return CurrentHistoryIndex > 0; }
        }

        /// <summary>
        /// やり直し判定フラグ
        /// （true：可能・false：不可）
        /// </summary>
        public bool IsRedoFlg
        {
            get
            {
                int TargetIndex = CurrentHistoryIndex + 1;
                TextBoxHistoryInfo HistoryInfo = HistoryInfoList.ElementAtOrDefault(TargetIndex);
                return !Equals(null, HistoryInfo);
            }
        }

        #endregion

        #region コンストラクタ

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="textBox">テキストボックス（初期設定済み）</param>
        /// <param name="maxHistoryCount">最大履歴数（デフォルト：１０００）</param>
        public TextBoxHistory(
            TextBox textBox,
            int maxHistoryCount = 1000)
        {
            TargetTextBox = textBox;
            MaxHistoryCount = maxHistoryCount;

            // 履歴情報リストの履歴情報を追加する。
            HistoryInfoList = new List<TextBoxHistoryInfo>
            {
                new TextBoxHistoryInfo(
                    TargetTextBox.Text,
                    TargetTextBox.SelectionStart)
            };

            // カレント履歴位置を設定する。
            CurrentHistoryIndex = HistoryInfoList.Count - 1;
        }

        #endregion

        #region パブリックメソッド

        /// <summary>
        /// 履歴追加処理
        /// </summary>
        public void HistoryAdd()
        {
            // 履歴追加フラグを判定する。
            if (HistoryAddFlg)
            {
                // 追加可能の場合

                // カレント位置を判定する。
                if (!Equals(HistoryInfoList.Count, CurrentHistoryIndex + 1))
                {
                    // 最新以外の場合

                    // 履歴情報リストを更新する。
                    HistoryInfoList = HistoryInfoList.Take(CurrentHistoryIndex + 1).ToList();
                }

                // 情報リストの項目数と、最大履歴数を判定する。
                if (Equals(HistoryInfoList.Count, MaxHistoryCount))
                {
                    // 一致する場合、最初の要素を削除する。
                    HistoryInfoList.RemoveAt(0);
                }

                // 履歴情報リストの履歴情報を追加する。
                HistoryInfoList.Add(
                    new TextBoxHistoryInfo(
                        TargetTextBox.Text,
                        TargetTextBox.SelectionStart));

                // カレント履歴位置を設定する。
                CurrentHistoryIndex = HistoryInfoList.Count - 1;
            }
            else
            {
                // 追加不可の場合
                HistoryAddFlg = true;
            }
        }

        /// <summary>
        /// 元に戻す処理
        /// </summary>
        public void Undo()
        {
            // 使用する履歴情報位置を判定する。
            int TargetIndex = CurrentHistoryIndex - 1;
            if (0 <= TargetIndex)
            {
                // ０以上の場合

                // 履歴追加フラグを設定する。
                HistoryAddFlg = false;

                TargetTextBox.Focus();

                // テキストボックスに、テキスト・キャレット位置・スクロール位置を設定する。
                TextBoxHistoryInfo HistoryInfo = HistoryInfoList.ElementAt(TargetIndex);
                TargetTextBox.Text = HistoryInfo.Text;
                TargetTextBox.SelectionStart = HistoryInfo.CaretPosition;
                TargetTextBox.ScrollToCaret();

                // カレント履歴位置をデクリメントする。
                CurrentHistoryIndex--;
            }
        }

        /// <summary>
        /// やり直し処理
        /// </summary>
        public void Redo()
        {
            int TargetIndex = CurrentHistoryIndex + 1;
            TextBoxHistoryInfo HistoryInfo = HistoryInfoList.ElementAtOrDefault(TargetIndex);
            if (!Equals(null, HistoryInfo))
            {
                // 履歴数以下の場合

                // 履歴追加フラグを設定する。
                HistoryAddFlg = false;

                TargetTextBox.Focus();

                // テキストボックスに、テキスト・キャレット位置・スクロール位置を設定する。
                TargetTextBox.Text = HistoryInfo.Text;
                TargetTextBox.SelectionStart = HistoryInfo.CaretPosition;
                TargetTextBox.ScrollToCaret();

                // カレント履歴位置をインクリメントする。
                CurrentHistoryIndex++;
            }
        }

        #endregion
    }

    /// <summary>
    /// テキストボックス履歴情報クラス
    /// </summary>
    internal class TextBoxHistoryInfo
    {
        #region プロパティ

        /// <summary>
        /// テキスト
        /// </summary>
        public string Text { get; set; }

        /// <summary>
        /// カーソル位置
        /// </summary>
        public int CaretPosition { get; set; }

        #endregion

        #region コンストラクタ

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="text">テキスト</param>
        /// <param name="caretPosition">カーソル位置</param>
        public TextBoxHistoryInfo(
            string text,
            int caretPosition)
        {
            Text = text;
            CaretPosition = caretPosition;
        }

        #endregion
    }
}
