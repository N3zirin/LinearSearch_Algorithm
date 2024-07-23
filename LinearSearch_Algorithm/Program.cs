class Program
{
    static void Main()
    {
        int[] array = { 10, 20, 30, 40, 50 };
        int target = 30;
        int index = Array.FindIndex(array, x => x == target);

        Console.WriteLine(index >= 0 ? $"Element found at index {index}" : "Element not found");
    }
}
