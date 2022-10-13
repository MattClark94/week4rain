int[] rainfall= new int[12]; 

for (int i = 0; i < rainfall.Length; i++)
{ 
    Console.WriteLine(" Enter amount " + i + ": "); 
    rainfall[i] = Convert.ToInt32(Console.ReadLine()); 
}

Console.Clear(); 

for (int i = 0; i < rainfall.Length; i++)
{
    Console.WriteLine("rainFall" + i + "=" +rainfall[i]); 
}




Console.ReadKey(); 
