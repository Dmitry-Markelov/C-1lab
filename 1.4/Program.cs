int n = 3;
int m = 4;
int[,] array = new int[n, m];
int s = 0;

for (int i = 0; i < n; i++) {
    for (int j = 0; j < m; j++) {
        Random x = new Random();
        int r = x.Next(-10, 11);
        array[i, j] = r;
    }
}

for (int i = 0; i < n; i++) { 
    for (int j = 0; j < m; j++) { 
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.Write("Введите число: ");
var num = int.Parse(Console.ReadLine() + " ");

for (int i = 0; i < n; i++){
    for (int j = 0; j < m; j++) {
        if (array[i, j] == num) s++;
    }
}

Console.WriteLine(s);