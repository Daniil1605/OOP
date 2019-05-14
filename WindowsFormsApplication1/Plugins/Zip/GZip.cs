using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Compression;
using System.IO;
using WindowsFormsApplication1;

    public class GZip : IPlugins
    {
        public string Name
        {
            get
            {
                return "GZip";
            }
        }
        public string Format
        {
            get
            {
                return ".gz";
            }
        }  
        private GZipStream gzip;

        public GZip() { }

        public void UsePlugin(string inputFile, string outputFile)
        {
            using (FileStream input = File.OpenRead(inputFile))
            using (FileStream output = File.Create(outputFile))
            using (gzip = new GZipStream(output, CompressionMode.Compress))
            {
                input.CopyTo(gzip);
            }
            File.Delete(inputFile);
        }

        public void DeUsePlugin(string inputFile, string outputFile)
        {
            using (FileStream input = File.OpenRead(inputFile))
            using (FileStream output = File.Create(outputFile))
            using (gzip = new GZipStream(input, CompressionMode.Decompress))
            {
                gzip.CopyTo(output);
            }
            File.Delete(inputFile);
        }
    }

