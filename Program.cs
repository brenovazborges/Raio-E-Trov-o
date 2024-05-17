decimal distancia, calculo, tempo;

Console.ForegroundColor = ConsoleColor.Yellow;
Console.BackgroundColor = ConsoleColor.Gray;
Console.WriteLine(">>>>ATIVIDADE RAIO E TROVÃO<<<<<\n");
Console.ResetColor();

Console.ForegroundColor = ConsoleColor.Blue;
Console.Write("Digite a quantos segundos você ouviu o trovão:");
Console.ResetColor();


tempo = Convert.ToInt32(Console.ReadLine());
calculo = Convert.ToDecimal(340.29);

distancia = tempo * calculo;

Console.ForegroundColor = ConsoleColor.DarkCyan;
Console.WriteLine($"A distância que voce ouviu o raio é de {distancia}KM ");
Console.ResetColor();


