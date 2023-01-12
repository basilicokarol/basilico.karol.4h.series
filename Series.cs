using System;
using System.Collections.Generic;

public static class Series
{
    public static string[] Slices(string numbers, int sliceLength)
    {
        // in caso di errore eseguire questa riga di codice per comuncare l'errore al chiamante!!
        // throw new ArgumentException();
        List<string> retVal = new List<string>();
        if (sliceLength <= 0) throw new ArgumentException();
        if (numbers.Length < sliceLength) throw new ArgumentException();
        for (int i = 0; i < numbers.Length-(sliceLength - 1);i++)
        {
            string s = numbers.Substring(i, sliceLength);
            retVal.Add(s);
        }


            return retVal.ToArray();
    }
}
