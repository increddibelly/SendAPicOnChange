using System.Drawing;
using Domain;
using FluentAssertions;
using InputProvider;
using NUnit.Framework;

namespace Test
{
    public class BitmapComparerTest
    {
        private BitmapComparer _cut = new BitmapComparer();
        private IInputProvider<Bitmap> inpy = new TestInputProvider();

        [SetUp]
        public void Setup()
        {
            inpy.Initialize();
        }

        [Test]
        public async void ShouldFindNose()
        {
            // arrange
            var first = await inpy.Get();
            var second = await inpy.Get();

            // act
            var result = _cut.Compare(first, second);

            // assert
            result.Should().Be(1);
        }

        [Test]
        public async void ShouldFindNothing()
        {
            // arrange
            var first = await inpy.Get();
            var second = first;

            // act
            var result = _cut.Compare(first, second);

            // assert
            result.Should().Be(0);
        }
    }
}
