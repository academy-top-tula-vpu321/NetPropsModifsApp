using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetPropsModifsApp
{

    // виден только внутри файла
    file class ClassFile { }

    // public для этой сборки
    // private для внешних сборок
    internal class ClassInternal { }

    public class ClassPublic { }

    class ModifiersExample
    {
        // виден только внутри класса или структуры
        private int number;
        int amount;

        // виден только внутри класса или структуры,
        // а также в производных классах
        // в рамках одной сборки
        private protected float x;

        protected internal string name;
    }
}
