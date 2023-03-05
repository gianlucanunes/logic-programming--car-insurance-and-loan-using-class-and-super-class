public class Emprestimo : Servico
{
    public double Valor { get; set; }
    public double Taxa { get; set; }

    public string ExibirDados()
    {
        return $"Contratante: {Contratante}\n" +
            $"Responsável: {Responsavel}\n" +
            $"Data do contrato: {DataContrato:dd/MM/yyyy}\n" +
            $"Valor: {Valor:c}\n" +
            $"Taxa: {Taxa:c}";
    }
}