namespace KataBankOCR
{
    public class AccountNumber
    {
        public string Value;

        public static AccountNumber From( char[,] accountNumberArray )
        {
            string accountNumberString = "";

            char[,] digit = new char[3,3];
            for( int i = 0; i < accountNumberArray.GetLength( 1 ); i = i + 3 )
            {
                for( int lineIndex = 0; lineIndex < 3; lineIndex++ )
                {
                    for( int columnIndex = i; columnIndex < i + 3; columnIndex++ )
                    {
                        digit[lineIndex, columnIndex - i] = accountNumberArray[lineIndex, columnIndex];
                    }
                }

                accountNumberString += Digit.From( digit ).Value;
            }

            return new AccountNumber { Value = accountNumberString };
        }
    }
}