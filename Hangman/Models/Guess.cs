using System.Collections.Generic;

namespace Hangman.Models
{
  public class Guess
  {
    public char Letter { get; set; }
    public int Id { get; }
    private static List<Guess> _guesses = new List<Guess> {};
    
    public Guess(char letter)
    {
      Letter = letter;
      _guesses.Add(this);
      Id = _guesses.Count;
    }

    public static List<Guess> GetAll()
    {
      return _guesses;
    }
    
    public static void ClearAll()
    {
      _guesses.Clear();
    }

    public static Guess Find(int searchId)
    {
      return _guesses[searchId-1];
    }

  }
}