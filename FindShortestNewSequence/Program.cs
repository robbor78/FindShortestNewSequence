using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindShortestNewSequence
{
  public class Program
  {
    static void Main(string[] args)
    {
    }

    public String findShortestNewSequence(String sequence)
    {
      Queue<string> que = new Queue<string>();
      Enqueue(que, String.Empty);

      while (true)
      {
        string test = que.Dequeue();
        if (sequence.Contains(test))
        {
          Enqueue(que, test);
        }
        else
        {
          return test;
        }
      }
    }

    private void Enqueue(Queue<string> que, string baseStr)
    {
      que.Enqueue(baseStr + "A");
      que.Enqueue(baseStr + "C");
      que.Enqueue(baseStr + "G");
      que.Enqueue(baseStr + "T");
    }
  }
}
