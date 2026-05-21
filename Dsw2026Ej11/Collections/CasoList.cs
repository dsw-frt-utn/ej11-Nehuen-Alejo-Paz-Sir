using Dsw2026Ej11.Domain;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Dsw2026Ej11.Collections;

//a. Crear un campo que represente una lista de alumnos (List<>)
//b. Incluir un método para agregar alumnos a la lista
//c. Incluir un método para retornar la lista
//d. Incluir un método para buscar un alumno por nombre
//e. Incluir un método para eliminar un alumno (debe recibir un alumno)
//f. Incluir un método para eliminar un alumno en una determinada posición de la lista
public class CasoList{
    //declaración
    private List<Alumno> alumnos = new();

    //agregar
    public void AgregarAlumno(Alumno alumno) => alumnos.Add(alumno);

    //retorno (obtener lista)
    public List<Alumno> ObtenerAlumnos() => alumnos;

    // Mostrar alumnos
    public void ListarAlumnos(){
        foreach (Alumno alumno in alumnos){
            Console.WriteLine(alumno);
        }
    }

    //buscar p/nombre -- diferencia entre String y string?
    public Alumno? BuscarAlumno(string nombre) => alumnos.Find(a => a.Nombre.Equals(nombre, StringComparison.OrdinalIgnoreCase));

    //eliminar p/alumno
    public void EliminarAlumno(Alumno alumno) => alumnos.Remove(alumno);

    //eliminar fu in particular
    public void EliminarPosicion(int posicion)
    {
        if (posicion >= 0 && posicion < alumnos.Count)
            alumnos.RemoveAt(posicion);
    }
    
    #region 
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

    //exepción si no existia alumno
    public Alumno BuscarAlumnoOld(string nombre) => alumnos.Find(correcto => correcto.Nombre == nombre);

    #endregion
}