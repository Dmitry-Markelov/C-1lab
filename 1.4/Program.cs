int[,] array = new int[10, 10];
int N = 9;
int M = 9;
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

string userChoose = Console.ReadLine();
int intValue = Convert.ToInt32(userChoose);

for (int i = 1; i <= 9; i++){
    for (int j = 1; j <= 9; j++) {
        if (array[i, j] == intValue) s++;
    }
}

Console.WriteLine(s);