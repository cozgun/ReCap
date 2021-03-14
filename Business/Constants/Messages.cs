using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        // public değişkenler PascalCase olmalı
        public static string CarAdded = "Araba eklendi";
        public static string CarNameInvalid = "Araba ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakımda";
        public static string CarsListed = "Arabalar listelendi";
        public static string RentalsListed = "Kiralanmış arabalar listelendi";
        public static string CustomerAdded = "Müşteri eklendi";
        public static string CustomerNameInvalid = "Müşteri ismi geçersiz";
        public static string CustomersListed = "Müşteriler listelendi";
        public static string RentalAdded = "Kiralık araç eklendi";
        public static string RentalInvalid = "Bu araç zaten kiralanmış durumda";
        public static string MaxImageLimitReached = "Yüklenebilecek maksimum görsel adedine ulaşılmış";
        public static string CarImageAdded = "Araç görseli eklendi";
        public static string CarImagesListed = "Araç görselleri listelendi";
        public static string AuthorizationDenied = "Yetkiniz yok.";
        public static string UserRegistered = "Kullanıcı kaydedildi";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Login başarılı";
        public static string UserAlreadyExists = "Kullanıcı zaten mevcut";
        public static string AccessTokenCreated = "Token oluşturuldu";
    }
}
