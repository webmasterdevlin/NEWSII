using System;
using System.Collections.Generic;
using FluentAssertions;
using NEWSII.Helpers;
using Xunit;

namespace NEWSII.UnitTests.Helpers;

public class HeartRateTest
{
    [Theory]
    [InlineData("50")]
    public void Add_HeartRateScore_ShowsCountOne(string bodyTempInput)
    {
        var numbers = new List<int>();
        HeartRate.AddHeartRateScore(bodyTempInput, numbers);
        numbers.Should().HaveCount(1);
    }
    
    [Theory]
    [InlineData("250")]
    public void Add_HeartRateScore_ThrowsArgumentOutOfRangeException(string bodyTempInput)
    {
        var numbers = new List<int>();
        Assert.Throws<ArgumentOutOfRangeException>(
            () => HeartRate.AddHeartRateScore(bodyTempInput, numbers)
            );
    }
    
    [Theory]
    [InlineData("abc")]
    public void Add_HeartRateScore_ThrowsArgumentException(string bodyTempInput)
    {
        var numbers = new List<int>();
        Assert.Throws<ArgumentException>(
            () => HeartRate.AddHeartRateScore(bodyTempInput, numbers)
        );
    }
}