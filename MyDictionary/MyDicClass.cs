using System;
using System.Collections.Generic;
using System.Text;

namespace MyDictionaryWork
{
    class MyDicClass<T1, T2, T3>
    {

        T1[] personId;
        T2[] personName;
        T3[] personSurname;
        T1[] idTemp;
        T2[] nameTemp;
        T3[] surnameTemp;

        public MyDicClass()
        {
            personId = new T1[0];
            personName = new T2[0];
            personSurname = new T3[0];

        }

        public void Add(T1 id, T2 name, T3 surname)
        {
            idTemp = personId;
            nameTemp = personName;
            surnameTemp = personSurname;

            personId = new T1[personId.Length + 1];
            personName = new T2[personName.Length + 1];
            personSurname = new T3[personSurname.Length + 1];
            for (int i = 0; i < idTemp.Length; i++)
            {
                personId[i] = idTemp[i];
                personName[i] = nameTemp[i];
                personSurname[i] = surnameTemp[i];

            }

            personId[personId.Length - 1] = id;
            personName[personName.Length - 1] = name;
            personSurname[personSurname.Length - 1] = surname;

        }

        public int Length
        {
            get { return personId.Length; }
        }

        public T1[] personIds
        {
            get { return personId; }
        }

        public T2[] personNames
        {
            get { return personName; }
        }

        public T3[] personSurnames
        {
            get { return personSurname; }
        }




    }
}
