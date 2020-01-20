using System;
using System.Reflection;
using System.Runtime.InteropServices;

#region Assembly Info
[assembly: AssemblyTitle("Console")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("Console")]
[assembly: AssemblyCopyright("Copyright 2020")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]
[assembly: ComVisible(false)]
[assembly: AssemblyVersion("1.0.*")]
#endregion

namespace Tests
{
  class Program
  {
    public static void Main(string[] args)
    {
      Tests.AsyncIO.Program.Run();
      Console.Write("Press any key to continue . . . ");
      Console.ReadKey(true);
    }
  }
}