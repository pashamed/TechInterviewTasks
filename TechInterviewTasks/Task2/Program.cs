using System;

int[] input = { 1, 2, 3, 4, 4, 56 };
int[] output;
//SortWithCollection(ref input, out output);
output = SortWithPointers(input);

foreach (int i in output)
{
    Console.WriteLine(i);
}
Console.ReadKey();

//time complexity O(n), space complexity O(1). This algorithm can be implemented as input array is sorted making n > n-1
int[] SortWithPointers(int[] input)
{
    output = input;
    int size = output.Length;
    int prev = 0;
    int next = 1;
    while (next < size)
    {
        if (output[next] != output[prev])
        {
            prev++;
            output[prev] = output[next];
        }
        next++;
    }
    prev++;
    return output[0..prev];
}


// O(n) for small data sets, this method is ok, else if data set is big, a sorted list or sorted dictionary can be used,
// which has time complexity retrieval O(log n), but for insertion or removal SortedDictionary is faster and has complexity O(log n) where SortedList has complexity of O(n)
static void SortWithCollection(ref int[] input, out int[] output)
{
    //according to sources the time complexity of inserting elements to HashSet is O(1), if it is of fixed size
    HashSet<int> ints = new HashSet<int>(input);
    output = new int[ints.Count]; // 1 operation

    //CopyTo has compelxity of O(n)
    ints.CopyTo(output, 0); // the space complexity HashSet.CopyTo will be O(n) where n is number of elements to copy
    
}



