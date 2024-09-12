using Xunit;

public class SoundexTests
{
    [Fact]
    public void HandlesEmptyString()
    {
        Assert.Equal(string.Empty, Soundex.GenerateSoundex(""));
    }

    [Fact]
    public void HandlesSingleCharacterAlphabets()
    {
        for (char singleAlphabet = 'A'; singleAlphabet <= 'Z'; ++singleAlphabet) 
        {
            Assert.Equal(singleAlphabet.ToString()+"000", Soundex.GenerateSoundex(singleAlphabet.ToString()));
        }
    }

    [Fact]
    public void IsRobertSoundexValueR163()
    {
        Assert.Equal("R163", Soundex.GenerateSoundex("Robert"));
    }

    [Fact]
    public void IsRupertSoundexValueR163()
    {
        Assert.Equal("R163", Soundex.GenerateSoundex("Rupert"));
    }

    [Fact]
    public void HandlesStringRubin()
    {
        Assert.Equal("R150", Soundex.GenerateSoundex("Rubin"));
    }
    
    [Fact]
    public void HandlesStringTymczak()
    {
        Assert.Equal("T522", Soundex.GenerateSoundex("Tymczak"));
    }

    [Fact]
    public void HandlesStringPfister()
    {
        Assert.Equal("P236", Soundex.GenerateSoundex("Pfister"));
    }

    [Fact]
    public void HandlesHoneyman()
    {
        Assert.Equal("H555", Soundex.GenerateSoundex("Honeyman"));
    }
}
