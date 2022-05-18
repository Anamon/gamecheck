using System.Collections.Generic;
using System.Threading.Tasks;

namespace Anamon.GameDigest.Services
{
    public interface IFileService
    {
        Task<IEnumerable<string>> GetFileList(string path, bool recursive);
    }
}
