# PolimorfizmDemo

** Polimorfizm adındanda anşalacağı gibi çokşekillilik sağlar.Çokşekilliği ,aşağıdaki kod üzerinden anlatacak olursak.Bir ana sınıfımız var,birde bu ana sınıftan türetilmiş aynı seviyede alt sınıflar var.Örneğin kodda ingiliz ve fransız sınıfları var.Her ikisininde selam ver metodu var.Fakat selam vermeleri farklı dilde.İşte her alt sınıf ana sınıfının metodunu kendine göre tekrar yazması,
düzenlemesi çokçeşitlilik sayesinde olur. **


```C#
Kod:
using System;
using System.Collections.Generic;
using System.Text;

namespace PolimorfizmOrnek1
{
    class insan 
    {
        public virtual void selamver() {
            Console.WriteLine("ugu");
        }
    }
    class fransız : insan {
        public override void selamver() {
            Console.WriteLine("bonjour");
        }
    }

    class ingiliz : insan
    {
        public override void selamver()
        {
            Console.WriteLine("Hi");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ingiliz ing = new ingiliz();
            ing.selamver();
            Console.Read();
        }
    }
}
```
