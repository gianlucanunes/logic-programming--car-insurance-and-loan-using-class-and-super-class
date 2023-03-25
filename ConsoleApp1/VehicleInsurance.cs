// Creating the public class VehicleInsurance, which will inherit from the super class Service
public class VehicleInsurance : Service
{
    // Creating the class properties
    public string Vehicle { get; set; }
    public double InsuranceValue { get; set; }
    public double FranchisePrice { get; set; }

    // Creating the Display Info method, which returns the info on the screen
    public string DisplayInfo()
    {
        return $"Contractor: {Contractor}\n" +
            $"Responsible: {Responsible}\n" +
            $"Contract Date: {ContractDate:dd/MM/yyyy}\n" +
            $"Vehicle: {Vehicle}\n" +
            $"Insurance Value: {InsuranceValue:c}\n" +
            $"Franchise Price: {FranchisePrice:c}";
    }
}