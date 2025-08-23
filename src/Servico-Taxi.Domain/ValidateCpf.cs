using System.Text.RegularExpressions;

namespace Servico_Taxi_Online_Cccat_Dotnet.Domain;

public class ValidateCpf
{
  private const int CpfLength = 11;

  public static bool ValidateCpfNumber(string cpf)
  {
    if (string.IsNullOrEmpty(cpf)) return false;
            
    cpf = Clean(cpf);
            
    if (cpf.Length != CpfLength) return false;
    if (AllDigitsAreTheSame(cpf)) return false;
            
    int digit1 = CalculateDigit(cpf, 10);
    int digit2 = CalculateDigit(cpf, 11);
            
    return ExtractDigit(cpf) == $"{digit1}{digit2}";
  }

  public static string Clean(string cpf)
  {
    if (string.IsNullOrEmpty(cpf)) return string.Empty;
    return Regex.Replace(cpf, @"\D", "");
  }

  private static bool AllDigitsAreTheSame(string cpf)
  {
    if (string.IsNullOrEmpty(cpf)) return false;
    char firstDigit = cpf[0];
    return cpf.All(digit => digit == firstDigit);
  }

  private static int CalculateDigit(string cpf, int factor)
  {
    int total = 0;
            
    foreach (char digit in cpf)
    {
      if (factor > 1)
      {
        total += int.Parse(digit.ToString()) * factor;
        factor--;
      }
    }
            
    int rest = total % 11;
    return (rest < 2) ? 0 : 11 - rest;
  }

  private static string ExtractDigit(string cpf)
  {
    if (cpf.Length < 2) return string.Empty;
    return cpf.Substring(cpf.Length - 2, 2);
  }
}