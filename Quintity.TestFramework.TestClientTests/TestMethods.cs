using System;
using Quintity.TestFramework.Core;


namespace Quintity.TestFramework.TestClientTests
{
    [TestClass]
    public class TestMethods : TestClassBase
    {
        #region TestMethods

        [TestMethod]
        public TestVerdict SimpleTest()
        {
            try
            {
                Setup();
            }
            catch( Exception e)
            {
                
            }
            finally
            {
                Teardown();
            }

            return TestVerdict;
        }

        #endregion

        #region Private and protected methods

        protected override void Setup()
        {
            base.Setup();
        }

        protected override void Teardown()
        {
            base.Teardown();
        }

        #endregion
    }
}
