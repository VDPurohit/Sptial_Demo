using NeoCortexApi.Encoders;
using NeoCortexApi.Network;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace SpatialPoller_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            Encoder_Category_Test en = new Encoder_Category_Test();
            en.TestCategoryEncoderWithInputArrayOfSizeFourDefaultSettings();

            //Encoder_Scalar_Test enScalar = new Encoder_Scalar_Test();
            //enScalar.TimeTickEncodingTest();
        }

    }
}

class Encoder_Category_Test {

    public void TestCategoryEncoderWithInputArrayOfSizeFourDefaultSettings()
        {
    // as the size of string array is 4 and width by default is 3 therefore the encoded bit array should be of
    // 12 bits in size
    int[] encodedBits = { 1, 1, 1, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
    Dictionary<string, object> encoderSettings = getDefaultSettings(); // creaing default constructor
    string[] arrayOfStrings = new string[] { "Milk", "Sugar", "Bread", "Egg" }; // array of input strings
    CategoryEncoder categoryEncoder = new CategoryEncoder(arrayOfStrings, encoderSettings); // passing the input array here
    int[] result = categoryEncoder.Encode(arrayOfStrings[0]); // encoding string "Milk"
        
        for (int i = 0; i < result.Length; i++) {
            Console.Write(result[i]);
        }
        Console.ReadLine();
        }


    /// <summary>
        /// This method is used to set the default settings for the encoder.
        /// by default we are keeping width as 2 and radius as 1  
        /// </summary>
        /// <returns>Dictionary<string, object> where key is string and value is object</returns>
        Dictionary<string, object> getDefaultSettings()
        {
            Dictionary<String, Object> encoderSettings = new Dictionary<string, object>();
            encoderSettings.Add("W", 3);
            encoderSettings.Add("Radius", (double)1);
            return encoderSettings;
        } 
}