using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AWSServerlessLambdaDemo.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : ControllerBase
    {
        // GET api/values
        [HttpGet]
        public IEnumerable<string> Get()
        {
            string directory = @"/tmp/";
            List<string> result = new List<string>();

            // Process the list of files found in the directory.
            string[] fileEntries = Directory.GetFiles(directory);
            foreach (string fileName in fileEntries)
            {
                result.Add(fileName);
            }
            return result;
        }

        // POST api/values
        [HttpPost]
        public void Post()
        {
            Guid guid = Guid.NewGuid();
            string directory = @"/tmp/";
            string path = directory + guid + ".txt";
            List<string> result = new List<string>();
            // Create the file, or overwrite if the file exists.
            using (FileStream fs = System.IO.File.Create(path))
            {
                byte[] info = new UTF8Encoding(true).GetBytes("This is some text in the file.");
                // Add some information to the file.
                fs.Write(info, 0, info.Length);
            }
        }
    }
}