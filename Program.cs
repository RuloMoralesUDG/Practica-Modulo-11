Console.WriteLine("Task 1");
var myArray = new int[10]{2,3,10,5,6,7,8,2,30,1};
ListRandomNumbers(10, 1, 100).ForEach(Console.WriteLine);
Console.WriteLine("Task 2");
DescendingOrder(myArray).ToList().ForEach(Console.WriteLine);
Console.WriteLine("Task 3");
List<string> list = new List<string>(){"Raul","Cesar","Veronica","Valeria","Raul","Cesar","Veronica","Valeria"};
RemoveDuplicates(list).ToList().ForEach(Console.WriteLine);
return;
List<int> ListRandomNumbers(int size, int lowerRank, int topRank)
{
    var list = new List<int>();
    var random = new Random();
    for (var i = 0; i < size; i++)
    {
        list.Add(random.Next(lowerRank, topRank));
    }
    return list;
}
int[] DescendingOrder(int[] array)
{
    return array.OrderByDescending(x => x).ToArray();
}
HashSet<string> RemoveDuplicates(List<string> list)
{
    return new HashSet<string>(list);
}