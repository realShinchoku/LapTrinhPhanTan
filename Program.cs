using console.Lab1;

Random random = new Random();
int length = random.Next(1, 1000);
int[] arr = new int[length];
for (int i = 0; i < length; i++)
{
    arr[i] = random.Next(1, 100);
}
foreach (int i in arr) Console.Write(i.ToString() + " ");

int k = random.Next(1, 10);
int range = length / k, s = 0;
Thread[] threads = new Thread[k];
Lab1[] labs = new Lab1[k];

for (int i = 1; i < k; i++)
{
    labs[i] = new Lab1(arr, s, s + range, i.ToString());
    threads[i] = new Thread(labs[i].Run);
    s += range;
}
foreach (var t in threads)
{
    t.Start();
}
foreach (var t in threads)
{
    try { t.Join(); } catch { }
}
foreach (var l in labs)
{
    l.Print();
}