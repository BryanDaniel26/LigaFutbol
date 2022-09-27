using System;

class LigaFutbol
{
    private int temporadas;
    private int puntajesFinales;
    private int juegosJugados;
    private int goles;
    private int jugadores;
    private int PuntuacionFinal;
    private string equipos = "";

    public void nombreEquipos (string equ1, string equ2)

    {
       Console.WriteLine("\t\tNombre Equipos {0} VS {1}", equ1, equ2);
    }


    public void SetPrimerEquipo()
    {
        //agregar for para ingresar el nombre de los jugadores (15 jugadores)
      //var jugadores = new List<string> {"Pedro Parages","Federico Revuelto", "Antonio Neyra", "Armando Giralt", "Manuel Prast", "Alberto Machimbarrena", "Sotero Aranguren", "Eulogio Aranguren", "Santiago Bernabeu", "Rene Petit", "Juan Monjardin", "Gaspar Rubio", "Jaime Lazcano", "Leonel Messi", "Karim Bensema"}; 
        int gol = 0;
        string [] jugadores = {};
        for (int i = 0; i<=4; i++){
            Console.WriteLine("Nombre=> \n");
            Console.ReadLine();
            Console.WriteLine("Goles=> ", jugadores);
            gol = System.Convert.ToInt32(Console.ReadLine());
        }
        
       foreach(var nombreJugadores in jugadores)
       {
        Console.WriteLine(nombreJugadores + "\n\t\tGoles {0}", gol);
       }  

       Console.WriteLine("\tLista de jugadores: \n");
       
    }
    
    /*
    public void SetSegundoEquipo(int gol)
    {
        //agregar for para ingresar el nombre de los jugadores (15 jugadores)
        var jugadores = new List<string> {"Rafael Lesmes", "Sabino Barinaga", "Prueden Sanchez", "Jose Quintana", "Jose Corona", "Adauto Iglesias", "Luis Molowny", "Manuel Fernandez", "Miguel Mendez", "Joaquin Navarro", "Juanito Alonso", "Roque Olsen", "Enrrique Mateos", "Ramon Marsal", "Joseito Fernandez"};

        goles = gol;

        foreach(var nombreJugadores in jugadores)
        {
            Console.WriteLine(nombreJugadores + "\n\t\tGoles {0}", gol);
        }
    }
    */

    public void Setjuegos()
    {
        int juegos_eq1, juegos_eq2; 
        
        //Equipo 1
        Console.WriteLine("\n\nCuantos juegos ha jugado el equipo 1 \n");
        juegos_eq1 = System.Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("El equipo 1 ha jugado {0} juegos", juegos_eq1);

        //Equipo 2
        Console.WriteLine("\n\nCuantos juegos ha jugado el equipo 2 \n");
        juegos_eq2 = System.Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("El equipo 2 ha jugado {0} juegos", juegos_eq2);

        //Marcador Final
               
    }

    public void SetPuntuacion()
    {
        int equipo1, equipo2;

        Console.Write("\n\n\t\tEl partido ha culminado con la siguiente puntuacion: \n");

        //Obtener la cantidad de goles por equipo
        Console.Write("Goles marcados por el equipo 1: ");
        equipo1 = System.Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Goles del primer equipo: \n{0}", equipo1);
        
        Console.Write("Goles marcados por el equipo 2: ");
        equipo2 = System.Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Goles del segundo equipo: \n{0}", equipo2);

        
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

         // //Juegos jugados por equipo
        LigaFutbol juegosJugados = new LigaFutbol();
        juegosJugados.Setjuegos();

        //Equipo 1
        LigaFutbol miEquipo1 = new LigaFutbol();
        Console.WriteLine("\n\tJugadores de los Tigres \n");
        miEquipo1.SetPrimerEquipo();

        // //Equipo 2
        // LigaFutbol miEquipo2 = new LigaFutbol();
        // Console.WriteLine("\n\tJugadores de los Leones\n");
        // miEquipo2.SetSegundoEquipo(2);

        //Marcador final
        LigaFutbol marcadorFinal = new LigaFutbol();
        marcadorFinal.SetPuntuacion();

        
        
    }
}