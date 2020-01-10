using PdfToImage;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace pdf2Image.GhostScriptPdf2ImageZW
{
    class Program
    {
        static void Main(string[] args)
        {
            test2();
        }

        static void test2()
        {
            string filePath = @"E:\Convert\pdf\";
            string filename = "CAR1";
            string pdfPath = filePath + filename + ".pdf";

            PDFConvert converter = new PDFConvert();
            converter.OutputFormat = "jpeg";
            converter.JPEGQuality = 800;// mPrintQuality; //80
            converter.ResolutionX = 150;
            converter.ResolutionY = 150;
            string imgPath = filePath + filename + converter.ResolutionX.ToString() + "_" + converter.ResolutionY.ToString() + ".jpg";
            //string imgPath = filePath + "gica1" + converter.ResolutionX.ToString() + "_" + converter.ResolutionY.ToString() + ".jpg";
            if (converter.Convert(pdfPath, imgPath, true, null))
            {
                Debug.WriteLine("Seccessed");
            }
            else
            {
                Debug.WriteLine("Falid");
            }
        }

        static void test1()
        {
            string[] args = new string[] { "11", "22" };

            string pdf_filename = GhostScriptPdf2Image.Pdf2Image.GetProgramFilePath("CAR1.pdf");
            string png_filename = GhostScriptPdf2Image.Pdf2Image.GetProgramFilePath("CAR1.png");
            pdf_filename = @"E:\Convert\pdf\msg222.pdf";
            png_filename = @"E:\Convert\pdf\msg222.jpg";
            if (!File.Exists(pdf_filename))
            {
                //File.WriteAllBytes(pdf_filename, Properties.Resources.pdf_sample);
            }

            if (args.Length > 2)
            {
                pdf_filename = args[1];
                png_filename = args[2];
            }

            List<string> errors = GhostScriptPdf2Image.Pdf2Image.Convert(pdf_filename, png_filename);
            if (errors.Any())
            {
                foreach (string error in errors)
                {
                    Console.WriteLine(error);
                }
            }
            else
            {
                Console.WriteLine("Conversion is successful.");
            }
        }
    }
}
