using System;

class MainClass {

  //Calculadora basica
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
        Console.WriteLine("A soma dos dois numeros digitados é {0}", (num1 + num2));
        break;
      case '-':
        if(num1 > num2)
          Console.WriteLine("A subtração dos dois numeros digitados é {0}", (num1 - num2));
        else
          Console.WriteLine("A subtração dos dois numeros digitados é {0}", (num2 - num1));
        break;
      case '*':
        Console.WriteLine("A multiplicação dos dois numeros digitados é {0}", (num1 * num2));
        break;
      case '/':
        Console.WriteLine("A divisão dos dois numeros digitados é {0}", (num1 / num2));
        break;
      default:
        Console.WriteLine("Opcao incorreta!");
        break;
    }

  }

  //Lanchonete
  public static void lanchonete(){

    int produto = 0;
    double 


    Console.WriteLine("Bem vindo a Lanchonete da UCL!");
    Console.WriteLine("Código   Produto      Preço Unitário (R$)");
    Console.WriteLine("---------------------------------");
    Console.WriteLine(" 100  Cachorro quente   R$ 1,70  ");
    Console.WriteLine(" 101   Bauru Simples    R$ 2,30  ");
    Console.WriteLine(" 102   Bauru com ovo    R$ 2,60  ");
    Console.WriteLine(" 103   Hamburguer       R$ 2,40  ");
    Console.WriteLine(" 104   Cheeseburguer    R$ 2,50  ");
    Console.WriteLine(" 105   Refrigerante     R$ 1,00  ");
    Console.WriteLine("----------------------------------");

    do{
      Console.Write("Digite o código do Produto que deseja, ou 0 para fechar a compra: ");
      produto = int.Parse(Console.ReadLine());

      switch (produto){
        case 100:
        case 101:
        case 102:
        case 103:
        case 104:
        case 105:

      }

    }while(produto != 0);




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
      Console.WriteLine("      (1) Calculadora basica");
      Console.WriteLine("      (2) Lanchonete");
      Console.WriteLine("      (3) Votação");
      Console.Write("      (4) Sair\n-> ");

      op = int.Parse(Console.ReadLine());
      
      switch (op){

        case 1:
          calcBasica();
          break;
        case 2:
          lanchonete();
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