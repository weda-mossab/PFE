using BlazorInputFile;
namespace AzureFormRecog.Services
{
    public interface IFileUpload
    {
        Task UploadFile(IFileListEntry file);
    }
}
