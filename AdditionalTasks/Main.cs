using System;

namespace AdditionalTasks
{
    class Additional
    {
        static void Main(string[] args)
        {
            //Class1.Exercise1();
            //Class1.UrlFormat("https://yourwebsite.com/section/id", "products", 90);
            //Console.WriteLine(Class1.UrlFormat("https://yourwebsite.com", "products", 90));

            Class1.UrlFormat("https://yourwebsite.com?section=section&id=id", "products", 90);
            Console.WriteLine(Class1.UrlFormat("https://yourwebsite.com?section", "products", 90));







        }
    }
}
