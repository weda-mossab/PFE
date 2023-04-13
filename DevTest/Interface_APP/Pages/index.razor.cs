using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.IO;
using BlazorInputFile;

namespace Interface_APP.Pages
{
    


     public class ViewImg : ComponentBase
    {
       
        byte[] imageFileBytes;
        protected string imagePreview;
        const int MaxFileSize = 4 * 1024 * 1024; // 4MB
        const string DefaultStatus = "Maximum size allowed for the image is 4 MB";
        protected string status = DefaultStatus;

        protected async Task ViewImage(IFileListEntry[] files)
        {
            var file = files.FirstOrDefault();
            if (file == null)
            {
                return;
            }
            else if (file.Size > MaxFileSize)
            {
                status = $"The file size is {file.Size} bytes, this is more than the allowed limit of {MaxFileSize} bytes.";
                return;
            }
            else
            {
                var memoryStream = new MemoryStream();
                await file.Data.CopyToAsync(memoryStream);
                imageFileBytes = memoryStream.ToArray();
                string base64String = Convert.ToBase64String(imageFileBytes, 0, imageFileBytes.Length);

                imagePreview = string.Concat("data:image/png;base64,", base64String);
                memoryStream.Flush();
                status = DefaultStatus;
            }
        }
    }
}