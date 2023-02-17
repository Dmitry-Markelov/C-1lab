int[] a = new int[] {1, 23, 13, 45, 5, 67, 27, 1, 92, 10};
int s = 0;
int average = 0;

for(int i = 0; i < a.Length; i++) {
    average += a[i];
    if (i == 9) average /= 10;
}

for(int i = 0; i < a.Length; i++) {
    if (a[i] > average) s++;
}

Console.WriteLine($"{s*100/10}%");