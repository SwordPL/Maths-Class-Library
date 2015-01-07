namespace MathsClassLibrary.Generics
{
    interface ICalc<T>
    {
        T Sum(T arg1, T arg2);
        T Difference(T arg1, T arg2);
        T Multiply(T arg1, T arg2);
        T Divide(T arg1, T arg2);
        T Divide(T arg1, int arg2);
        int Compare(T arg1, T arg2);
    }
}
