using AwsTools.Infrastructure.S3;

namespace AwsToolsTest.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            S3List s3 = new S3List();
            s3.exe();
        }
    }
}