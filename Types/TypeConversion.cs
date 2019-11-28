using System;
using System.Collections.Generic;
using System.Text;

namespace Types
{
    public class TypeConversion
    {
        byte assignedByte = 1;  // 1 byte   (00000001)
        int assignedInt = 1;    // 4 bytes  (00000000 000000000 00000000 00000001)
        string assignedString = "1";
        string nullString = null;

        public void ConversionImplicit()
        { 
            int newInt = assignedByte;
            float newFloat = assignedInt;
            //byte newByte = assignedInt;           // does not compile since data loss could occur
        }

        public void ConversionExplicitByCasting()
        {
            byte newByte1 = (byte)assignedInt;      // cast to show awareness of potential data loss
            // int newInt = (int)assignedString;    // Incompatible types
        }

        public void ConversionOfNonCompatibleTypes()
        {
            int newInt1 = Convert.ToInt32(assignedString);
            int newInt2 = int.Parse(assignedString);

            Console.WriteLine("### Convert.ToInt32 and int.Parse:\n");

            Console.WriteLine($"Convert.ToInt32(assignedString):");
            Console.WriteLine(Convert.ToInt32(assignedString));

            Console.WriteLine($"int.Parse(assignedString):");
            Console.WriteLine(int.Parse(assignedString));

            Console.WriteLine();

            Console.WriteLine("### Handling Null Strings:\n");

            Console.WriteLine("Convert.ToInt32(null):");
            Console.WriteLine(Convert.ToInt32(null));

            Console.WriteLine($"int.Parse(null):");
            try
            {
                Console.WriteLine(int.Parse(nullString));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine();
            

        }
    }
}
