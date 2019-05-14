using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.IO;
using WindowsFormsApplication1;

public class Base64 : IPlugins
{
    public string Name
    {
        get
        {
            return "Base64";
        }
    }
    public string Format
    {
        get
        {
            return ".b64";
        }
    }

    public Base64() { }

    public void UsePlugin(string inputFile, string outputFile)
    {
        
        {
            string filetext;
            byte[] filebytes;
            filebytes=File.ReadAllBytes(inputFile);
            filetext = System.Convert.ToBase64String(filebytes);
            using (StreamWriter sw = new StreamWriter(outputFile, false, System.Text.Encoding.Default))
            {
                sw.Write(filetext);
            }
            File.Delete(inputFile);
        }
    }

    public void DeUsePlugin(string inputFile, string outputFile)
    {
        
        {
            string filetext;

            using (StreamReader sr = new StreamReader(inputFile))
            {
                filetext = sr.ReadToEnd();
            }
            var base64EncodedBytes = System.Convert.FromBase64String(filetext);
            File.WriteAllBytes(outputFile, base64EncodedBytes);
            //using (StreamWriter sw = new StreamWriter(outputFile, false, System.Text.Encoding.Default))
            //{
              //  sw.Write(filetext);
            //}
            File.Delete(inputFile);
        }
    }
}
