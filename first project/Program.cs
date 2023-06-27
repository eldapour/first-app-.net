using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Reflection;
using System.Linq;

interface Ifather
{
    void Tree();
}
partial class Father : Ifather
{
    public int Id { get; set; }
    public string Name { get; set; }


    public void Tree()
    {
        Console.WriteLine("Hi");
    }
}

class List
{
    private List<Father> fathers;

    public List()
    {
        fathers = new List<Father>();
        fathers.Add(new Father() { Id = 1, Name = "Kareem" });
        fathers.Add(new Father() { Id = 2, Name = "Ahmed" });
        fathers.Add(new Father() { Id = 3, Name = "Mosad" });
        fathers.Add(new Father() { Id = 4, Name = "Mohamed" });
        fathers.Add(new Father() { Id = 5, Name = "Nour" });
    }

    public string this[int Id]
    {
        get
        {
            return fathers.FirstOrDefault(father => father.Id == Id).Name;
        }
        set
        {
            fathers.FirstOrDefault(father => father.Id == Id).Name = value;
        }
    }

}


class Program
{
    static void Main()
    {
        //#region game code
        //Console.WriteLine("======= GUESS GAME =======");
        //Console.WriteLine("Please guess num from 1 to 10 : ");
        //int num1 = int.Parse(Console.ReadLine());

        //Random random = new Random();
        //int randomNumber = random.Next(1, 10); // generates a random integer between 1 and 10



        //if (num1 == randomNumber)
        //{
        //    Console.WriteLine("You Win :)");
        //}
        //else
        //{
        //    Console.WriteLine("You Lose :(");
        //    Console.WriteLine("Do You Play Again (Y,N)=> Yes or No");
        //    string answer = Console.ReadLine();
        //    if (answer == "y" || answer == "Y" || answer == "yes" || answer == "Yes")
        //    {
        //        Main();
        //    }
        //    else
        //    {
        //        Console.WriteLine("Thanks For your Time ! .");
        //    }
        //}
        //#endregion

        List list = new List();
        Console.WriteLine(list[5]);

        //DataTable table = new DataTable();
        //table.Columns.Add("Name");
        //table.Columns.Add("Age");

        //DataRow row = table.NewRow();
        //row["Name"] = "Karem";
        //row["Age"] = 20;

        //Console.WriteLine(row["Name"] + "|" + row["Age"]);

        Console.ReadKey(true);
    } // end main

    [Obsolete("this method is old ..  use new !", true)]
    public static int sum(int num1, int num2)
    {
        int sum = num1 + num2;
        return sum;
    } // end sum

    public static int sum(int num1, int num2, params int[] nums)
    {
        int sum = num1 + num2;
        foreach (int N in nums)
        {
            sum += N;
        }
        return sum;
    } // end sum

} // end class