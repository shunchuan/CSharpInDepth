﻿using System.ComponentModel;
using System.IO;
using System.Net;

namespace Chapter10
{
    [Description("Listing 10.04")]
    class UsingStreamUtilWithExtensions
    {
        static void Main()
        {
            WebRequest request = WebRequest.Create("http://manning.com");
            using (WebResponse response = request.GetResponse())
            using (Stream responseStream = response.GetResponseStream())
            using (FileStream output = File.Create("response.dat"))
            {
                responseStream.CopyTo(output); 
            }
        }
    }
}
