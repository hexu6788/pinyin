using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PinYin
{
    public static class PinYin
    {
        private static ChineseLib _chineseLib;

        static PinYin()
        {
            _chineseLib = new ChineseLib();
        }

        private static bool IsChinese(string word)
        {
            var match = " 0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz~!@#$%^&*()_+{}|:\"<>?-=[]\\;',./`、【】《》‘’：；\"";
            for (var i = 0; i < match.Length; i++)
            {
                if (word.Equals(match[i].ToString()))
                    return false;
            }
            return true;
        }

        public static string GetPinYin(string text, PinYinType type)
        {
            if (string.IsNullOrWhiteSpace(text))
                return string.Empty;

            text = text.Trim();
            text = _chineseLib.ReplaceTermsAndIdiom(text, type);
            text = _chineseLib.ReplaceWord(text, type);

            return text.Trim();
        }
    }
}
