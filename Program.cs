using Task1.Model;
using System;
using System.Collections;


Operation obj= new Operation();

obj.InputMessageData("Введите команду команду");

int command = obj.InputInt(Console.ReadLine());
int idAdd=-1;

while(true){
    switch (command)
    {
        case 1:
            Transaction newItem=new Transaction();       
            Console.Write("Введите Id: ");
            idAdd = obj.InputInt(Console.ReadLine());
            if(!obj.Checked(idAdd))
            {
                newItem.Id=Math.Abs(idAdd);
                
                Console.Write("Введите дату: ");
                newItem.TransactionDate=obj.InputDate(Console.ReadLine());

                Console.Write("Введите сумму: ");
                newItem.Amount=obj.InputAmount(Console.ReadLine());
                
                obj.AddItem(newItem);
                Console.WriteLine("[OK]");

                obj.InputMessageData("Введите команду команду:");
                command = obj.InputInt(Console.ReadLine());
                break;
            }else{
                Console.WriteLine("Транзакция с таким ID уже существует.");
                break;
            }
        case 2:
            Console.Write("Введите Id: ");
            int id= obj.InputInt(Console.ReadLine());
            string resultJson=obj.GetId(id);
            
            Console.WriteLine(resultJson);
            Console.WriteLine("[OK]");

            obj.InputMessageData("Введите команду команду:");
            command = obj.InputInt(Console.ReadLine());
            break;
        case 3:
            Environment.Exit(0);
            break;
        default:
            obj.InputMessageData("Такой комманды не существует");
            command = obj.InputInt(Console.ReadLine());
            break;
    };
}