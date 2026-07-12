public static class Tournament
{   
    public static void Tally(Stream inStream, Stream outStream)
    {
        using var reader = new StreamReader(inStream);
        string input = reader.ReadToEnd();

        string[] jogos = input.Split('\n', StringSplitOptions.RemoveEmptyEntries);
        string tabela = $"{"Team",-30} | {"MP",2} | {"W",2} | {"D",2} | {"L",2} | {"P",2}\n";

        Dictionary<string, int[]> estatisticas = new();


        for (var i = 0; i < jogos.Length; i++)
        {
            string[] jogoAtual = jogos[i].Split(";");
            string time1 = jogoAtual[0];
            string time2 = jogoAtual[1];
            string resultado = jogoAtual[2];

            if (!estatisticas.ContainsKey(time1))
                estatisticas.Add(time1, new int[5]);

            if (!estatisticas.ContainsKey(time2))
                estatisticas.Add(time2, new int[5]);

            estatisticas[time1][0] += 1;
            estatisticas[time2][0] += 1;

            if (resultado == "win")
            {
                estatisticas[time1][1] += 1;
                estatisticas[time1][4] += 3;
                estatisticas[time2][3] += 1;
            }
            else if (resultado == "loss")
            {
                estatisticas[time1][3] += 1;
                estatisticas[time2][1] += 1;
                estatisticas[time2][4] += 3;
            }
            else if (resultado == "draw")
            {
                estatisticas[time1][2] += 1;
                estatisticas[time1][4] += 1;
                estatisticas[time2][2] += 1;
                estatisticas[time2][4] += 1;
            }
        }

        var ordenado = estatisticas
            .OrderByDescending(item => item.Value[4]);

        foreach (var item in ordenado)
        {
            int partidas = item.Value[0];
            int vitorias = item.Value[1];
            int empates = item.Value[2];
            int derrotas = item.Value[3];
            int pontos = item.Value[4];

            tabela += $"{item.Key,-30} | {partidas,2} | {vitorias,2} | {empates,2} | {derrotas,2} | {pontos,2}\n";
        }

        using var writer = new StreamWriter(outStream, leaveOpen: true);
        writer.Write(tabela.TrimEnd('\n'));
    }
}
