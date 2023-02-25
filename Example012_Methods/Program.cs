// Вид 1 (ничего не принимают, ничего не возвращают)
void Method1()
{
  Console.WriteLine("Автор ...");
}
Method1();

// Вид 2 (что-то принимают, ничего не возвращают)
void Method2(string msg)
{
  Console.WriteLine(msg);
}
Method2(msg: "Текст сообщения");

void Method21(string msg, int count)
{
  int i = 0;
  while (i < count)
  {
    Console.WriteLine(msg);
    i++;
  }
}
Method21(msg: "Текст", count: 4);
Method21(count: 2, msg: "новый текст");

// Вид 3 (ничего не принимают, что-что возвращают)
int Method3()
{
  return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);

// Вид 4 (что-что принимают, что-что возвращают)
// string Method4(int count, string text)
// {
//   int i = 0;
//   string result = String.Empty;
//   while (i < count)
//   {
//     result = result + text;
//     i++;
//   }
//   return result;
// }
// string res = Method4(10, "z");
// Console.WriteLine(res);

string Method41(int count, string text)
{
  string result = String.Empty;
  for (int i = 0; i < count; i++)
  {
    result = result + text;
  }
  return result;
}
string res = Method41(10, "abc");
Console.WriteLine(res);

// Цикл в цикле (на примере таблицы умножения)
for (int i = 2; i <= 10; i++)
{
 for (int j = 2; j <= 10; j++)
 {
  Console.WriteLine($"{i}*{j}={i*j}");
 } 
 Console.WriteLine();
}