int n = 4;
int m = 6;
var array = new int[n, m];

int x = 0;
int y = 0;

int _col = 0;
int _row = 0;
int current = 0;

while (_row < n)
{
    x = _col;
    y = _row;
    while ((y < n) && (x >= 0))
    {
        array[y, x] = current;
        y += 1;
        x -= 1;
        current += 1;
    }

    if (_col < (m - 1))
        _col += 1;
    else
        _row += 1;
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(String.Format("{0}\t", array[i, j]));
    }
    Console.WriteLine();
}
