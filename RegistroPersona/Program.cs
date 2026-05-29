/*Registrar los datos de una persona
 nombres, apellidos, edad, sexo
 */

using System;
using System.ComponentModel.Design;

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
    static void Agregar(String nom, String ape, int eda, Boolean sex, int posicion)
    {
        Persona per = new Persona();
        per.nombres = nom;
        per.apellidos = ape;
        per.edad = eda;
        per.sexo = sex;
        personas[posicion] = per;
        Console.Beep();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Registro guardado correctamente.");
        Console.ResetColor();
    }

    public static void PedirDatos(int pos)
    {
        string nombres;
        string apellidos;
        bool sexo;
        int edad;

        Console.Write("Dime tu nombre: ");
        nombres = Console.ReadLine();
        Console.Write("Dime tu apellido: ");
        apellidos = Console.ReadLine();
        Console.Write("Dime tu sexo [True: Hombre - False: Mujer]: ");
        sexo = Boolean.Parse(Console.ReadLine());
        Console.Write("Dime tu edad: ");
        edad = int.Parse(Console.ReadLine());

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
            op = int.Parse(Console.ReadLine());
        } while (op != 4);
    }
    public static void Main()
    {
        Menu();
    }
}