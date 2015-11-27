using ApprovalTests;
using ApprovalTests.Reporters;
using NUnit.Framework;


namespace Tests
{
    public class TestClass
    {
        [Test]
        [UseReporter(typeof(DiffReporter))]
        public void TestAdd()
        {
            var calc = new Calculator();
            var result = calc.Add(2, 3);
            Approvals.Verify(result);
        }
    }
}
