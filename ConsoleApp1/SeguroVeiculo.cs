public class SeguroVeiculo : Servico
{
    public string Veiculo { get; set; }
    public double PrecoSeguro { get; set; }
    public double PrecoFranquia { get; set; }

    public string ExibirDados()
    {
        return $"Contratante: {Contratante}\n" +
            $"Responsável: {Responsavel}\n" +
            $"Data do contrato: {DataContrato:dd/MM/yyyy}\n" +
            $"Veículo: {Veiculo}\n" +
            $"Preço do Seguro: {PrecoSeguro:c}\n" +
            $"Preço da Franquia: {PrecoFranquia:c}";
    }

}

