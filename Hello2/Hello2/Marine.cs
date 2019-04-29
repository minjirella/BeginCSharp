using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello2
{
    class Marine
    {
        public Marine()
        {
            HP = 50;
        }

        public int HP;

        private static int MaxHP = 50;
        public static void UpgradeHP()
        {
            // 정적 멤버에서는 비정적 멤버에 접근불가.
            // HP--; //인스턴스 멤버에 대해서는 접근이 안된다. (static이 아님)

            MaxHP += 10;
        }

        public void Heal()
        {
            // 비정적 멤버는 정적멤버에 접근가능.
            while (HP <= MaxHP)
            {
                HP++;
            }
        }
    }
}
