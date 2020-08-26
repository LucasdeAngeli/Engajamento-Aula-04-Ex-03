using System;

class MainClass {
  public static void Main (string[] args) {

    int vt_nulo, vt_br, Jose_Couve, Joana_Bravo, Roberto_Nove, voto;

    Console.WriteLine("================================");
    Console.WriteLine("        TABELA DE VOTAÇÃO");
    Console.WriteLine("--------------------------------");
    Console.WriteLine("Cód -    Descrição");
    Console.WriteLine("33  - José Couve");
    Console.WriteLine("25  - Joana Bravo");
    Console.WriteLine("10  - Roberto Nove");
    Console.WriteLine("0   - Voto Branco");
    Console.WriteLine("4   - Voto Nulo");
    Console.WriteLine("================================");

    Console.WriteLine ("Informe seu voto: ");
    voto = int.Parse(Console.ReadLine());

    while (voto != 1){
      if (voto == 33){
        Jose_Couve++;
      }
      else
      if (voto == 25){
        Joana_Bravo++;
      }
      else
      if (voto == 10){
        Roberto_Nove++;
      }
      else
      if (voto == 0){
        vt_br++;
      }
      else
      if (voto == 4){
        vt_nulo++;
      }
      else{
        Console.WriteLine("Voto Inválido");
      }
    }
  }
}