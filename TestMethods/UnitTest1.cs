namespace TestMethods
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GetVINCountry_CorrectValue_Asia()
        {
            VIN_LIB.Class1 class1 = new VIN_LIB.Class1();

            string vin = "JHMCM56557C404453";
            string expected = "Азия";

            string actual = class1.GetVINCountry(vin);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetVINCountry_CorrectValue_Asia_Ex2()
        {
            VIN_LIB.Class1 class1 = new VIN_LIB.Class1();

            string vin = "RHMCM56557C404453";
            string expected = "Азия";

            string actual = class1.GetVINCountry(vin);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetVINCountry_CorrectValue_Africa()
        {
            VIN_LIB.Class1 class1 = new VIN_LIB.Class1();

            string vin = "AHMCM56557C404453";
            string expected = "Африка";

            string actual = class1.GetVINCountry(vin);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetVINCountry_CorrectValue_Africa_Ex2()
        {
            VIN_LIB.Class1 class1 = new VIN_LIB.Class1();

            string vin = "HHMCM56557C404453";
            string expected = "Африка";

            string actual = class1.GetVINCountry(vin);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetVINCountry_CorrectValue_Europe()
        {
            VIN_LIB.Class1 class1 = new VIN_LIB.Class1();

            string vin = "SHMCM56557C404453";
            string expected = "Европа";

            string actual = class1.GetVINCountry(vin);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetVINCountry_CorrectValue_Europe_Ex3()
        {
            VIN_LIB.Class1 class1 = new VIN_LIB.Class1();

            string vin = "ZHMCM56557C404453";
            string expected = "Европа";

            string actual = class1.GetVINCountry(vin);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetVINCountry_CorrectValue_NorthAmerica()
        {
            VIN_LIB.Class1 class1 = new VIN_LIB.Class1();

            string vin = "5HMCM56557C404453";
            string expected = "Северная Америка";

            string actual = class1.GetVINCountry(vin);
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void GetVINCountry_CorrectValue_Oceania()
        {
            VIN_LIB.Class1 class1 = new VIN_LIB.Class1();

            string vin = "6HMCM56557C404453";
            string expected = "Океания";

            string actual = class1.GetVINCountry(vin);
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void GetVINCountry_CorrectValue_Oceania_Ex2()
        {
            VIN_LIB.Class1 class1 = new VIN_LIB.Class1();

            string vin = "7HMCM56557C404453";
            string expected = "Океания";

            string actual = class1.GetVINCountry(vin);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetVINCountry_CorrectValue_SouthAmerika()
        {
            VIN_LIB.Class1 class1 = new VIN_LIB.Class1();

            string vin = "8HMCM56557C404453";
            string expected = "Южная Америка";

            string actual = class1.GetVINCountry(vin);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetVINCountry_IncorrectValueVin()
        {
            VIN_LIB.Class1 class1 = new VIN_LIB.Class1();

            string vin = "яHMCM56к57C404453";
            string expected = "Страна не определена";

            string actual = class1.GetVINCountry(vin);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetVINCountry_IncorrectValueVin_Ex2()
        {
            VIN_LIB.Class1 class1 = new VIN_LIB.Class1();

            string vin = "00000000000";
            string expected = "Страна не определена";

            string actual = class1.GetVINCountry(vin);
            Assert.AreEqual(expected, actual);
        }
        


        [TestMethod]
        public void CheckVIN_IncorrectValue_Ex1()
        {
            VIN_LIB.Class1 class1 = new VIN_LIB.Class1();

            string vin = "AHMCM56557C404453";
            bool notExpected = true;

            bool actual = class1.CheckVIN(vin);
            Assert.AreNotEqual(notExpected, actual);
        }

        [TestMethod]
        public void CheckVIN_IncorrectValue_Ex2()
        {
            VIN_LIB.Class1 class1 = new VIN_LIB.Class1();

            string vin = "qwe";
            bool notExpected = true;

            bool actual = class1.CheckVIN(vin);
            Assert.AreNotEqual(notExpected, actual);
        }

        [TestMethod]
        public void CheckVIN_IncorrectValue_Ex3()
        {
            VIN_LIB.Class1 class1 = new VIN_LIB.Class1();

            string vin = "asddsa213";
            bool notExpected = true;

            bool actual = class1.CheckVIN(vin);
            Assert.AreNotEqual(notExpected, actual);

         
        }

        [TestMethod]
        public void CheckVIN_Fail()
        {
            VIN_LIB.Class1 class1 = new VIN_LIB.Class1();

            string vin = "asddsa213";
            bool notExpected = true;

            bool actual = class1.CheckVIN(vin);
            //Assert.AreNotEqual(notExpected, actual);
            Assert.


        }



    }
}