using System;
using Xunit;

namespace TDDFizzBuzz.Tests
{
    public class TestsFixture : IDisposable
    {
        public TestsFixture()
        {
            FizzBuzz = FizzBuzz.Instance;
        }

        public void Dispose()
        {
        }

        public FizzBuzz FizzBuzz { get; private set; }
    }

    public class Tests : IClassFixture<TestsFixture>
    {
        TestsFixture fixture;

        public Tests(TestsFixture fixture)
        {
            this.fixture = fixture;
        }

        [Theory]
        [InlineData(1, "1")]
        [InlineData(11, "11")]
        [InlineData(23, "23")]
        public void _3と5の倍数以外の数を文字列に変換する(int num, string expected)
        {
            //Act 実行
            var actual = FizzBuzz.GetNum(num);
            //Assert 検証
            actual.Is(expected);
        }

        [Theory]
        [InlineData(3)]
        [InlineData(6)]
        [InlineData(9)]
        public void _3の倍数を渡すと文字列Fizzを返す(int num)
        {
            //Act 実行
            var actual = FizzBuzz.GetNum(num);
            //Assert 検証
            actual.Is("Fizz");
        }

        [Theory]
        [InlineData(5)]
        [InlineData(10)]
        [InlineData(20)]
        public void _5の倍数を渡すと文字列Buzzを返す(int num)
        {
            //Act 実行
            var actual = FizzBuzz.GetNum(num);
            //Assert 検証
            actual.Is("Buzz");
        }

        [Theory]
        [InlineData(15)]
        [InlineData(30)]
        [InlineData(60)]
        public void _3と5の倍数を渡すと文字列FizzBuzzを返す(int num)
        {
            //Act 実行
            var actual = FizzBuzz.GetNum(num);
            //Assert 検証
            actual.Is("FizzBuzz");
        }

        [Theory]
        [InlineData(0)]
        [InlineData(101)]
        [InlineData(-1)]
        public void _1から100以外の数を渡すと例外を返す(int num)
        {
            //Act 実行
            var actual = Assert.Throws<ArgumentException>(() => FizzBuzz.GetNum(num));
            //Assert 検証
            actual.Message.Is("1から100までの数字を入力してください");
        }

    }

}
