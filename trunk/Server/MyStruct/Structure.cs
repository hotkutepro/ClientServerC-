using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;
using System.Drawing;

namespace MyStruct
{
    [Serializable()]
    public class Structure : ISerializable
    {
        private string _textChat;
        Font _myFont;
        Color _myColor;

        public Structure()
        {
            this.TextChat = null;
            this.MyFont = new Font("Arial", 9, FontStyle.Regular);
            this.MyColor = Color.Red;
        }

        public Structure(string text, Font font, Color color)
        {
            this.TextChat = text;
            this.MyFont = font;
            this.MyColor = color;
        }

        public Structure(Structure st)
        {
            this.TextChat = st.TextChat;
            this.MyFont = st.MyFont;
            this.MyColor = st.MyColor;
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("text", this.TextChat);
            info.AddValue("font", this.MyFont);
            info.AddValue("color", this.MyColor);
        }
        public Structure(SerializationInfo info, StreamingContext context)
        {
            this.TextChat = (string)info.GetValue("text", typeof(string));
            this.MyFont = (Font)info.GetValue("font", typeof(Font));
            this.MyColor = (Color)info.GetValue("color", typeof(Color));
        }

        public Color MyColor
        {
            get { return _myColor; }
            set { _myColor = value; }
        }

        public Font MyFont
        {
            get { return _myFont; }
            set { _myFont = value; }
        }
        public string TextChat
        {
            get { return _textChat; }
            set { _textChat = value; }
        }
    }
}
