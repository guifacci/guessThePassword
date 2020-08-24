using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

class MainClass {
  public static void Main (string[] args) {
    
    
    SecureString pass = maskInputString();
    string Password = new System.Net.NetworkCredential(string.Empty, pass).Password;
    Console.WriteLine();
    Console.WriteLine(Password);
    Console.ReadKey();
   

  }

private static SecureString maskInputString()
{
  Console.WriteLine ("Please enter the password: ");
  SecureString password = new SecureString();
  ConsoleKeyInfo keyInfo;

  do
  {
    keyInfo = Console.ReadKey(true);
    if(!char.IsControl(keyInfo.KeyChar))
    {
      password.AppendChar(keyInfo.KeyChar);
      Console.WriteLine("*");
    }
    else if(keyInfo.Key == ConsoleKey.Backspace && password.Length > 0)
    {
      password.RemoveAt(password.Length - 1);
      Console.Write("\b \b");
    }
  }
while(keyInfo.Key != ConsoleKey.Enter);
{
  return password;
}



}


}
