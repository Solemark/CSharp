namespace ConsoleApps.Unittest;
public class TestFizzBuzz
{
    [Fact]
    public void TestFizzBuzzTo20With3And5()
    {
        const int fizz = 3;
        const int buzz = 5;
        const int max = 20;
        const string expect = "1\n2\nfizz\n4\nbuzz\nfizz\n7\n8\nfizz\nbuzz\n11\nfizz\n13\n14\nfizzbuzz\n16\n17\nfizz\n19\nbuzz\n";
        string result = FizzBuzz.fizzBuzz(fizz, buzz, max);
        Assert.Equal(expect, result);
    }
}
