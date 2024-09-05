using System;
using System.Text;
using System.Text.RegularExpressions;

public class Soundex
{
    public static string GenerateSoundex(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            return string.Empty;
        }

        StringBuilder soundex = new StringBuilder();
        soundex.Append(char.ToUpper(name[0]));
        GetIndexFromChar(name, ref soundex);
        
        AppendZeros(ref soundex);
        soundex.ToString();
    }
    
    private static void GetIndexFromChar (string name, ref StringBuilder soundex)
    {
        for (int i = 1; i < name.Length && soundex.Length < 4; i++)
        {
            GetSoundexCodeAndAppend(name[i], ref soundex);
        }
    }

    private static void GetSoundexCodeAndAppend (char c, ref StringBuilder soundex)
    {
        char code = GetSoundexCode(c);
        if (code != '0' && code != soundex[soundex.Length - 1])
        {
            soundex.Append(code);
        }
    }

    private static void AppendZeros(ref StringBuilder soundex)
    {
        while (soundex.Length < 4)
        {
            soundex.Append('0');
        }
    }
    
    private static char GetSoundexCode(char c)
    {
        c = char.ToUpper(c);

        if((ReplaceCharWithDigit("BFPVCGJKQSXZ"), c, '7') == '7')
        {
            if(ReplaceCharWithDigit("BFPV", c, '1') == '1')
            {
                return '1';
            }
            else
            {
                return '2';
            }
        }
        return '0';
    }

    private static char ReplaceCharWithDigit(string CharSet, char c, char number)
    {
        if(CharSet.Contains(c))
            return number;
        return '0';
    }
}
