using System;
namespace CompoundingCalculaor
{
	public class Calculator
	{
        byte years;
        decimal principle;
        decimal returnRate;
        decimal yearlyDeposit;

        byte yearsPast;
        decimal totalInvested;
        decimal balance;

        public Calculator(byte years=10, decimal principle=100000, decimal returnRate=7, decimal yearlyDeposit=10000)
		{
            this.years = years;
            this.principle = principle;
            this.returnRate = returnRate;
            this.yearlyDeposit = yearlyDeposit;
            yearsPast = 0;
            totalInvested = principle;
            balance = principle;
		}

        public void Calculate()
        {
            while (yearsPast < years)
            {
                totalInvested += yearlyDeposit;
                balance = (balance * (1 + returnRate / 100)) + yearlyDeposit;
                yearsPast++;
                Write();
            }
        }

        public void Write()
        {
            Console.WriteLine($"Year #{yearsPast}\n" +
                $"Total Invested: {totalInvested}\n" +
                $"Profit %: {(100 * balance) / totalInvested }\n" +
                $"Balance: {balance}\n");
        }
	}
}

