using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int simpleArraySum(int n, int[] ar) {
        // Complete this function
        int prev = 0, cur = 1;
        while(cur<n && ar[cur]<=0){
            prev = cur;
            cur*=2;
        }
        cur = cur<n?cur:n-1;
        for(int i=prev;i<=cur;i++){
            if(ar[i]>0) return i;
        }
        return -1;
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int result = simpleArraySum(n, ar);
        Console.WriteLine(result);
    }
}
