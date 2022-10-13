int[] rainfall= new int[12]; 

string[] month = new string[12] { "Jan", "Feb", "March", "April", "May", "June", "July", "Aug", "Sept", "Oct", "Nov", "Dec"}; 

for (int i = 0; i < rainfall.Length; i++)
{ 
    Console.WriteLine(" Enter amount " + i + ": "); 
    rainfall[i] = Convert.ToInt32(Console.ReadLine()); 
}

Console.Clear(); 

for (int i = 0; i < rainfall.Length; i++)
{
    Console.WriteLine(" For the month of" + month[i] + "=" + rainfall[i]); 
}


Console.ReadKey(); 
