using System.ComponentModel;

namespace MyDictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> productList = new MyDictionary<int, string>();
            productList.Add(123456, "Erkek Pantolon");
            productList.Add(123457,"Kadın Pantolon");
            productList.Add(123458, "Erkek Spor Ayakkabı");
            productList.Add(123459, "Kadın Spor Ayakkabı");

            for (int i = 0; i < productList.Count; i++)
            {
                Console.WriteLine(productList.key[i] +" => " + productList.value[i]);
            }


        }

        class MyDictionary<Tk,Tv> 
        {
            public Tk[]  key;
            public Tv[] value;
           
            public MyDictionary() 
            { 
                key = new Tk[0];
                value = new Tv[0];
            }

            public void Add(Tk _key,Tv _value) 
            {
                //Başta oluşturduğumuz arrayin referansını tempKey e atıyoruz böylelikle verilerimiz kaybolmuyor
                Tk[] tempKey = key;
                Tv[] tempValue = value;

                key = new Tk[key.Length + 1];
                value = new Tv[value.Length + 1];

                for (int i = 0; i < tempKey.Length; i++)
                {
                    key[i] = tempKey[i];
                    value[i] = tempValue[i];
                }
                key[key.Length-1] = _key;
                value[key.Length-1]= _value;

            }
            public int Count { get { return key.Length; } }
           
        }
    }
}
