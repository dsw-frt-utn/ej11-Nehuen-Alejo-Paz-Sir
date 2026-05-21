using Dsw2026Ej11.Domain;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dsw2026Ej11.Collections;

//a. Crear un campo que represente una lista de alumnos (List<>)
//b. Incluir un método para agregar alumnos a la lista
//c. Incluir un método para retornar la lista
//d. Incluir un método para buscar un alumno por nombre
//e. Incluir un método para eliminar un alumno (debe recibir un alumno)
//f. Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList
{
    //declaración
    private readonly List<Alumno> alumnos = new();

    //agregar
    public void AgregarAlumno(Alumno alumno)
    {
        if(alumno == null)
            throw new ArgumentNullException(nameof(alumno));
        alumnos.Add(alumno);
    }

    //retorno (obtener lista)
    public List<Alumno> ObtenerAlumnos() => new(alumnos);

    // Mostrar alumnos
    public void ListarAlumnos()
    {
        foreach (Alumno alumno in alumnos){
            Console.WriteLine(alumno);
        }
    }

    //buscar p/nombre -- con lambda
    public Alumno? BuscarAlumno(string nombre) => alumnos.Find(alumno => alumno.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));

    //eliminar p/alumno
    public void EliminarAlumno(Alumno alumno) => alumnos.Remove(alumno);

    //eliminar en particular
    public void EliminarPosicion(int posicion)
    {
        if (posicion >= 0 && posicion < alumnos.Count)
            alumnos.RemoveAt(posicion);
    }

    #region funciones mal implementadas
    //No valida si alumno es null
    public void AgregarAlumnoOld(Alumno alumno) => alumnos.Add(alumno);

    //devuelve lista internamente, rompiendo encapsulación
    public List<Alumno> ObtenerAlumnosOld() => alumnos;

    //muestra, no retorna la lista
    public void ListarAlumnosOld()
    {
        foreach (Alumno alumno in alumnos)
        {
            Console.WriteLine(alumno);
        }
    }

    //lanza exepcion si el indice no existe
    public void EliminarPosicionOld(int pocision) => alumnos.RemoveAt(pocision);

    //exepción si no existe alumno
#pragma warning disable CS8603 // Posible tipo de valor devuelto de referencia nulo
    public Alumno BuscarAlumnoOld(string nombre) => alumnos.Find(correcto => correcto.Nombre == nombre);
#pragma warning restore CS8603 // Posible tipo de valor devuelto de referencia nulo

    #endregion
}