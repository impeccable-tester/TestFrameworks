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

        [Test]
        [UseReporter(typeof(DiffReporter))]
        public void TestSub()
        {
            var calc = new Calculator();
            var result = calc.Sub(2, 3);
            Approvals.Verify(result);
        }

        [Test]
        [UseReporter(typeof(DiffReporter))]
        public void TestMul()
        {
            var calc = new Calculator();
            var result = calc.Mul(2, 3);
            Approvals.Verify(result);
        }

        [Test]
        [UseReporter(typeof(DiffReporter))]
        public void TestDiv()
        {
            var calc = new Calculator();
            var result = calc.Div(2, 3);
            Approvals.Verify(result);
        }

    }
}
