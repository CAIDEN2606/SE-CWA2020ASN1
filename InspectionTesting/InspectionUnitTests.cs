using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SE_CWA2020ASN1_Prog;
using System.Drawing;

namespace InspectionTesting
{
    [TestClass]
    public class InspectionUnitTests
    {
        /// <summary>
        /// Test for opening sqlite connection
        /// </summary>
        [TestMethod]
        public void SetUp()
        {


        }

        /// <summary>
        ///Testing the intervention class 
        /// </summary>
        [TestMethod]
        //rename according to test type
        public void TestMethod1()
        {
            //arrange
            Intervention testintv;
            WorkArea testwar;
            Bitmap bm;
            string filePath =  @".\inspectImages\";
            int id = 2;
            string name = "test name";
            string type = "test type";
            string acomms = "test acomments";
            string icomms = "test icomments";
            Image img1 = null;
            Image img2 = null;
            Image img3 = null;
            String filenames = filePath + @"1img1.jpg";
            var bm1 = new Bitmap(filenames);
            img1 = new Bitmap(bm1);
            var bm2 = new Bitmap(filePath + @"1img2.jpg");
            img2 = new Bitmap(bm2);
            var bm3 = new Bitmap(filePath + @"1img3.jpg");
            img3 = new Bitmap(bm3);
            
            //act
            testintv = new Intervention(id, name, type, acomms, icomms, img1, img2, img3);

            string worka = "test work area";
            string summ = "test summary";
            testwar = new WorkArea(worka, summ);
            testwar.addInterv(testintv);
            
            //assert
            Assert.AreEqual(id,testintv.Interv_ID);
        }

        /// <summary>
        /// Testing the inspection class
        /// </summary>
        [TestMethod]
        //rename according to test type
        public void TestMethod2()
        {
            Inspection testinsp;
            string siteName = "site";
            DateTime date = DateTime.Now;
            string inspName = "inspectorName";
            string jobType = "job type";
            string jobDesc = "job descr";
            string supervisor = "supervisor";

            testinsp = new Inspection(siteName,date, inspName, jobType, jobDesc, supervisor);

            Assert.AreEqual(siteName, testinsp.Site_Name);
            Assert.AreEqual(supervisor.Length, testinsp.Supervisor_Name.Length);
            Assert.IsNotNull(date);
        }

        /// <summary>
        /// Method to test if a file is deleted from folder
        /// </summary>
        [TestMethod]
        //rename according to test type
        public void TestMethod3()
        {
            WorkArea testwar;
            string worka = "test work area";
            string summ = "test summary";

            testwar = new WorkArea(worka, summ);
            Assert.AreEqual(worka, testwar.Work_Area);
            Assert.AreEqual(summ.Length, testwar.Inspection_Summary.Length);
        }

        /// <summary>
        /// Method to test the image directory is created where the application file is contained
        /// </summary>
        [TestMethod]
        //rename according to test type
        public void TestMethod4()
        {
            //test if images folder is created
            string folderPath = @".\inspectImages";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                Assert.IsTrue(File.Exists(folderPath));
            }
            else
            {
                Assert.IsTrue(Directory.Exists(folderPath));
            }
        }

        /// <summary>
        /// Method to test if data is saved to an inspection list
        /// </summary>
        [TestMethod]
        //rename according to test type
        public void TestMethod5()
        {


        }

        /// <summary>
        /// Test to confirm sqlite connection close
        /// </summary>
        [TestMethod]
        public void TearDown()
        {


        }

        
    }
}
