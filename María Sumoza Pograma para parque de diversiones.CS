using System;
					
public class Program
{
	public static void Main()
	{
		String cadena = "";
		int años = 0;
		int mides = 0;
		Console.WriteLine(" Hola!, este es el parque del maravilloso mundo de la fantasía ");
		Console.WriteLine("Para entrar a nuestro parque necesitamos que ingrese ciertos datos suyos:");
		Console.WriteLine("Primero, cuantos años tienes?");
		cadena = Console.ReadLine();
		años = Convert.ToInt32(cadena);
		
		if (años <= 9)
		{
			Console.WriteLine(" lo sentimos, eres muy joven para los juegos de nuestro parque ");
		}
		    
		else
		
		
		if (años >= 85)
		{
			Console.WriteLine(" lo sentimos, tu edad no es óptima  para los juegos de nuestro parque ");
		}
		else
		{
			Console.WriteLine("Segundo, Cuanto mides en centimetros?");
			cadena = Console.ReadLine();
			mides = Convert.ToInt32(cadena);
			
			if(mides <= 150)
				{
                Console.WriteLine("Puedes entrar al planeta de los colchones inflables,la estrella de los toboganes ,las sillas voladoras y los carritos chocones para niños ");    
                }
			else
                {
                    Console.WriteLine("Puedes subir a casi todos nuestros juegos , exceptuando los carritos chocones para niños");
                
                }
		Console.WriteLine("Que tengas un día maravilloso en nuestro parque :)!");
			
			Console.ReadLine();
			
        
        }
    }
}   
	