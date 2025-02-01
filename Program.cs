using System;
using System.Collections.Generic;

class Program
{
    static List<string> todoList = new List<string>();

    static void Main()
    {
        while (true)
        {
            Console.WriteLine("\nTo-Do List:");
            ShowAll();
            Console.WriteLine("\nเลือกคำสั่ง: (1) เพิ่ม (2) ลบ (3) ออก");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Add();
                    break;
                case "2":
                    Remove();
                    break;
                case "3":
                    Console.WriteLine("ออกจากโปรแกรม...");
                    return;
                default:
                    Console.WriteLine("❌ คำสั่งไม่ถูกต้อง ลองใหม่อีกครั้ง");
                    break;
            }
        }
    }

    static void Add()
    {
        Console.Write("📝 ป้อนรายการที่ต้องทำ: ");
        string task = Console.ReadLine();
        todoList.Add(task);
        Console.WriteLine($"✅ '{task}' ถูกเพิ่มแล้ว!");
    }

    static void Remove()
    {
        ShowAll();
        Console.Write("🔢 ป้อนหมายเลขที่ต้องการลบ: ");
        if (int.TryParse(Console.ReadLine(), out int index) && index > 0 && index <= todoList.Count)
        {
            Console.WriteLine($"🗑 ลบ '{todoList[index - 1]}' ออกจากรายการ");
            todoList.RemoveAt(index - 1);
        }
        else
        {
            Console.WriteLine("❌ หมายเลขไม่ถูกต้อง");
        }
    }

    static void ShowAll()
    {
        if (todoList.Count == 0)
        {
            Console.WriteLine("📭 ไม่มีรายการ");
        }
        else
        {
            for (int i = 0; i < todoList.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {todoList[i]}");
            }
        }
    }
}
