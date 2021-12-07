namespace Properties
{
    using System;
    using System.Linq;
    using Libreria;

    /// <summary>
    /// The seeds of italian cards.
    /// </summary>
    public enum ItalianSeeds
    {
        DENARI,
        COPPE,
        SPADE,
        BASTONI,
    }

    /// <summary>
    /// The names of italian cards.
    /// </summary>
    public enum ItalianNames
    {
        ASSO,
        DUE,
        TRE,
        QUATTRO,
        CINQUE,
        SEI,
        SETTE,
        FANTE,
        CAVALLO,
        RE,
    }

    /// <summary>
    /// The runnable entrypoint of the exercise.
    /// </summary>
    public class Program
    {
        /// <inheritdoc cref="Program" />
        public static void Main()
        {
            DeckFactory df = new DeckFactory();
            Card my = new Card("TRE", "DENARI", 2);


            //Test uso libreria
            /*
            Class1 c1 = new Class1();
            c1.SayHello();
            */

            df.Names = (Enum.GetNames(typeof(ItalianNames)).ToList());
            df.Seeds = (Enum.GetNames(typeof(ItalianSeeds)).ToList());

            // TODO understand string format convention
            Console.WriteLine("The {1} deck has {0} cards: ", df.GetDeckSize(), "italian");

            foreach (Card c in df.GetDeck())
            {
                Console.WriteLine(c);
                //Test Equals
                if (c.Equals(my))
                {
                    Console.WriteLine("Siamo uguali");
                }
            }
        }
    }
}
