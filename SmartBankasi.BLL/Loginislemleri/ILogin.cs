using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartBankasi.BLL.Loginislemleri
{
    interface ILogin
    {
        bool Login(string kullaniciAdi, string kullanicisifre);
    }
}
