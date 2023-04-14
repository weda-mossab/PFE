function ShowMessageFile(FileName, FileSize, FileType) {
    document.getElementById("MessageBox").innerHTML = "File Name :" + FileName + "</br>File Type :" + FileType + " </br> File Path: D:\\My Desk\\Projects\\Practice\\BlazorApp_formRecog\\BlazorApp_formRecog\\UploadloadedFiles\\" + FileName + " ";
    return false;
}