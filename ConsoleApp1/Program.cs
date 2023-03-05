SeguroVeiculo seg = new SeguroVeiculo();
Emprestimo emp = new Emprestimo();


Console.WriteLine("Opções:\n[S] Seguro Veicular\n[E] Empréstimo\n\n");

_inicio:
Console.Write("Selecione a opção desejada: ");
string opc = Console.ReadLine().ToUpper();

if (opc != "S" && opc != "E")
{
    Console.WriteLine("\nOpção inválida! Tente novamente!\n");
    goto _inicio;
}
else if (opc == "S")
{
    Console.WriteLine("\nPreencha os dados abaixo:");

    Console.Write("\nContratante: ");
    seg.Contratante = Console.ReadLine();

    Console.Write("\nResponsável: ");
    seg.Responsavel = Console.ReadLine();

_data:
    Console.Write("\nData: ");
    DateTime data;
    if (DateTime.TryParse(Console.ReadLine(), out data))
    {
        seg.DataContrato = data;
    }
    else
    {
        Console.WriteLine("\nERRO: Valor de data inválido! Tente novamente!\n");
        goto _data;
    }

    Console.Write("\nVeículo: ");
    seg.Veiculo = Console.ReadLine();

_precoS:
    Console.Write("\nPreço do seguro: ");
    double precoSeg;
    if (double.TryParse(Console.ReadLine(), out precoSeg))
    {
        seg.PrecoSeguro = precoSeg;
    }
    else
    {
        Console.WriteLine("\nERRO: Valor inválido! Tente novamente!\n");
        goto _precoS;
    }

_precoF:
    Console.Write("\nPreço da franquia: ");
    double precoFra;
    if (double.TryParse(Console.ReadLine(), out precoFra))
    {
        seg.PrecoFranquia = precoFra;
    }
    else
    {
        Console.WriteLine("\nERRO: Valor inválido! Tente novamente!\n");
        goto _precoF;
    }
}

else if (opc == "E")
{
    Console.WriteLine("\nPreencha os dados abaixo:");

    Console.Write("\nContratante: ");
    emp.Contratante = Console.ReadLine();

    Console.Write("\nResponsável: ");
    emp.Responsavel = Console.ReadLine();

_data:
    Console.Write("\nData: ");
    DateTime data;
    if (DateTime.TryParse(Console.ReadLine(), out data))
    {
        emp.DataContrato = data;
    }
    else
    {
        Console.WriteLine("\nERRO: Valor de data inválido! Tente novamente!\n");
        goto _data;
    }

_precoV:
    Console.Write("\nValor: ");
    double valor;
    if (double.TryParse(Console.ReadLine(), out valor))
    {
        emp.Valor = valor;
    }
    else
    {
        Console.WriteLine("\nERRO: Valor inválido! Tente novamente!\n");
        goto _precoV;
    }

_precoT:
    Console.Write("\nTaxa: ");
    double taxa;
    if (double.TryParse(Console.ReadLine(), out taxa))
    {
        emp.Taxa = taxa;
    }
    else
    {
        Console.WriteLine("\nERRO: Valor inválido! Tente novamente!\n");
        goto _precoT;
    }
}

_imprimir:
Console.WriteLine("\nDeseja imprimir o serviço na tela?\n[S] Sim\n[N] Não\n");
string opc2 = Console.ReadLine().ToUpper();

if (opc2 != "S" && opc2 != "N")
{
    Console.WriteLine("\nERRO: Opção inválida! Tente novamente!\n");
    goto _imprimir;
}
else
{
    switch (opc2)
    {
        case "S":
            if (opc == "S")
            {
                Console.WriteLine(seg.ExibirDados());
                goto _fim;
            }
            else
            {
                Console.WriteLine(emp.ExibirDados());
                goto _fim;
            }

        case "N":
            goto _fim;

    }
}

_fim:
Console.WriteLine("\nTecle espaço para continuar...");
Console.ReadKey();
