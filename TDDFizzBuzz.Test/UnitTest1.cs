using System;
using Xunit;

namespace TDDFizzBuzz.Tests
{
    public class Tests : IDisposable
    {
        private FizzBuzz fizzBuzz;

        //前準備
        public Tests()
        {
            fizzBuzz = new FizzBuzz();
        }

        [Fact]
        public void _1を渡すと文字列1を返す()
        {
            //Act 実行
            var actual = fizzBuzz.GetNum(1);
            //Assert 検証
            Assert.Equal("1", actual);
        }

        [Fact]
        public void _2を渡すと文字列2を返す()
        {
            //Act 実行
            var actual = fizzBuzz.GetNum(2);
            //Assert 検証
            Assert.Equal("2", actual);
        }

        [Fact]
        public void _3を渡すと文字列Fizzを返す()
        {
            //Act 実行
            var actual = fizzBuzz.GetNum(3);
            //Assert 検証
            Assert.Equal("Fizz", actual);
        }

        [Fact]
        public void _5を渡すと文字列Buzzを返す()
        {
            //Act 実行
            var actual = fizzBuzz.GetNum(5);
            //Assert 検証
            Assert.Equal("Buzz", actual);
        }

        //後片付け
        public void Dispose()
        {
        }
    }

}
