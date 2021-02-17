using System.Data;
using System.Collections;
using System;

namespace ienumerables
{
    public class Person
    {
        public string firstname;
        public string lastname;
        public Person(string fname, string lname)
        {
            this.firstname = fname;
            this.lastname = lname;
        }
    }

    public class People : IEnumerable
    {
        private Person[] _people;

        public People(Person[] pArray)
        {
            _people = new Person[pArray.Length];

            for (int i = 0; i < pArray.Length; i++)
            {
                _people[i] = pArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return (IEnumerator) GetEnumerator();
        }

        public PeopleEnum GetEnumerator()
        {
            return new PeopleEnum(_people);
        }
    }

    public class PeopleEnum : IEnumerator
    {
        private Person[] _people;
        int position = -1;
        public PeopleEnum(Person[] list)
        {
            _people = list;
        }
        public bool MoveNext()
        {
            position++;
            return (position < _people.Length);
        }

        public bool MoveBack()
        {
            position--;
            return (position > -1);
        }

        public void Reset()
        {
            position = -1;
        }

        public void BackToZero()
        {
            position = 0;
        }

        object IEnumerator.Current
        {
            get
            {
                return Current;
            }
        }

        public Person Current
        {
            get
            {
                try
                {
                    return _people[position];
                }
                catch (IndexOutOfRangeException)
                {
                    throw new InvalidOperationException();
                }
            }
        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            Person[] peopleArray = new Person[3]
            {
                new Person("Saranga", "Buwaneka"),
                new Person("Lalsinghe", "TD"),
                new Person("Ira", "Muna")
            };

            People peoplelist = new People(peopleArray);
            PeopleEnum enumerator = peoplelist.GetEnumerator();

            // The enumerator can be explicitly used

            enumerator.MoveNext();
            Console.WriteLine($"{enumerator.Current.firstname} {enumerator.Current.lastname}");
            enumerator.MoveNext();
            Console.WriteLine($"{enumerator.Current.firstname} {enumerator.Current.lastname}");
            enumerator.MoveBack();
            Console.WriteLine($"{enumerator.Current.firstname} {enumerator.Current.lastname}");
            enumerator.MoveNext();
            enumerator.MoveNext();
            Console.WriteLine($"{enumerator.Current.firstname} {enumerator.Current.lastname}");
            enumerator.BackToZero();
            Console.WriteLine($"{enumerator.Current.firstname} {enumerator.Current.lastname}");

            // Or it can be used abstractly via a foreach method

            foreach (Person p in peoplelist)
            {
                Console.WriteLine($"{p.firstname} {p.lastname}");
            }
        }
    }
}
