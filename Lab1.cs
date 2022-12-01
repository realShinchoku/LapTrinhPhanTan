namespace console.Lab1
{
    internal class Lab1
    {
        private int[] _arr { get; set; }
        private int _s { get; set; }
        private int _e { get; set; }
        private string _name { get; set; }
        private int _count { get; set; } = 0;
        private int _sum { get; set; } = 0;

        public Lab1(int[] arr, int s, int e, string name)
        {
            _arr = arr;
            _s = s;
            _e = e;
            _name = name;
        }

        public void Run()
        {
            for (int i = _s; i < _e; i++)
            {
                if (_arr[i] % 3 == 0)
                {
                    Console.WriteLine(_name + ": " + _arr[i]);
                    _sum += _arr[i];
                    _count++;
                }
            }
        }

        public void Print()
        {
            Console.WriteLine("Sum " + _name + " = " + _sum);
            Console.WriteLine("Count " + _name + " = " + _count);
        }
    }
}