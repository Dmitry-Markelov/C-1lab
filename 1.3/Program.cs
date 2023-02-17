string str = "101110";
int bla  = Convert.ToInt32(str, 2);
string s = Convert.ToString(bla,16);
Console.WriteLine(s);