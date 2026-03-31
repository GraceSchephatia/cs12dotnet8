// TimesTable(7,20);

ConfigureConsole(culture:"fr-FR");
//ConfigureConsole(useComputerCulture: true);

decimal taxToPay = CalculateTax(amount: 149, twoLetterRegionCode: "CA");
WriteLine($"You must pay {taxToPay:C} in tax.");