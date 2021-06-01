using System;
class ReplacestheValues {
  static void Main() {
    Console.Write("Please give a number as 1st variable: ");
	int variable1=Convert.ToInt16(Console.ReadLine());
	Console.Write("Please give a number as 2nd variable: ");
	int variable2=Convert.ToInt16(Console.ReadLine());
	Console.WriteLine("The values ​​you entered  \n" +"Variable 1:"+ variable1 + " Variable 2:" + variable2);
	variable1=variable1+variable2;
	variable2=variable1-variable2;
	variable1=variable1-variable2;
	Console.WriteLine("Changed new values   \n" +"Variable 1:"+ variable1 + " Variable 2:" + variable2);
	
	
  }
}
