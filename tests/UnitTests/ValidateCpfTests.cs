using Servico_Taxi_Online_Cccat_Dotnet.Domain;

namespace UnitTests;

public class ValidateCpfTests
{
  [Theory]
  [InlineData("52242477056", true)]
  [InlineData("11144477735", true)]
  [InlineData("11144477745", false)]
  [InlineData("12345678901", false)]
  [InlineData("00000000000", false)]
  [InlineData("11111111111", false)]
  public void ValidateCpf_WithManyFormats_ShouldHaveExpectedResult(string cpf, bool expectedResult)
  {
    var validateCpf = ValidateCpf.IsValid(cpf);
    Assert.Equal(expectedResult, validateCpf);
  }
  
  [Theory]
  [InlineData("")]
  [InlineData(null)]
  [InlineData("123")]
  [InlineData("12345678901234")]
  [InlineData("abcdefghijk")]
  public void ValidateCpf_InvalidFormat_ShouldHaveReturnFalse(string invalidCpf)
  {
    var validateCpf = ValidateCpf.IsValid(invalidCpf);
    Assert.False(validateCpf);
  }
}