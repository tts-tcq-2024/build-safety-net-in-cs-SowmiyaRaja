using System;
using System.Text;

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
        return soundex.ToString();
    }
    
    private static void GetIndexFromChar (string name, ref StringBuilder soundex)
    {
        char prevCode = GetSoundexCodeForCharSetBFPVCGJKQSXZ(name[0]);
        for (int i = 1; i < name.Length && soundex.Length < 4; i++)
        {
            prevCode = GetSoundexCodeAndAppend(name[i], ref soundex, prevCode);
        }
    }

    private static char GetSoundexCodeAndAppend (char c, ref StringBuilder soundex, char prevCode)
    {
        char code = GetSoundexCodeForCharSetBFPVCGJKQSXZ(c);
        if (code != '0' && code != prevCode)
        {
            soundex.Append(code);
        }
        return code;
    }

    private static void AppendZeros(ref StringBuilder soundex)
    {
        while (soundex.Length < 4)
        {
            soundex.Append('0');
        }
    }
    
    private static char GetSoundexCodeForCharSetBFPVCGJKQSXZ(char c)
    {
        c = char.ToUpper(c);       
        if(ReplaceCharWithDigit("BFPV", c, '1') == '1')
        {
            return '1';
        }
        else if(ReplaceCharWithDigit("CGJKQSXZ", c, '2') == '2')
        {
            return '2';
        }
        else
        {
            return GetSoundexCodeForCharSetDTL(c);
        }
    }

    private static char GetSoundexCodeForCharSetDTL(char c)
    {
        if(ReplaceCharWithDigit("DT", c, '3') == '3')
        {
            return '3';
        }
        else if(ReplaceCharWithDigit("L", c, '4') == '4')
        {
            return '4';
        }
        else
        {
            return GetSoundexCodeForCharSetMNR(c);
        }
    }

    private static char GetSoundexCodeForCharSetMNR(char c)
    {
            if(ReplaceCharWithDigit("MN", c, '5') == '5')
            {
                return '5';
            }
            else if(ReplaceCharWithDigit("R", c, '6') == '6')
            {
                return '6';
            }
            else
            {
                 return '0';   
            }
    }
    

    private static char ReplaceCharWithDigit(string CharSet, char c, char number)
    {
        if(CharSet.Contains(c))
            return number;
        return '0';
    }
}
