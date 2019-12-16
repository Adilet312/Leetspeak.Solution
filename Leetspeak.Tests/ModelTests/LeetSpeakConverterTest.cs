using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetspeakConvertor;
namespace LeetSpeakTester.Tests
{
    [TestClass]
    public class LeetSpeakTester
    {
        [TestMethod]
        public void LeetSpeak_Get_Method_Return_Valid_Value()
        {
            LeetspeakTranslator word = new LeetspeakTranslator("Epicodus");
            Assert.AreEqual("Epicodus",word.GetWords());
        }

        [TestMethod]
         public void LeetSpeak_Get_Method_Return_InValid_Value()
        {
            LeetspeakTranslator word = new LeetspeakTranslator("Epicodus");
            Assert.AreNotEqual("Epic",word.GetWords());
        }

        [TestMethod]
        public void LeetSpeak_Set_Method_Set_Valid_Value()
        {
            LeetspeakTranslator word = new LeetspeakTranslator("Epicodus");
            string setValue = "Seattle";
            word.SetWords(setValue);
            Assert.AreEqual(setValue,word.GetWords());
        }

        [TestMethod]
        public void LeetSpeak_Set_Method_Set_InValid_Value()
        {
            LeetspeakTranslator word = new LeetspeakTranslator("Epicodus");
            string setValue = "Seattle";
            word.SetWords(setValue);
            Assert.AreNotEqual("Epi",word.GetWords());
        }

        [TestMethod]
        public void LeetSpeak_s_Valid_Translation()
        {
            LeetspeakTranslator word = new LeetspeakTranslator("Epicodus");
            Assert.AreEqual("3pic0duz",word.Translate());
        }


    }
}