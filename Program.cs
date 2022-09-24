string[] GetUserData()
{
    Console.WriteLine("How many elements do you want to enter?");
    int N = Convert.ToInt32(Console.ReadLine());
    int i = 0;
    string[] Array = new string[N];
    while (i < N)
    {
        Console.WriteLine("Enter" + (i + 1) + " element");
        Array[i] = Console.ReadLine();
        i++;
    }
    return Array;
}

string[] GetAnArrayByCondition(string[] Array)
{
    int i = 0;
    string[] OutPutArray = new string[Array.Length];
    foreach (var stringArray in Array)
    {
        if (stringArray.Length <= 3)
        {
            OutPutArray[i] = stringArray;
            i++;
        }
    }
    return OutPutArray;

}

void OutputTheResult(string[] OutPutArray)
{
    string StringArray = "[ ";
    foreach (var item in OutPutArray)
    {
        if (item != null)
        {
            StringArray = StringArray + item + "; ";    
        } 
    }
    StringArray = StringArray + "]";

    Console.WriteLine("Result: ");
    Console.WriteLine(StringArray);
}


string[] Array = GetUserData();
string[] OutPutArray = GetAnArrayByCondition(Array);
OutputTheResult(OutPutArray);


