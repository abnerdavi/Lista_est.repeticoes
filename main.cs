using System;

class MainClass {

  //Exercicio 3) Faça um Programa que peça dois números e imprima a soma
  public static void soma2num(){
    float num1 = pegaNum();
    float num2 = pegaNum();
    Console.WriteLine("\nA soma dos numeros informados é {0}\n", (num1+num2));
  }

  //Exercicio 4) Faça um Programa que peça as 4 notas bimestrais e mostre a média.
  public static void calcMedia(){
    
    float[] notas = new float[4];
    float media=0;
    Console.WriteLine("Digite a seguir, as 4 notas bimestrais, sendo uma de cada vez");
    for(int i=0;i<4;i++){
      notas[i] = pegaNum();
      media = media + notas[i];
    }
    
    media = (float)media/4;

    Console.WriteLine("\nA media das notas informadas é {0}\n",media);
  }

  public static void calcBasica(){

    char operacao;
    int num1 = pegaNum();
    int num2 = pegaNum();
        
    Console.WriteLine("----- MENU DE OPCOES DA CALCULADORA----- ");
    Console.WriteLine("      + : ADIÇÃO ");
    Console.WriteLine("      - : SUBTRAÇÃO");
    Console.WriteLine("      * : MULTIPLICAÇÃO");
    Console.WriteLine("      / : DIVISÃO");
    Console.Write("Digite o caractere referente a opção desejada\n>> ");
    operacao = char.Parse(Console.ReadLine());
    
    switch (operacao){

      case +:
        
        break;
      case -:
        
        break;
      case *:
        
        break;
      case /:
        
        break;
      default:
        Console.WriteLine("Opcao incorreta!");
        break;
    }


  }

  //funcao para coletas numeros inteiros do usuario
  public static int pegaNum(){
    
    Console.Write("Informe um numero inteiro:\n>> ");
    int num = int.Parse(Console.ReadLine());
    
    return num;
  }

  public static void Main () {

    int op;
    bool repeat=true;

    while(repeat){

      Console.WriteLine("----- MENU DE OPCOES DE EXERCICIOS----- ");
      Console.WriteLine("      (1) calculadora basica");
      Console.WriteLine("      (2) Lanchonete");
      Console.WriteLine("      (3) Votação");
      Console.Write("      (4) Sair\n-> ");

      op = int.Parse(Console.ReadLine());
      
      switch (op){

        case 1:
          
          break;
        case 2:
          
          break;
        case 3:
          
          break;
        case 4:
          repeat = false;
          break;
        default:
          Console.WriteLine("Opcao incorreta!");
          break;
      }
      Console.WriteLine("Pressione qualquer tecla para continuar...");
      Console.ReadKey(true);//para esperar o usuario digitar uma tecla para continuar
      Console.Clear();//limpa tela
    }
  }
}