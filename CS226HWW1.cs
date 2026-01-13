void one()
{
    int odd_counter = 0;
    int even_counter = 0;
    Console.Writeline("inout integers");
    int[] input_array = int.Parse(Console.ReadLine());
    for (int i = 0; i < input_array.Length(); i++)
    {
        if (input_array[i] % 2 != 0)
        {
            odd_counter++;
        }
        else 
        {
            even_counter++;
        }
    }
    Console.Writeline("odd: " + odd_counter + "even: " + even_counter);
}

void two()
{
    Console.Writeline("input integers");
    int[] input_array = int.Parse(Console.ReadLine());
    Console.WriteLine("input indexing switch");
    int index_switch = int.Parse(Console.ReadLine());

    int[] extra_array;

    for (int i = 0; i < input_array.Length(); i++)
    {
        extra_array[i] = input_array[i];
        if (i +2 < input_array.Length())
            input_array[i + 2] = input_array[i];
        else
        {
            int temp = i - input_array.Length();
            if (temp < 0)
                temp*= -1;
            input_array[temp] = input_array[i];
        }
    }
}

void three()
{
    int[] array = {1, 2, 3, 4, 5};
    Console.WriteLine(array);

    int rmv_int = int.Parse(Console.ReadLine());
    for (int i = 0; i <array.Length(); i++)
    {
        if (array[i] == rmv_int)
        {
            int j = 0;
            while (j < array.Length())
            {
                array[j-1] = array[j+1];
                j++;
                if (j = array.Length())
                {
                    break;
                }
            } 
        }
    }
}

void four()
{
    List<int> a = new List<int> { 1, 3, 5, 7 };
    List<int> b = new List<int> { 2, 4, 6, 8 };

    static List<int> MergeSortedLists(List<int> a, List<int> b)
    {
        List<int> result = new List<int>();

        int i = 0, j = 0;

        // Merge while both lists have elements
        while (i < a.Count && j < b.Count)
        {
            if (a[i] <= b[j])
            {
                result.Add(a[i]);
                i++;
            }
            else
            {
                result.Add(b[j]);
                j++;
            }
        }

        // Add remaining elements from a
        while (i < a.Count)
        {
            result.Add(a[i]);
            i++;
        }

        // Add remaining elements from b
        while (j < b.Count)
        {
            result.Add(b[j]);
            j++;
        }

        return result;
    }
}
List<int> merged = MergeSortedLists(a, b);
}

void five()
{
    string s = "Potatoes";

    Dictionary<string, int> MyDict = new Dictionary<string, int>();

    int counter = 0;
    for (int i = 0; i < s.Length(); i++)
    {
        for (int j = 0; j < s.Length(); j++)
        {
            if (s[i] = s[j])
            {
                counter++;
            }
        }
        MyDict.Add(s[i], counter);
    }

}

void six()
{
    string sentence = "My balls on your chin.";
    string temp;
    string[] parse_string;
    int temp_index_for_parse = 0;

    for (int i = 0; i < sentence.Length(); i++)
    {  
        if[sentence[i] !=' ']
            temp+=sentence[i];
        else
        {
            parse_string[temp_index_for_parse] = temp;
            temp_index_for_parse++;
            temp.Clear();
        }
    }
    string[] temp_array = parse_string;
    for(int i = 0; i < parse_string.Length(); i++)
    {
        for (int j = parse_sting.Length(); j > 0; j--)
        {
            parse_string[i] = parse_string[j];
            parse_string[j] = temp_array[i];

        }


    }
}

int main()
{
    return 0;
}