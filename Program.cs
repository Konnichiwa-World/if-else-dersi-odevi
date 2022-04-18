using System;namespace if_else_dersi
{class Program
    {static void Main(string[] args)
    {float pi=22/7; Console.WriteLine("Geometrik şekillerin hacim/çevre ve alanlarini bulma programina hosgeldiniz.\n Lütfen Önce Şekli Seçiniz. \n 1- Ucgen 2-Kare 3-Küp 4-Daire 5-Silindir 6- İsyanqar26"); float x =float.Parse(Console.ReadLine());
if(x==1){System.Console.WriteLine("Lütfen sırasıyla yukseklik ve taban giriniz:"); float a = float.Parse(Console.ReadLine()); float b = float.Parse(Console.ReadLine()); System.Console.WriteLine("Ucgenin Alani:" + Convert.ToString(a*b/2) + "Ucgenin yuzeyi: bu kadar veri yetersiz, kenar uzunlukları verilmeliydi.");}
if(x==2){System.Console.WriteLine("Lütfen yukseklik belirtiniz:");Int32 c =Int32.Parse(Console.ReadLine()); System.Console.WriteLine("Karenin Alani" + c*c + " " + "Karenin hacmi:" + 4*c);};
if(x==3){System.Console.WriteLine("Lütfen yukseklik giriniz:");float d =float.Parse(Console.ReadLine());System.Console.WriteLine("Kupun Hacmi:" + d*d*d + " " + "Karenin yüzeyi:" + 6*d*d);};
if(x==4){System.Console.WriteLine("Lutfen sadece yaricap giriniz:");float e =float.Parse(Console.ReadLine());System.Console.WriteLine("Dairenin Alani:" + pi*e*e + " " + "Dairenin Çevresi" + 2*pi*e);};
if(x==5){System.Console.WriteLine("Lütfen sirasiyla yükseklik ve yaricap giriniz:");float f = float.Parse(Console.ReadLine());float g =float.Parse(Console.ReadLine());
System.Console.WriteLine("Silindirin Hacmi:" + pi*f*f*g + " " + "Silindirin yüzeyi:" + (2*2*pi*g*g)+(f*2*pi*g));}
if(x==6) {System.Console.WriteLine("https://www.youtube.com/watch?v=LR_PVLdDe4o");};}}}
