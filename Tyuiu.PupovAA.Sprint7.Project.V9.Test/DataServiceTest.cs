using Tyuiu.PupovAA.Sprint7.Project.V9.Lib;
namespace Tyuiu.PupovAA.Sprint7.Project.V9.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {

        [TestMethod]
        public void TestMethod1()
        {
        }
        [TestMethod]
        public void DeleteRows()
        {

            string[,] testData = new string[3, 2]
            {
            { "", "" },
            { "", "" },
            { "", "" }};


            string result = DataService.DeleteRows(testData);

            
            Assert.AreEqual("0,1,2", result);
        }
    
    [TestMethod]
        public void SearchWord()
        {
            
            string[,] testData = {{ "Иван", "25", "Москва" },
                                    { "Петр", "30", "Питер" },
                                    { "Мария", "25", "Москва" }};
            string searchText = "Петр";

            
            var result = DataService.SearchWord(testData, searchText);

            
            Assert.AreEqual(1, result.Count); 
            Assert.AreEqual(1, result[0].Row); 
            Assert.AreEqual(0, result[0].Column); 
        }
    }
}
