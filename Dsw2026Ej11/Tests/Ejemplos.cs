using Dsw2026Ej11.Collections;
using Dsw2026Ej11.Domain;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dsw2026Ej11.Tests;


internal class Ejemplos
{
    //Agregar 3 alumnos a la lista
    //Listar por consola los alumnos
    //Buscar por nombre un alumno que exista y mostrar por consola
    //Buscar por nombre un alumno que no exista y mostrar por consola el texto "No existe"
    //Eliminar un alumno y listar por consola los alumnos
    //Eliminar el primer elemento de la lista y listar por consola los alumnos
    public static void EjemploList(){

        CasoList lista = new CasoList();
        Console.WriteLine("----- Caso de prueba para List -----");
        Console.WriteLine();

        Console.WriteLine("Se carga la lista...");
        lista.AgregarAlumno(new Alumno(123, "Ana", 7));
        lista.AgregarAlumno(new Alumno(124, "Daniel", 4));
        lista.AgregarAlumno(new Alumno(125, "Messi", 10));
        Console.WriteLine();

        Console.WriteLine("Listado de Alumnos:");
        lista.ListarAlumnos();
        Console.WriteLine();

        /*
        Console.WriteLine("Se busca un alumno:");
        Console.WriteLine(lista.BuscarAlumno("Ana"));
        Console.WriteLine();

        Console.WriteLine("Se busca un Alumno que no existe:");
        Console.WriteLine(lista.BuscarAlumno("Riquelme"));
        Console.WriteLine();
        */

        Console.WriteLine("Buscar alumno existente:");
        Alumno? encontrado = lista.BuscarAlumno("Ana");

        Console.WriteLine(
            encontrado != null
                ? encontrado
                : "No existe");

        Console.WriteLine();

        Console.WriteLine("Buscar alumno inexistente:");
        Alumno? inexistente = lista.BuscarAlumno("Riquelme");

        Console.WriteLine(
            inexistente != null
                ? inexistente
                : "No existe");
        Console.WriteLine();

        Console.WriteLine("Se borra un alumno con el objeto:");
        if (encontrado != null)
        {
            lista.EliminarAlumno(encontrado);
        }
        lista.ListarAlumnos();
        Console.WriteLine();

        Console.WriteLine("Se elemina un alumno por posicion:");
        lista.EliminarPosicion(1);
        lista.ListarAlumnos();
        Console.WriteLine();
    }

    //Agregar 3 alumnos al diccionario
    //Listar por consola los alumnos
    //Buscar un alumno por clave y mostrar por consola
    //Buscar un alumno por clave, pero que no exista, y mostrar por consola el texto "No existe"
    //Eliminar un alumno por clave y listar por consola los alumnos
    public static void EjemploDictionary()
    {
        CasoDictionary dicc = new CasoDictionary();
        Console.WriteLine("----- Casos de prueba para Dictionary -----");
        Console.WriteLine();

        Console.WriteLine("Se carga la lista...");
        dicc.AgregarAlumno(new Alumno(123, "Ana", 7));
        dicc.AgregarAlumno(new Alumno(124, "Daniel", 4));
        dicc.AgregarAlumno(new Alumno(125, "Messi", 10));
        Console.WriteLine();

        Console.WriteLine("Listado de Alumnos:");
        foreach (var item in dicc.ObtenerAlumnos())
        {
            Console.WriteLine(item.Value);
        }
        Console.WriteLine();

        /*
        Console.WriteLine("Se busca un alumno por su clave:");
        Console.WriteLine(dicc.BuscarPorClave(124));
        Console.WriteLine();

        Console.WriteLine("Se busca un Alumno por su clave que no existe:");
        Console.WriteLine(dicc.BuscarPorClave(126));
        Console.WriteLine();

        
        Console.WriteLine("Se borra un alumno con el objeto:");
        dicc.EliminarAlumno(124);
        dicc.ObtenerAlumnos();
        Console.WriteLine();
        */

        Console.WriteLine("Buscar por clave:");
        
        Alumno? alumno = dicc.BuscarPorClave(124);
        Console.WriteLine(
            alumno != null
                ? alumno
                : "No existe");
        Console.WriteLine();

        Console.WriteLine("Buscar clave inexistente:");
        Alumno? inexistente = dicc.BuscarPorClave(126);
        Console.WriteLine(
            inexistente != null
                ? inexistente
                : "No existe");
        Console.WriteLine();

        Console.WriteLine("Eliminar por clave:");

        dicc.EliminarAlumno(124);

        foreach (var item in dicc.ObtenerAlumnos())
        {
            Console.WriteLine(item.Value);
        }

        Console.WriteLine();
    }

    //Realizar una llamada a cada método definido en CasoLinq y mostar por consola según corresponda
    public static void EjemploLinq()
    {
        CasoLinq linq = new CasoLinq();

        Console.WriteLine("----- Casos de prueba LINQ -----");
        Console.WriteLine();

        Console.WriteLine("Primer libro:");
        Console.WriteLine(linq.GetPrimero());
        Console.WriteLine();

        Console.WriteLine("Último libro:");
        Console.WriteLine(linq.GetUltimo());
        Console.WriteLine();

        Console.WriteLine("Suma total de precios:");
        Console.WriteLine(linq.GetTotalPrecios());
        Console.WriteLine();

        Console.WriteLine("Promedio de precios:");
        Console.WriteLine(linq.GetPromedioPrecios());
        Console.WriteLine();

        Console.WriteLine("Libros con ID > 15:");

        foreach (Libro libro in linq.GetListById())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine();

        Console.WriteLine("Libros formateados:");

        foreach (string libro in linq.GetLibros())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine();

        Console.WriteLine("Libro con mayor precio:");
        Console.WriteLine(linq.GetMayorPrecio());
        Console.WriteLine();

        Console.WriteLine("Libro con menor precio:");
        Console.WriteLine(linq.GetMenorPrecio());
        Console.WriteLine();

        Console.WriteLine("Libros con precio mayor al promedio:");

        foreach (Libro libro in linq.GetMayorPromedio())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine();

        Console.WriteLine("Libros ordenados descendente:");

        foreach (Libro libro in linq.GetListaDescendente())
        {
            Console.WriteLine(libro);
        }

        Console.WriteLine();
    }
}
