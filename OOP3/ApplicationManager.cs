using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{

    class ApplicationManager
    {
        //ICreditManager Bütün CreditManagerlerin referansını tutabildiği için böyle bir kullanım yaptık.
        //Method injection yapıyoruz =>DoApplication(ICreditManager creditManager,ILoggerService loggerService)
        public void DoApplication(ICreditManager creditManager,List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme
            //Aşağıdaki kullanım yanlış kullanım
            //MortgageCreditManager mortgageCreditManager = new MortgageCreditManager();
            //mortgageCreditManager.Calculate();

            //Bu doğru bir kullanımdır
            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }
        public void KrediOnBilgilendirmesiYap(List<ICreditManager> krediler) 
        {
            foreach (var item in krediler)
            {
                item.Calculate();
            }
        }
    }
}
