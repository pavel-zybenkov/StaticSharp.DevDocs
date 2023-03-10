// See https://aka.ms/new-console-template for more information
using StaticSharp.Gears;
using StaticSharp;
using StaticSharp.DevDocs.Main;

using StaticSharp.DevDocs.Main.Root;

namespace StaticSharp.DevDocs.Main
{
    internal class Program
    {
        private static async Task Main(string[] args)
        {
            switch (args.FirstOrDefault())
            {
                case "s":
                    await Server();
                    break;
                case "g":
                    await Generator();
                    break;
                default:
                    Console.WriteLine("Add command line parameter: \"s\" - server mode, \"g\" - generator mode");
                    break;
            }

            Console.WriteLine(args.Length);
        }

        public static async Task Server()
        {
            Cache.RootDirectory = Static.MakeAbsolutePath(".cache");

            await new StaticSharp.Server(
                new DefaultMultilanguagePageFinder<Language>((language) => new αRoot(language)),
                new DefaultMultilanguageNodeToPath<Language>()
                ).RunAsync();
        }

        public static async Task Generator()
        {
            Cache.RootDirectory = Static.MakeAbsolutePath(".cache");

            var projectPath = ProjectDirectory.Path;
            var baseDirectory = Path.GetFullPath(Path.Combine(projectPath, "../GeneratedSite"));

            var generator = new MultilanguageStaticGenerator<Language>(
                new DefaultMultilanguageNodeToPath<Language>(),
                new AbsoluteUrl("http", "localhost"),
                FilePath.FromOsPath(baseDirectory)
                );

            await generator.GenerateAsync(new αRoot(default));
        }
    }
}