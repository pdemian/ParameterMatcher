using System;
using System.Collections.Generic;

class MatchFunction<TSource, TResult>
{
    private List<Tuple<Func<TSource, TResult>, Func<TSource, bool>>> functions;

    public MatchFunction()
    {
        functions = new List<Tuple<Func<TSource, TResult>, Func<TSource, bool>>>();
    }

    public void Match(Func<TSource, TResult> func, Func<TSource, bool> predicate)
    {
        functions.Add(new Tuple<Func<TSource, TResult>, Func<TSource, bool>>(func, predicate));
    }
    public void Match(Func<TSource, TResult> func)
    {
        functions.Add(new Tuple<Func<TSource, TResult>, Func<TSource, bool>>(func, a => true));
    }

    public TResult Run(TSource arg)
    {
        foreach (var func in functions)
        {
            if (func.Item2(arg))
            {
                return func.Item1(arg);
            }
        }

        return default(TResult);
    }
}
class MatchFunction<TSource1, TSource2, TResult>
{
    private List<Tuple<Func<TSource1, TSource2, TResult>, Func<TSource1, TSource2, bool>>> functions;

    public MatchFunction()
    {
        functions = new List<Tuple<Func<TSource1, TSource2, TResult>, Func<TSource1, TSource2, bool>>>();
    }

    public void Match(Func<TSource1, TSource2, TResult> func, Func<TSource1, TSource2, bool> predicate)
    {
        functions.Add(new Tuple<Func<TSource1, TSource2, TResult>, Func<TSource1, TSource2, bool>>(func, predicate));
    }
    public void Match(Func<TSource1, TSource2, TResult> func)
    {
        functions.Add(new Tuple<Func<TSource1, TSource2, TResult>, Func<TSource1, TSource2, bool>>(func, (a, b) => true));
    }

    public TResult Run(TSource1 arg1, TSource2 arg2)
    {
        foreach (var func in functions)
        {
            if (func.Item2(arg1, arg2))
            {
                return func.Item1(arg1, arg2);
            }
        }

        return default(TResult);
    }
}
class MatchFunction<TSource1, TSource2, TSource3, TResult>
{
    private List<Tuple<Func<TSource1, TSource2, TSource3, TResult>, Func<TSource1, TSource2, TSource3, bool>>> functions;

    public MatchFunction()
    {
        functions = new List<Tuple<Func<TSource1, TSource2, TSource3, TResult>, Func<TSource1, TSource2, TSource3, bool>>>();
    }

    public void Match(Func<TSource1, TSource2, TSource3, TResult> func, Func<TSource1, TSource2, TSource3, bool> predicate)
    {
        functions.Add(new Tuple<Func<TSource1, TSource2, TSource3, TResult>, Func<TSource1, TSource2, TSource3, bool>>(func, predicate));
    }
    public void Match(Func<TSource1, TSource2, TSource3, TResult> func)
    {
        functions.Add(new Tuple<Func<TSource1, TSource2, TSource3, TResult>, Func<TSource1, TSource2, TSource3, bool>>(func, (a, b, c) => true));
    }

    public TResult Run(TSource1 arg1, TSource2 arg2, TSource3 arg3)
    {
        foreach (var func in functions)
        {
            if (func.Item2(arg1, arg2, arg3))
            {
                return func.Item1(arg1, arg2, arg3);
            }
        }

        return default(TResult);
    }
}
class MatchFunction<TSource1, TSource2, TSource3, TSource4, TResult>
{
    private List<Tuple<Func<TSource1, TSource2, TSource3, TSource4, TResult>, Func<TSource1, TSource2, TSource3, TSource4, bool>>> functions;

    public MatchFunction()
    {
        functions = new List<Tuple<Func<TSource1, TSource2, TSource3, TSource4, TResult>, Func<TSource1, TSource2, TSource3, TSource4, bool>>>();
    }

    public void Match(Func<TSource1, TSource2, TSource3, TSource4, TResult> func, Func<TSource1, TSource2, TSource3, TSource4, bool> predicate)
    {
        functions.Add(new Tuple<Func<TSource1, TSource2, TSource3, TSource4, TResult>, Func<TSource1, TSource2, TSource3, TSource4, bool>>(func, predicate));
    }
    public void Match(Func<TSource1, TSource2, TSource3, TSource4, TResult> func)
    {
        functions.Add(new Tuple<Func<TSource1, TSource2, TSource3, TSource4, TResult>, Func<TSource1, TSource2, TSource3, TSource4, bool>>(func, (a, b, c, d) => true));
    }

    public TResult Run(TSource1 arg1, TSource2 arg2, TSource3 arg3, TSource4 arg4)
    {
        foreach (var func in functions)
        {
            if (func.Item2(arg1, arg2, arg3, arg4))
            {
                return func.Item1(arg1, arg2, arg3, arg4);
            }
        }

        return default(TResult);
    }
}
class MatchFunction<TSource1, TSource2, TSource3, TSource4, TSource5, TResult>
{
    private List<Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, bool>>> functions;

    public MatchFunction()
    {
        functions = new List<Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, bool>>>();
    }

    public void Match(Func<TSource1, TSource2, TSource3, TSource4, TSource5, TResult> func, Func<TSource1, TSource2, TSource3, TSource4, TSource5, bool> predicate)
    {
        functions.Add(new Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, bool>>(func, predicate));
    }
    public void Match(Func<TSource1, TSource2, TSource3, TSource4, TSource5, TResult> func)
    {
        functions.Add(new Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, bool>>(func, (a, b, c, d, e) => true));
    }

    public TResult Run(TSource1 arg1, TSource2 arg2, TSource3 arg3, TSource4 arg4, TSource5 arg5)
    {
        foreach (var func in functions)
        {
            if (func.Item2(arg1, arg2, arg3, arg4, arg5))
            {
                return func.Item1(arg1, arg2, arg3, arg4, arg5);
            }
        }

        return default(TResult);
    }
}
class MatchFunction<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TResult>
{
    private List<Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, bool>>> functions;

    public MatchFunction()
    {
        functions = new List<Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, bool>>>();
    }

    public void Match(Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TResult> func, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, bool> predicate)
    {
        functions.Add(new Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, bool>>(func, predicate));
    }
    public void Match(Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TResult> func)
    {
        functions.Add(new Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, bool>>(func, (a, b, c, d, e, f) => true));
    }

    public TResult Run(TSource1 arg1, TSource2 arg2, TSource3 arg3, TSource4 arg4, TSource5 arg5, TSource6 arg6)
    {
        foreach (var func in functions)
        {
            if (func.Item2(arg1, arg2, arg3, arg4, arg5, arg6))
            {
                return func.Item1(arg1, arg2, arg3, arg4, arg5, arg6);
            }
        }

        return default(TResult);
    }
}
class MatchFunction<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TResult>
{
    private List<Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, bool>>> functions;

    public MatchFunction()
    {
        functions = new List<Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, bool>>>();
    }

    public void Match(Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TResult> func, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, bool> predicate)
    {
        functions.Add(new Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, bool>>(func, predicate));
    }
    public void Match(Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TResult> func)
    {
        functions.Add(new Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, bool>>(func, (a, b, c, d, e, f, g) => true));
    }

    public TResult Run(TSource1 arg1, TSource2 arg2, TSource3 arg3, TSource4 arg4, TSource5 arg5, TSource6 arg6, TSource7 arg7)
    {
        foreach (var func in functions)
        {
            if (func.Item2(arg1, arg2, arg3, arg4, arg5, arg6, arg7))
            {
                return func.Item1(arg1, arg2, arg3, arg4, arg5, arg6, arg7);
            }
        }

        return default(TResult);
    }
}
class MatchFunction<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TResult>
{
    private List<Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, bool>>> functions;

    public MatchFunction()
    {
        functions = new List<Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, bool>>>();
    }

    public void Match(Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TResult> func, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, bool> predicate)
    {
        functions.Add(new Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, bool>>(func, predicate));
    }
    public void Match(Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TResult> func)
    {
        functions.Add(new Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, bool>>(func, (a, b, c, d, e, f, g, h) => true));
    }

    public TResult Run(TSource1 arg1, TSource2 arg2, TSource3 arg3, TSource4 arg4, TSource5 arg5, TSource6 arg6, TSource7 arg7, TSource8 arg8)
    {
        foreach (var func in functions)
        {
            if (func.Item2(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8))
            {
                return func.Item1(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8);
            }
        }

        return default(TResult);
    }
}
class MatchFunction<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TResult>
{
    private List<Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, bool>>> functions;

    public MatchFunction()
    {
        functions = new List<Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, bool>>>();
    }

    public void Match(Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TResult> func, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, bool> predicate)
    {
        functions.Add(new Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, bool>>(func, predicate));
    }
    public void Match(Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TResult> func)
    {
        functions.Add(new Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, bool>>(func, (a, b, c, d, e, f, g, h, i) => true));
    }

    public TResult Run(TSource1 arg1, TSource2 arg2, TSource3 arg3, TSource4 arg4, TSource5 arg5, TSource6 arg6, TSource7 arg7, TSource8 arg8, TSource9 arg9)
    {
        foreach (var func in functions)
        {
            if (func.Item2(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9))
            {
                return func.Item1(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
            }
        }

        return default(TResult);
    }
}
class MatchFunction<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TResult>
{
    private List<Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, bool>>> functions;

    public MatchFunction()
    {
        functions = new List<Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, bool>>>();
    }

    public void Match(Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TResult> func, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, bool> predicate)
    {
        functions.Add(new Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, bool>>(func, predicate));
    }
    public void Match(Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TResult> func)
    {
        functions.Add(new Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, bool>>(func, (a, b, c, d, e, f, g, h, i, j) => true));
    }

    public TResult Run(TSource1 arg1, TSource2 arg2, TSource3 arg3, TSource4 arg4, TSource5 arg5, TSource6 arg6, TSource7 arg7, TSource8 arg8, TSource9 arg9, TSource10 arg10)
    {
        foreach (var func in functions)
        {
            if (func.Item2(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10))
            {
                return func.Item1(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10);
            }
        }

        return default(TResult);
    }
}
class MatchFunction<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TResult>
{
    private List<Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, bool>>> functions;

    public MatchFunction()
    {
        functions = new List<Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, bool>>>();
    }

    public void Match(Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TResult> func, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, bool> predicate)
    {
        functions.Add(new Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, bool>>(func, predicate));
    }
    public void Match(Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TResult> func)
    {
        functions.Add(new Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, bool>>(func, (a, b, c, d, e, f, g, h, i, j, k) => true));
    }

    public TResult Run(TSource1 arg1, TSource2 arg2, TSource3 arg3, TSource4 arg4, TSource5 arg5, TSource6 arg6, TSource7 arg7, TSource8 arg8, TSource9 arg9, TSource10 arg10, TSource11 arg11)
    {
        foreach (var func in functions)
        {
            if (func.Item2(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11))
            {
                return func.Item1(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11);
            }
        }

        return default(TResult);
    }
}
class MatchFunction<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TResult>
{
    private List<Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, bool>>> functions;

    public MatchFunction()
    {
        functions = new List<Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, bool>>>();
    }

    public void Match(Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TResult> func, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, bool> predicate)
    {
        functions.Add(new Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, bool>>(func, predicate));
    }
    public void Match(Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TResult> func)
    {
        functions.Add(new Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, bool>>(func, (a, b, c, d, e, f, g, h, i, j, k, l) => true));
    }

    public TResult Run(TSource1 arg1, TSource2 arg2, TSource3 arg3, TSource4 arg4, TSource5 arg5, TSource6 arg6, TSource7 arg7, TSource8 arg8, TSource9 arg9, TSource10 arg10, TSource11 arg11, TSource12 arg12)
    {
        foreach (var func in functions)
        {
            if (func.Item2(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12))
            {
                return func.Item1(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12);
            }
        }

        return default(TResult);
    }
}
class MatchFunction<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TResult>
{
    private List<Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, bool>>> functions;

    public MatchFunction()
    {
        functions = new List<Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, bool>>>();
    }

    public void Match(Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TResult> func, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, bool> predicate)
    {
        functions.Add(new Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, bool>>(func, predicate));
    }
    public void Match(Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TResult> func)
    {
        functions.Add(new Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, bool>>(func, (a, b, c, d, e, f, g, h, i, j, k, l, m) => true));
    }

    public TResult Run(TSource1 arg1, TSource2 arg2, TSource3 arg3, TSource4 arg4, TSource5 arg5, TSource6 arg6, TSource7 arg7, TSource8 arg8, TSource9 arg9, TSource10 arg10, TSource11 arg11, TSource12 arg12, TSource13 arg13)
    {
        foreach (var func in functions)
        {
            if (func.Item2(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13))
            {
                return func.Item1(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13);
            }
        }

        return default(TResult);
    }
}
class MatchFunction<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TResult>
{
    private List<Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, bool>>> functions;

    public MatchFunction()
    {
        functions = new List<Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, bool>>>();
    }

    public void Match(Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TResult> func, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, bool> predicate)
    {
        functions.Add(new Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, bool>>(func, predicate));
    }
    public void Match(Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TResult> func)
    {
        functions.Add(new Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, bool>>(func, (a, b, c, d, e, f, g, h, i, j, k, l, m, n) => true));
    }

    public TResult Run(TSource1 arg1, TSource2 arg2, TSource3 arg3, TSource4 arg4, TSource5 arg5, TSource6 arg6, TSource7 arg7, TSource8 arg8, TSource9 arg9, TSource10 arg10, TSource11 arg11, TSource12 arg12, TSource13 arg13, TSource14 arg14)
    {
        foreach (var func in functions)
        {
            if (func.Item2(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14))
            {
                return func.Item1(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14);
            }
        }

        return default(TResult);
    }
}
class MatchFunction<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TResult>
{
    private List<Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, bool>>> functions;

    public MatchFunction()
    {
        functions = new List<Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, bool>>>();
    }

    public void Match(Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TResult> func, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, bool> predicate)
    {
        functions.Add(new Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, bool>>(func, predicate));
    }
    public void Match(Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TResult> func)
    {
        functions.Add(new Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, bool>>(func, (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o) => true));
    }

    public TResult Run(TSource1 arg1, TSource2 arg2, TSource3 arg3, TSource4 arg4, TSource5 arg5, TSource6 arg6, TSource7 arg7, TSource8 arg8, TSource9 arg9, TSource10 arg10, TSource11 arg11, TSource12 arg12, TSource13 arg13, TSource14 arg14, TSource15 arg15)
    {
        foreach (var func in functions)
        {
            if (func.Item2(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15))
            {
                return func.Item1(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15);
            }
        }

        return default(TResult);
    }
}
class MatchFunction<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TSource16, TResult>
{
    private List<Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TSource16, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TSource16, bool>>> functions;

    public MatchFunction()
    {
        functions = new List<Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TSource16, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TSource16, bool>>>();
    }

    public void Match(Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TSource16, TResult> func, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TSource16, bool> predicate)
    {
        functions.Add(new Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TSource16, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TSource16, bool>>(func, predicate));
    }
    public void Match(Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TSource16, TResult> func)
    {
        functions.Add(new Tuple<Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TSource16, TResult>, Func<TSource1, TSource2, TSource3, TSource4, TSource5, TSource6, TSource7, TSource8, TSource9, TSource10, TSource11, TSource12, TSource13, TSource14, TSource15, TSource16, bool>>(func, (a, b, c, d, e, f, g, h, i, j, k, l, m, n, o, p) => true));
    }

    public TResult Run(TSource1 arg1, TSource2 arg2, TSource3 arg3, TSource4 arg4, TSource5 arg5, TSource6 arg6, TSource7 arg7, TSource8 arg8, TSource9 arg9, TSource10 arg10, TSource11 arg11, TSource12 arg12, TSource13 arg13, TSource14 arg14, TSource15 arg15, TSource16 arg16)
    {
        foreach (var func in functions)
        {
            if (func.Item2(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16))
            {
                return func.Item1(arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9, arg10, arg11, arg12, arg13, arg14, arg15, arg16);
            }
        }

        return default(TResult);
    }
}