using System;
using System.IO;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SE_CWA2020ASN1_Prog;
using SE_CWA2020ASN1_Prog.Properties;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Diagnostics;
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
        ///test if a file is renamed with a prefix of an integer 
        /// </summary>
        [TestMethod]
        //rename according to test type
        public void TestMethod1()
        {
            //arrange
            int interventionTotal = 1;
            string fileName = Application.StartupPath + @"\inspectImages\";


            //act


            //assert
            Assert.AreEqual(5,5);

        }

        /// <summary>
        /// Testing function to open and close the camera
        /// </summary>
        [TestMethod]
        //rename according to test type
        public void TestMethod2()
        {
            ImageCapture ic = new ImageCapture();
            ic.

        }

        /// <summary>
        /// Method to test if a file is deleted from folder
        /// </summary>
        [TestMethod]
        //rename according to test type
        public void TestMethod3()
        {


        }

        /// <summary>
        /// Method to test if data is saved to the work area list
        /// </summary>
        [TestMethod]
        //rename according to test type
        public void TestMethod4()
        {


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

        /// <summary>
        /// Prints the inspection list to console to confirm details entered
        /// </summary>
        //private void getInspectionTest()
        //{

        //    Console.WriteLine("Inspection details");
        //    //printing in console
        //    foreach (Inspection i in inspection)
        //    {
        //        //MessageBox.Show(i.tostring());
        //        Console.WriteLine("Inspection name: " + i.Site_Name.ToString() + "," + i.Inspection_Date.ToString());
        //    }

        //}

        /// <summary>
        /// print intervention list contents to console
        /// </summary>
        //public void getInterventionTest()
        //{
        //    foreach (Intervention i in interv)
        //    {
        //        Console.WriteLine("Intervention = " + i.Heading_Name.ToString() + "," + "Subheading = " + i.Subheading_Name.ToString());
        //    }
        //}

        ///// <summary>
        ///// print inspectionArea objects to console
        ///// </summary>
        //public void getInspectionAreaTest()
        //{
        //    foreach (InspectionArea ia in inspArea)
        //    {
        //        Console.WriteLine("Inspection area = " + ia.Work_Area.ToString());
        //    }
        //}
    }
}
