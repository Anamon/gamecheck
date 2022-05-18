using System.CommandLine;
using System.Threading.Tasks;

using Microsoft.Extensions.DependencyInjection;

using Anamon.GameDigest.Models.Enums;
using Anamon.GameDigest.Services;
using Anamon.GameDigest.Services.Implementations;

namespace Anamon.GameDigest
{
    class Program
    {
        static async Task<int> Main(string[] args)
        {
            ServiceProvider serviceProvider = new ServiceCollection()
                .AddSingleton<IFileService, FileService>()
                .BuildServiceProvider();

            // TODO: i18n. [Anamon]
            Option pathOption = new Option<string>
                (name: "--path",
                description: "The path to digest or identify files in.",
                getDefaultValue: () => ".");
            Option fileOption = new Option<string>
                (name: "--file",
                description: "The digest file to create or check against.")
                { IsRequired = true };
            Option formatOption = new Option<DigestFormat>
                (name: "--format",
                description: "The format to use when creating the digest file.",
                getDefaultValue: () => DigestFormat.Sfv);

            Command digestCommand = new Command("digest", "Create file digest");
            Command checkCommand = new Command("check", "Check files against a digest");
            Command identifyCommand = new Command("identify", "Identify release");

            digestCommand.Add(pathOption);
            digestCommand.Add(fileOption);
            digestCommand.Add(formatOption);

            digestCommand.SetHandler(async (string pathOptionValue, string fileOptionValue, DigestFormat formatOptionValue) =>
                await CreateDigest(pathOptionValue, fileOptionValue, formatOptionValue),
                pathOption, fileOption, formatOption);

            RootCommand rootCommand = new RootCommand();
            rootCommand.Add(digestCommand);
            rootCommand.Add(checkCommand);
            rootCommand.Add(identifyCommand);

            // TODO: Move. [Anamon]
            IFileService? fileService = serviceProvider.GetService<IFileService>()!;

            await rootCommand.InvokeAsync(args);

            return 0;
        }

        // TODO: Refactor. [Anamon]
        public static Task CreateDigest(string path, string file, DigestFormat format)
        {
            // TODO: Implement. [Anamon]
            return Task.Delay(0);
        }
    }
}
