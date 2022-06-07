using System;
 
namespace lr1
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Chose one of the tasks:\n" +
                        "1. Drives current state\n" +
                        "2. Files\n" +
                        "3. JSON\n" +
                        "4. XML\n" +
                        "5. ZIP");
      int option;
      try
      {
        option = Convert.ToInt32(Console.ReadLine());
      }
      catch (Exception e)
      {
        option = -1;
      }
      Console.Clear();
 
      switch (option)
      {
        case 1:
          Drive.GetInfo();
          break;
        case 2:
          Files.Run();
          break;
        case 3:
          Json.Run();
          break;
        case 4:
          Xml.Run();
          break;
        case 5:
          Zip.Run();
          break;
        case 0:
          Environment.Exit(0);
          break;
        default:
          Console.WriteLine("error");
          break;
      }
    }
  }
}
 
 
 
 
