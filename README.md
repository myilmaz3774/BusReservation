# 🚌 Otobüs Bilet Rezervasyon Sistemi (N-Tier Architecture)

Bu proje, C# programlama dili ve MSSQL veritabanı kullanılarak geliştirilmiş, **Katmanlı Mimari (N-Tier Architecture)** prensiplerine tam uyumlu bir masaüstü biletleme otomasyonudur.

## 🎯 Proje Amacı
Otobüs firmalarının bilet satış süreçlerini, müşteri kayıtlarını ve sefer takibini modüler, bakımı kolay ve genişletilebilir bir yazılım mimarisiyle dijitalleştirmek.

## 🏗️ Kullanılan Teknolojiler ve Mimari
Proje, kod tekrarını önlemek ve test edilebilirliği artırmak için 4 ana katmana ayrılmıştır:
* **Entity Layer:** Veritabanı tablolarının nesne karşılıkları (Customer, Ticket, BusTrip).
* **Data Access Layer (DAL):** ADO.NET ile SQL Server CRUD (Ekle/Sil/Güncelle/Listele) işlemleri.
* **Business Layer (BLL):** Biletleme kısıtlamaları ve veri doğrulama işlemleri (Örn: Koltuk sınırı kontrolleri).
* **UI Layer:** Windows Forms (Kullanıcı etkileşimi).

## 🚀 Öne Çıkan Özellikler
* N-Tier mimarisi sayesinde veritabanı bağımsızlığının temellerinin atılması.
* Güvenli veri ekleme (SQL Injection korumalı `SqlParameter` kullanımı).
* Hata yakalama (Exception Handling) ile iş katmanından arayüze anlamlı mesajların iletilmesi.

## 💻 Kurulum
1. `Database` klasöründeki `script.sql` dosyasını SQL Server'da çalıştırarak `BusReservationDB` veritabanını oluşturun.
2. `DataAccessLayer` içerisindeki `TicketDAL.cs` dosyasında bulunan `connString` değişkenini kendi yerel SQL sunucunuza göre güncelleyin.
3. Çözümü (Solution) Visual Studio'da derleyin ve çalıştırın.
