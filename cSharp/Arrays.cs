using System;
using System.Collections.Generic;

namespace cSharp{
    static class Functions{
        public static void Array(int[] x){
            for(int idx = 0; idx < x.Length; idx++){
                System.Console.WriteLine(x[idx]);
            }
        } 
        public static void Print1to255(){
            for(int idx = 1; idx< 256; idx++){
                System.Console.WriteLine(idx);
            }
        }
        public static void Odds(){
            for(int idx = 1; idx<256; idx++){
                if(idx % 2 != 0){
                    System.Console.WriteLine(idx);
                }
            }
        }
        public static void Sum(){
            int sum = 0;
            for(int idx = 0; idx<256; idx++){
                System.Console.WriteLine($"New number: {idx} Sum {sum}");
                sum += idx;
            }
        }
    }
}