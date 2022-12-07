namespace CSharpSyntax;

public class UnitTest1
{
    [Fact] //Attributes 
    public void TestingTheAdditionOperationOnIntegers()
    {
        //Given (Arrange)
        int a = 10, b = 20, answer;

        //When (Act)
        answer = a + b;   //   "System Under Test (SUT) = THE THING BEING TESTED.. which is the addition operator" 

        //Then (Assert)
        Assert.Equal(30, answer);
    }


    [Theory]
    [InlineData(2,2,4)]
    [InlineData(13,3,16)]
    [InlineData(15,4,19)]
    public void CanAddAnyTwoIntegers(int a, int b, int expected)
    {
        int answer = a + b;
        Assert.Equal(expected, answer);
    }


}