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
            for (var i = 0; i < _chineseLib.SpecialWord.Length; i++)
            {
                if (word.Equals(_chineseLib.SpecialWord[i].ToString()))
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
            text = _chineseLib.ReplaceSpecialWordSpace(text);

            return text.Trim();
        }
    }
}
