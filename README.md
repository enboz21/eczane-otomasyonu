# Eczane Stok Takip Sistemi

Bu proje, C# dili, .NET platformu, Katmanlı Mimari ve SOLID prensipleri kullanılarak geliştirilmiş bir masaüstü eczane stok takip uygulamasıdır. DevExpress WinForms kontrolleri ile modern bir arayüz sunar ve veritabanı işlemleri Entity Framework Core ile MS SQL Server üzerinden yapılır.

Bu proje, bir staj kapsamında öğrenme amacıyla geliştirilmiştir.

## ✨ Özellikler

* **Ana Veri Yönetimi:** İlaç, Marka, Kategori, Tedarikçi ekleme, silme, güncelleme ve listeleme (CRUD) işlemleri.
* **Parti Bazlı Stok Girişi:** Eczaneye giren her ilaç partisinin Son Kullanma Tarihi (SKT) ve Alış Fiyatı ile birlikte kaydedilmesi.
* **Satış Ekranı:**
    * Barkod veya ilaç adına göre ürün arama.
    * Bulunan ilacın stoktaki, SKT'si en yakın partilerinin listelenmesi (FEFO - First Expired First Out).
    * Sanal sepet yönetimi (ürün ekleme, çıkarma).
    * Satış tamamlama ve stoktan otomatik düşme.
* **Temel Raporlama:** Stok durumunu gösteren basit bir liste ekranı.

## 💻 Kullanılan Teknolojiler

* **Dil:** C#
* **Platform:** .NET (Kullandığın sürümü belirt, örn: .NET 8)
* **Arayüz:** Windows Forms (WinForms)
* **UI Kütüphanesi:** DevExpress WinForms Controls (Kullandığın sürümü belirt, örn: v24.1)
* **ORM:** Entity Framework Core
* **Veritabanı:** MS SQL Server (LocalDB, Express veya hangisini kullandıysan)
* **Mimari:** Katmanlı Mimari (UI, Business, DataAccess, Entities)
* **Prensipler:** SOLID
* **Tasarım Desenleri:** Repository Pattern, Dependency Injection (Microsoft.Extensions.DependencyInjection)
* **Veri Aktarım:** DTO (Data Transfer Object) - İlaç listeleme gibi yerlerde kullanıldı.

## 🏗️ Mimari

Proje, sorumlulukların ayrılması prensibine uygun olarak 4 ana katmandan oluşmaktadır:

1.  **Entities:** Veritabanı tablolarına karşılık gelen saf C# sınıflarını (POCO) ve DTO'ları içerir.
2.  **DataAccess:** Veritabanı erişim mantığını içerir. Entity Framework Core context sınıfı ve Repository Pattern implementasyonları (Generic Repository ve özel repository'ler) bu katmandadır.
3.  **Business:** İş kurallarını, validasyonları ve uygulama mantığını içerir. Manager/Service sınıfları bu katmandadır ve DataAccess katmanındaki arayüzlere bağımlıdır.
4.  **UI (WinForms):** Kullanıcı arayüzünü (formlar, kontroller) içerir. Business katmanındaki arayüzlere bağımlıdır. Dependency Injection ile servisler formlara enjekte edilir.

## 🚀 Kurulum ve Çalıştırma

Projeyi yerel makinenizde çalıştırmak için aşağıdaki adımları izleyin:

1.  **Ön Koşullar:**
    * Visual Studio 2022 veya üzeri (.NET geliştirme araçları yüklü).
    * .NET SDK (Projede kullanılan sürüm, örn: .NET 8 SDK).
    * MS SQL Server (Express, Developer veya LocalDB sürümü).

2.  **Projeyi Klonlama:**
    ```bash
    git clone [SENİN GITHUB DEPO ADRESİN]
    cd [PROJE KLASÖRÜNÜN ADI]
    ```

3.  **Veritabanını Kurma:**
    * SQL Server Management Studio (SSMS) veya başka bir SQL aracı kullanarak boş bir veritabanı oluşturun (Önerilen isim: `EczaneStokDB`).
    * Bu depodaki **`DatabaseSchema.sql`** dosyasını bulun.
    * Bu `.sql` dosyasının içeriğini, oluşturduğunuz boş veritabanı üzerinde çalıştırın. Bu işlem, gerekli tüm tabloları ve ilişkileri oluşturacaktır.

4.  **Bağlantı Ayarları (`appsettings.json`):**
    * `UI` (veya `EczaneStok.WinFormUI`) projesinin içindeki **`appsettings.example.json`** dosyasını kopyalayın ve kopyanın adını **`appsettings.json`** olarak değiştirin.
    * Oluşturduğunuz `appsettings.json` dosyasını açın.
    * `ConnectionStrings` bölümündeki `DefaultConnection` değerini kendi **yerel SQL Server sunucu adınız** ve **veritabanı adınız** ile güncelleyin. Örnek:
        * LocalDB için: `"Server=(localdb)\\MSSQLLocalDB;Database=EczaneStokDB;Trusted_Connection=True;"`
        * SQL Express için: `"Server=.\\SQLEXPRESS;Database=EczaneStokDB;Trusted_Connection=True;"`
    * **Not:** `appsettings.json` dosyası `.gitignore` tarafından izlenmediği için GitHub'a gönderilmez.

5.  **Projeyi Derleme ve Çalıştırma:**
    * `[ProjeAdı].sln` dosyasını Visual Studio ile açın.
    * Menüden `Build` -> `Rebuild Solution` seçeneğini seçerek projeyi derleyin.
    * `UI` projesini başlangıç projesi olarak ayarlayın (Sağ tık -> `Set as Startup Project`).
    * `F5` tuşuna basarak veya `Start` butonuna tıklayarak uygulamayı çalıştırın.

## 📄 Lisans

Bu proje **MIT Lisansı** altında lisanslanmıştır. Daha fazla bilgi için lütfen depodaki `LICENSE` dosyasına bakın.

*(Buraya istersen Copyright (c) 2025 [Adın Soyadın] gibi bir satır ekleyebilirsin)*

---

*Bu README dosyasını kendi projenin detaylarına göre (kullandığın .NET sürümü, DevExpress sürümü, depo adresin vb.) güncellemeyi unutma.*
