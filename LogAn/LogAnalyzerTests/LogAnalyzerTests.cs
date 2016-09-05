namespace LogAnTests
{
    using NUnit.Framework;

    [TestFixture]
    public class LogAnalyzerTests
    {
        [TestCase("filewithgoodextension.SLF")]
        [TestCase("filewithgoodextension.slf")]
        public void
 IsValidLogFileName_ValidExtensions_ReturnsTrue(string file)
        {
            LogAnalyzer la = MakeAnalyzer();
            bool result = la.IsValidLogFileName(file);
            Assert.True(result);
        }


        [Test]
        public void
IsValidFileName_WhenCalled_ChangesWasLastFileNameValid()
        {
            LogAnalyzer la = MakeAnalyzer();
            la.IsValidLogFileName("badname.foo");
            Assert.False(la.WasLastFileNameValid);
        }

        private LogAnalyzer MakeAnalyzer()
        {
            return new LogAnalyzer();
        }
    }
}
