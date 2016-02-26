using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FindShortestNewSequence;
using System.Linq;

namespace UnitTestProject1
{
  [TestClass]
  public class UnitTest1
  {
    [TestMethod]
    public void TestMethod1()
    {

      string[] allSequences = new string[] {
      "AGGTCTA",
"AGACGACGGAGAACGA",
"A",
"AAGATACACCGGCTTCGTG"
};

      string[][] allMissing = new string[][] {
        new string[] {"AA", "AC" },
        new string[] {"T" },
        new string[] {"C" },
            new string[] {"AAA","CAT" }
      };

      Program p = new Program();
      int length = allSequences.Length;
      for (int i = 0; i < length; i++)
      {
        string sequence = allSequences[i];

        string actual = p.findShortestNewSequence(sequence);

        string[] expected = allMissing[i];

        TestEqual(expected, actual);
      }

    }

    private void TestEqual(string[] expected, string actual)
    {
      Assert.IsTrue(expected.Intersect(new string[] { actual }).Count() != 0);
    }
  }
}
