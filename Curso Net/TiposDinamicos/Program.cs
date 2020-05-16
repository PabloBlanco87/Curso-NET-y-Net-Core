using System;

namespace TiposDinamicos
{
    class Program
    {
        static void Main(string[] args)
        {
            ExampleClass ec = new ExampleClass();
            //ec.exampleMethod1(10, 4);     //Da error porque no encuentra un constructor con dos argumentos

            dynamic dynamic_ec = new ExampleClass();
            dynamic_ec.exampleMethod1(10, 4);       //Aquí si deja, pero en lugar de fallar en tiempo de compilación, nos falla en tiempo de ejecución

            dynamic_ec.someMethod("some argument", 7, null);
            dynamic_ec.nonexistentMethod();

            dynamic d = 8;
            var suma = d + 4;

            //¿Cuando se utilizan? Cuando no sepamos que vamos a obtener como resultado.


        }
    }

    class ExampleClass
    {
        public ExampleClass() { }
        public ExampleClass(int v) { }

        public void exampleMethod1(int i) { }

        public void exampleMethod2(string str) { }
    }
}
