

namespace BasicCRUDOperations;

public class Program { 
    
    static void Main(string[] args)
    {
        RunProgram();
    }


    private static void RunProgram() {
        Console.WriteLine("Program to save and read products:  ");
        bool programInRunningMode = true;
        Operations operations = new();

        while (programInRunningMode) { 
            Console.WriteLine("Choose Operation: ");    
            Console.WriteLine("1. add");    
            Console.WriteLine("2. read");    
            Console.WriteLine("3. update");
            Console.WriteLine("4. delete");
            Console.WriteLine("5. search by name");
            Console.WriteLine("6. finish");

            int operationMode;
            if (!int.TryParse(Console.ReadLine(), out operationMode) || operationMode < 1 || operationMode > 7)
            { 
                Console.WriteLine("Invalid choise. Please choose again!");
                continue;
            }

            switch (operationMode) 
            {
                case 1:
                    operations.Add();
                    break;
                case 2:
                    operations.Read(); 
                    break;
                case 3:
                    operations.Update();
                    break;
                case 4:
                    operations.Delete(); 
                    break;
                case 5:
                    operations.Search();
                    break;
                case 6:
                    programInRunningMode = false;   
                    break;
            }
        }
    
    
    }

}