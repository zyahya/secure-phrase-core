namespace SecurePhrase.Tests;

public class GeneratorTests
{
    [Fact]
    public void DefaultPassphraseLength_ShouldBeFive()
    {
        var passphrase = Passphrase.Generate();

        var passphraseLength = passphrase.Split("-").Length;

        Assert.NotNull(passphrase);
        Assert.Equal(5, passphraseLength);
    }

    [Fact]
    public void Should_return_passphrase_of_length_10()
    {
        var passphrase = Passphrase.Generate(10);

        var passphraseLength = passphrase.Split("-").Length;

        Assert.NotNull(passphrase);
        Assert.Equal(10, passphraseLength);
    }
}
