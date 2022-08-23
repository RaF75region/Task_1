using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Task1.Model
{
    public class Operation
    {
        List<Transaction> Data;

        public Operation(){
            Data=new List<Transaction>();
        }
        
        // Вывод сообщений о вводу комманд
        public void InputMessageData(string message){
            Console.WriteLine(message);
            Console.Write("(1 - add, 2 - get, 3 - exit): ");
        }

        // Добавление данных Transaction
        public void AddItem(Transaction item){
            Data.Add(item);
        }

        // Ввод числового значения
        public int InputInt(string value){
            while(true){
                if(!int.TryParse(value, out int result))
                {
                    Console.Write("Неккоректный ввод дынных, повторите попытку: ");
                    value=Console.ReadLine();
                    
                }else{
                    return result;
                }
            }
        }

        // Ввод даты
        public DateTime InputDate(string date){
            while(true){
                if(!DateTime.TryParse(date, out DateTime outDate))
                {
                    Console.Write("Некорректный формат DateTime, повторите ввод: ");
                    date = Console.ReadLine();
                }else{
                    return outDate;
                }
            }
        }

        // Ввод значения типа Decimal
        public decimal InputAmount(string amount){
            while(true){
                if(!decimal.TryParse(amount, out decimal outDate))
                {
                    Console.Write("Некорректный ввод Amount, повторите ввод: ");
                    amount = Console.ReadLine();
                }else{
                    return outDate;
                }
            }
        }

        // Получение данных Transaction по ID
         public string GetId(int id){
            Transaction item = Data.Where(opt=>opt.Id==id).FirstOrDefault();
            return JsonSerializer.Serialize(item);
        }
    }
}
