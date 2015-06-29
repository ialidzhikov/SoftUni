using System;
using Novacode;

namespace WordDocumentGenerator
{
    class WordDocumentGenerator
    {
        static void Main()
        {
            string fileName = "SoftUni-OOP-Game-Contest.docx";
            DocX doc = DocX.Create(fileName);

            var titleFormatting = new Formatting();
            titleFormatting.FontFamily = new System.Drawing.FontFamily("Calibri");
            titleFormatting.Size = 28;
            titleFormatting.Bold = true;
            titleFormatting.Position = 12;

            Paragraph title = doc.InsertParagraph("SoftUni OOP Game Contest", false, titleFormatting);
            title.Alignment = Alignment.center;


            Image image = doc.AddImage("rpg-game.png");
            Picture picture = image.CreatePicture(234, 605);
            Paragraph pictureParagraph = doc.InsertParagraph("", false);
            pictureParagraph.InsertPicture(picture, 0);

            var bodyFormatting = new Formatting();
            bodyFormatting.FontFamily = new System.Drawing.FontFamily("Calibri");
            bodyFormatting.Size = 12;
            bodyFormatting.Position = 12;
            
            string textOne =
                "SoftUni is organizing a contest for the best role playing game from the OOP teamwork projects. The winning teams will receive a grand prize! ";
            Paragraph bodyParagraphOne = doc.InsertParagraph(textOne, false, bodyFormatting);


            string textTwo = "The game should be:";
            Paragraph bodyParagraphTwo = doc.InsertParagraph(textTwo, false, bodyFormatting);


            //Paragraph listItemOne = doc.
            List bullet = doc.AddList("The game should be: ", 0, ListItemType.Bulleted);
            
            bullet.AddItem(doc.InsertParagraph("Item1", false, bodyFormatting));


            doc.Save();
        }
    }
}
