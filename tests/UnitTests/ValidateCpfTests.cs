using Servico_Taxi_Online_Cccat_Dotnet.Domain;

namespace UnitTests;

public class ValidateCpfTests
{
  [Fact]
  public void ValidateCpf_CpfIsValid_ShouldReturnTrue()
  {
    //Arrange
    var cpf = "52242477056";
    
    //Act
    var validateCpf = ValidateCpf.IsValid(cpf);
    
    //Assert
    Assert.True(validateCpf);
  }

  [Theory]
  [InlineData("11144477735", true)]
  [InlineData("12345678901", false)]
  [InlineData("00000000000", false)]
  [InlineData("11111111111", false)]
  public void ValidateCpf_WithManyFormats_ShouldHaveExpectedResult(string cpf, bool expectedResult)
  {
    // Act  
    var validateCpf = ValidateCpf.IsValid(cpf);
    
    //Assert
    Assert.Equal(expectedResult, validateCpf);
  }
}