using System;
class HelloWorld {
  static void Main() {
     
      int classe;
    
    Console.WriteLine("Escolha uma classe:");
    Console.WriteLine("1. Guerreira");
    Console.WriteLine("2. Mago");
    Console.WriteLine("3. Arqueira");
    classe = int.Parse(Console.ReadLine());
    
    switch (classe) {
        
       case 1:
        Console.WriteLine( "As habilidades especiais dessa classe são: Ataque Pesado, Defesa Total");
       break;
       
       case 2:
       Console.WriteLine( "As habilidades especiais dessa classe são: Bola de Fogo, Escudo de Gelo");
       break;
       
       case 3:
       Console.WriteLine( "As habilidades especiais dessa classe são: Flecha Precisa, Disparo Triplo");
       break;
       
       default:
        Console.WriteLine( "Opção inválida");
       break;
      
    }
    
      
  }
}