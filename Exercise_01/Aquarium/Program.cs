using System;

namespace Aquarium
{
    class Program
    {
        static void Main(string[] args)
        {
            double PercentageDivider = 100;
            double qubSmToQubDmsDevider = 0.001;
            int lenghtInSm = int.Parse(Console.ReadLine());
            int widthInSm = int.Parse(Console.ReadLine());
            int heightInSm = int.Parse(Console.ReadLine());
            double percentageOfAccsesories = double.Parse(Console.ReadLine());

            Double totalLittersInQubSms = lenghtInSm * widthInSm * heightInSm;
            double totalLittersInQubDms = totalLittersInQubSms * qubSmToQubDmsDevider;
            double totalInLitters = totalLittersInQubDms;

            double accessoriesInPercentage = percentageOfAccsesories / PercentageDivider;
            double accessoriesVolume = totalInLitters * accessoriesInPercentage;

            double waterVolume = totalInLitters - accessoriesVolume;
            Console.WriteLine(waterVolume);

        }
    }
}
