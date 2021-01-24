using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ADV7_ARRAYS
{
    class Program
    {
        static void CriaLinha()
        {
            for (byte i = 0; i < 60; i++)
                Console.Write("-");
        }
        static void Main(string[] args)
        { //ARRAY ALUNOS ARMAZENARA OS NOMES DOS ALUNOS 
            string[] alunos = new string[2]; 
          //ARRAY NOTAS ARMAZENARA AS NOTAS DOS DOIS ALUNOS DOS DOIS SEMESTRES 
            double[,] notas = new double[2, 4]; 

            //alimentando o array com os nomes dos alunos 
            alunos[0] = "pedro  junior ";
            alunos[1] = "alexandre nascimento ";

            // alimentando as notas dos alunos
            notas [0,0]=6.8;
            notas [0,1]=7.0;
            notas [0,2]=8;
            notas [0,3]=9.5;
            notas [1,0]=6.0;
            notas [1,1]=7.5;
            notas [1,2]=5.5;
            notas[1, 3] = 3.3;
            //exibe o nome do aluno e suas notas 
            for (byte i = 0; i < alunos.Length; i++) {
                CriaLinha();
                Console.WriteLine("\n aluno : {0}", alunos[i]);
                CriaLinha();
                //para cada aluno obtido , faz outro loop pegando as notas do array notas 
                for (byte j = 0; j <= 3; j++) {
                    Console.WriteLine("\n nota : {0} do primeiro semestre : {1}",j+1 , notas[i,j]);
                }
                CriaLinha();
                Console.ReadKey();
            }

        }
    }
}
