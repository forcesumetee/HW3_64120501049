public class Program
{
    public static void Main(string[] args)
    {
        char vars;  
        string start = "stay01";
        int number = 0;    
        string bools = "false";
        CircularLinkedList<char> character = new CircularLinkedList<char>();
        character.Add('J');
        character.Add('G'); 
        character.Add('O'); 
        character.Add('R'); 
        CircularLinkedList<char> Inputchar = new CircularLinkedList<char>();
        do
        {
            vars = Inputcharacter();    
            if (vars == character.Get(0) || vars == character.Get(1) 
            || vars == character.Get(2) || vars == character.Get(3))
               {
                    bools = "true"; 
                    Inputchar.Add(vars);                                                     
                    if (Inputchar.Get(number) == 'R' && start == "stay01")  
                    {
                       Console.WriteLine("*****************");
                       Console.WriteLine("Invalid pattern.");
                       Inputchar.Set(0,Inputcharacter());                      
                    }  
                    else if (Inputchar.Get(number-1) == 'R' && Inputchar.Get(number-2) == Inputchar.Get(number))  
                    {
                       Console.WriteLine("*****************");
                       Console.WriteLine("Invalid pattern.");
                       Inputchar.Remove(number);
                       number--;
                    }  
                    else if(Inputchar.Get(number) == 'G' && Inputchar.Get(number-1) == 'G' 
                    && Inputchar.Get(number-2) == 'G' && Inputchar.Get(number-3) == 'G' && number > 2)
                    {
                       Console.WriteLine("*****************");
                       Console.WriteLine("Invalid pattern.");
                       Inputchar.Remove(number);
                       number--;
                    } 
                    else if(Inputchar.Get(number) == 'G' && Inputchar.Get(number+1) == 'G' 
                    && Inputchar.Get(number+2) == 'G' && Inputchar.Get(number+3) == 'G' && number > 2)
                    {
                       Console.WriteLine("*****************");
                       Console.WriteLine("Invalid pattern.");
                       Inputchar.Remove(number);
                       number--;
                    }                   
                    number++;   
                    start = "stay00";                                                                                              
               }             
            else 
            {
                 bools = "false"; 
            }          
                     
        }
        while(bools == "true");
        Console.WriteLine("*****************");
        for (int i = 0;i < Inputchar.GetLength();i++)
        { 
            Console.Write(Inputchar.Get(i));
        }
    }
    static char Inputcharacter()
    {
        Console.WriteLine("*****************");
        Console.Write("Input flower : ");
        return char.Parse(Console.ReadLine());
    }

}
