using Core.Entities.Concrete;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constans
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün Eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        internal static string ProductsListed = "ürün Listelendi!";
        internal static string MaintenanceTime ="Bakımdayız!";
        public static string ProductCountOfCategoryError = "Ürünün kategorisinde en fazla 10 ürün olmalıdır!";
        public static string ProductNameAlredyExists = "Aynı isimde başka bir ürün ekleyemezsiniz";
        public static string CategoryLimitExists = "Kategori sayısı 15'i aşmıştır.";
        public static string AuthorizationDenied = "Bu işlemi yapmanız için gereken yetkiniz yok!";
        internal static string UserRegistered;
        internal static User UserNotFound;
        internal static User PasswordError;
        internal static string SuccessfulLogin;
        internal static string UserAlreadyExists;
        internal static string AccessTokenCreated;
    }
}
