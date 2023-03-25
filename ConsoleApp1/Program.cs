/*
 * 
 *      EN: Logic Programming Exercise: Car Insurance and Loan using class and Super Class concepts.
 *      PT-BR: Exercício de Lógica de Programação: Seguro de veículo e Empréstimo usando os conceitos de Classe e Super Classe.
 *
 *      Created by / Feito por: Gianluca Nunes
 *
 */

// Creating the VehIns object to store the insurance information
VehicleInsurance vehIns = new VehicleInsurance();
// Creating the loan object to store the loan information
Loan loan = new Loan();

Console.WriteLine("-=- CAR INSURANCE AND LOAN -=-\n");

// Asking the user which option he wants
Console.WriteLine("Options:\n[I] Vehicle Insurance\n[L] Loan\n");

_beggining:
Console.Write("Select a correct option: ");
string opt = Console.ReadLine().ToUpper();

// Validating the user input
if (opt != "I" && opt != "L")
{
    Console.WriteLine("\nIncorrect option! Please, try it again.\n");
    goto _beggining;
}

// Insurance form
else if (opt == "I")
{
    // Asking the user to fill the form
    Console.WriteLine("\nPlease, fill the form bellow:");

    Console.Write("\nContractor: ");
    vehIns.Contractor = Console.ReadLine();

    Console.Write("\nResponsible: ");
    vehIns.Responsible = Console.ReadLine();

_dateIns:
    // Validating the Contrac tDate
    Console.Write("\nDate: ");
    DateTime dateIns;
    if (DateTime.TryParse(Console.ReadLine(), out dateIns))
    {
        vehIns.ContractDate = dateIns;
    }

    else
    {
        Console.WriteLine("\nIncorrect date value! Please, try it again.");
        goto _dateIns;
    }

    Console.Write("\nVehicle: ");
    vehIns.Vehicle = Console.ReadLine();

_insValue:
    // Validating the Insurance Value
    Console.Write("\nInsurance value: ");
    double insValue;
    if (double.TryParse(Console.ReadLine(), out insValue))
    {
        vehIns.InsuranceValue = insValue;
    }

    else
    {
        Console.WriteLine("\nIncorrect value! Please, try it again.");
        goto _insValue;
    }

_franPrice:
    // Validating the Franchise Price
    Console.Write("\nFranchise price: ");
    double franPrice;
    if (double.TryParse(Console.ReadLine(), out franPrice))
    {
        vehIns.FranchisePrice = franPrice;
    }

    else
    {
        Console.WriteLine("\nIncorrect value! Please, try it again.");
        goto _franPrice;
    }
}

// Loan form
else if (opt == "L")
{
    // Asking the user to fill the form
    Console.WriteLine("\nPlease, fill the form bellow:");

    Console.Write("\nContractor: ");
    loan.Contractor = Console.ReadLine();

    Console.Write("\nResponsible: ");
    loan.Responsible = Console.ReadLine();

_dateLoan:
    // Validating the Contract Date
    Console.Write("\nDate: ");
    DateTime dateLoan;
    if (DateTime.TryParse(Console.ReadLine(), out dateLoan))
    {
        loan.ContractDate = dateLoan;
    }

    else
    {
        Console.WriteLine("\nIncorrect date value! Please, try it again.");
        goto _dateLoan;
    }

_loanValue:
    // Validating the Loan Value
    Console.Write("\nValue: ");
    double value;
    if (double.TryParse(Console.ReadLine(), out value))
    {
        loan.Value= value;
    }

    else
    {
        Console.WriteLine("\nIncorrect value! Please, try it again.");
        goto _loanValue;
    }

_taxesValue:
    // Validating the Taxes Value
    Console.Write("\nTaxes: ");
    double taxes;
    if (double.TryParse(Console.ReadLine(), out taxes))
    {
        loan.Taxes = taxes;
    }

    else
    {
        Console.WriteLine("\nIncorrect value! Please, try it again.");
        goto _taxesValue;
    }
}

// Asking the user if he wants to display the info at the screen
_displayInfo:
Console.WriteLine("\nDo you want to display the service details?\n[Y] Yes\n[N] No\n");
string optDisplay = Console.ReadLine().ToUpper();

// Validating the user input
if (optDisplay != "Y" && optDisplay != "N")
{
    Console.WriteLine("\nIncorrect option! Please, try it again.");
    goto _displayInfo;
}

// Displaying the info according to the user choosen option (Insurance or Loan)
else
{
    switch (optDisplay)
    {
        case "Y":
            if (opt == "I")
            {
                Console.WriteLine(vehIns.DisplayInfo());
                goto _end;
            }
            else
            {
                Console.WriteLine(loan.DisplayInfo());
                goto _end;
            }
        case "N":
            goto _end;
    }
}

// Ending the program
_end:
Console.WriteLine("\nPress space to close the program...");
Console.ReadKey();