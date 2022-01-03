using NUnit.Framework;
using ProgramJenkinsTraining;

namespace JenkinsTraining
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            Assert.AreEqual("Say Hi!", ProgramJ.Hi());
        }

        [Test]
        public void Test2()
        {
            Assert.AreEqual("Say Hi", ProgramJ.Hi());
        }
    }
}