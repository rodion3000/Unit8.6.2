using System;
using System.IO;

class FileCleaner
{
    public static void Main(string[] args)
    {
        Console.WriteLine($"Размер папки:{GetSize(args[0])}байт");
    }
    public static long GetSize(string path = (@"\Users\ggg"))
    {
        if (!Directory.Exists(path))
            return 0;
        long size = 0;
        try
        {
            var root = new DirectoryInfo(path);
            var Directory = root.GetDirectories();
            var files = root.GetFiles();
            foreach (var Files in files)
            {
                if (Files.Exists)
                {
                    size += Files.Length;
                }
            }
            foreach (var Director in Directory)
            {
                size += GetSize(Director.FullName);
            }
            return size;
        }

        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
            return 0;
        }


    }


}
