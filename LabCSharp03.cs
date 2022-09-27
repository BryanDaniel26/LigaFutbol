using System;

class LigaFutbol
{
    private int temporadas;
    private int puntajesFinales;
    private int juegosJugados;
    private int jugadores;
    private int PuntuacionFinal;

    public void nombreEquipos (string equ1, string equ2)

    {
       Console.WriteLine("\t\tNombre Equipos {0} VS {1}", equ1, equ2);
    }


    public void SetPrimerEquipo()
    {
       //Insertar los nombres de los jugadores
       int cantidad = 3;
       string [] lista_nombres;
       int gol = 0;
       int total = 0;

        Console.Write("\t------------Jugadores del primer equipo------------ \n\n");
        lista_nombres = new string[cantidad];

        for(int i = 0; i<cantidad; i++){
            Console.Write("Nombre {0}: ", i + 1);
            lista_nombres[i] = Console.ReadLine();
            //Cantidad de goles por jugador
            Console.Write("Goles anotados por el jugador: ");
            gol = System.Convert.ToInt32(Console.ReadLine());
            //Total de goles del equipo
            total += gol;
            //jugadores del equipo

            int [] _total = {gol};
        }

        for (int i = 0; i < cantidad; i++){
            Console.WriteLine("{0}. {1}", i + 1, lista_nombres[i]);
        }
        Console.WriteLine("Goles totales del equipo: {0}", total);

    }
    
    
    public void SetSegundoEquipo()
    {
         //Insertar los nombres de los jugadores
       int cantidad = 3;
       string [] lista_nombres;
       int gol = 0;
       int total = 0;

        Console.Write("\t------------Jugadores del segundo equipo------------ \n");
        lista_nombres = new string[cantidad];

        for(int i = 0; i<cantidad; i++){
            Console.Write("\nNombre {0}: ", i + 1);
            lista_nombres[i] = Console.ReadLine();
            //Cantidad de goles por jugador
            Console.Write("Goles anotados por el jugador: ");
            gol = System.Convert.ToInt32(Console.ReadLine());
            //Total de goles del equipo
            total += gol;
            //jugadores del equipo

            int [] _total = {gol};
        }

        for (int i = 0; i < cantidad; i++){
            Console.WriteLine("{0}. {1} \n", i + 1, lista_nombres[i]);
        }
        Console.WriteLine("Goles totales del equipo: {0}\n", total);
        
    }

    public void Setjuegos()
    {
        int juegos_eq1, juegos_eq2; 
        
        //Equipo 1
        Console.Write("\nCuantos juegos ha jugado el equipo 1: \n");
        juegos_eq1 = System.Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("juegos del equipo {0}\n", juegos_eq1);

        //Equipo 2
        Console.WriteLine("Cuantos juegos ha jugado el equipo 2\n");
        juegos_eq2 = System.Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Juegos del equipo {0}\n", juegos_eq2);

               
    }

}


//Clase principal

class LabCSharp02
{
    static void Main()
    {

        //Presentacion
        Console.WriteLine("\t\tBienvenido a Nueva Tempora de la Liga de Futbol\n");
        LigaFutbol nombreEquipos = new LigaFutbol();
        nombreEquipos.nombreEquipos("Tigres", "Leones\n"); //Agregando el nombre a los equipos

        //Equipo 1
        LigaFutbol miEquipo1 = new LigaFutbol();
        Console.WriteLine("\t\tPrimer equipo \n");
        miEquipo1.SetPrimerEquipo();

        //Equipo 2
        LigaFutbol miEquipo2 = new LigaFutbol();
        Console.WriteLine("\t\tSegundo equipo");
        miEquipo2.SetSegundoEquipo();

        //Juegos jugados por equipo
        LigaFutbol juegosJugados = new LigaFutbol();
        juegosJugados.Setjuegos();
   
    }
}