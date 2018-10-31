using System;
using System.IO;

public class Base64_enc
{
    public static void Main(string[] args)
    {
        if (args.Length < 1)
        {
            Console.WriteLine("EXAMPLE: base64_enc.exe [path_to_file]");
            return;
        }

        using (FileStream fs = File.OpenRead(args[0]))
        {
            byte[] data = new byte[fs.Length];
            fs.Read(data, 0, (int)fs.Length);
            Console.WriteLine(Convert.ToBase64String(data));
        }
    }
}