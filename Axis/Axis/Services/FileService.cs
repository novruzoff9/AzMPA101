namespace Axis.Services;

public class FileService : IFileService
{
    public string SaveFile(IFormFile file, string folderpath)
    {
        if (!Directory.Exists(folderpath))
            Directory.CreateDirectory(folderpath);

        var filePath = Path.Combine(folderpath, file.FileName);

        using var stream = new FileStream(filePath, FileMode.Create);
        file.CopyTo(stream);
        return file.FileName;
    }
}
