int n = 4;
int m = 6;
int [,]a = new int[n, m];
int i = 0;
int j = 0;
int col = 0;
int row = 0;
int s = 0;

while (row < n){
    i = row;
    j = col;
    while((i < n) && (j >= 0))
        a[i++, j--] = s++;

    if(col < (m - 1))
        col = col + 1;
    else row = row + 1;
}

for(i = 0; i < n; ++i){
    for(j = 0; j < m; ++j){
        Console.Write(String.Format("{0,3}", a[i, j]));
    }
Console.WriteLine();
}