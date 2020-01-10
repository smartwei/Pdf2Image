using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using WebSupergoo.ABCpdf6;

namespace pdf2image.ABCpdf
{
    class Program
    {
        static void Main(string[] args)
        {
            var theDoc = new Doc();

            theDoc.Read("E:\\Convert\\new.pdf");

            theDoc.Rendering.DotsPerInch = 200;
            
            for (int i = 0; i < 4; i++)
            {
                theDoc.PageNumber = i;
                theDoc.Rect.String = theDoc.CropBox.String;
                theDoc.Rendering.Save("E:\\Convert\\new" + i.ToString(CultureInfo.InvariantCulture) + ".JPG");
            }
        }
    }
}
