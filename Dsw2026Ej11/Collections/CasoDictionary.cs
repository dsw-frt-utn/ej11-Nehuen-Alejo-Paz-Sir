using Dsw2026Ej11.Domain;

namespace Dsw2026Ej11.Collections;

//Crear un diccionario donde la clave sea el legajo y el valor el alumno
//Incluir un método para agregar un alumno al diccionario
//Incluir un método para buscar un alumno utilizando la clave
//Incluir un método para retornar el diccionario
//Incluir un método para eliminar un alumno utilizando la clave
public class CasoDictionary{
    //Dictionary <TKey, TValue> -- por qué no usar SortedDictionary?
    private Dictionary<int, Alumno> diccionario = new();

    //agregar
    public void AgregarAlumno(Alumno alumno) => diccionario[alumno.Id] = alumno;

    //buscar usando clave
#pragma warning disable CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL
    public Alumno? BuscarPorClave(int clave) => diccionario.TryGetValue(clave, out Alumno encontrado)? encontrado : null;
#pragma warning restore CS8600 // Se va a convertir un literal nulo o un posible valor nulo en un tipo que no acepta valores NULL

    //retornar dicc entero
    public IReadOnlyDictionary<int, Alumno> ObtenerAlumnos()
    {
        return diccionario;
    }
    public Dictionary<int, Alumno> ObtenerAlumnosOld() => diccionario;

    //eliminar p/clave
    public void EliminarAlumno(int clave) => diccionario.Remove(clave);
}
