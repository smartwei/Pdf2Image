using Aspose.Pdf.Drawing;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace pdf2image.AsposePdf
{
    class Program
    {
        static void Main(string[] args)
        {
            string dir = @"E:\Convert\pdf\";
            int r = 50;
            string fileName = "t2222";
            string pdfFile = dir + fileName+".pdf";
            string imgFile = dir + fileName + "_asposePDF_" + r.ToString() + ".jpg";
            //ConsoleTest3.ModifyInMemory.ActivateMemoryPatching();
            Aspose.Pdf.Document document = new Aspose.Pdf.Document(pdfFile);
            var device = new Aspose.Pdf.Devices.JpegDevice(r);
            //遍历每一页转为jpg
            for (var i = 1; i <= document.Pages.Count; i++)
            {
                string filePathOutPut = System.IO.Path.Combine(dir, string.Format("{0}.jpg", i));
                FileStream fs = new FileStream(imgFile, FileMode.OpenOrCreate);
                try
                {
                    device.Process(document.Pages[1], fs);
                    fs.Close();
                }
                catch (Exception ex)
                {
                    fs.Close();
                    File.Delete(filePathOutPut);
                }
                break;
            } 
        }
    }
}
