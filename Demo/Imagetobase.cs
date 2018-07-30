using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace Demo
{
   
    public class Imagetobase
    {
        static string base64String = null;
        public static string GetBase64StringForImage(string imgPath)
        {
            byte[] imageBytes = System.IO.File.ReadAllBytes(imgPath);
            string base64String = Convert.ToBase64String(imageBytes);
            return base64String;
        }  
     
        public System.Drawing.Image Base64ToImage(string param)
        {
            byte[] imageBytes = Convert.FromBase64String(param);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }
    }
    
}