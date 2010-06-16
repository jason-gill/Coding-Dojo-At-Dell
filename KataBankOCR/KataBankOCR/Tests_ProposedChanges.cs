using System.Collections.Generic;
using System.IO;
using System.Text;
using Machine.Specifications;

namespace KataBankOCR.ProposedChanges
{
    public abstract class from_a_file
    {
        protected static Digit Digit;
        protected static string Value;

        public static char[,] AsciiDigit
        {
            get
            {
                TextReader tr = new StreamReader( string.Format( @"Files\AsciiDigit3x3_{0}.txt", Value ) );
                return ParseFrom( tr );
            }
        }

        static char[,] ParseFrom( TextReader tr )
        {
            List<string> lines = new List<string>();

            string readLine;
            while( (readLine = tr.ReadLine()) != null )
            {
               lines.Add( readLine ); 
            }

            char[,] asciiDigit = new char[lines[0].Length,lines.Count];


            for( int i = 0; i < lines.Count; i++ )
            {
                for( int j = 0; j < lines[i].Length; j++ )
                {
                    asciiDigit[i,j] = lines[i][j];
                }
            }

            return asciiDigit;
        }
    }

    public class When_parsing_the_3X3_ascii_digit_0 : from_a_file
    {
        It should_have_a_value_of_0 = () => Digit.Value.ShouldEqual( Value );
        Because of = () => Digit = Digit.From( AsciiDigit );
        Establish context = () => Value = "0";
    }
    public class When_parsing_the_3X3_ascii_digit_1 : from_a_file
    {
        It should_have_a_value_of_1 = () => Digit.Value.ShouldEqual( Value );
        Because of = () => Digit = Digit.From( AsciiDigit );
        Establish context = () => Value = "1";
    }
    public class When_parsing_the_3X3_ascii_digit_2 : from_a_file
    {
        It should_have_a_value_of_2 = () => Digit.Value.ShouldEqual( Value );
        Because of = () => Digit = Digit.From( AsciiDigit );
        Establish context = () => Value = "2";
    }
    public class When_parsing_the_3X3_ascii_digit_3 : from_a_file
    {
        It should_have_a_value_of_3 = () => Digit.Value.ShouldEqual( Value );
        Because of = () => Digit = Digit.From( AsciiDigit );
        Establish context = () => Value = "3";
    }
    public class When_parsing_the_3X3_ascii_digit_4 : from_a_file
    {
        It should_have_a_value_of_4 = () => Digit.Value.ShouldEqual( Value );
        Because of = () => Digit = Digit.From( AsciiDigit );
        Establish context = () => Value = "4";
    }
    public class When_parsing_the_3X3_ascii_digit_5 : from_a_file
    {
        It should_have_a_value_of_5 = () => Digit.Value.ShouldEqual( Value );
        Because of = () => Digit = Digit.From( AsciiDigit );
        Establish context = () => Value = "5";
    }
    public class When_parsing_the_3X3_ascii_digit_6 : from_a_file
    {
        It should_have_a_value_of_6 = () => Digit.Value.ShouldEqual( Value );
        Because of = () => Digit = Digit.From( AsciiDigit );
        Establish context = () => Value = "6";
    }
    public class When_parsing_the_3X3_ascii_digit_7 : from_a_file
    {
        It should_have_a_value_of_7 = () => Digit.Value.ShouldEqual( Value );
        Because of = () => Digit = Digit.From( AsciiDigit );
        Establish context = () => Value = "7";
    }
    public class When_parsing_the_3X3_ascii_digit_8 : from_a_file
    {
        It should_have_a_value_of_8 = () => Digit.Value.ShouldEqual( Value );
        Because of = () => Digit = Digit.From( AsciiDigit );
        Establish context = () => Value = "8";
    }
    public class When_parsing_the_3X3_ascii_digit_9 : from_a_file
    {
        It should_have_a_value_of_9 = () => Digit.Value.ShouldEqual( Value );
        Because of = () => Digit = Digit.From( AsciiDigit );
        Establish context = () => Value = "9";
    }

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

    class Digit0 : Digit
    {
        public static readonly char[,] Ascii_3x3 = new char[,]
                                                       {
                                                           { ' ', '_', ' ' }, //  _ 
                                                           { '|', ' ', '|' }, // | |
                                                           { '|', '_', '|' } //  |_|
                                                       };

        public override string Value
        {
            get
            {
                return "0";
            }
        }
    }
    class Digit1 : Digit
    {
        public static readonly char[,] Ascii_3x3 = new char[,]
                                                       {
                                                           { ' ', ' ', ' ' }, //   
                                                           { ' ', ' ', '|' }, //   |
                                                           { ' ', ' ', '|' } //    | 
                                                       };

        public override string Value
        {
            get
            {
                return "1";
            }
        }
    }
    class Digit2 : Digit
    {
        public static readonly char[,] Ascii_3x3 = new char[,]
                                                       {
                                                           { ' ', '_', ' ' }, //  _ 
                                                           { ' ', '_', '|' }, //  _| 
                                                           { '|', '_', ' ' } //  |_
                                                       };

        public override string Value
        {
            get
            {
                return "2";
            }
        }
    }
    class Digit3 : Digit
    {
        public static readonly char[,] Ascii_3x3 = new char[,]
                                                       {
                                                           { ' ', '_', ' ' }, //  _ 
                                                           { ' ', '_', '|' }, //  _| 
                                                           { ' ', '_', '|' } //   _|
                                                       };

        public override string Value
        {
            get
            {
                return "3";
            }
        }
    }
    class Digit4 : Digit
    {
        public static readonly char[,] Ascii_3x3 = new char[,]
                                                       {
                                                           { ' ', ' ', ' ' }, //   
                                                           { '|', '_', '|' }, // |_| 
                                                           { ' ', ' ', '|' } //    |
                                                       };

        public override string Value
        {
            get
            {
                return "4";
            }
        }
    }
    class Digit5 : Digit
    {
        public static readonly char[,] Ascii_3x3 = new char[,]
                                                  {
                                                           { ' ', '_', ' ' }, //  _ 
                                                           { '|', '_', ' ' }, // |_ 
                                                           { ' ', '_', '|' } //   _|
                                                  };

        public override string Value
        {
            get
            {
                return "5";
            }
        }
    }
    class Digit6 : Digit
    {
        public static readonly char[,] Ascii_3x3 = new char[,]
                                                       {
                                                           { ' ', '_', ' ' }, //  _ 
                                                           { '|', '_', ' ' }, // |_ 
                                                           { '|', '_', '|' } //  |_|
                                                       };

        public override string Value
        {
            get
            {
                return "6";
            }
        }
    }
    class Digit7 : Digit
    {
        public static readonly char[,] Ascii_3x3 = new char[,]
                                                       {
                                                           { ' ', '_', ' ' }, //  _   
                                                           { ' ', ' ', '|' }, //   | 
                                                           { ' ', ' ', '|' } //    | 
                                                       };

        public override string Value
        {
            get
            {
                return "7";
            }
        }
    }
    class Digit8 : Digit
    {
        public static readonly char[,] Ascii_3x3 = new char[,]
                                                       {
                                                           { ' ', '_', ' ' }, //  _  
                                                           { '|', '_', '|' }, // |_|  
                                                           { '|', '_', '|' } //  |_| 
                                                       };

        public override string Value
        {
            get
            {
                return "8";
            }
        }
    }
    class Digit9 : Digit
    {
        public static readonly char[,] Ascii_3x3 = new char[,]
                                                       {
                                                           { ' ', '_', ' ' }, //  _
                                                           { '|', '_', '|' }, // |_| 
                                                           { ' ', '_', '|' } //   _| 
                                                       };

        public override string Value
        {
            get
            {
                return "9";
            }
        }
    }
}