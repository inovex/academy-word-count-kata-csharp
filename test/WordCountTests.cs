using NUnit.Framework;
namespace WordCount.Test
{
    public class WordCountTests
    {
        [Test]
        public void HandleInput_OneWord_SaysNumberIsOne()
        {
            String input = "foo";
            String expectedOutput = "Number of words: 1";
            WordCount wordCount = new WordCount();

            String output = wordCount.HandleInput(input);

            Assert.AreEqual(output, expectedOutput);
        }
    }
}
