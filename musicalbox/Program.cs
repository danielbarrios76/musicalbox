using System;

namespace musicalbox
{
    class Program
    {
      static void ShowMessage(string text, string message)
      {
        Console.Write(text + " " + message);
      }
      

      static void Main(string[] args)
      {
        var musicalBox = new MusicalBox();

        //for test
        musicalBox.AddMusicalWord("perro");
        musicalBox.AddMusicalWord("lado");
        musicalBox.AddMusicalWord("casa");
        musicalBox.AddMusicalWord("piano");
        

        ShowMessage("Palabras en la cajita musica: ", musicalBox.GetWords());
        
        

      }
    }
}
