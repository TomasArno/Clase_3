using System.Runtime.CompilerServices;
using System.Text;

namespace ClassLibraryStudent
{
    public class Student
    {
        static int random;

        public string nombre;
        public string apellido;
        public int legajo;

        float _notaPrimerParcial;
        float _notaSegundoParcial;
        static Student()
        {
            Random randomNum = new Random();
            random = randomNum.Next(6,10);
        }

        public Student(string nombre, string apellido, int legajo)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void SetNotaPrimerParcial(float notaPrimerParcial)
        {
            this._notaPrimerParcial = notaPrimerParcial;
        }

        public void SetNotaSegundoParcial(float notaSegundoParcial)
        {
            this._notaSegundoParcial = notaSegundoParcial;
        }

        float CalcularPromedio()
        {
            return (this._notaPrimerParcial + this._notaSegundoParcial) / 2;
        }

        public dynamic CalcularNotaFinal()
        {
            if (this._notaPrimerParcial >= 4 && this._notaSegundoParcial >= 4)
            {
                return random;
            }
            else
            {
                return -1;
            }

        }

        public void Mostrar()
        {
            
            StringBuilder sb = new StringBuilder();

            sb.Append($"Nombre completo: {this.nombre} {this.apellido} \nNro. legajo {this.legajo} \n");
            sb.Append($"Nota primer parcial: {this._notaPrimerParcial} \nNota segundo parcial: {this._notaSegundoParcial} \n");
            sb.Append($"Promedio: {this.CalcularPromedio()} \n");

            float notaFinal = this.CalcularNotaFinal();

            if (notaFinal != -1)
            {
                sb.Append($"NOTA FINAL: {notaFinal}\n\n");
            }
            else
            {
                sb.Append($"NOTA FINAL: Alumno Desaprobado \n\n");
            }

            Console.WriteLine(sb);
        }
    }
}