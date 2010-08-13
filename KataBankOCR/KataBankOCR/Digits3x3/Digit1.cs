namespace KataBankOCR.Digits3x3
{
    public class Digit1 : Digit
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
}