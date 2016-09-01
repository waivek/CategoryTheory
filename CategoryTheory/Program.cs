using System;

class Program
{
    int increment(int x)
    {
        return x + 1;
    }

    float halve(int x)
    {
        float f_x = (float) x;
        return f_x/2;
    }
    // Implement the composition function in your favorite language. It takes two
    // functions as arguments and returns a function that is their composition
    Func<A, C> compose<A, B, C>(Func<B, C> g, Func<A, B> f)
    {
        return x => g(f(x));
    }

    T Identity<T>(T a)
    {
        return a;
    }
    static void Main(string[] args)
    {

        Program p = new Program();
//        Func<int, float> increment_then_halve = p.compose<int, int, float>(p.halve, p.increment);
//        int x = 3;
//        Console.WriteLine("({0} + 1) / 2 = {1}", x, increment_then_halve(x));

    }
}
