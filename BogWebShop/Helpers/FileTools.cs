using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace BogWebShop.Helpers
{
    public class FileTools
    {
            public string UploadFile(HttpPostedFileBase fil, string outputPath)
            {
                string fileName = Path.GetFileName(fil.FileName);
                string[] allowedTypes = { "jpg", "jpeg", "png", "gif" };

                string extension = Path.GetExtension(fileName).Substring(1).ToLower();
                if (allowedTypes.Contains(extension))
                {
                    string newName = DateTime.Now.ToString("yyyyMMddhhmmssf") + "." + extension;

                    fil.SaveAs(outputPath + newName);

                    return newName;
                }
                else
                {
                    return null;
                }

        }
    }
}