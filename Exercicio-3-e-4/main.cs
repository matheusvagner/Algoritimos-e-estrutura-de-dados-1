using System;

class MainClass {

  public static void soma (int numero1, int numero2){
    int somaN = numero1 + numero2;
    Console.WriteLine ("A soma dos números é: " + somaN);
  }

  public static void mediaBimestral (float nota1, float nota2, float nota3, float nota4){
    float mediaN = ((nota1 + nota2 + nota3 + nota4)/ 4);
    Console.WriteLine ("A media é: " + mediaN);
  }

  public static void Main () {
    Console.WriteLine ("--------------------------------Exercicio 3---------------------------------------" );
    Console.WriteLine ("Insira o primeiro numero:" );
    int numero1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Insira o segundo numero:" );
    int numero2 = Convert.ToInt32(Console.ReadLine());
    soma(numero1, numero2);
    Console.WriteLine ("--------------------------------Exercicio 4---------------------------------------" );
    Console.WriteLine ("Insira a primeira nota:" );
    float nota1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Insira a segunda nota:" );
    float nota2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Insira a terceira nota:" );
    float nota3 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Insira a quarta nota:" );
    float nota4 = Convert.ToInt32(Console.ReadLine());
    mediaBimestral(nota1, nota2, nota3, nota4);
  }
}
