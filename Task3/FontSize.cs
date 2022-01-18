using System;

namespace Task3
{
    internal class FontSize
    {
        private string fontSize;

        public FontSize(string fontSize)
        {
            this.fontSize = fontSize;
        }

        public FontSize(double fontSizeDouble)
        {
        }

        public static implicit operator double(FontSize v)
        {
            throw new NotImplementedException();
        }
    }
}