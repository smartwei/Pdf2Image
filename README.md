 Pdf2Image
================================
c#把pdf转成图片  
copy 项目: https://github.com/stone0090/OfficeTools.Pdf2Image.Word2Image

**ExtractImagesFromPDF.itextsharp**  
　　没有效果  
**ExtractImagesFromPDF.PDFSharp**  
　　没有效果  
**ExtractTextFromPDF.itextsharp**  
　　没有效果  
**pdf2image.ABCpdf**  
　　不能用，异常：System.DllNotFoundException:“无法加载 DLL“ABCpdfCE6.dll”: 找不到指定的模块。 (异常来自 HRESULT:0x8007007E)。”  
**pdf2image.AcrobatZW**  
　　先把项目名字改成pdf2image.AcrobatZW，可以转成图片，但一定要安装Acrobat，而且用到了系统粘贴板，用一次以后粘贴板的内容会丢失,  
**pdf2image.Apitron.PDF.RasterizerZW**  
　　pdf转图片，可以用，但是有水印  
**pdf2image.AsposePdf**  
　　(强烈推荐)pdf转图片，可以用，用了aspose破解的DLL,有30MB,目前已经换成这个了  
**pdf2Image.GhostScriptPdf2ImageZW**  
　 pdf转图片，可以用，后来自己找到的，可以用,但是只能把项目设置为x86 (32位）的项目  
**pdf2image.GhostscriptZW**  
　　以可使用，无水印，dll有10MB,后来又用了这个，但是有一些pdf转换报错:未经处理的异常:  System.AccessViolationException: 尝试读取或写入受保护的内存pdf2image.O2S.Components.PDFRender4NET(700kb)，可以转换但是有问题(不要用），但是PDF中如果有表格或vison画的图，不能正常显示,网上也有人介绍说一直在使用https://www.cnblogs.com/lyl6796910/p/3318056.html  
  用了一下，发布以后有一部分从我们系统中生成出来pdf的不能使用而且一直在pdfFile.GetPageImage这一行卡住也不报异常，导致程序不向下执行(2019-11-27 HAWB(HELKA)-HSZAE1911001.pdf) ，因此不再使用  
    
**pdf2image.PDFLibNet**	  
　　(1.7MB)pdf转图片，可以用，还不错，中文字体没压力,(但是Winform程序添加引用以下，提示混合模式程序集是针对“v2.0.50727”版的运行时生成的,在没有配置其他信息的情况，因为这个dll只能在x86（32）下生成程序)  
　　在外面可以，但是添加到.net4.5项目中就报错：System.TypeLoadException:“方法实现中引用的声明不能是 final 方法。类型:“PDFLibNet.xPDFBinaryReader”，  
**pdf2image.SautinSoft.PdfFocus**	  
　　pdf转图片,左上角有水印，中文字体转换感觉不一样  
**pdf2image.TallComponents.PDF.Rasterizer**  
　　pdf转图片，可以用，但有水印  
**word2image.Aspose**  
　　(6.2MB)doc/docx转图片文件,可以使用，没水印  
**word2pdf.Microsoft**  
　　没有结果，不能用  
  
   
