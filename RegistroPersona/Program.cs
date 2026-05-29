/*Registrar los datos de una persona
nombres, apellidos, sexo, edad
*/

struct Persona
{
    public string nombres;
    public string apellidos;
    public Boolean sexo;
    public int edad;
}



class Program()
{
    static Persona[] personas = new Persona[10];

    public static void Agregar(String nom, String ape, int eda, Boolean sex, int posicion)
    {
        Persona per = new Persona();
        per.nombres = nom;
        per.apellidos=ape;
        per.edad=eda;
        per.sexo=sex;
        personas[posicion] = per;
        Console.Beep();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Registro guardado.");
        
    }

    public static void PedirDatos(int pos)
    {
        string nombres;
        string apellidos;
        bool sexo;
        int edad;

        Console.Write("Nombre: ");
        nombres = Console.ReadLine()!;
        Console.Write("Apellido: ");
        apellidos = Console.ReadLine()!;
        Console.Write("Sexo [True: Hombre - False: Mujer]: ");
        sexo = Boolean.Parse(Console.ReadLine()!);
        Console.Write("Edad: ");
        edad = int.Parse(Console.ReadLine()!);
        Agregar(nombres, apellidos, edad, sexo, pos);
    }

    public static void Menu()
    {
        int op = 0, pos = 0;
        do
        {
            Console.Clear();
            Console.WriteLine("1. Agregar");
            Console.WriteLine("2. Mostrar");
            Console.WriteLine("3. Eliminar");
            Console.WriteLine("4. Salir");
            Console.Write("Opción: ");
            op = int.Parse(Console.ReadLine()!);
        } while (op != 4);
    }

    public static void Main()
    {
        

        
    }

}
//Julio Javier Sevilla Gallegos