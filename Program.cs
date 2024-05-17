decimal distancia, calculo, tempo;

Console.WriteLine(">>>>ATIVIDADE RAIO E TROVÃO<<<<<\n");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("Digite a quantos segundos você ouviu o trovão:");
Console.ResetColor();


tempo = Convert.ToInt32(Console.ReadLine());
calculo = Convert.ToDecimal(340.29);

distancia = tempo * calculo;

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine($"A distância do raio que voce ouviu é de {distancia}KM ");
Console.ResetColor();


