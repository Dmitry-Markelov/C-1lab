var array = new int[5,5];
var newArray = new double[5,5];
int n = 5;

for (int i = 0; i < n; i++) {       
    for (int j = 0; j < n; j++) {   
        Random x = new Random();
        int randomNumber = x.Next(-10, 11);
        array[i, j] = randomNumber;
    }
}

for (int i = 0; i < n; i++) { 
    for (int j = 0; j < n; j++) { 
        Console.Write(array[i, j] + "\t");
    }
    Console.WriteLine(); // переход на новую строку 
}

int max = 0;

for (int i = 0; i < n; i++){
    for (int j = 0; j < n; j++) {
        if (Math.Abs(array[i, j]) > max) max = Math.Abs(array[i, j]);
    }
}
Console.WriteLine(max);
for (int i = 0; i < n; i++){
    for (int j = 0; j < n; j++) {
        newArray[i, j] = array[i, j] / max;
    }
}

for (int i = 0; i < n; i++) { 
    for (int j = 0; j < n; j++) { 
        Console.Write(newArray[i, j] + "\t");
    }
    Console.WriteLine(); // переход на новую строку 
}