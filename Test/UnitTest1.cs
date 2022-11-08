using System;
using TestATM;
using Xunit;

namespace BankATMTestsLibrary;

public class UnitTest1
{
    [Fact]
        public void Bank_Test()
        {
            //Arrage - setting up our values for test
            Program.Balance = 100;
            //Act - verb... we are telling out unit test to do something
            bool result = Program.Deposit(50);
            //Assert - checking if it all adds up(does it bring us the vaule we want)
            Assert.True(result);
        }
        [Fact]
        public void CannotWithdrawBalance()
        {
            Program.Balance = 20;

            Program.Withdraw(22);

            Assert.Equal(20, Program.Balance);
        }
        [Fact]
        public void CanWithdraw()
        {
            Program.Balance = 5000m;

            Program.Withdraw(400);

            Assert.Equal(4600, Program.Balance);
        }
}