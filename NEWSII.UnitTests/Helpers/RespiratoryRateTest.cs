using System;
using System.Collections.Generic;
using FluentAssertions;
using NEWSII.Helpers;
using Xunit;

namespace NEWSII.UnitTests.Helpers;

public class RespiratoryRateTest
{
    [Theory]
    [InlineData("11")]
    public void Add_RespiratoryRateScore_ShowsCountOne(string bodyTempInput)
    {
        var numbers = new List<int>();
        RespiratoryRate.AddRespiratoryRateScore(bodyTempInput, numbers);
        numbers.Should().HaveCount(1);
    }
    
    [Theory]
    [InlineData("70")]
    public void Add_RespiratoryRateScore_ThrowsArgumentOutOfRangeException(string bodyTempInput)
    {
        var numbers = new List<int>();
        Assert.Throws<ArgumentOutOfRangeException>(
            () => RespiratoryRate.AddRespiratoryRateScore(bodyTempInput, numbers)
        );
    }
    
    [Theory]
    [InlineData("abc")]
    public void Add_RespiratoryRateScore_ThrowsArgumentException(string bodyTempInput)
    {
        var numbers = new List<int>();
        Assert.Throws<ArgumentException>(
            () => RespiratoryRate.AddRespiratoryRateScore(bodyTempInput, numbers)
        );
    }
}