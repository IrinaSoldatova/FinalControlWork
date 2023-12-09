Console.Clear();
string[] InputArray()
{
    Console.WriteLine("Введите массивы строк через пробел:");
    string[] userArr = Console.ReadLine().Split(' ');
    return userArr;
}

int LenghtArray(string[] userArr)
{
    int count = 0;
    for (int i = 0; i < userArr.Length; i++)
    {
        if (userArr[i].Length <= 3)
        {
            count++;
        }
    }
    return count;
}
string[] CreateNewArray(string[] array, int lenArr)
{
    string[] newArray = new string[lenArr];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            newArray[j] = array[i];
            j++;
        }
    }
    return newArray;

}

string[] userArray = InputArray();
int len = LenghtArray(userArray);
string[] resultArray = CreateNewArray(userArray, len);
Console.WriteLine("[" + string.Join(", ", resultArray) + "]");