using System;
using System.Linq;
using System.Collections.Generic;

namespace HelloWold;

public static class Program 
{         
    public static void Main()
	
    {
		int CRL;
		int CRL2;
	    Console.WriteLine("NÚMERO MAIOR,IGUAL OU MENOR");
		Console.WriteLine("Digite um Número:");
	    CRL = int.Parse(Console.ReadLine());
	    Console.WriteLine("Digite outro Número:");
		CRL2 = int.Parse(Console.ReadLine());
	
		if(CRL > CRL2){
		Console.WriteLine(CRL+" é maior que "+CRL2);
		}
		
		else if (CRL == CRL2){
		Console.WriteLine(CRL+" é igual que " +CRL2);
		}
		
		else{
			
		Console.WriteLine(CRL+ " é menor que " +CRL2);
		}
		
		
        
    }
}
