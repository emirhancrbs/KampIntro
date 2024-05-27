using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    //birisi bu interfaceyi kullanırsa kullanılan yerde interfacenin içindeki methodları içermek zorunda
    //interface yazım kuralı : Iile başlatmak zorundasın.
    //interfaceler genellikle operasyonel metodlarda kullanılır
    //interfaceler newlenemez!!!!!
    //IcreditManager bizim için referans tutsun diye ve aynı zamanda tüm kredi tiplerinin uygulaması zorunlu isteniler operasyonları tutsun diye bu interfaceyi oluşturduk
    //interfacenin içindeki operasyonlar alternatif sistemler için bir şablon ve referans tutucu görevi görür
    //interfaceleri birbirinin alternatifi olan ama kod içerikler ifarklı olan durumlar için kullanırız.
    interface ICreditManager
    {
        void Calculate();
        void BişeyYap();  
        
    }
}
