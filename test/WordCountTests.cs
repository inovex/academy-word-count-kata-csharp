using NUnit.Framework;
namespace WordCount.Test
{
    public class WordCountTests
    {
        [Test]
        public void HandleInoput_OneWord_SaysNumberIsOne()
        {
            var input = "foo";
            var expectedOutput = "Number of words: 1";
            var wordCount = new WordCount();

            var output = wordCount.HandleInput(input);

            Assert.That(expectedOutput, Is.EqualTo(output));
        }
    }
}
