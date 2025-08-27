using System.Text.RegularExpressions;

namespace Servico_Taxi_Online_Cccat_Dotnet.Domain;

public static class ValidateCpf
{
  private const int CpfLength = 11;
  private static readonly string[] InvalidCpfs = {
    "00000000000", "11111111111", "22222222222", "33333333333",
    "44444444444", "55555555555", "66666666666", "77777777777",
    "88888888888", "99999999999"
  };

  public static bool IsValid(string cpf)
  {
    if (string.IsNullOrWhiteSpace(cpf)) 
      return false;

    var cleanCpf = new string(cpf.Where(char.IsDigit).ToArray());
        
    if (cleanCpf.Length != CpfLength || InvalidCpfs.Contains(cleanCpf))
      return false;

    var sum = 0;
    for (var i = 0; i < 9; i++)
      sum += (cleanCpf[i] - '0') * (10 - i);
        
    var firstDigit = sum % 11 < 2 ? 0 : 11 - (sum % 11);
    if (firstDigit != (cleanCpf[9] - '0')) 
      return false;

    sum = 0;
    for (var i = 0; i < 10; i++)
      sum += (cleanCpf[i] - '0') * (11 - i);
        
    var secondDigit = sum % 11 < 2 ? 0 : 11 - (sum % 11);
    return secondDigit == (cleanCpf[10] - '0');
  }
}