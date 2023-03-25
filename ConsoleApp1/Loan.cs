// Creating the public class Loan, which will inherit from the super class Service
public class Loan : Service
{
    // Creating the class properties
    public double Value { get; set; }
    public double Taxes { get; set; }

    // Creating the Display Info method, which returns the info on the screen
    public string DisplayInfo()
    {
        return $"Contractor: {Contractor}\n" +
            $"Responsible: {Responsible}\n" +
            $"Contract Date: {ContractDate:dd/MM/yyyy}\n" +
            $"Value: {Value:c}\n" +
            $"Taxes: {Taxes:c}";
    }
}