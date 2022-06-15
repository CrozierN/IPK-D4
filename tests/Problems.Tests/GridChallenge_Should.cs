using System.Collections.Generic;
using Xunit;

namespace Problems.Tests;

public class GridChallenge_Should
{
    [Fact]
    public void gridChallenge_OutputIsString()
    {
        // arrange 
        var alphabets = new List<string>() { "ebacd" };
        var gridChallenge = new GridChallenge();

        // act
        var returnWord = gridChallenge.challenge(alphabets);

        // assert
        Assert.IsType<string>(returnWord);
    }

    [Fact]
    public void gridChallange_OutputIsString_ReturnYes()
    {
        var alphabets = new List<string>() { "ebacd", "fghij", "olmkn", "trpqs", "xywuv"};
        var gridChallenge = new GridChallenge();

        var returnWord = gridChallenge.challenge(alphabets);

        Assert.Equal("YES", returnWord); 
    }
}
