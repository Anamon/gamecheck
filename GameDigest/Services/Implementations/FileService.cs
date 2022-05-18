using System.Collections.Generic;
using System.Threading.Tasks;

namespace Anamon.GameDigest.Services.Implementations
{
    public class FileService : IFileService
    {
        public async Task<IEnumerable<string>> GetFileList(string path, bool recursive)
        {
            // FIXME: Placate warning. [Anamon]
            await Task.Delay(0);

            // TODO: Implement. [Anamon]
            return new string[0];
        }
    }
}
