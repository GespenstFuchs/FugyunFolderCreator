using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace FugyunFolderCreator
{
    /// <summary>
    /// ふぎゅんフォルダ作成クラス
    /// </summary>
    public partial class MainForm : Form
    {
        #region プロパティ

        /// <summary>
        /// テキストボックス履歴情報
        /// </summary>
        TextBoxHistory TextBoxHistory { get; set; }

        /// <summary>
        /// ドロップフラグ
        /// （true：ドロップ中・false：ドロップ中以外）
        /// </summary>
        bool DropFlg { get; set; } = false;

        #endregion

        #region フィールド

        /// <summary>
        /// 使用不可文字リスト
        /// </summary>
        private readonly List<string> InvalidCharList;

        #endregion

        #region コンストラクタ

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            ActiveControl = PathTextBox;

            // テキストボックス履歴情報のインスタンスを生成する。
            TextBoxHistory = new TextBoxHistory(PathTextBox);

            // 使用不可文字リストを生成する。
            InvalidCharList = new List<string>();
            Array.ForEach(Path.GetInvalidFileNameChars(), invalidChar => InvalidCharList.Add(invalidChar.ToString()));
        }

        #endregion

        /// <summary>
        ///ドラッグ開始処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            // データ種類を判定し、マウスポインタを変更する。
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        /// <summary>
        /// ドラッグドロップ処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            // ドロップされたフォルダ・ファイルのパスを配列として、保持する。
            string[] dropPathAr = e.Data.GetData(DataFormats.FileDrop, false) as string[];

            string addText = string.Empty;

            // 配列化されたパスを基に処理を行う。
            Array.ForEach(dropPathAr, path =>
            {
                // フォルダに限定するため、フォルダ存在チェックを行い、結果を判定する。
                if (IsFolderExist(path))
                {
                    // 存在する場合
                    if (string.IsNullOrEmpty(addText))
                    {
                        addText = path;
                    }
                    else
                    {
                        addText = string.Concat(addText, Environment.NewLine, path);
                    }
                }
            });

            if (!string.IsNullOrEmpty(addText))
            {
                // ドロップフラグに、【ドロップ中】を設定する。
                DropFlg = true;

                if (string.IsNullOrEmpty(PathTextBox.Text))
                {
                    PathTextBox.Text = addText;
                }
                else
                {
                    PathTextBox.Text = string.Concat(PathTextBox.Text, Environment.NewLine, addText);
                }

                // ドロップフラグに、【ドロップ中以外】を設定する。
                DropFlg = false;
            }
        }

        /// <summary>
        /// フォルダ作成ボタン押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void FolderCreateButton_Click(object sender, EventArgs e)
        {
            FolderCreateTran();
        }

        /// <summary>
        /// フォルダ削除ボタン押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void FolderDeleteButton_Click(object sender, EventArgs e)
        {
            FolderDeleteTran(false);
        }

        /// <summary>
        /// フォルダ全削除ボタン押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void FolderAllDeleteButton_Click(object sender, EventArgs e)
        {
            FolderDeleteTran(true);
        }

        /// <summary>
        /// 入力したパスをクリアボタン押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void PathClearButton_Click(object sender, EventArgs e)
        {
            PathTextBox.Clear();
            ActiveControl = PathTextBox;
        }

        /// <summary>
        /// パステキストボックステキスト変更処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void PathTextBox_TextChanged(object sender, EventArgs e)
        {
            // 標準の履歴情報を削除する。
            PathTextBox.ClearUndo();

            // ドロップフラグを判定する。
            if (DropFlg)
            {
                // ドロップ中の場合

                // パステキストボックスのキャレットを末尾に設定する。
                PathTextBox.Select(PathTextBox.Text.Length, 0);
            }

            // 履歴情報を追加する。
            TextBoxHistory.HistoryAdd();
        }

        #region メニュー関連

        /// <summary>
        /// フォルダ作成メニュー押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void FolderCreateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderCreateButton_Click(sender, e);
        }

        /// <summary>
        /// フォルダ削除メニュー押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void FolderDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderDeleteButton_Click(sender, e);
        }

        /// <summary>
        /// フォルダ全削除メニュー押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void FolderAllDeleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FolderAllDeleteButton_Click(sender, e);
        }

        /// <summary>
        /// 入力したパスをクリアメニュー押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void PathClearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PathClearButton_Click(sender, e);
        }

        #endregion

        #region パスコンテキストメニュー関連

        /// <summary>
        /// コンテキストメニュー表示処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">パラメータ</param>
        private void PathContextMenuStrip_Opening(object sender, CancelEventArgs e)
        {
            // 元に戻す判定フラグを判定する。
            if (TextBoxHistory.IsUndoFlg)
            {
                // 可能の場合
                UndoToolStripMenuItem.Enabled = true;
            }
            else
            {
                // 不可の場合
                UndoToolStripMenuItem.Enabled = false;
            }

            // やり直し判定フラグを判定する。
            if (TextBoxHistory.IsRedoFlg)
            {
                // 可能の場合
                RedoToolStripMenuItem.Enabled = true;
            }
            else
            {
                // 不可の場合
                RedoToolStripMenuItem.Enabled = false;
            }
        }

        /// <summary>
        /// 元に戻すメニュー押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBoxHistory.Undo();
        }

        /// <summary>
        /// やり直しメニュー押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TextBoxHistory.Redo();
        }

        /// <summary>
        /// 切り取りメニュー押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PathTextBox.Cut();
        }

        /// <summary>
        /// コピーメニュー押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PathTextBox.Copy();
        }

        /// <summary>
        /// 貼り付けメニュー押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PathTextBox.Paste();
        }

        /// <summary>
        /// 削除メニュー押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void DelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PathTextBox.Text))
            {
                return;
            }

            int selectionStart = PathTextBox.SelectionStart;

            // 選択範囲を判定する。
            if (Equals(PathTextBox.SelectionLength, 0))
            {
                // 存在しない場合

                int newLineLength = Environment.NewLine.Length, removeLength = 1;

                // 選択開始位置＋改行コード数・文字数を判定する。
                if ((selectionStart + newLineLength) <= PathTextBox.Text.Length)
                {
                    // より多い場合

                    // 選択開始位置以降が改行コードか判定する。
                    if (string.Equals(Environment.NewLine, PathTextBox.Text.Substring(selectionStart, newLineLength)))
                    {
                        // 改行コードの場合
                        removeLength = newLineLength;
                    }
                }

                // 文字を削除する。
                PathTextBox.Text = PathTextBox.Text.Remove(selectionStart, removeLength);

                // 選択位置を設定する。
                PathTextBox.SelectionStart = selectionStart;
            }
            else
            {
                // 存在する場合
                PathTextBox.SelectedText = string.Empty;
            }
        }

        /// <summary>
        /// 行選択メニュー押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void RowSelectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PathTextBox.Text))
            {
                return;
            }

            // パステキストボックスの選択範囲位置を取得・取得する。
            int selectionStart = PathTextBox.SelectionStart;

            // 選択開始行位置・選択終了行位置を取得・保持する。
            int startLineIndex = PathTextBox.GetLineFromCharIndex(selectionStart);
            int endLineIndex = PathTextBox.GetLineFromCharIndex(selectionStart + PathTextBox.SelectionLength);

            // 選択開始行位置・選択終了行位置を判定する。
            if (Equals(startLineIndex, endLineIndex))
            {
                // 同一行の場合
                PathTextBox.Select(PathTextBox.GetFirstCharIndexFromLine(startLineIndex), PathTextBox.Lines[startLineIndex].Length);
            }
            else
            {
                // 不一致の場合

                // 選択範囲の改行分を加算する。
                int selectionLength = (endLineIndex - startLineIndex) * Environment.NewLine.Length;

                // 選択文字数を加算する。
                for (int index = startLineIndex; index <= endLineIndex; index++)
                {
                    selectionLength += PathTextBox.Lines[index].Length;
                }

                PathTextBox.Select(PathTextBox.GetFirstCharIndexFromLine(startLineIndex), selectionLength);
            }

            ActiveControl = PathTextBox;
        }

        /// <summary>
        /// 全選択メニュー押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void SelectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PathTextBox.SelectAll();
        }

        /// <summary>
        /// 選択行のフォルダを開くメニュー押下処理
        /// </summary>
        /// <param name="sender">オブジェクト</param>
        /// <param name="e">イベント</param>
        private void FolderOpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PathTextBox.Text))
            {
                return;
            }

            string path;
            List<string> pathList = new List<string>();

            // パステキストボックスの選択範囲位置を取得・取得する。
            int selectionStart = PathTextBox.SelectionStart;

            // 選択開始行位置・選択終了行位置を取得・保持する。
            int startLineIndex = PathTextBox.GetLineFromCharIndex(selectionStart);
            int endLineIndex = PathTextBox.GetLineFromCharIndex(selectionStart + PathTextBox.SelectionLength);

            // 選択行のパスを保持する。
            for (int index = startLineIndex; index <= endLineIndex; index++)
            {
                // パスを保持し、有無を判定する。
                path = PathTextBox.Lines[index];
                if (!string.IsNullOrWhiteSpace(path))
                {
                    // ドライブ文字を、大文字に変換し、保持する。
                    path = string.Concat(path[0].ToString().ToUpper(), path.Substring(1));

                    // パスの末尾を判定する。
                    if (string.Equals(Const.Yen, path.Substring(path.Length - 1, 1)))
                    {
                        // 【\】の場合、削除する。
                        path = path.Substring(0, path.Length - 1);
                    }

                    // パスリストに、パスを設定する。
                    pathList.Add(path);
                }
            }

            // パスリストの有無を判定する。
            if (pathList.Any())
            {
                // フォルダの有無を判定し、フォルダが存在する場合、フォルダを開く。
                foreach (var openPath in pathList.Distinct())
                {
                    if (IsFolderExist(openPath))
                    {
                        Process.Start("EXPLORER.EXE", openPath);
                    }
                }
            }
        }

        #endregion

        /// <summary>
        /// フォルダ作成処理
        /// </summary>
        private void FolderCreateTran()
        {
            try
            {
                // 確認メッセージボックスを表示し、戻り値を判定する。
                CustomMessageBox msgBox = new CustomMessageBox();
                msgBox.MessageBoxSetting(
                    "フォルダ作成確認",
                    "入力されたパスでフォルダを作成してよろしいですか？",
                    3,
                    Const.ButtonTextListForQustion,
                    1);
                msgBox.ShowDialog(this);
                if (!Equals(msgBox.MessageBoxResult, CustomMessageBox.RETURN_BUTTON1))
                {
                    return;
                }

                // 未入力チェック
                if (string.IsNullOrWhiteSpace(PathTextBox.Text))
                {
                    msgBox.MessageBoxSetting(
                        Const.Error,
                        "フォルダパスが未入力です。",
                        1,
                        Const.ButtonTextListOkOnly,
                        0);
                    msgBox.ShowDialog(this);
                    return;
                }

                // ドライブ文字リストを取得・保持する。
                List<string> driveLetterList = GetDriveLetterList(),
                    createPathList = new List<string>();

                string path, tempPath = string.Empty;

                // 入力されたパスを基に処理を行う。
                for (int index = 0; index < PathTextBox.Lines.Count(); index++)
                {
                    // パスを保持する。
                    path = PathTextBox.Lines[index];

                    // パスの有無を判定する。
                    if (!string.IsNullOrWhiteSpace(path))
                    {
                        // ドライブ文字を、大文字に変換し、保持する。
                        path = string.Concat(path[0].ToString().ToUpper(), path.Substring(1));

                        // チェック処理を行い、結果を判定する。
                        if (CheckTran(path, driveLetterList, index + 1))
                        {
                            // 正常の場合

                            // 全フォルダ名を基にループさせる。
                            foreach (string folderName in path.Split(Const.YenAr, StringSplitOptions.RemoveEmptyEntries))
                            {
                                // 予約語の有無を判定する。
                                if (Const.InvalidFolderNameList.Any(word => string.Equals(word, folderName.ToUpper())))
                                {
                                    // 存在する場合

                                    // メッセージボックスを表示し、処理を終了する。
                                    msgBox.MessageBoxSetting(
                                        Const.Error,
                                        string.Format("{0}行目：フォルダ名に使用出来ない文字列（予約語）が含まれています。", ConvertNumberWide(index + 1)),
                                        1,
                                        Const.ButtonTextListOkOnly,
                                        0);
                                    msgBox.ShowDialog(this);
                                    return;
                                }
                            }

                            // 作成パスリストに、パスを追加する。
                            createPathList.Add(path);
                        }
                        else
                        {
                            // エラーの場合、処理を終了する。
                            return;
                        }
                    }
                }

                int folderNo = 0, rowIndex = 1;

                try
                {
                    // 仮フォルダを作成する。
                    bool createFlg = false;
                    do
                    {
                        // 仮フォルダパスを生成する。
                        tempPath = string.Concat(driveLetterList[0], Const.Yen, folderNo);

                        // フォルダ検索処理を呼び出し、結果の有無を判定する。
                        if (IsFolderExist(tempPath))
                        {
                            // 存在する場合
                            folderNo++;
                        }
                        else
                        {
                            // 存在しない場合

                            // 仮フォルダを生成し、作成フラグを設定する。
                            Directory.CreateDirectory(tempPath);
                            createFlg = true;
                        }
                    } while (!createFlg);

                    // 仮フォルダ下にフォルダを作成する。
                    for (int index = 0; index < PathTextBox.Lines.Count(); index++)
                    {
                        path = PathTextBox.Lines[index];

                        // パスの有無を判定する。
                        if (!string.IsNullOrWhiteSpace(path))
                        {
                            // パスが存在している場合

                            // 作成するフォルダパスを生成し、フォルダを作成する。
                            Directory.CreateDirectory(string.Concat(tempPath, path.Substring(2)));
                        }

                        rowIndex++;
                    }

                    // 仮フォルダを削除する。
                    Microsoft.VisualBasic.FileIO.FileSystem.DeleteDirectory(
                        tempPath,
                        Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs,
                        Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently,
                        Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing);

                    // フォルダを作成する。
                    createPathList.ForEach(createPath => Directory.CreateDirectory(createPath));

                    // 完了メッセージボックスを表示する。
                    msgBox.MessageBoxSetting(
                        "フォルダ作成完了",
                        "フォルダが作成されました。",
                        0,
                        Const.ButtonTextListOkOnly,
                        0);
                    msgBox.ShowDialog(this);

                }
                catch (Exception ex)
                {
                    // 仮フォルダのパスの保持の有無を判定する。
                    if (!string.IsNullOrEmpty(tempPath) && IsFolderExist(tempPath))
                    {
                        // 保持されている場合

                        // 仮フォルダを削除する。
                        Microsoft.VisualBasic.FileIO.FileSystem.DeleteDirectory(
                            tempPath,
                            Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs,
                            Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently,
                            Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing);
                    }

                    // エラーメッセージを表示する。
                    msgBox.MessageBoxSetting(
                        Const.Error,
                        ex.Message,
                        1,
                        Const.ButtonTextListOkOnly,
                        0);
                    msgBox.ShowDialog(this);
                }
            }
            finally
            {
                ActiveControl = PathTextBox;
            }
        }

        /// <summary>
        /// フォルダ削除処理
        /// </summary>
        /// <param name="allDeleteFlg">全削除フラグ（true：全削除・false：削除）</param>
        private void FolderDeleteTran(bool allDeleteFlg)
        {
            CustomMessageBox msgBox = new CustomMessageBox();

            try
            {
                string title = "フォルダ削除確認",
                    message = @"入力されたパスのフォルダを削除してよろしいですか？
（フォルダ内にファイルが存在する場合、ファイルごと削除します。）";

                // 全削除フラグを判定する。
                if (allDeleteFlg)
                {
                    // 全削除の場合
                    title = "フォルダ全削除確認";
                    message = @"入力されたパスの全フォルダを削除してよろしいですか？
（フォルダ内にファイルが存在する場合、ファイルごと削除します。）";
                }

                // 確認メッセージボックスを表示し、戻り値を判定する。
                msgBox.MessageBoxSetting(
                    title,
                    message,
                    3,
                    Const.ButtonTextListForQustion,
                    1);
                msgBox.ShowDialog(this);
                if (!Equals(msgBox.MessageBoxResult, CustomMessageBox.RETURN_BUTTON1))
                {
                    return;
                }

                // 未入力チェック
                if (string.IsNullOrWhiteSpace(PathTextBox.Text))
                {
                    msgBox = new CustomMessageBox();
                    msgBox.MessageBoxSetting(
                        Const.Error,
                        "フォルダパスが未入力です。",
                        1,
                        Const.ButtonTextListOkOnly,
                        0);
                    msgBox.ShowDialog(this);
                    return;
                }

                // ドライブ文字リストを取得・保持する。
                List<string> driveLetterList = GetDriveLetterList(),
                    deletePathList = new List<string>();

                string path, tempPath = string.Empty;

                // 入力されたパスを基に処理を行う。
                for (int index = 0; index < PathTextBox.Lines.Count(); index++)
                {
                    // パスを保持する。
                    path = PathTextBox.Lines[index];

                    // パスの有無を判定する。
                    if (!string.IsNullOrWhiteSpace(path))
                    {
                        // ドライブ文字を、大文字に変換し、保持する。
                        path = string.Concat(path[0].ToString().ToUpper(), path.Substring(1));

                        // チェック処理を行い、結果を判定する。
                        // （本来フォルダ存在チェックのみで良いが、エラー発生時、エラー行位置がわからないため、チェックを行う。）
                        if (CheckTran(path, driveLetterList, index + 1))
                        {
                            // 正常の場合

                            // フォルダを検索し、結果を判定する。
                            if (IsFolderExist(path))
                            {
                                // 存在する場合
                                // 全削除フラグを判定する。
                                if (allDeleteFlg)
                                {
                                    // 全削除の場合

                                    // パスを、【ドライブ文字:\フォルダ】の形式にする。
                                    tempPath = string.Join(Const.Yen, path.Split(Const.YenAr, StringSplitOptions.None).Take(2));
                                }
                                else
                                {
                                    // 削除の場合
                                    tempPath = path;
                                }

                                // 削除パスリストに、パスを追加する。
                                deletePathList.Add(tempPath);
                            }
                        }
                        else
                        {
                            // エラーの場合、処理を終了する。
                            return;
                        }
                    }
                }

                // 削除パスリストの有無を判定する。
                if (deletePathList.Any())
                {
                    // 存在する場合、削除パスリストを一意にし、ループさせる。。
                    foreach (string deletePath in deletePathList.Distinct())
                    {
                        // フォルダ検索処理を行い、存在する場合、フォルダを削除する。
                        if (IsFolderExist(deletePath))
                        {
                            Microsoft.VisualBasic.FileIO.FileSystem.DeleteDirectory(
                                deletePath,
                                Microsoft.VisualBasic.FileIO.UIOption.OnlyErrorDialogs,
                                Microsoft.VisualBasic.FileIO.RecycleOption.DeletePermanently,
                                Microsoft.VisualBasic.FileIO.UICancelOption.DoNothing);
                        }
                    }
                }

                // 全削除フラグを判定する。
                if (allDeleteFlg)
                {
                    // 全削除の場合
                    title = "フォルダ全削除完了";
                    message = "フォルダが全削除されました。";
                }
                else
                {
                    // 削除の場合
                    title = "フォルダ削除完了";
                    message = "フォルダが削除されました。";
                }

                // 完了メッセージボックスを表示する。
                msgBox = new CustomMessageBox();
                msgBox.MessageBoxSetting(
                    title,
                    message,
                    0,
                    Const.ButtonTextListOkOnly,
                    0);
                msgBox.ShowDialog(this);
            }
            catch (Exception ex)
            {
                // エラーメッセージを表示する。
                msgBox.MessageBoxSetting(
                    Const.Error,
                    ex.Message,
                    1,
                    Const.ButtonTextListOkOnly,
                    0);
                msgBox.ShowDialog(this);
            }
            finally
            {
                ActiveControl = PathTextBox;
            }
        }

        /// <summary>
        /// チェック処理
        /// </summary>
        /// <param name="path">パス</param>
        /// <param name="driveLetterList">ドライブ文字リスト</param>
        /// <param name="rowIndex">行数</param>
        /// <returns>チェック結果（true：正常・false：エラー）</returns>
        private bool CheckTran(string path, List<string> driveLetterList, int rowIndex)
        {
            CustomMessageBox msgBox = new CustomMessageBox();

            // 文字数チェック
            if (240 < path.Length)
            {
                // 文字数が２４０文字以上の場合、エラーとする。
                msgBox.MessageBoxSetting(
                    Const.Error,
                    string.Format(@"{0}行目：パスの入力可能文字数は、２４０文字までです。
入力文字数：{1}文字", ConvertNumberWide(rowIndex), ConvertNumberWide(path.Length)),
                    1,
                    Const.ButtonTextListOkOnly,
                    0);
                msgBox.ShowDialog(this);
                return false;
            }

            // 無名フォルダチェック
            if (!Equals(-1, path.IndexOf(Const.Double_Yen)))
            {
                // 無名フォルダが存在する場合、エラーとする。
                msgBox.MessageBoxSetting(
                    Const.Error,
                    string.Format("{0}行目：フォルダ名が指定されていない箇所があります。", ConvertNumberWide(rowIndex)),
                    1,
                    Const.ButtonTextListOkOnly,
                    0);
                msgBox.ShowDialog(this);
                return false;
            }

            // パスを配列化する。
            // （末端要素がブランクの場合、削除する。（スペースの場合は削除しない。））
            string[] folderNameAr = path.Split(Const.YenAr, StringSplitOptions.None);
            if (string.IsNullOrEmpty(folderNameAr.Last()))
            {
                folderNameAr = folderNameAr.Take(folderNameAr.Length - 1).ToArray();
            }

            // 要素数チェック
            if (2 > folderNameAr.Count())
            {
                // 要素数が２個以下の場合、エラーとする。
                msgBox.MessageBoxSetting(
                    Const.Error,
                    string.Format("{0}行目：フォルダ名が入力されていません。", ConvertNumberWide(rowIndex)),
                    1,
                    Const.ButtonTextListOkOnly,
                    0);
                msgBox.ShowDialog(this);
                return false;
            }

            // パス使用文字チェック
            // ドライブ文字以外で、ループさせる。
            foreach (string folderName in folderNameAr.Skip(1))
            {
                foreach (string invalidChar in InvalidCharList)
                {
                    if (folderName.Contains(invalidChar))
                    {
                        // パスに使用出来ない文字が使用されている場合、エラーとする。
                        msgBox.MessageBoxSetting(
                            Const.Error,
                            string.Format("{0}行目：フォルダ名に使用出来ない文字が含まれています。", ConvertNumberWide(rowIndex)),
                            1,
                            Const.ButtonTextListOkOnly,
                            0);
                        msgBox.ShowDialog(this);
                        return false;
                    }
                }
            }

            // スペース・ドットチェック
            foreach (string folderName in folderNameAr)
            {
                if (string.IsNullOrWhiteSpace(folderName))
                {
                    // スペースのみのフォルダが存在する場合、エラーとする。
                    msgBox.MessageBoxSetting(
                        Const.Error,
                        string.Format("{0}行目：スペース（全角・半角問わず）のみのフォルダは、処理出来ません。", ConvertNumberWide(rowIndex)),
                        1,
                        Const.ButtonTextListOkOnly,
                        0);
                    msgBox.ShowDialog(this);
                    return false;
                }
                else if (string.Equals(Const.Dot, folderName))
                {
                    // ドットのみのフォルダが存在する場合、エラーとする。
                    msgBox.MessageBoxSetting(
                        Const.Error,
                        string.Format("{0}行目：【.】のみのフォルダは、処理出来ません。", ConvertNumberWide(rowIndex)),
                        1,
                        Const.ButtonTextListOkOnly,
                        0);
                    msgBox.ShowDialog(this);
                    return false;
                }
                else if (folderName.EndsWith(Const.Dot))
                {
                    // フォルダ名の末尾が【.】の場合、エラーとする。
                    msgBox.MessageBoxSetting(
                        Const.Error,
                        string.Format("{0}行目：フォルダ名の末尾が【.】の場合、処理出来ません。", ConvertNumberWide(rowIndex)),
                        1,
                        Const.ButtonTextListOkOnly,
                        0);
                    msgBox.ShowDialog(this);
                    return false;
                }
            }

            // ドライブ文字を保持する。
            string driveLetter = path.Substring(0, 2);

            // ドライブチェック
            if (!driveLetterList.Contains(driveLetter))
            {
                // 存在していないドライブ文字が指定されている場合、エラーとする。
                msgBox.MessageBoxSetting(
                    Const.Error,
                    string.Format("{0}行目：存在しないドライブ文字（C:やD:）が入力されています。", ConvertNumberWide(rowIndex)),
                    1,
                    Const.ButtonTextListOkOnly,
                    0);
                msgBox.ShowDialog(this);
                return false;
            }

            return true;
        }

        /// <summary>
        /// フォルダ検索処理
        /// </summary>
        /// <param name="searchPath">検索パス</param>
        /// <returns>検索結果（true：フォルダ有り・false：フォルダ無し）</returns>
        private bool IsFolderExist(string searchPath)
        {
            string targetPath;

            string[] pathAr = searchPath.Split(Const.YenAr, StringSplitOptions.None);
            if (pathAr.Length <= 1)
            {
                return false;
            }
            else
            {
                // ドライブ文字を設定する。
                targetPath = string.Concat(pathAr.First(), Const.Yen);

                for (int index = 1; index < pathAr.Length; index++)
                {
                    if (string.IsNullOrWhiteSpace(pathAr[index]))
                    {
                        return false;
                    }
                    else
                    {
                        // 対象フォルダ名のフォルダを検索する。
                        // （正確性を重視したいので、正規化は行わない方法で、フォルダを検索する。）
                        if (!Directory.EnumerateDirectories(targetPath, pathAr[index], SearchOption.TopDirectoryOnly).Any())
                        {
                            return false;
                        }

                        // フォルダ名を追加する。
                        targetPath = string.Concat(targetPath, pathAr[index], Const.Yen);
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// ドライブ文字リスト取得処理
        /// </summary>
        /// <returns>ドライブ文字リスト</returns>
        private List<string> GetDriveLetterList()
        {
            // ドライブ文字リストを返却する。
            // （固定ディスク・リムーバブルドライブ・ネットワークドライブ、かつ使用可能なドライブ文字を設定する。）
            return DriveInfo.GetDrives()
                .Where(Info => Const.AvailableDriveTypeList.Contains(Info.DriveType) && Info.IsReady)
                .Select(Info => Info.Name.Replace(Const.Yen, string.Empty))
                .ToList();
        }

        /// <summary>
        /// 半角数値→全角数値変換処理
        /// </summary>
        /// <param name="narrowNumber">半角数値</param>
        /// <returns>変換した全角数値</returns>
        private string ConvertNumberWide(int narrowNumber)
        {
            string narrowNumberStr = narrowNumber.ToString(), convertNumber = string.Empty;
            foreach (char number in narrowNumberStr)
            {
                string value = Const.FullWidthNumberList.ElementAtOrDefault(int.Parse(number.ToString()));
                if (!string.IsNullOrEmpty(value))
                {
                    convertNumber = string.Concat(convertNumber, value);
                }
            }

            return convertNumber;
        }
    }
}
