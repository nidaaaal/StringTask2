using System.Diagnostics.Tracing;

namespace StringTask
{
    public class Program
    {
        //public string word = "Bananas";
        static void Main(string[] args)
        {
            var a=new Converter();
             a.change("Bananas");

        }
    }


    public class  Converter
    {
        public void change(string value) 
        {
          var arr =  value.ToArray();

           var newArr = arr.Reverse().Where(x=>x.ToString().Length %2 ==0).ToString();

            Console.WriteLine(newArr);

        }
    }
}
