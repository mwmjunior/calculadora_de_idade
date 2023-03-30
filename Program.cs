// Programa recebe o ano do nascimento de uma pessoa e calcula a idade dessa pessoa em anos e semanas.

Console.WriteLine (@$"
|--------------------------------------------------------------------------------------------------|
|                 Programa para calcular a idade de uma pessoa em anos e semanas                   |       
|--------------------------------------------------------------------------------------------------| 
");

//************************************** ENTRADA DE DADOS ********************************************//

 

//******** DECLARAÇÃO DAS VARIÁVEIS **********//
 
 float ano,idade,semanas;


Console.WriteLine($"Informe sua data de nascimento e veja sua idade em anos e semanas: ");
ano = float.Parse (Console.ReadLine());

   
//*************************************** PROCESSAMENTO DE DADOS ******************************************//
 
 idade = DateTime.Now.Year - ano;
 semanas = idade * 52;


 //*************************************** SAÍDA DE DADOS *************************************************//

 Console.WriteLine($"A sua idade completa é {idade} anos");
 Console.WriteLine($"A sua idade em semanas é {semanas} ");