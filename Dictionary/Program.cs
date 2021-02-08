using System;

namespace Dictionary 
{
    class Program 
    {
        static void Main(string[] args) 
        {
            MyDictionary<string, string> ogrenciler = new MyDictionary<string, string>();
            ogrenciler.Add("Matematik", "Aysu Deliahmetoğlu");
            ogrenciler.Add("Fizik", "Mehmet Akif");
            ogrenciler.Add("Kimya", "Abdullah Çınar");

            ogrenciler.List();
        }
    }
    class MyDictionary<D, I> 
    {
        D[] _class;
        I[] _name;

        public MyDictionary() 
        {
            _class = new D[0];
            _name = new I[0];
        }

        public void Add(D tClass, I tName) 
        {
            D[] tempClass = _class;
            _class = new D[_class.Length + 1];
            for (int i = 0; i < tempClass.Length; i++) 
            {
                _class[i] = tempClass[i];
            }
            _class[_class.Length - 1] = tClass;


            I[] tempName = _name;
            _name = new I[_name.Length + 1];
            for (int i = 0; i < tempName.Length; i++) 
            {
                _name[i] = tempName[i];
            }
            _name[_name.Length - 1] = tName;
        }

        public void List() 
        {
            for(int i=0; i<_class.Length; i++) 
            {
                Console.WriteLine(_class[i] + " " + _name[i]);
            }
        }
        public int Count 
        {
            get { return _class.Length; }
        }
    }
}
