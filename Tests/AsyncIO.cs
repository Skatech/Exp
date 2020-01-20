using System;
using System.Text;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Threading;
using System.Threading.Tasks;

namespace Tests.AsyncIO
{
  static class Program
  {
    static async Task TestAsync()
    {
      using (var fs = new FileStream("Tests.txt", FileMode.Create, FileAccess.ReadWrite, FileShare.None, 1024, FileOptions.Asynchronous))
      {
        var data = Encoding.UTF8.GetBytes("Hello, World!\r\n");
        for (int i = 0; i < 100; i++)
          await fs.WriteAsync(data, 0, data.Length);

        fs.Position = 0;
        var buff = new byte[1024];
        while (true)
        {
          int read = await fs.ReadAsync(buff, 0, buff.Length);
          if (read > 0)
          {
            var test = Encoding.UTF8.GetString(buff, 0, read);
            Console.Write(test);
          }
          else break;
        }
      }
    }
    
    internal static void Run()
    {
      var task = TestAsync();
      Console.WriteLine("Testing...");
      task.Wait();
      Console.WriteLine("Finished...");

    }
  }
}