﻿using System;

namespace tso
{
    class Program
    {
        public static void MostrarAdyacencia(int[][] matrix){
            for(int i = 0; i< matrix.Length; i++){
                for(int j=0; j<matrix[i].Length; j++){
                    Console.Write("\t{0}",matrix[i][j]);
                }
                Console.Write("\n");
            }
        }

        public static void Main(string[] args)
        {

            int[][] matrix = new int[][] {  new int[] {0,3,5,2,0,0,0,10}, 
                                            new int[] {3,0,5,8,4,0,6,6}, 
                                            new int[] {5,5,0,0,1,7,9,0},
                                            new int[] {2,8,0,0,12,0,0,14},
                                            new int[] {0,4,1,12,0,0,15,0},
                                            new int[] {0,0,7,0,0,0,0,9},
                                            new int[] {0,6,9,0,15,0,0,3},
                                            new int[] {10,6,0,14,0,9,3,0} };
            int[,] informacion=new int[matrix.Length,3];

            for(int i=0; i< matrix.Length; i++){
                informacion[i,0] = 0;
                informacion[i,1] = int.MaxValue;
                informacion[i,2] = 0;
            }


        }
    }
}
