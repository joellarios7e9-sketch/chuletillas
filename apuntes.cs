using System;
public class Program
{
    public static void Main()
    {
        //Line Comment

        /*
        Bloc comment
        */

        //Tipus nomVariable = valor:
        int gravity = 10;
        bool isAdmin = true;
        double price = 10.99;
        char letter = 'A';
        decimal priceTax = 10.45; //Solo para monedas
        string nameUser = "Larios"; //String con S mayus es una classe String, normalmente en programacion lo veremos con "s".


        /*
        Nomeclaturas:
            -   UpperCamelCase --> Primeras letras de cada palabra mayus
            -   lowerCamelCase --> Primera letra minus
            -   kebab-case
            -   snake_case
        C# es Case Sensitive
        */

        //Utilizar nombres descriptivos q puedan mantenerse en el tiempo
        int num1 = 2;
        int num2 = 3;
        int result = 0;
        //No se pueden crear variables con palabras reservadas: IF, WHILE, FOR...

        //Constantes:
        // ESTRUCTURA: const type nameVartiable = value;
        const int GravityValue = 3;
        const bool HasPrivileges = false;

        //namespaces
        /*
        Manera d'agrupar els membres de nivell superior relacionats en una jerarquia sense conflicte.
        Exemple estructura:
            using System;
            namespace HelloWorldProject{
                public class HelloWorld{
		            public static void Main(){
                        const string Msg = "Introdueix el teu nom: ";
                        string name;
                        int num;
                        Console.WriteLine(Msg);
                        name = Console.ReadLine();
                        Console.WriteLine("Hola, " + name + "!");
		            }
                }
            }

        */

        /*
        Jerarquia a la hora de escribir: Pàgina #9 T02
        Primero va esto pero sigue la misma jerarquia q abajo:
        const
        var

        Value Data Types:
            Pre Defined Types : int, char, bool, float, double, decimal...
            User Defined Types : enum, struct

        Reference Data Types:
            Pre Defined Types : object, string
            User Defined Types: class, interface, delegate
        */
        /*
        Conversió de tipus
        automatica --> de petit a gran --> declarar nuevas variables
        manual --> de gran a petit --> convert
        
        convert --> facil d'utilitzar
        parse/Tryparse --> millor opció que convert, més rapid
        
        */

        /*

        // / --> cociente 6 / 2 --> 3
        // % --> resto 6 % 2 --> 0

        int r =6;
        Console.WriteLine("valor r:" + r++);
        Console.WriteLine("Valor de r despues" + r);

        int num = 3;
        num++; //num <-- + 1, incremento de 1
        num = num +3; --> clasica
        num + = 3; --> version pro

        Console.WriteLine (3 > 5); --> comprovacion, no se guarda

        Console.WriteLine ( (4 > 5 && 10 != 2) || (num <=2)); --> Esto se pierde porque no esta asignado a ninguna variable ni const

        //Salida por pantalla

        Console.WriteLine("Hola");
        Console.WriteLine($"Tu num {num} i el bool {isCorrect}"); --> Recomendada
        Console.WriteLine("Tu num {0} i bool {1}",num,isCorrect);
        Console.WriteLine("Tu num" + num + "is bool" + isCorrect);


        */

        //Casting implicito es cuando no intervienes, explicito es cuando intervienes

        //Casting.

        char letter = 'A';
        int numASCII = letter


        Console.WriteLine($"Valor decimal {numASCII} i letra {letter}");

        //Casting Explicito manual

        double valor = 10.00;
        int valorS = (int)valor;

        Console.WriteLine($"Valor double : {valor} - valor int {valorS}");

        //Con metodo

        int numerito = Convert.ToInt32( Console.ReadLine() ); //Utilizamos clases de la API
        int numerazo = Int32.Parse(Console.ReadLine() );

        
        //TryParse devuelve bool:
        
        Console.WriteLine("Dame un num");
        int luckyNumber;

        if (Int32.TryParse(Console.ReadLine(), out luckyNumber)) //Console.ReadLine() solo devuelve string
        {
            Console.WriteLine($"Tu num es: {luckyNumber}");
        }
        else
        {
            Console.WriteLine("Error"); //Control de errores
        }

        //Try Catch
        //ClassExepcion *IMPORTANTE*

        //Ternario IF

        int nif = (4 > 5) ? 4 : 2;


        int nifS = ((4 > 5) ? (2 < 2) ? 2 : 2 : 4);

        if (4 > 5)
        {
            if (2 < 2)
            {
                nifS = 2;
            }else
            {
                nifS = 1;
            }
        }
        else
        {
            nifS = 4;
        }


        //Switch

        string pokemon = "Charizard";
        string attack = ""
        Console.WriteLine("Introduce el ataque");
        switch (pokemon)
        {
            case "Charizard":
                attack = Console.ReadLine();
                if(attack == "Llamarada")
                {
                    Console.WriteLine("Lanza llamarada");
                }else if(attack == "Lanzallamas")
                {
                    Console.WriteLine("Lanzo lanzallamas");
                }
                else
                {
                    Console.WriteLine("No reconozco el ataque.");
                }
                break;
            case "Bulbasur":
                Console.WriteLine("Selecciona el ataque");
                Console.WriteLine("1 - Danza pétalo");
                Console.WriteLine("2 - Drenadoras");
                attack = Console.ReadLine();
                switch (Convert, Int32(attack))
                {
                    case 1:
                        Console.WriteLine("Has hecho danza pétalo");
                        break;
                    case 2:
                        Console.WriteLine("Has lanzado drenadoras");
                        break;
                    default:
                        Console.WriteLine("Tt un bulbasur no puede hacer hydrobomba que te piensas q es Lugia?");
                        break;
                }

                break;
            default:
                Console.WriteLine("No conozco al pokemon");
                break;
        }

    }
}
