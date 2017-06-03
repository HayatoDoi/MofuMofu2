using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MofuMofu
{
    public class KeyDownCount
    {
        //xorされた値
        private int? value;
        //xorのキー
        private int? key;
        //メモリをチェックマン
        MemCheck memCheck;
        public KeyDownCount()
        {
            value = null;
            key = null;
            memCheck = new MemCheck();
        }
        public void save(int v)
        {
            System.Random random = new System.Random();
            //鍵の生成
            this.key = random.Next(1000);
            //値の登録
            this.value = v ^ this.key;
            memCheck.save((int)this.value);
        }
        public int load()
        {
            if(this.value != null &&
                this.key != null &&
                memCheck.check((int)this.value) != false)
            {
                //値を戻して返す
                return ((int)this.value ^ (int)this.key);
            }
            return 0;
        }
    }
    class MemCheck
    {
        //保存する値
        private int[] swap;
        public MemCheck()
        {
            swap = new int[10];
        }
        public void save(int v)
        {
            //スワップ10個に値を保存
            for(int i = 0;i < 10; i++)
            {
                swap[i] = v;
            }
        }
        public bool check(int v)
        {
            //スワップ10個と値を確認
            for (int i = 0; i < 10; i++)
            {
                if(swap[i] != v)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
