using System;
using System.Text;

namespace HTMLDispatcher
{
    public class ElementBuilder
    {
        #region Fields

        private StringBuilder openingTag = new StringBuilder();
        private string closingTag;
        private string content;

        #endregion

        #region Constructors

        public ElementBuilder(string elementsName)
        {
            CreateTags(elementsName);
        }

        #endregion

        #region Methods

        public void AddAttribute(string attribute, string value)
        {
            this.openingTag.Insert(this.openingTag.Length - 1, string.Format(" {0}=\"{1}\"", attribute, value));
        }

        public void AddContent(string content)
        {
            this.content = content;
        }

        public override string ToString()
        {
            return string.Format("{0}{1}{2}", openingTag, content, closingTag);
        }

        private void CreateTags(string elementsName)
        {
            this.openingTag.AppendFormat("<{0}>", elementsName);
            if (elementsName != "img" && elementsName != "input")
            {
                this.closingTag = string.Format("</{0}>", elementsName);
            }
            else
            {
                this.closingTag = "";
            }
        }

        #endregion

        #region Operators

        public static string operator *(ElementBuilder elementBuilder, int number)
        {
            return elementBuilder.ToString() + elementBuilder.ToString();
        }

        #endregion
    }
}
