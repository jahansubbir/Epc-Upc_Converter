using System;
using System.Numerics;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LeviEpcUpcConverter
{
    public interface IEpc2UpcConverter
    {
        string Convert2Upc(string epc, Epc2UpcConverter.CheckDigitFormat checkDigitFormat);
    }
    public class Epc2UpcConverter : IEpc2UpcConverter
    {
        public enum CheckDigitFormat
        {
            USA, UK
        }
        public string Convert2Upc(string epc, CheckDigitFormat checkDigitFormat)
        {
            var binary = Convert2Binary(epc);

            var sgtin = binary.Substring(14, 24);
            var item = binary.Substring(38, 20);
            switch (checkDigitFormat)
            {
                case CheckDigitFormat.USA:
                    sgtin = Convert.ToInt32(ConvertBinary2Decimal(sgtin)).ToString("D6");
                    item = Convert.ToInt32(ConvertBinary2Decimal(item)).ToString("D5");
                    break;
                case CheckDigitFormat.UK:
                    sgtin = Convert.ToInt32(ConvertBinary2Decimal(sgtin)).ToString("D7");
                    item = Convert.ToInt32(ConvertBinary2Decimal(item)).ToString("D5");
                    break;
            }

            var decimalString = String.Join(String.Empty, new[] { sgtin, item });

            Int64 checkDigit = GenerateCheckDigit(decimalString, checkDigitFormat);
            decimalString += checkDigit;
            return decimalString;
        }

        private string Convert2Binary(string epc)
        {
            var binary = String.Join(String.Empty, epc.Select(
                c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')
            ));
            return binary;
        }

        private string ConvertBinary2Decimal(string binary)
        {
            string decimalString = String.Empty;
            BigInteger result = 0;
            ; try
            {

                // I'm totally skipping error handling here
                foreach (char c in binary)
                {
                    result <<= 1;
                    result += c == '1' ? 1 : 0;
                }
                //  decimalString = Convert.ToString(Convert.(binary), 10).ToString();
            }
            catch (Exception e)
            {

            }
            return result.ToString();
        }

        private Int64 GenerateCheckDigit(string decimalString, CheckDigitFormat checkDigitFormat)
        {
            var array = decimalString.Select(digit => Int32.Parse(digit.ToString())).ToList();
            var multiplicationArray = new Int64[array.Count];
            for (int i = 0; i < array.Count; i++)
            {
                switch (checkDigitFormat)
                {
                    case CheckDigitFormat.UK:
                        multiplicationArray[i] = i % 2 == 0 ? array[i] * 1 : array[i] * 3;
                        break;
                    case CheckDigitFormat.USA:
                        multiplicationArray[i] = i % 2 == 0 ? array[i] * 3 : array[i] * 1;
                        break;
                }
            }

            var sum = multiplicationArray.Sum();
            var nearestRound = RoundUp(sum);
            var checkDigit = nearestRound - sum;
            return checkDigit;


        }
        Int64 RoundUp(Int64 toRound)
        {
            if (toRound % 10 == 0) return toRound;
            return (10 - toRound % 10) + toRound;
        }
    }
}
