﻿using System.Drawing.Imaging;
using System.IO;
using Apitron.PDF.Rasterizer.Configuration;

namespace Apitron.PDF.RasterizerZW
{
    class Program
    {
        public enum Definition
        {
            One = 1, Two = 2, Three = 3, Four = 4, Five = 5, Six = 6, Seven = 7, Eight = 8, Nine = 9, Ten = 10
        }

        /// <summary>
        /// 将PDF文档转换为图片的方法
        /// </summary>
        /// <param name="pdfInputPath">PDF文件路径</param>
        /// <param name="imageOutputPath">图片输出路径</param>
        /// <param name="imageName">生成图片的名字</param>
        /// <param name="startPageNum">从PDF文档的第几页开始转换</param>
        /// <param name="endPageNum">从PDF文档的第几页开始停止转换</param>
        /// <param name="imageFormat">设置所需图片格式</param>
        /// <param name="definition">设置图片的清晰度，数字越大越清晰</param>
        public static void ConvertPDF2Image(string pdfInputPath, string imageOutputPath,
            string imageName, int startPageNum, int endPageNum, ImageFormat imageFormat, Definition definition)
        {
            FileStream fs = new FileStream(pdfInputPath, FileMode.Open);

            Apitron.PDF.Rasterizer.Document doc = new Apitron.PDF.Rasterizer.Document(fs);

            if (!Directory.Exists(imageOutputPath))
            {
                Directory.CreateDirectory(imageOutputPath);
            }

            // validate pageNum
            if (startPageNum <= 0)
            {
                startPageNum = 1;
            }

            if (endPageNum > doc.Pages.Count)
            {
                endPageNum = doc.Pages.Count;
            }

            if (startPageNum > endPageNum)
            {
                int tempPageNum = startPageNum;
                startPageNum = endPageNum;
                endPageNum = startPageNum;
            }

            // start to convert each page 0-based numeration
            for (int i = startPageNum-1; i <= endPageNum-1; i++)
            {
                RenderingSettings option = new RenderingSettings();
                option.DrawImages = true;
                option.DrawText = true;
                option.DrawAnotations = true;

                doc.Pages[i].Render((int) doc.Pages[i].Width, (int) doc.Pages[i].Height, option).Save(imageOutputPath + imageName + i.ToString() + "." + imageFormat, imageFormat);
            }

            fs.Dispose();
        }

        public static void Main(string[] args)
        {
            ConvertPDF2Image("E:\\Convert\\pdf\\t2222.pdf", "E:\\Convert\\pdf\\", "t2222", 1, 5, ImageFormat.Jpeg, Definition.One);
        }
    }
}
