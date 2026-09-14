// Fig. 5.6: PruebaLibroCalificaciones.cs
// Crea el objeto LibroCalificaciones e invoca a su método DeterminarPromedio.
public class PruebaLibroCalificaciones
{
    public static void Main(string[] args)
    {
        // crea el objeto miLibroCalificaciones de LibroCalificaciones y
        // pasa el nombre del curso al constructor
        LibroCalificaciones miLibroCalificaciones = new LibroCalificaciones(
           "CS101 Introducción a la programación en C#");

        miLibroCalificaciones.MostrarMensaje(); // muestra el mensaje de bienvenida
        miLibroCalificaciones.DeterminarPromedioClase(); // encuentra el promedio de
        // calificaciones
    } // fin de Main
} // fin de la clase PruebaLibroCalificaciones