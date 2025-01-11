﻿using System.Collections.Generic;
using System.IO;

namespace FugyunFolderCreator
{
    /// <summary>
    /// 定数クラス
    /// </summary>
    internal class Const
    {
        #region メッセージ

        /// <summary>
        /// エラー
        /// </summary>
        public const string Error = "エラー";

        #endregion

        #region 記号

        /// <summary>
        /// *
        /// </summary>
        public const string Asterisk = "*";

        /// <summary>
        /// :
        /// </summary>
        public const string Colon = ":";

        /// <summary>
        /// .
        /// </summary>
        public const string Dot = ".";

        /// <summary>
        /// "
        /// </summary>
        public const string Double_Quotation = "\"";

        /// <summary>
        /// \\
        /// </summary>
        public const string Double_Yen = @"\\";

        /// <summary>
        /// >
        /// </summary>
        public const string Greater_Than = ">";

        /// <summary>
        /// <
        /// </summary>
        public const string Less_Than = "<";

        /// <summary>
        /// ?
        /// </summary>
        public const string Question = "?";

        /// <summary>
        /// /
        /// </summary>
        public const string Slash = "/";

        /// <summary>
        /// |
        /// </summary>
        public const string Vertical_Line = "|";

        /// <summary>
        /// \
        /// </summary>
        public const string Yen = @"\";

        #endregion

        #region 配列・リスト

        /// <summary>
        /// 【\】単独配列
        /// </summary>
        public static readonly string[] YenAr = { Yen };

        /// <summary>
        /// ボタンテキストリスト（質問）
        /// </summary>
        public static readonly List<string> ButtonTextListForQustion = new List<string>()
        {
            "はい",
            "いいえ"
        };

        /// <summary>
        /// ボタンテキストリスト（ＯＫ）
        /// </summary>
        public static readonly List<string> ButtonTextListOkOnly = new List<string>()
        {
            "ＯＫ"
        };

        /// <summary>
        /// 使用可能ドライブリスト
        /// </summary>
        public static List<DriveType> AvailableDriveTypeList = new List<DriveType>()
        {
            DriveType.Fixed,
            DriveType.Removable,
            DriveType.Network,
        };

        /// <summary>
        /// 使用不可フォルダ名リスト
        /// </summary>
        public static readonly List<string> InvalidFolderNameList = new List<string>()
        {
            "CON",
            "PRN",
            "AUX",
            "NUL",
            "COM0",
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "LPT0",
            "LPT1",
            "LPT2",
            "LPT3",
            "LPT4",
            "LPT5",
            "LPT6",
            "LPT7",
            "LPT8",
            "LPT9"
        };

        /// <summary>
        /// 全角数値リスト
        /// </summary>
        public static readonly List<string> FullWidthNumberList = new List<string>()
        {
            "０",
            "１",
            "２",
            "３",
            "４",
            "５",
            "６",
            "７",
            "８",
            "９"
        };

        #endregion
    }
}