using System;

class Example
{
    class Node<T>
    {
        public T data;
        public Node<T> next;
        public Node(T data, Node<T> next)
        {
            this.data = data;
            this.next = next;
        }
    }

    public static void Main(string[] args)
    {
        //factorial
        MatchFunction<int, int> factorial = new MatchFunction<int, int>();
        factorial.Match(x => 1, x => x <= 1);           //if x <= 1, return 1
        factorial.Match(x => x * factorial.Run(x - 1)); //else return x * factorial(x - 1)

        Console.WriteLine("Factorial of 6 is: " + factorial.Run(6));


        //fibonacci
        MatchFunction<int, int> fibonacci = new MatchFunction<int, int>();
        fibonacci.Match(x => 0, x => x <= 0);                               //if x <= 0, return 0
        fibonacci.Match(x => 1, x => x == 1);                               //else if x == 1, return 1
        fibonacci.Match(x => fibonacci.Run(x - 1) + fibonacci.Run(x - 2));  //else return fibonacci(x - 1) + fibonacci(x - 2)

        Console.WriteLine("9th Element of the fibonacci sequence is: " + fibonacci.Run(9));

        //default functionality
        MatchFunction<int, int> nothing = new MatchFunction<int, int>();
        Console.WriteLine("Nothing(10) is: " + nothing.Run(10));
        
        MatchFunction<int, int, int> Ackermann = new MatchFunction<int, int, int>();
        Ackermann.Match( (m,n) => n + 1,                                         (m,n) => m == 0);
        Ackermann.Match( (m,n) => Ackermann.Run(m - 1, 1),                       (m,n) => m > 0 && n == 0);
        Ackermann.Match( (m,n) => Ackermann.Run(m - 1, Ackermann.Run(m, n - 1)), (m,n) => m > 0 && n > 0);
        
        Console.WriteLine("Ackermann(3,4) is: " + Ackermann.Run(3, 4));


        //McCarthy 91 function
        MatchFunction<int, int> McCarthy91 = new MatchFunction<int, int>();
        McCarthy91.Match(n => n - 10, n => n > 100);
        McCarthy91.Match(n => McCarthy91.Run(McCarthy91.Run(n + 11)));

        Console.WriteLine("McCarthy91 of 53 = " + McCarthy91.Run(53));


        //Linked List traverser
        MatchFunction<Node<string>, string> node_traverser = new MatchFunction<Node<string>, string>();
        //if null
        node_traverser.Match(x => "null", x => x == null);
        //if at the end of the linked list
        node_traverser.Match(x => x.data, x => x.next == null);
        //otherwise
        node_traverser.Match(x => x.data + "->" + node_traverser.Run(x.next));

        Console.WriteLine(node_traverser.Run(new Node<string>("Hello", new Node<string>("World", new Node<string>("!",null)))));

    }
}
