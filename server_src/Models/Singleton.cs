using AltV.Net;
using System;
using System.Collections.Generic;
using System.Text;

namespace StoryLineRP.Models
{
    public class SingletonBase<T>
    {
        public static T Instance { get; set; }
    }

    public class Singleton<T> : SingletonBase<T> where T : Singleton<T>
    {
        public Singleton()
        {
            Instance = (T)this;
        }
    }
}