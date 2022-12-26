using System.Runtime.CompilerServices;

namespace StaticSharp.DevDocs.Main
{
    internal static class ProjectDirectory
    {
        private static string GetPath([CallerFilePath] string path = "")
        {
            return System.IO.Path.GetDirectoryName(path);
        }
        public static string Path => GetPath();
    }
}