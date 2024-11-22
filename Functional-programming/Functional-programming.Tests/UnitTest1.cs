using FluentAssertions;

namespace Functional_programming.Tests;

public class Tests
{


    [TestCase(TestName = "AddTen Test")]
    public void Exercises001_AddTen_should_add_Ten()
    {

        //Act
        int result = Exercises001.AddTen(10);

        //Assert

        result.Should().Be(20);

    }

    [TestCase(TestName = "SquareIt Test")]
    public void Exercises001_SquareIt_should_square_n()
    {

        //Act
        int result = Exercises001.SquareIt(4);

        //Assert

        result.Should().Be(16);
    }

    [TestCase(TestName = "GrammarCheck Test")]
    public void Exercises001_GrammarCheck_should_check_startWithX_endWithY()
    {

        //Act
        bool result = Exercises001.GrammarCheck("HelloWorld!");

        //Assert

        result.Should().Be(false);

    }

    [TestCase(TestName = "CheckValidEmail Test")]
    public void Exercises001_CheckValidEmail_should_validateEmail()
    {

        //Act
        string result = Exercises001.CheckValidEmail("bart1012@northcoders.co.uk");

        //Assert

        result.Should().Be("Email domain and user valid, please continue\r\n");

    }
}
