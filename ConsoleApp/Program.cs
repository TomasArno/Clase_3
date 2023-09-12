using ClassLibraryStudent;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student estudiante1 = new Student("Tomás", "Arno", 2244);
            Student estudiante2 = new Student("Matías", "Arnoski", 2444);
            Student estudiante3 = new Student("mia", "Arneitor", 2222);

            estudiante1.SetNotaPrimerParcial(10);
            estudiante1.SetNotaSegundoParcial(5);
            estudiante1.Mostrar();

            estudiante2.SetNotaPrimerParcial(4);
            estudiante2.SetNotaSegundoParcial(4);
            estudiante2.Mostrar();

            estudiante3.SetNotaPrimerParcial(4);
            estudiante3.SetNotaSegundoParcial(3);
            estudiante3.Mostrar();
        }
    }
}