using System.Collections.Generic;
using System.Text;
using KataBankOCR.Digits3x3;

namespace KataBankOCR
{
    public abstract class Digit
    {
        public abstract string Value { get; }

        public static Digit From( char[,] digit )
        {
            return digits[UniqueKeyFrom( digit )];
        }

        static string UniqueKeyFrom( char[,] digit )
        {
            StringBuilder key = new StringBuilder();

            for( int i = 0; i <= digit.GetUpperBound( 0 ); i++ )
            {
                for( int j = 0; j <= digit.GetUpperBound( 1 ); j++ )
                {
                    key.Append( digit[i, j] );
                } 
            }

            return key.ToString();
        }

        static Digit()
        {
            digits = new Dictionary<string, Digit>
                     {
                         { UniqueKeyFrom( Digit0.Ascii_3x3 ), new Digit0() },
                         { UniqueKeyFrom( Digit1.Ascii_3x3 ), new Digit1() },
                         { UniqueKeyFrom( Digit2.Ascii_3x3 ), new Digit2() },
                         { UniqueKeyFrom( Digit3.Ascii_3x3 ), new Digit3() },
                         { UniqueKeyFrom( Digit4.Ascii_3x3 ), new Digit4() },
                         { UniqueKeyFrom( Digit5.Ascii_3x3 ), new Digit5() },
                         { UniqueKeyFrom( Digit6.Ascii_3x3 ), new Digit6() },
                         { UniqueKeyFrom( Digit7.Ascii_3x3 ), new Digit7() },
                         { UniqueKeyFrom( Digit8.Ascii_3x3 ), new Digit8() },
                         { UniqueKeyFrom( Digit9.Ascii_3x3 ), new Digit9() }
                     };
        }

        static Dictionary<string, Digit> digits; 
    }
}