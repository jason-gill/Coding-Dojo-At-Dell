using System;
using Machine.Specifications;

namespace KataBankOCR
{
    public class When_parsing_the_3X3_digit_that_represents_0
    {
        It should_be_equal_to_0
            = () => DigitZero.From(
                String.Format( "{0}{1}{2}", " _ ", "| |", "|_|" ) ).Value.ShouldEqual( "0" );
    }

    public class When_parsing_the_3X3_digit_that_represents_1
    {
        It should_be_equal_to_1
            = () => DigitOne.From(
                String.Format( "{0}{1}{2}", "   ", "  |", "  |" ) ).Value.ShouldEqual( "1" );
    }

    abstract class Digit
    {
        public abstract string Value
        {
            get;
        }

        public virtual string LINE
        {
            get
            {
                return string.Empty;

            }
        }

        public static Digit From( string stringDigit )
        {
            //if( stringDigit == String.Format( "{0}{1}{2}", LINE ) )
            //{
            //    return CreatedDigit();
            //}

            throw new NotSupportedException();
        }

        protected abstract Digit CreatedDigit();
    }

    class DigitOne : Digit
    {
        public const string
            LINE1 = "   ",
            LINE2 = "  |",
            LINE3 = "  |";

        public override string LINE
        {
            get
            {
                return string.Format( "{0}{1}{2}", LINE1, LINE2, LINE3 );
            }
        }
        public override string Value
        {
            get
            {
                return "1";
            }
        }

        protected override Digit CreatedDigit()
        {
            return new DigitOne();
        }
    }

    class DigitZero : Digit
    {
        public const string
            LINE1 = " _ ",
            LINE2 = "| |",
            LINE3 = "|_|";

        public override string LINE
        {
            get
            {
                return string.Format( "{0}{1}{2}", LINE1, LINE2, LINE3 );
            }
        }
        public override string Value
        {
            get
            {
                return "0";
            }
        }
        protected override Digit CreatedDigit()
        {
            return new DigitZero();
        }
    }
}