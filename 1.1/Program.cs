﻿int[] a = new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
int[] b = new int[] {11, 12, 13, 14, 15, 16, 17, 18, 19, 20};
int[] c = new int[10];

for(int i = 0; i < a.Length; i++){
    if (i % 2 == 0) c[i] = a[i + 1];
    else c[i] = b[i - 1];
}

Console.WriteLine(string.Join(" ", c));