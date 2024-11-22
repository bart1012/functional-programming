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

    [TestCase(TestName = "GetCoolPeople Test")]
    public void Exercises002_GetCoolPeople_Should_return_filled_list()
    {

        //Act
        List<string> result = Exercises002.GetCoolPeople();

        //Assert
        result.Should().BeEquivalentTo(new List<string>() {"rich.neat@boardgamer.com",
            "poppy.mcdonnell@irishdancer.com",
            "neil.hughes@walkingoncustard.com",
            "alice.yang@midfielder.com",
            "pippa.austin@musician.com"});
    }

    [TestCase(TestName = "SquaredNumbers Test")]
    public void Exercises002_SquaredNums_return_squaredNums()
    {
        List<int> nums = new List<int>() { 1, 2, 3, 4, 5 };

        //Act
        Exercises002.SquaredNums(nums);

        //Assert
        nums.Should().BeEquivalentTo(new List<int>() { 1, 4, 9, 16, 25 });

    }

    [TestCase(TestName = "FilterEmails Test")]
    public void Exercises002_FilterEmails_return_Dictionary()
    {
        Dictionary<string, List<string>> expectedDictionary = new Dictionary<string, List<string>>();
        expectedDictionary[".co.uk"] = new List<String>() { "link@hyrule.co.uk", "ziggy@spidersfrommars.co.uk" };
        expectedDictionary[".com"] = new List<String>() { "alice.yang@northcoders.com", "richard.neat@northcoders.com", "shrek@duloc.com", "neil.hughes@walkingoncustard.com", };
        expectedDictionary["invalid"] = new List<String>() { "mario@plumbing.it", "csharp@microsoft.cs", "lemmy@motorhead.co,uk", "me@myhouse.sleep" };



        List<string> emailList = new List<string>
                {
                    "alice.yang@northcoders.com",
                    "richard.neat@northcoders.com",
                    "mario@plumbing.it",
                    "link@hyrule.co.uk",
                    "shrek@duloc.com",
                    "neil.hughes@walkingoncustard.com",
                    "csharp@microsoft.cs",
                    "ziggy@spidersfrommars.co.uk",
                    "lemmy@motorhead.co,uk",
                    "me@myhouse.sleep"
                };

        //Act
        var result = Exercises002.FilterEmails(emailList);


        //Assert
        result.Should().BeEquivalentTo(expectedDictionary);

    }
}
