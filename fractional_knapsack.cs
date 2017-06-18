using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
    static void Main(String[] args) {
        int t0 = Convert.ToInt32(Console.ReadLine());
        for(int t = 0; t<t0;t++){
            int[] input0 = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
            int[] input1 = Array.ConvertAll(Console.ReadLine().Trim().Split(' '), Convert.ToInt32);
            int n = input0[0], w = input0[1];
            List<Item> lst = new List<Item>();
            for(int k=0;k<2*n;k+=2){
                lst.Add(new Item(input1[k], input1[k+1]));
            }
            lst.Sort();
            int result = 0;
            foreach(var item in lst){
                if(w>item.weight){
                    result+=item.cost;
                    w-=item.weight;
                }
                else{
                    result+= item.costperweight * w;
                    w = 0;
                }
            }
            Console.WriteLine(result);
        }
    }
    
    class Item : IComparable<Item> {
        public int cost;
        public int weight;
        public int costperweight;
        
        public Item(int c, int w){
            cost = c;
            weight = w;
            costperweight = c/w;
        }
        
        public int CompareTo(Item other){
            if(this.costperweight > other.costperweight) return -1;
            else if(this.costperweight < other.costperweight) return 1;
            else return 0;
        }
    }
}
