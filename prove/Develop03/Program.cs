using System;

class Program
{
    static void Main(string[] args)
    {
        // string myScripture = "And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, save he shall prepare a way for them that they may accomplish the thing which he commandeth them";

        string myScripture = "7 And it came to pass that I, Nephi, said unto my father: I will go and do the things which the Lord hath commanded, for I know that the Lord giveth no commandments unto the children of men, have he shall prepare a way for them that they may accomplish the thing which he commandeth them. 8 And it came to pass that when my father had heard these words he was exceedingly glad, for he knew that I had been blessed of the Lord. 9 And I, Nephi, and my brethren took our journey in the wilderness, with our tents, to go up to the land of Jerusalem.";

        Reference newReference = new Reference("1 Nefi", 3, 7, 9);
        Scripture newScripture = new Scripture(newReference, myScripture);
        //Excedding requirements: hides words that hasn´t been hidden before
        List<int> randomNumbers = new List<int>();

        string userOption = "";
        while (userOption != "quit")
        {
            Console.WriteLine(newScripture.GetDisplayText());
            Console.WriteLine("Press Enter to continue or type 'quit' to end");
            userOption = Console.ReadLine().ToLower();
            if (userOption == "")
            {
                for (int i = 0; i <= 2; i++)
                {
                    Console.WriteLine(i);
                    while (true)
                    {
                        Random random = new Random();
                        int randNum = random.Next(1, newScripture.GetLength() + 1);
                        if (!randomNumbers.Contains(randNum))
                        {
                            newScripture.HideRandomWords(randNum);
                            randomNumbers.Add(randNum);
                            break;
                        }
                        else if(newScripture.GetLength() == randomNumbers.Count)
                        {
                            break;
                        }
                        else
                        {
                            continue;
                        }
                    }

                }
            }
            else
            {
                continue;
            }
            Console.Clear();
            if (newScripture.IsCompletlyHidden())
            {
                break;
            }
        }
    }
}