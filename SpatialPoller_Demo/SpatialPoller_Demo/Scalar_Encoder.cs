using NeoCortexApi.Encoders;
using NeoCortexApi.Network;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace SpatialPoller_Demo
{
    class Scalar_Encoder
    {
        static void Main(string[] args)
        {
            Encoder_Scalar_Test enScalar = new Encoder_Scalar_Test();
            enScalar.Scalar_Encoder();      
    }
}

    class Encoder_Scalar_Test
    {

        public void Scalar_Encoder()
        {

            /// <summary>
            /// Encodes one year in a time-tick resolution.
            /// </summary>
            /// <param name="input"></param>
            /// <param name="expectedResult"></param>

            double input = 1.0;
            int inputBits = 200;
            double max = 1;
            CortexNetworkContext ctx = new CortexNetworkContext();

            DateTime now = DateTime.Now;

            Dictionary<string, object> encoder_Settings = new Dictionary<string, object>()
            {
                { "W", 15},
                { "N", inputBits},
                { "Radius", -1.0},
                { "MinVal", 0.0},
                { "Periodic", false},
                { "Name", "scalar"},
                { "ClipInput", false},
                { "MaxVal", max}
            };

            ScalarEncoder scalar_Encoder = new ScalarEncoder(encoder_Settings);
            var result = scalar_Encoder.Encode(input);

            Console.WriteLine(input);

            Console.WriteLine(NeoCortexApi.Helpers.StringifyVector(result));
            //Console.WriteLine(NeoCortexApi.Helpers.StringifyVector(expectedResult));
        }
    }

}
