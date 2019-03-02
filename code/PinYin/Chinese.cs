using System;

namespace PinYin
{
    internal class Chinese
    {
        internal string Text { get; set; }
        internal string PinYin { get; set; }
        internal string PinYinFirstLetter { get; set; }

        internal Chinese(string text, string pinYin, string pinYinFirstLetter)
        {
            Text = text;
            PinYin = pinYin;
            PinYinFirstLetter = pinYinFirstLetter;
        }
    }
}
