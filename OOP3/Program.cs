using System.Collections.Generic;

namespace OOP3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            //personalFinanceCreditManager.Calculate();

            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            //vehicleCreditManager.Calculate();

            //interfacelerde interfaceyi implemente eden classın referans değerini tutabilir.
            //MortgageCreditManager mortgageCreditManager = new MortgageCreditManager();

            ICreditManager mortageCreditManager = new MortgageCreditManager();
            // mortageCreditManager.Calculate();


           
            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();


            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.DoApplication(new YeniKrediManager(),new List<ILoggerService>() { new SmsLoggerService(),new FileLoggerService()});
            //applicationManager.DoApplication(personalFinanceCreditManager,new DatabaseLoggerService); şeklinde de yazılabilir.

            List<ICreditManager> krediler = new List<ICreditManager>() {personalFinanceCreditManager, vehicleCreditManager };

           // applicationManager.KrediOnBilgilendirmesiYap(krediler);
        }
    }
}
