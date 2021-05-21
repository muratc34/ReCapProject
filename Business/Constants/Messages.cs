using Core.Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        public static string BrandAdded = "Marka eklendi.";
        public static string BrandNotAdded = "Marka eklenemedi.";
        public static string BrandUpdated = "Marka güncellenemedi.";
        public static string BrandNotUpdated = "Marka güncellendi.";
        public static string BrandDeleted = "Marka silindi.";
        public static string BrandListed = "Markalar listelendi.";

        public static string CarNotAdded = "Araç eklenemedi.";
        public static string CarAdded = "Araç eklendi.";
        public static string CarUpdated = "Araç güncellendi.";
        public static string CarDeleted = "Araç silindi.";
        public static string CarsListed = "Araçlar listelendi";

        public static string ColorAdded = "Renk eklendi.";
        public static string ColorUpdated = "Renk güncellendi.";
        public static string ColorDeleted = "Renk silindi.";
        public static string ColorsListed = "Renkler listelendi.";

        public static string UserAdded = "Kullanıcı eklendi.";
        public static string UserDeleted = "Kullanıcı silindi.";
        public static string UserUpdated = "Kullanıcı güncellendi.";
        public static string UsersListed = "Kullanıcılar listelendi.";

        public static string CustomerAdded = "Müşteri eklendi.";
        public static string CustomerDeleted = "Müşteri silindi.";
        public static string CustomerUpdated = "Müşteri güncellendi.";
        public static string CustomersListed = "Müşteriler listelendi.";

        public static string RentalAdded = "Kiralık araba eklendi.";
        public static string RentalNullReturnDate = "Kiralık araba eklenemedi çünkü araba kiralanmış ve teslim edilmemiş.";
        public static string RentalDeleted = "Kiralık araba silindi.";
        public static string RentalUpdated = "Kiralık araba güncellendi.";
        public static string RentalListed = "Kiralık arabalar listelendi.";

        public static string ImageLimitExceded = "Bu araç için eklenebilecek resim limitine ulaşıldı.";
        public static string ImageAdded = "Resim eklendi.";
        public static string ImageDeleted = "Resim silindi.";
        public static string ImageUpdate = "Resim güncellendi.";

        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Bu kullanıcı zaten mevcut";
        public static string UserRegistered = "Kullanıcı başarıyla kayıt edildi";
        public static string AccessTokenCreated= "Access Token başarıyla oluşturuldu";
    }
}
