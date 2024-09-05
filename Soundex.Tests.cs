using Xunit;

public class SoundexTests
{
    [Fact]
    public void HandlesEmptyString()
    {
        Assert.Equal(string.Empty, Soundex.GenerateSoundex(""));
    }

    [Fact]
    public void HandlesSingleCharacter()
    {
        Assert.Equal("A000", Soundex.GenerateSoundex("A"));
    }

    [Fact]
    public void HandlesStringRobert()
    {
        Assert.Equal("R163", Soundex.GenerateSoundex("Robert"));
    }

    [Fact]
    public void HandlesStringRupert()
    {
        Assert.Equal("R163", Soundex.GenerateSoundex("Rupert"));
    }

    [Fact]
    public void HandlesStringRubin()
    {
        Assert.Equal("R150", Soundex.GenerateSoundex("Rubin"));
    }

    [Fact]
    public void HandlesStringAshcraft()
    {
        Assert.Equal("A261", Soundex.GenerateSoundex("Ashcraft"));
    }

    [Fact]
    public void HandlesStringAshcroft()
    {
        Assert.Equal("A261", Soundex.GenerateSoundex("Ashcroft"));
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
