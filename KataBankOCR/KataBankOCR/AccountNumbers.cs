using System.Collections.Generic;
using System.IO;

namespace KataBankOCR
{
    public abstract class AccountNumbers
    {
        public static List<char[,]> ParseFrom( TextReader tr )
        {
            List<char[,]> accountNumbers = new List<char[,]>();

            List<string> lines = new List<string>();

            string readLine;
            while( (readLine = tr.ReadLine()) != null )
            {
                lines.Add( readLine );
            }

            for( int indexToTheFirstLineOfAnAccountNumber = 0;
                 indexToTheFirstLineOfAnAccountNumber < lines.Count;
                 indexToTheFirstLineOfAnAccountNumber = indexToTheFirstLineOfAnAccountNumber + 4 )
            {
                char[,] accountNumber = new char[3, lines[0].Length];

                for( int lineIndex = indexToTheFirstLineOfAnAccountNumber;
                     lineIndex < indexToTheFirstLineOfAnAccountNumber + 3;
                     lineIndex++ )
                {
                    for( int columnIndex = 0;
                         columnIndex < lines[lineIndex].Length;
                         columnIndex++ )
                    {
                        accountNumber[lineIndex - indexToTheFirstLineOfAnAccountNumber, columnIndex] = lines[lineIndex][columnIndex];
                    }
                }

                accountNumbers.Add( accountNumber );
            }

            return accountNumbers;
        }
    }
}