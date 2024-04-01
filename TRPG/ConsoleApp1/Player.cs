using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Player



    {
        public int hp = 100;
        public int at = 10;

        public void AddAt(int _at)
        {
            at += _at;
        }

        //public void AddAt() //void는 리턴을 안해주겠다는 거
        //{
        //at += 10;
        //공격력을 올려주기 위한 함수
        //}

        
        public void Fight(int monsterAt)
        {
           hp -= monsterAt;
        }
        internal void Addat(int v)
        {
            throw new NotImplementedException();
        }

    }
}
