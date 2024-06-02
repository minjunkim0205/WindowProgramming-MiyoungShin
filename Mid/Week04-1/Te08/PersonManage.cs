using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Te03
{
    internal class PersonManage
    {
        private Person[] people;
        private Random rnd;
        private int index = 0;
        public PersonManage()
        {
            people = new Person[50];
            rnd = new Random();
        }
        // 아이디를 입력받으며 비밀번호는 1부터 100 사이의 난수를 생성하여 저장하는 메소드
        public void Save(string id)
        {
            if (index >= people.Length)
            {
                Console.WriteLine("더 이상 저장할 수 없습니다.");
                return;
            }
            Person person = new Person();
            person.Id = id;
            person.Pass = rnd.Next(1, 101);
            people[index++] = person;
        }
        // 문자열 id를 매개변수로 받아 id에 해당하는 비밀번호를 반환하는 인덱서
        public int this[string id]
        {
            get
            {
                for (int i = 0; i < index; i++)
                {
                    if (people[i].Id.Equals(id, StringComparison.OrdinalIgnoreCase))
                    {
                        return people[i].Pass;
                    }
                }
                return 0;
            }
        }
        // 매개변수로 받은 문자열 id와 일치하는 비밀번호 반환, 없으면 0을 반환하는 메소드
        public int FindPass(string id)
        {
            foreach (Person person in people)
            {
                if (person != null && person.Id.Equals(id, StringComparison.OrdinalIgnoreCase))
                {
                    return person.Pass;
                }
            }
            return 0;
        }
        // 배열에 저장된 모든 내용을 출력하는 메소드
        public void PrintAll()
        {
            foreach (Person person in people)
            {
                if (person != null)
                {
                    Console.WriteLine($"ID : {person.Id}, Password : {person.Pass}");
                }
            }
        }
    }
}
