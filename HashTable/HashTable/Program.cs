using HashTable;
namespace HashTable
{

    class program
    {

        static void Main(string[] args)
        {
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
        }
    }
}