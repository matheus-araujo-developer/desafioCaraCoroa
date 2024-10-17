    int numMoedas = 50;
    bool[] moedas = new bool[numMoedas];

    for (int i = 0; i < numMoedas; i++)
    {
        moedas[i] = true;
    }

    for (int pessoa = 1; pessoa <= numMoedas; pessoa++)
    {
        for (int moeda = pessoa - 1; moeda < numMoedas; moeda += pessoa)
        {
                moedas[moeda] = !moedas[moeda];
        }
    }

    Console.WriteLine("Estado final das moedas:");
    for (int i = 0; i < numMoedas; i++)
    {
            Console.WriteLine($"Moeda {i + 1}: {(moedas[i] ? "Cara" : "Coroa")}");
    }