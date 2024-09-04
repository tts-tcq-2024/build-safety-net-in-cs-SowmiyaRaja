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
        GetSoundexCodeAndAppend(name, ref soundex);
        
        AppendZeros(ref soundex);
        soundex.ToString();
    }
    
    private static void PassIndex (string name, ref StringBuilder soundex)
    {
        for (int i = 1; i < name.Length && soundex.Length < 4; i++)
        {
            GetSoundexCodeAndAppend(name[i], soundex);
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
        
        return ReplaceCharWithDigit("BFPV", c, '1');
        return ReplaceCharWithDigit("CGJKQSXZ", c, '2');
        return ReplaceCharWithDigit("DT", c, '3');
        return ReplaceCharWithDigit("L", c, '4');
        return ReplaceCharWithDigit("MN", c, '5');
        return ReplaceCharWithDigit("R", c, '6');      
        return 0;
    }

    private static char ReplaceCharWithDigit(string CharSet, char c, char number)
    {
        if(CharSet.Contains(c))
            return number;
    }
}
