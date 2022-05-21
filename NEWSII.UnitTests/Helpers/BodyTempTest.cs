using System;
using System.Collections.Generic;
using FluentAssertions;
using NEWSII.Helpers;
using Xunit;

namespace NEWSII.UnitTests.Helpers;

public class BodyTempTest
{
    [Theory]
    [InlineData("36")]
    public void Add_BodyTempScore_ShowsCountOne(string bodyTempInput)
    {
        var numbers = new List<int>();
        BodyTemp.AddBodyTempScore(bodyTempInput, numbers);
        numbers.Should().HaveCount(1);
    }
    
    [Theory]
    [InlineData("50")]
    public void Add_BodyTempScore_ThrowsArgumentOutOfRangeException(string bodyTempInput)
    {
        var numbers = new List<int>();
        Assert.Throws<ArgumentOutOfRangeException>(
            () => BodyTemp.AddBodyTempScore(bodyTempInput, numbers)
            );
    }
    
    [Theory]
    [InlineData("abc")]
    public void Add_BodyTempScore_ThrowsArgumentException(string bodyTempInput)
    {
        var numbers = new List<int>();
        Assert.Throws<ArgumentException>(
            () => BodyTemp.AddBodyTempScore(bodyTempInput, numbers)
        );
    }
}