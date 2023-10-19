using CodeTest;

namespace Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {

        }

        [Theory]
        [TestCase("a", 1)]
        [TestCase("ab", 3)]
        [TestCase("abc", 4)]
        [TestCase("vgwtzfpwujzcwrehqxjqtyncrxrtqgwmqpnqjxdxpzwkzgchrh", 214)]
        [TestCase("apczadfxhzwayqyppadunggjdwzdnhfzkbtkgynxtwbebkzhtgzknhjrupypfhpfiqawegixyepcwkpwkparbiamkwpfjjtfkmwuhevdwararwygdxikjqdecgvbjnfaajzcedvpkgaggpacwnvfcguvziynkqtxptfzaqtgtbfwmjqyeyryzddmqwknadvkgbigiukk", 1064)]
        [TestCase("wqgmtcrqqxvgtrzezgiwucrquucfiugaaninfckwikzaenpidcvgfciacthznwyvwxxftdxmixqpphkmkxmyxervjcyunpawqzqgxefrpwcnwancuqcuptuuchgxgjznexexwtpxiehrywwkchpqaiqqnyqfvcmqefajtzppayhaktbqiqepueinwhnjenywydxpahhnfqzqppeupuaxvnuimtrepvgufczrirpavxatbwavvhbmrpcmenxxkgtyabvbpezjmacchmxrknhbeiyniuhqgjkkpkmeufeakrvfihxyixeerjpizxgftuhnndejwyvfxfzktkhbbquyjtavifumahwvqqynzhbjaykwpphduitxxnkmfzdyahjnipqbvritjkignmzmnejxmmpnabudhbzwdnhzbbqwdhqtytfkrqkdqepeehvfhekjchbwaitmhwbjabnfyagqkarybmkmdcjcmnpvkjepjtniwyemzgfw", 3422)]

        public void TestLogic(string strInput, int iExpected)
        {
            int iResult = Program.countSubstrings(strInput);

            Assert.AreEqual(iExpected, iResult);


        }
    }
}