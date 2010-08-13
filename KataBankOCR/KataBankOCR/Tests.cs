using System;
using System.Collections.Generic;
using System.IO;
using Machine.Specifications;

namespace KataBankOCR
{
    public abstract class digit_from_a_file
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

    public class When_parsing_the_3X3_ascii_digit_0 : digit_from_a_file
    {
        It should_have_a_value_of_0 = () => Digit.Value.ShouldEqual( Value );
        Because of = () => Digit = Digit.From( AsciiDigit );
        Establish context = () => Value = "0";
    }
    public class When_parsing_the_3X3_ascii_digit_1 : digit_from_a_file
    {
        It should_have_a_value_of_1 = () => Digit.Value.ShouldEqual( Value );
        Because of = () => Digit = Digit.From( AsciiDigit );
        Establish context = () => Value = "1";
    }
    public class When_parsing_the_3X3_ascii_digit_2 : digit_from_a_file
    {
        It should_have_a_value_of_2 = () => Digit.Value.ShouldEqual( Value );
        Because of = () => Digit = Digit.From( AsciiDigit );
        Establish context = () => Value = "2";
    }
    public class When_parsing_the_3X3_ascii_digit_3 : digit_from_a_file
    {
        It should_have_a_value_of_3 = () => Digit.Value.ShouldEqual( Value );
        Because of = () => Digit = Digit.From( AsciiDigit );
        Establish context = () => Value = "3";
    }
    public class When_parsing_the_3X3_ascii_digit_4 : digit_from_a_file
    {
        It should_have_a_value_of_4 = () => Digit.Value.ShouldEqual( Value );
        Because of = () => Digit = Digit.From( AsciiDigit );
        Establish context = () => Value = "4";
    }
    public class When_parsing_the_3X3_ascii_digit_5 : digit_from_a_file
    {
        It should_have_a_value_of_5 = () => Digit.Value.ShouldEqual( Value );
        Because of = () => Digit = Digit.From( AsciiDigit );
        Establish context = () => Value = "5";
    }
    public class When_parsing_the_3X3_ascii_digit_6 : digit_from_a_file
    {
        It should_have_a_value_of_6 = () => Digit.Value.ShouldEqual( Value );
        Because of = () => Digit = Digit.From( AsciiDigit );
        Establish context = () => Value = "6";
    }
    public class When_parsing_the_3X3_ascii_digit_7 : digit_from_a_file
    {
        It should_have_a_value_of_7 = () => Digit.Value.ShouldEqual( Value );
        Because of = () => Digit = Digit.From( AsciiDigit );
        Establish context = () => Value = "7";
    }
    public class When_parsing_the_3X3_ascii_digit_8 : digit_from_a_file
    {
        It should_have_a_value_of_8 = () => Digit.Value.ShouldEqual( Value );
        Because of = () => Digit = Digit.From( AsciiDigit );
        Establish context = () => Value = "8";
    }
    public class When_parsing_the_3X3_ascii_digit_9 : digit_from_a_file
    {
        It should_have_a_value_of_9 = () => Digit.Value.ShouldEqual( Value );
        Because of = () => Digit = Digit.From( AsciiDigit );
        Establish context = () => Value = "9";
    }

    public class When_parsing_the_account_number_123456789
    {
        It should_have_a_value_of_123456789 = () => accountNumber.Value.ShouldEqual( "123456789");

        Because of = () =>
                     {
                         TextReader tr = new StreamReader( string.Format( @"Files\123456789.txt" ) );
                         List<char[,]> accountNumberArray = AccountNumbers.ParseFrom( tr );

                         accountNumber = AccountNumber.From( accountNumberArray[0] );
                     };

        static AccountNumber accountNumber;
    }

    public class When_parsing_a_file_that_has_two_account_numbers
    {
        It should_have_account_number_123456789 = () => 
            firstAccountNumber.Value.ShouldEqual( "123456789" );
        It should_have_account_number_723456780 = () => 
            secondAccountNumber.Value.ShouldEqual( "723456780" );

        Because of = () =>
                     {
                         TextReader tr = new StreamReader( string.Format( @"Files\TwoAccountNumbers.txt" ) );
                         List<char[,]> accountNumberArray = AccountNumbers.ParseFrom( tr );

                         firstAccountNumber = AccountNumber.From( accountNumberArray[0] );
                         secondAccountNumber = AccountNumber.From( accountNumberArray[1] );
                     };

        static AccountNumber firstAccountNumber;
        static AccountNumber secondAccountNumber;
    }
}