using HashTable;
namespace HashTable
{

    class program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("-----------Welcome to HashTable Program----------");
            bool end = true;
            Console.WriteLine("\n1.FindFrequencyOfWords\n2.FindFrequencyOfParagraph & RemoveWordFromPhrase\n3.End Of Program ");
            while (end)
            {
                Console.WriteLine("\nEnter Option To Execute The Program");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        MyMapNode<string, int> hash = new MyMapNode<string, int>(5);
                        string words = "to be or not to be";
                        string[] arr = words.Split(' ');
                        LinkedList<string> checkForDuplication = new LinkedList<string>();
                        foreach (string element in arr) // to -> be
                        {
                            int count = 0;
                            foreach (string match in arr) //to->be->or->not->to-> be-> 
                            {
                                if (element == match)
                                {
                                    count++;//1->2
                                    if (checkForDuplication.Contains(element))
                                    {
                                        break;
                                    }
                                }

                            }

                            if (!checkForDuplication.Contains(element))
                            {
                                checkForDuplication.AddLast(element);
                                hash.Add(element, count);//(to,2)
                            }
                        }
                        hash.Display();
                        break;
                    case 2:
                        MyMapNode<string, int> hashT = new MyMapNode<string, int>(5);

                        string word = "Paranoids are not paranoid because they are paranoid but because they keep putting themselves deliberately into paranoid avoidable situations";
                        string[] arra = word.Split(' ');
                        LinkedList<string> checkForDuplications = new LinkedList<string>();
                        foreach (string element in arra)
                        {
                            int count = 0;
                            foreach (string match in arra)
                            {
                                if (element == match)
                                {
                                    count++;
                                    if (checkForDuplications.Contains(element))
                                    {
                                        break;
                                    }
                                }

                            }

                            if (checkForDuplications.Contains(element))
                            {
                                continue;
                            }
                            checkForDuplications.AddLast(element);
                            hashT.Add(element, count);
                        }
                        int freq = hashT.Get("avoidable");
                        Console.WriteLine("Frequency of the word Avoidable: " + freq);
                        hashT.Remove("avoidable");
                        freq = hashT.Get("avoidable");
                        Console.WriteLine("Frequency of the word Avoidable after removing: " + freq);
                        break;
                    case 3:
                        end = false;
                        Console.WriteLine("Program Is Ended.");
                        break;
                    default:
                        Console.WriteLine("Enter The Correct Option");
                        break;




                }

            }
        }
    }
}