using LearnPrism.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
        }

        [TestMethod]
        public void �N������DDD�Ń{�^������������EEE�ɂȂ�()
        {
            var vm = new MainPageViewModel(null,null);
            Assert.AreEqual("DDD", vm.LabelC);
            vm.ButtonC.Execute();
            Assert.AreEqual("EEE", vm.LabelC);
        }
    }
}
