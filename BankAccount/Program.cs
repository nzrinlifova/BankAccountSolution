
using BankAccount;

public class Program
{
    public static void Main(string[] args)
    {
        Bank kapital = new Bank();

        Account nezrin = new Account(1253, "nezrin", 256);
        kapital.Add(nezrin);
        Account aysu = new Account(1919, "aysu", 10000);
        kapital.Add(aysu);
        Console.WriteLine("xos gelmisiz:");

        Console.WriteLine("\n 1.movcud musteri  \n 2. yeni musteri \n 3.accountun sayi \n 4.delete");
        int MainMenu = int.Parse(Console.ReadLine());

        switch (MainMenu)
        {
            case 1:
                Console.WriteLine("istifadeci adini daxil et");
                string OwnerName = Console.ReadLine();
                var profil = kapital.GetBankAccountByOwner(OwnerName);
                if (profil != null)
                {
                    bool AnswerUser = true;
                    while (true)
                    {
                        Console.WriteLine("istediyiniz emeliyyati secin");
                        Console.WriteLine("\n 1.Musterimelumati(displayinfo) \n 2.Deposit \n 3.withdraw \n 4.transferfund \n 0.quitapplication \n 5.esas menyuya qayit  ");
                        int menu = int.Parse(Console.ReadLine());
                        switch (menu)
                        {
                            case 1:
                                aysu.DisplayAccountInfo();
                                break;
                            case 3:
                                Console.WriteLine("ne qeder pul cixarmaq isteyersiniz?");
                                decimal withdraw = Convert.ToDecimal(Console.ReadLine());
                                aysu.Withdraw(withdraw);
                                break;
                            case 2:
                                Console.WriteLine("ne qeder pul elave etmek isteyirsiz?");
                                decimal deposit = Convert.ToDecimal(Console.ReadLine());
                                aysu.Deposit(deposit);
                                break;
                            case 4:
                                Console.WriteLine("gondermek istediyini istifadecinin adi:");
                                string qebuleden = Console.ReadLine();
                                var data = kapital.GetBankAccountByOwner(qebuleden);
                                if (data == null)
                                {
                                    Console.WriteLine("account tapilmadi");
                                }
                                else
                                {
                                    Console.WriteLine("kocurmek istediyin meblegi daxil edin");
                                    decimal kocurulecekmebleg = int.Parse(Console.ReadLine());
                                    profil.TransferFunds(data, kocurulecekmebleg);
                                    profil.Withdraw(kocurulecekmebleg);
                                }

                                break;
                            case 5:
                                Console.WriteLine("ANA MENUYDASIZ");
                                AnswerUser = false;
                                break;

                            case 0:
                                Console.WriteLine("proqram baglandi");
                                return;
                            default:
                                Console.WriteLine("secdiyni emmeliyyat men yuda yoxdu");
                                break;
                        }

                    }
                }
                else
                {
                    Console.WriteLine("bele bir istifadeci yoxdu");
                }
                break;
            case 2:
                Console.WriteLine("musteri nomrenizi yazin");
                int accuntNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("musteri adinizi yazin");
                string ownerName = Console.ReadLine();
                Console.WriteLine("balansi elave edin");
                decimal Balance = decimal.Parse(Console.ReadLine());
                kapital.Add(new Account(accuntNumber, ownerName, Balance));
                break;
            case 3:
                kapital.GetBankAccountsCount();
                break;
            case 4:
                Console.WriteLine("silmek istediyiniz accountun adin yazin");
                string DeleteName = Console.ReadLine();
                kapital.DeleteBankAccount(DeleteName);

                break;
        }




    }
}