// Liner search in arry 
// O(N)
int[] numbers = new[] { 1, 7, 5, 6, 2, 8, 62, 41, 8, 3, 21, 8, 32, 1, 8, 6, 25, 9, 5, 487, 6 };

int serch(int[] numb, int searchFor)
{
    for (int i = 0; i < numb.Length; i++)
    {
        if (numb[i] == searchFor)
        {
            return numb[i];
        }
    }
    return -1;
}

//Bianery Search in arry
// O(lgN)
var SortedArry = numbers;
Array.Sort(SortedArry);

SearchBianary(12, SortedArry);

int SearchBianary(int findNumber, int[] arry)
{
    int last_index = arry.Length - 1;
    int First_index = 0;
    int Tedad_Search = 1;

    while ( First_index<=last_index)
    {
        int min = (last_index + First_index) / 2;
        if (arry[min] < findNumber)
        {
            First_index = min+1;
            Tedad_Search++;
        }
        else if (arry[min] > findNumber)
        {
            last_index = min-1;
            Tedad_Search++;
        }
        else
        {
            break;
        }
    }

    return Tedad_Search;
}

//insert in Arry
// O(n)
string[]arr=new string[6];
arr[0] = "B";
arr[1] = "C";
arr[2] = "D";
arr[3] = "E";
arr[4] = "F";

//we want insert k to index 2
for (int i = arr.Length-1; i > 0; i--)
{
    arr[i] = arr[i - 1];
    if (i==2)
    {
        break;
    }
}

arr[2] = "k";

//Delete in Arry
string[] arr2 = new string[6];
arr2[0] = "B";
arr2[1] = "C";
arr2[2] = "D";
arr2[3] = "E";
arr2[4] = "F";

//We want Delete D
arr[2] = "";
for (int i = 2; i < arr2.Length-1; i++)
{
    arr2[i]=arr2[i+1];
}
Console.ReadKey();