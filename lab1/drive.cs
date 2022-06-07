using System;
using System.IO;
 
 
namespace lr1
{
 
  class Drive
  {
    public static void GetInfo()
    {
      DriveInfo[] drives = DriveInfo.GetDrives();
 
      Console.WriteLine($"{drives.Length} drives detected\n");
      foreach (var drive in drives)
      {
        if (drive.IsReady)
        {
          Console.WriteLine($"Name: {drive.Name}\n"
                           +"Volume label: {drive.VolumeLabel}\n"
                           +"Size: {drive.TotalSize}\n"
                           +"Filesystem: {drive.DriveFormat}\n");
        }
        else
        {
          Console.WriteLine($"Drive {drive.Name} is not ready.");
          Console.WriteLine();
        }
      }
    }
  }
 
}
