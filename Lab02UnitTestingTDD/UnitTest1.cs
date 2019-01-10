using System;
using Xunit;
using Lab02UnitTesting;

namespace Lab02UnitTestingTDD
{
    public class UnitTest1
    {
        [Fact]
        public void CanRegisterWithdrawlOne()
        {
            Assert.Equal(20, Program.RemoveFunds(20));
        }
        [Fact]
        public void CanRegisterWithdrawlTwo()
        {
            Assert.Equal(60, Program.RemoveFunds(60));
        }
        [Fact]
        public void CanRegisterDepositlOne()
        {
            Assert.Equal(20, Program.AddFunds(20));
        }
        [Fact]
        public void CanRegisterDepositlTwo()
        {
            Assert.Equal(60, Program.AddFunds(60));
        }
        [Theory]
        [InlineData(10)]
        [InlineData(15)]
        [InlineData(20)]
        [InlineData(25)]
        [InlineData(40)]
        [InlineData(50)]
        [InlineData(60)]
        [InlineData(70)]
        [InlineData(80)]
        [InlineData(90)]
        [InlineData(100)]
        [InlineData(150)]
        [InlineData(200)]
        public void WithdrawSeries(double amount)
        {
            Assert.Equal(amount, Program.RemoveFunds(amount));
        }
        [Theory]
        [InlineData(10)]
        [InlineData(15)]
        [InlineData(20)]
        [InlineData(25)]
        [InlineData(40)]
        [InlineData(50)]
        [InlineData(60)]
        [InlineData(70)]
        [InlineData(80)]
        [InlineData(90)]
        [InlineData(100)]
        [InlineData(150)]
        [InlineData(200)]
        public void DepositSeries(double amount)
        {
            Assert.Equal(amount, Program.AddFunds(amount));
        }



    }
}
