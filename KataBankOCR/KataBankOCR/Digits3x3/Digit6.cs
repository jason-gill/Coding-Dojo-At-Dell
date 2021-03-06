﻿namespace KataBankOCR.Digits3x3
{
    public class Digit6 : Digit
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
}