#region task1 
int[] arr = { 5, 12, 7, 3, 19, 12, 4 };


int max1 = int.MinValue;
int max2 = int.MinValue;

foreach (int num in arr)
{
    if (num > max1)
    {
        max2 = max1; 
        max1 = num;
    }
    else if (num > max2 && num < max1)
    {
        max2 = num;
    }
}

if (max2 == int.MinValue)
    Console.WriteLine("There is no second largest element.");
else
    Console.WriteLine("The second largest element " + max2);
#endregion
#region task2

Console.WriteLine();

    int[,] matrix = 
    {
            {5, 12, 7},
            {3, 19, 12},
            {4, 8, 1}
     };

        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        int[] temp = new int[rows * cols];
        int k = 0;
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                temp[k++] = matrix[i, j];

       
        Array.Sort(temp);

        k = 0;
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                matrix[i, j] = temp[k++];

       
        Console.WriteLine("Sorted array:");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write(matrix[i, j] + "\t");
    }
    Console.WriteLine();
}
#endregion
#region task 4

Console.WriteLine();
int[,] mat =
        {
            { 5,  2,  3 },
            { 4, 10,  6 },
            { 7,  8, 15 }
        };

int row = mat.GetLength(0);
int col = mat.GetLength(1);

int sum = 0;


for (int i = 0; i < Math.Min(row, col); i++)
{
    sum += mat[i, i];
}

Console.WriteLine("\r\nMatrix:");
for (int i = 0; i < row; i++)
{
    for (int j = 0; j < col; j++)
        Console.Write(mat[i, j] + "\t");
    Console.WriteLine();
}

Console.WriteLine($"\nSum of the elements of the main diagona {sum}");
#endregion
#region task3

Console.WriteLine();


        int[] arrstart = { 5, 12, 7, 3, 19 };
        Console.WriteLine("\r\nInitial array: " + string.Join(", ", arrstart));

        Console.Write("\r\nEnter the index of the item to delete: ");
        int index = int.Parse(Console.ReadLine() ?? "0");

        if (index < 0 || index >= arrstart.Length)
        {
            Console.WriteLine("Incorrect index!");
            return;
        }

        int[] newArr = new int[arrstart.Length - 1];
        int h = 0;
        for (int i = 0; i < arrstart.Length; i++)
        {
            if (i == index) continue; 
            newArr[h++] = arrstart[i];
        }

        Console.WriteLine("\r\nArray after deletion " + string.Join(", ", newArr));
#endregion