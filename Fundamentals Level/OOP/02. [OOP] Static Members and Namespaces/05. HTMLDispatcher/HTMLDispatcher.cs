using System;

namespace HTMLDispatcher
{
    public static class HTMLDispatcher
    {
        #region Fields

        public static string CreateImage(string srcValue, string altValue, string titleValue)
        {
            ElementBuilder img = new ElementBuilder("img");
            img.AddAttribute("src", srcValue);
            img.AddAttribute("alt", altValue);
            img.AddAttribute("title", titleValue);
            
            return img.ToString();
        }

        public static string CreateURL(string hrefValue, string titleValue, string content)
        {
            ElementBuilder anchor = new ElementBuilder("a");
            anchor.AddAttribute("href", hrefValue);
            anchor.AddAttribute("title", titleValue);
            anchor.AddContent(content);

            return anchor.ToString();
        }

        public static string CreateInput(string inputType, string nameValue, string titleValue)
        {
            ElementBuilder input = new ElementBuilder("input");
            input.AddAttribute("name", nameValue);
            input.AddAttribute("title", titleValue);

            return input.ToString();
        }

        #endregion


        static void Main()
        {
            ElementBuilder div = new ElementBuilder("div");
            div.AddAttribute("id", "page");
            div.AddAttribute("class", "big");
            div.AddContent("<p>Hello</p>");
            Console.WriteLine(div * 2);

            Console.WriteLine();
            Console.WriteLine(CreateImage("smiley.gif", "Smiley face", "Project 101"));
            Console.WriteLine(CreateURL("http://softuni.bg", "SoftUni hyperlink", "Better education"));
            Console.WriteLine(CreateInput("text", "fname", "Input tag"));
        }
    }
}
