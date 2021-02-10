using System;
using GameProject.Entities;
using GameProject.Concrete;
using GameProject.Abstract;
using GameProject.Adapters;
namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n ******* Kullanıcı İşlemleri ******* \n");
            Member member = new Member() {MemberId=1,MemberName="ENES" ,MemberLastName="DERE",NationalityId="46924800654",YearOfBirth=1997 };
            BaseMemberManager baseMemberManager = new PubgMemberManager(new MernisServiceAdapter());
            baseMemberManager.Add(member);

            Console.WriteLine("\n ******* Oyun İşlemleri *******\n");
            Game game = new Game() { GameId=1,GameName="Pubg",GamePrice=100};
            GameManager gameManager = new GameManager();
            gameManager.Add(game);
            gameManager.Delete(game);
            gameManager.Update(game);

            Console.WriteLine("\n******* Kampanya İşlemleri *******\n");
            Campaign campaign = new Campaign() { CampaignId = 1, DateOfFinish =new DateTime(2021, 03, 16), DateOfStarts=new DateTime(2021,03,01),PersentageOfDiscount=30 };
            CampaignManager campaignManager = new CampaignManager();
            campaignManager.Add(campaign);
            campaignManager.Delete(campaign);
            campaignManager.Update(campaign);

            Console.WriteLine("\n******* Satış İşlemleri *******\n");
            Sale sale = new Sale() { SaleId=1,DateOfSale=new DateTime(DateTime.Today.Year,DateTime.Today.Month,DateTime.Today.Day)};
            SaleManager saleManager = new SaleManager();
            saleManager.Sale(member, game);

            Console.WriteLine("\n//////////////////////////  İYİ  GÜNLER  ////////////////////\n");

        }
    }
}
