using System;
using System.Collections.Generic;
using System.Text;
using GameProject.Abstract;
using GameProject.Entities;
using MernisServiceReference;

namespace GameProject.Adapters
{
    public class MernisServiceAdapter : ICustomerCheckManager
    {
        public bool CheckUser(Member member)
        {
            KPSPublicSoapClient client = new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return client.TCKimlikNoDogrulaAsync(new TCKimlikNoDogrulaRequest(new TCKimlikNoDogrulaRequestBody(TCKimlikNo: Convert.ToInt64(member.NationalityId), Ad: member.MemberName, Soyad: member.MemberLastName, DogumYili: member.YearOfBirth))).Result.Body.TCKimlikNoDogrulaResult;
        }

        
    }
}
