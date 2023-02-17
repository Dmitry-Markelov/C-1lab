int[,] array = new int[6, 6];
int N = 5;
int M = 5;
int s = 0;

for (int i = 1; i <= N; i++) {       // N - число строк
    for (int j = 1; j <= N; j++) {   // M - число столбцов
        Random x = new Random();
        int n = x.Next(-100, 100);
        array[i, j] = n;
    }
}

for (int i=1; i <= N; i++) { 
    for (int j=1; j <= N; j++) { 
        Console.Write(array[i, j] + " ");
    }
    Console.WriteLine(); // переход на новую строку 
}

int max = 0;

for (int i = 1; i <= 5; i++){
    for (int j = 1; j <= 5; j++) {
        if (Math.Abs(array[i, j]) > max) max = Math.Abs(array[i, j]);
    }
}
Console.WriteLine(max);