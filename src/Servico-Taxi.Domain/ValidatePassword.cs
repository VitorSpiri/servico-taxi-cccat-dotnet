using System.Text.RegularExpressions;

namespace Servico_Taxi_Online_Cccat_Dotnet.Domain;

public class ValidatePassword
{
  public static bool IsValid(string password)
  {
    return Regex.IsMatch(password ?? "", @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)[a-zA-Z\d]{8,}$");
  }
}