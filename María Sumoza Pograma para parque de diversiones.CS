using System;
					
public class Program
{
	public static void Main()
	{
		String cadena = "";
		int a�os = 0;
		int mides = 0;
		Console.WriteLine(" Hola!, este es el parque del maravilloso mundo de la fantas�a ");
		Console.WriteLine("Para entrar a nuestro parque necesitamos que ingrese ciertos datos suyos:");
		Console.WriteLine("Primero, cuantos a�os tienes?");
		cadena = Console.ReadLine();
		a�os = Convert.ToInt32(cadena);
		
		if (a�os <= 9)
		{
			Console.WriteLine(" lo sentimos, eres muy joven para los juegos de nuestro parque ");
		}
		    
		else
		
		
		if (a�os >= 85)
		{
			Console.WriteLine(" lo sentimos, tu edad no es �ptima  para los juegos de nuestro parque ");
		}
		else
		{
			Console.WriteLine("Segundo, Cuanto mides en centimetros?");
			cadena = Console.ReadLine();
			mides = Convert.ToInt32(cadena);
			
			if(mides <= 150)
				{
                Console.WriteLine("Puedes entrar al planeta de los colchones inflables,la estrella de los toboganes ,las sillas voladoras y los carritos chocones para ni�os ");    
                }
			else
                {
                    Console.WriteLine("Puedes subir a casi todos nuestros juegos , exceptuando los carritos chocones para ni�os");
                
                }
		Console.WriteLine("Que tengas un d�a maravilloso en nuestro parque :)!");
			
			Console.ReadLine();
			
        
        }
    }
}   
	