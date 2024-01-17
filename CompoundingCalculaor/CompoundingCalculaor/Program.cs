using CompoundingCalculaor;

/* 
 * This example simulates the compounding of an account with initial value of 100K at 7% per year for 34 years to which we add an extra 10k per year.
 * 
 * years = how many years you plan to invest (example 34)
 * principle = initial deposit (example 100k)
 * returnRate = the amount, in %, the investement in questions returns per year (example 7%)
 * yearlyDeposit = the amount of money you plan to add to this account yearly (example 10k)
 */

Calculator calculator = new Calculator(34, 10000, 7, 10000); 

calculator.Calculate();
Console.ReadKey();