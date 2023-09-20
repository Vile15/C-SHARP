using System;
using System.Linq;
using System.Collections.Generic;

namespace jebson;

public class idade 
{         
        public static void Main(){
			
			
			
		Console.WriteLine("Me diga a sua idade:");
		
		int idade = int.Parse(Console.ReadLine());
        
		if(idade >= 0 && idade <= 4){
		Console.WriteLine("Você é um bebê.");
	}
	
	    else if(idade >= 5 && idade <= 11){
		
		Console.WriteLine("Você é uma criança.");
	
		}
		else if(idade == 12 || idade == 13){
		
		Console.WriteLine("Você é Pré-Adolescente.");
		}
		
		else if (idade >= 14 && idade <= 17){
		
		Console.WriteLine("Você é um adolescente");
		}
		
		else if (idade >= 18 && idade <= 59){
		
		Console.WriteLine("Você é um adulto");
		}
		
		else if (idade >= 60){
		Console.WriteLine("Você já é um idoso(a)");
		}
		
		else{
		Console.WriteLine("Apenas númeŕos inteiros são permitidos.");
		}
		
		}
		}
		