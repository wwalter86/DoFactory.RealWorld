using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DoFactory.GangOfFour.Abstract.RealWorld
{
    class Animal
    {
        public string _animalType;
    private Dictionary<string,string> _parts = new Dictionary<string,string>();
 
    // Constructor

    public Animal(string animalType)
    {
      this._animalType = animalType;
    }
 
    // Indexer

    public string this[string key]
    {
      get { return _parts[key]; }
      set { _parts[key] = value; }
    }
 
    public void Show()
    {
      Console.WriteLine("\n---------------------------");
      Console.WriteLine("Animal Type: {0}", _animalType);
      Console.WriteLine(" Food : {0}", _parts["food"]);
      Console.WriteLine(" Weight : {0}", _parts["weight"]);
      Console.WriteLine(" #Live: {0}", _parts["live"]);
      Console.WriteLine(" #Average Life : {0}", _parts["averageLife"]);
    }
    }
}
