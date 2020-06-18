using System;
using paul = System.Collections.Specialized;
using aliasType = System.Console;
using aliasNamespace = System;

namespace Namespaces
{
    class SampleClass
    {
        public void SampleMethod()
        {
            Console.WriteLine($"Sample Method");
            // The following generates an error, because System.Console is a type and not a Namespace
            // aliasType::WriteLine($"Hello");
            // The following is fine and *desired* because the alias is for a Namespace
            aliasNamespace::Console.Write($"Sample Method aliased");
        }
    }
    /// <summary>
    /// Yes, you can nest Namespaces for structure
    /// </summary>
    namespace NestedNamespaces
    {
        class SampleClass
        {
            public void SampleMethod()
            {
                Console.WriteLine($"Nested Sample Method");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var myListDictionary = new paul::ListDictionary();
            var myOuterClass = new SampleClass();
            myOuterClass.SampleMethod();

            var myInnerClass = new NestedNamespaces.SampleClass();
            myInnerClass.SampleMethod();

            Console.ReadLine();
        }
    }
}
