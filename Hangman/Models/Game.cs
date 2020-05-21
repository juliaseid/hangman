using System.Collections.Generic;

namespace Hangman.Models
{
  public class Game
  {
    public string Word {get; set;}
    public List<Guess> Guesses {get; set;}
    public bool [] BodyParts = new bool [6];
    private List<string> AllWords = new List<string> {"potato", "roadrunner", "bottle", "spaceship", "lamppost", "blanket", "cottage", "stationary", "whiteboard", "sunflower", "taffeta", "gossamer", "sneezes", "raindrops", "whiskers", "copper", "kettles", "woolen", "mittens", "packages", "favorite", "sashes", "snowflakes", "eyelashes", "winters"};
    public Game(string word)
    {
      Word = word;
      Guesses = new List<Guess>{};
      BodyParts = new bool[6];
    }

    public string WordSelector()
    {
      int num = random.Next(AllWords.Count);
      word = AllWords[num];
    }

    public char [] WordArray ()
    {
      char [] wordArray = word.ToCharArray();
      return wordArray;
    }

    

  }
}