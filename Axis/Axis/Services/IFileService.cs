using Axis.Models;

namespace Axis.Services;

public interface IFileService
{
    string SaveFile(IFormFile file, string folderpath);
}
