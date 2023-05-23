using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün İsmi Geçersiz";

        public static string ProductsListed = "Ürünler Listelendi";
        public static string MaintenanceTime = "Sistem Bakımda";
        public static string ProductCountOfCategoryError="Maksimum 10 Adet kayıt edilebilir.";
        public static string ProductNameAlreadyExists="Bu isimde ürün zaten başka bir ürün var.";
        public static string CategoryLimitExceded="Kategori limiti aşıldığı için yeni ürün eklenemiyor";
        public static string AuthorizationDenied="Yetkiniz yok.";
        public static string UserRegistered="Kayıt olundu.";
        public static string UserNotFound="Kullanıcı bulunamadı.";
        public static string PasswordError="Parola hatalı";
        public static string SuccessfulLogin = "Giriş başarılı.";
        public static string UserAlreadyExists= "Kullanıcı mevcut.";
        public static string AccessTokenCreated="Token oluşturuldu.";
    }
}
