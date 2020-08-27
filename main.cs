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
    Console.Write("Digite o caractere referente a opção desejada: ");
    operacao = char.Parse(Console.ReadLine());
    
    switch (operacao){

      case '+':
        Console.WriteLine("A soma dos dois numeros digitados é {0}", (num1 + num2));
        break;
      case '-':
        Console.WriteLine("A subtração dos dois numeros digitados é {0}", (num1 - num2));
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
    double valor_Apagar = 0;

    Console.WriteLine("\tBem vindo a Lanchonete da UCL!");
    Console.WriteLine("\tCódigo   Produto      Preço Unitário (R$)");
    Console.WriteLine("\t---------------------------------");
    Console.WriteLine("\t 100  Cachorro quente   R$ 1,70  ");
    Console.WriteLine("\t 101   Bauru Simples    R$ 2,30  ");
    Console.WriteLine("\t 102   Bauru com ovo    R$ 2,60  ");
    Console.WriteLine("\t 103   Hamburguer       R$ 2,40  ");
    Console.WriteLine("\t 104   Cheeseburguer    R$ 2,50  ");
    Console.WriteLine("\t 105   Refrigerante     R$ 1,00  ");
    Console.WriteLine("\t----------------------------------");

    do{
      Console.Write("Digite o código do Produto que deseja, ou 0 para fechar a compra: ");
      produto = int.Parse(Console.ReadLine());

      switch (produto){
        case 100:
          valor_Apagar += 1.70;
          break;
        case 101:
          valor_Apagar += 2.30;
          break;
        case 102:
          valor_Apagar += 2.60;
          break;
        case 103:
          valor_Apagar += 2.40;
          break;
        case 104:
          valor_Apagar += 2.50;
          break;
        case 105:
          valor_Apagar += 1.00;
          break;
        case 0:
          Console.WriteLine("Compra fechada!");
          break;
        default:
          Console.WriteLine("Codigo de produto invalido, digite novamente...");
          break;
      }

    }while(produto != 0);

    Console.WriteLine("O valor a pagar do seu lanche é R${0}",valor_Apagar);
  }

  //votacao
  public static void urnaVotos(){

    int cand_1,cand_2,cand_3,vt_brancos, vt_nulos, voto;
    char op = 'Y';
    cand_1 = cand_2 = cand_3 = vt_brancos = vt_nulos = 0;

    do{
      
      Console.WriteLine("Digite o numero correspondente ao voto desejado:");
      Console.WriteLine(" 33 - José Couve");
      Console.WriteLine(" 25 - Joana Bravo");
      Console.WriteLine(" 10 - Roberto Nove");
      Console.WriteLine(" 0 - Voto branco");
      Console.WriteLine(" 4 - Voto nulo");
      voto = int.Parse(Console.ReadLine());
      Console.Clear();
      
      if(voto == 33)
        cand_1++;
      else if(voto == 25)
        cand_2++;
      else if(voto == 10)
        cand_3++;
      else if(voto == 0)
        vt_brancos++;
      else if(voto == 4)
        vt_nulos++;
      
      Console.WriteLine("Sessão encerrada, pressione Y/y caso tenha outro eleitor ou N/n para encerrar a votação ");
      op = char.Parse(Console.ReadLine()); 

    }while(op == 'Y' || op == 'y');

    if(cand_1 >= cand_2 && cand_1 >=cand_2)
      Console.WriteLine("O Candidato José Couve ganhou a votação com {0} votos", cand_1);
    else if(cand_2 >= cand_1 && cand_2 >= cand_3)
      Console.WriteLine("A Candidata Joana Bravo ganhou a votação com {0} votos", cand_2);
    else if(cand_3>=cand_1 && cand_3>=cand_2)
      Console.WriteLine("O Candidato Roberto Nove ganhou a votação com {0} votos", cand_3);
    
    Console.WriteLine("Houve um total de {0} votos nulos e {1} votos brancos", vt_nulos, vt_brancos);


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
          Console.Clear();
          calcBasica();
          break;
        case 2:
          Console.Clear();
          lanchonete();
          break;
        case 3:
        Console.Clear();
          urnaVotos();
          break;
        case 4:
          repeat = false;
          break;
        default:
          Console.WriteLine("Opcao incorreta!");
          break;
      }
      Console.WriteLine("\nPressione qualquer tecla para continuar...");
      Console.ReadKey(true);//para esperar o usuario digitar uma tecla para continuar
      Console.Clear();//limpa tela
    }
  }
}