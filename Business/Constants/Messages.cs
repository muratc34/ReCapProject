using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public class Messages
    {
        internal static string BrandAdded = "Marka eklendi.";
        internal static string BrandNotAdded = "Marka eklenemedi.";
        internal static string BrandUpdated = "Marka güncellenemedi.";
        internal static string BrandNotUpdated = "Marka güncellendi.";
        internal static string BrandDeleted = "Marka silindi.";
        internal static string BrandListed = "Markalar listelendi.";

        internal static string CarNotAdded = "Araç eklenemedi.";
        internal static string CarAdded = "Araç eklendi.";
        internal static string CarUpdated = "Araç güncellendi.";
        internal static string CarDeleted = "Araç silindi.";
        internal static string CarsListed = "Araçlar listelendi";

        internal static string ColorAdded = "Renk eklendi.";
        internal static string ColorUpdated = "Renk güncellendi.";
        internal static string ColorDeleted = "Renk silindi.";
        internal static string ColorsListed = "Renkler listelendi.";

        internal static string UserAdded = "Kullanıcı eklendi.";
        internal static string UserDeleted = "Kullanıcı silindi.";
        internal static string UserUpdated = "Kullanıcı güncellendi.";
        internal static string UsersListed = "Kullanıcılar listelendi.";

        internal static string CustomerAdded = "Müşteri eklendi.";
        internal static string CustomerDeleted = "Müşteri silindi.";
        internal static string CustomerUpdated = "Müşteri güncellendi.";
        internal static string CustomersListed = "Müşteriler listelendi.";

        internal static string RentalAdded = "Kiralık araba eklendi.";
        internal static string RentalNullReturnDate = "Kiralık araba eklenemedi çünkü araba kiralanmış ve teslim edilmemiş.";
        internal static string RentalDeleted = "Kiralık araba silindi.";
        internal static string RentalUpdated = "Kiralık araba güncellendi.";
        internal static string RentalListed = "Kiralık arabalar listelendi.";
    }
}
