using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.BratsunDA.Sprint5.TaskReview.V17.Lib;

namespace Tyuiu.BratsunDA.Sprint5.TaskReview.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            string path = @"C:\Users\Supervisor\source\repos\Tyuiu.BratsunDA.Sprint5.Review\Tyuiu.BratsunDA.Sprint5.TaskReview.V17\bin\Debug\OutPutDataFileTask7V17.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExist = fileinfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
