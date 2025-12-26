using System;
class BonusSalary{
    public static int[,] GenerateData(){


        Random random = new Random();
        int[,] data = new int[10, 2]; 
        for (int i = 0; i < 10; i++){
            data[i, 0] = random.Next(10000, 100000);
            data[i, 1] = random.Next(1, 11);
        }
        return data;
    }

    public static double[,] Bonus(int[,] data){
        //oldSalary, years
        double[,] result = new double[10, 3]; 
        for (int i = 0; i < 10; i++){
            double bonusRate = data[i, 1] > 5 ? 0.05 : 0.02;
            double bonus = data[i, 0] * bonusRate;
            double newSalary = data[i, 0] + bonus;

            //oldSalary, bonus, newSalary
            result[i, 0] = data[i, 0];
            result[i, 1] = bonus;
            result[i, 2] = newSalary;
        }
        return result;
    }

    public static void Main(string[] args){
        int[,] employe = GenerateData();
        double[,] ans = Bonus(employe);
        double totalOld = 0, totalBonus = 0, totalNew = 0;
        Console.WriteLine("OldSalary\tBonus\tNewSalary");

        for (int i = 0; i < 10; i++){
            Console.WriteLine(
                ans[i, 0] + "\t" +
                ans[i, 1] + "\t" +
                ans[i, 2]
            );

            //total
            totalOld += ans[i, 0];
            totalBonus += ans[i, 1];
            totalNew += ans[i, 2];
        }

        //output
        Console.WriteLine("Total Old Salary: " + totalOld);
        Console.WriteLine("Total Bonus: " + totalBonus);
        Console.WriteLine("Total New Salary: " + totalNew);
    }
}
