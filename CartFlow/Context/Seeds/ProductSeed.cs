using CartFlow.Models;

namespace CartFlow.Context.Seeds;

public static class ProductSeed
{
    public static List<Product> Data => new()
    {
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Teknoloji Ürünü 1",
            Description = "Teknoloji kategorisi örnek ürün 1",
            Price = 137m,
            Stock = 23,
            Sold = 7,
            CategoryId = Guid.Parse("019F08A6-792E-716C-AA96-A77A670B615A"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Teknoloji Ürünü 2",
            Description = "Teknoloji kategorisi örnek ürün 2",
            Price = 274m,
            Stock = 26,
            Sold = 14,
            CategoryId = Guid.Parse("019F08A6-792E-716C-AA96-A77A670B615A"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Teknoloji Ürünü 3",
            Description = "Teknoloji kategorisi örnek ürün 3",
            Price = 411m,
            Stock = 29,
            Sold = 21,
            CategoryId = Guid.Parse("019F08A6-792E-716C-AA96-A77A670B615A"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Teknoloji Ürünü 4",
            Description = "Teknoloji kategorisi örnek ürün 4",
            Price = 548m,
            Stock = 32,
            Sold = 28,
            CategoryId = Guid.Parse("019F08A6-792E-716C-AA96-A77A670B615A"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Teknoloji Ürünü 5",
            Description = "Teknoloji kategorisi örnek ürün 5",
            Price = 685m,
            Stock = 35,
            Sold = 35,
            CategoryId = Guid.Parse("019F08A6-792E-716C-AA96-A77A670B615A"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Teknoloji Ürünü 6",
            Description = "Teknoloji kategorisi örnek ürün 6",
            Price = 822m,
            Stock = 38,
            Sold = 42,
            CategoryId = Guid.Parse("019F08A6-792E-716C-AA96-A77A670B615A"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Gayrimenkul Ürünü 1",
            Description = "Gayrimenkul kategorisi örnek ürün 1",
            Price = 359m,
            Stock = 41,
            Sold = 49,
            CategoryId = Guid.Parse("019F08B8-F30B-7ED0-A389-087547932D37"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Gayrimenkul Ürünü 2",
            Description = "Gayrimenkul kategorisi örnek ürün 2",
            Price = 496m,
            Stock = 44,
            Sold = 56,
            CategoryId = Guid.Parse("019F08B8-F30B-7ED0-A389-087547932D37"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Gayrimenkul Ürünü 3",
            Description = "Gayrimenkul kategorisi örnek ürün 3",
            Price = 633m,
            Stock = 47,
            Sold = 63,
            CategoryId = Guid.Parse("019F08B8-F30B-7ED0-A389-087547932D37"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Gayrimenkul Ürünü 4",
            Description = "Gayrimenkul kategorisi örnek ürün 4",
            Price = 770m,
            Stock = 50,
            Sold = 70,
            CategoryId = Guid.Parse("019F08B8-F30B-7ED0-A389-087547932D37"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Aksesuar Ürünü 1",
            Description = "Aksesuar kategorisi örnek ürün 1",
            Price = 507m,
            Stock = 53,
            Sold = 77,
            CategoryId = Guid.Parse("019F08B9-29A2-714A-A6F2-1D4A0734E73D"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Aksesuar Ürünü 2",
            Description = "Aksesuar kategorisi örnek ürün 2",
            Price = 644m,
            Stock = 56,
            Sold = 84,
            CategoryId = Guid.Parse("019F08B9-29A2-714A-A6F2-1D4A0734E73D"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Aksesuar Ürünü 3",
            Description = "Aksesuar kategorisi örnek ürün 3",
            Price = 781m,
            Stock = 59,
            Sold = 1,
            CategoryId = Guid.Parse("019F08B9-29A2-714A-A6F2-1D4A0734E73D"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Aksesuar Ürünü 4",
            Description = "Aksesuar kategorisi örnek ürün 4",
            Price = 918m,
            Stock = 62,
            Sold = 8,
            CategoryId = Guid.Parse("019F08B9-29A2-714A-A6F2-1D4A0734E73D"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Aksesuar Ürünü 5",
            Description = "Aksesuar kategorisi örnek ürün 5",
            Price = 1055m,
            Stock = 65,
            Sold = 15,
            CategoryId = Guid.Parse("019F08B9-29A2-714A-A6F2-1D4A0734E73D"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Spor Ürünü 1",
            Description = "Spor kategorisi örnek ürün 1",
            Price = 692m,
            Stock = 68,
            Sold = 22,
            CategoryId = Guid.Parse("019F08BA-5838-7D1F-8298-2921C18D770C"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Spor Ürünü 2",
            Description = "Spor kategorisi örnek ürün 2",
            Price = 829m,
            Stock = 71,
            Sold = 29,
            CategoryId = Guid.Parse("019F08BA-5838-7D1F-8298-2921C18D770C"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Spor Ürünü 3",
            Description = "Spor kategorisi örnek ürün 3",
            Price = 966m,
            Stock = 74,
            Sold = 36,
            CategoryId = Guid.Parse("019F08BA-5838-7D1F-8298-2921C18D770C"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Spor Ürünü 4",
            Description = "Spor kategorisi örnek ürün 4",
            Price = 1103m,
            Stock = 77,
            Sold = 43,
            CategoryId = Guid.Parse("019F08BA-5838-7D1F-8298-2921C18D770C"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Spor Ürünü 5",
            Description = "Spor kategorisi örnek ürün 5",
            Price = 1240m,
            Stock = 80,
            Sold = 50,
            CategoryId = Guid.Parse("019F08BA-5838-7D1F-8298-2921C18D770C"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Giyim Ürünü 1",
            Description = "Giyim kategorisi örnek ürün 1",
            Price = 877m,
            Stock = 83,
            Sold = 57,
            CategoryId = Guid.Parse("019F08BA-8A2F-7489-B10E-DE71178D9A20"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Giyim Ürünü 2",
            Description = "Giyim kategorisi örnek ürün 2",
            Price = 1014m,
            Stock = 86,
            Sold = 64,
            CategoryId = Guid.Parse("019F08BA-8A2F-7489-B10E-DE71178D9A20"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Giyim Ürünü 3",
            Description = "Giyim kategorisi örnek ürün 3",
            Price = 1151m,
            Stock = 89,
            Sold = 71,
            CategoryId = Guid.Parse("019F08BA-8A2F-7489-B10E-DE71178D9A20"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Giyim Ürünü 4",
            Description = "Giyim kategorisi örnek ürün 4",
            Price = 1288m,
            Stock = 92,
            Sold = 78,
            CategoryId = Guid.Parse("019F08BA-8A2F-7489-B10E-DE71178D9A20"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Giyim Ürünü 5",
            Description = "Giyim kategorisi örnek ürün 5",
            Price = 1425m,
            Stock = 95,
            Sold = 85,
            CategoryId = Guid.Parse("019F08BA-8A2F-7489-B10E-DE71178D9A20"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Kitap Ürünü 1",
            Description = "Kitap kategorisi örnek ürün 1",
            Price = 1062m,
            Stock = 98,
            Sold = 2,
            CategoryId = Guid.Parse("019F08BA-B96F-73AF-BED7-201A139D6F66"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Kitap Ürünü 2",
            Description = "Kitap kategorisi örnek ürün 2",
            Price = 1199m,
            Stock = 101,
            Sold = 9,
            CategoryId = Guid.Parse("019F08BA-B96F-73AF-BED7-201A139D6F66"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Kitap Ürünü 3",
            Description = "Kitap kategorisi örnek ürün 3",
            Price = 1336m,
            Stock = 104,
            Sold = 16,
            CategoryId = Guid.Parse("019F08BA-B96F-73AF-BED7-201A139D6F66"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Kitap Ürünü 4",
            Description = "Kitap kategorisi örnek ürün 4",
            Price = 1473m,
            Stock = 107,
            Sold = 23,
            CategoryId = Guid.Parse("019F08BA-B96F-73AF-BED7-201A139D6F66"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Kitap Ürünü 5",
            Description = "Kitap kategorisi örnek ürün 5",
            Price = 1610m,
            Stock = 110,
            Sold = 30,
            CategoryId = Guid.Parse("019F08BA-B96F-73AF-BED7-201A139D6F66"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Oyun Ürünü 1",
            Description = "Oyun kategorisi örnek ürün 1",
            Price = 1247m,
            Stock = 113,
            Sold = 37,
            CategoryId = Guid.Parse("019F08BA-EFA5-787A-AB95-48DC207F7884"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Oyun Ürünü 2",
            Description = "Oyun kategorisi örnek ürün 2",
            Price = 1384m,
            Stock = 116,
            Sold = 44,
            CategoryId = Guid.Parse("019F08BA-EFA5-787A-AB95-48DC207F7884"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Oyun Ürünü 3",
            Description = "Oyun kategorisi örnek ürün 3",
            Price = 1521m,
            Stock = 119,
            Sold = 51,
            CategoryId = Guid.Parse("019F08BA-EFA5-787A-AB95-48DC207F7884"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Oyun Ürünü 4",
            Description = "Oyun kategorisi örnek ürün 4",
            Price = 1658m,
            Stock = 122,
            Sold = 58,
            CategoryId = Guid.Parse("019F08BA-EFA5-787A-AB95-48DC207F7884"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Oyun Ürünü 5",
            Description = "Oyun kategorisi örnek ürün 5",
            Price = 1795m,
            Stock = 125,
            Sold = 65,
            CategoryId = Guid.Parse("019F08BA-EFA5-787A-AB95-48DC207F7884"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Gıda Ürünü 1",
            Description = "Gıda kategorisi örnek ürün 1",
            Price = 1432m,
            Stock = 128,
            Sold = 72,
            CategoryId = Guid.Parse("019F08BB-1A94-76C5-9A80-049BB0539F35"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Gıda Ürünü 2",
            Description = "Gıda kategorisi örnek ürün 2",
            Price = 1569m,
            Stock = 131,
            Sold = 79,
            CategoryId = Guid.Parse("019F08BB-1A94-76C5-9A80-049BB0539F35"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Gıda Ürünü 3",
            Description = "Gıda kategorisi örnek ürün 3",
            Price = 1706m,
            Stock = 134,
            Sold = 86,
            CategoryId = Guid.Parse("019F08BB-1A94-76C5-9A80-049BB0539F35"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Gıda Ürünü 4",
            Description = "Gıda kategorisi örnek ürün 4",
            Price = 1843m,
            Stock = 137,
            Sold = 3,
            CategoryId = Guid.Parse("019F08BB-1A94-76C5-9A80-049BB0539F35"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Bahçe Ürünü 1",
            Description = "Bahçe kategorisi örnek ürün 1",
            Price = 1580m,
            Stock = 140,
            Sold = 10,
            CategoryId = Guid.Parse("019F08BB-6B1F-7605-B8A0-C2C887CF4699"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Bahçe Ürünü 2",
            Description = "Bahçe kategorisi örnek ürün 2",
            Price = 1717m,
            Stock = 143,
            Sold = 17,
            CategoryId = Guid.Parse("019F08BB-6B1F-7605-B8A0-C2C887CF4699"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Bahçe Ürünü 3",
            Description = "Bahçe kategorisi örnek ürün 3",
            Price = 1854m,
            Stock = 146,
            Sold = 24,
            CategoryId = Guid.Parse("019F08BB-6B1F-7605-B8A0-C2C887CF4699"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Bahçe Ürünü 4",
            Description = "Bahçe kategorisi örnek ürün 4",
            Price = 1991m,
            Stock = 149,
            Sold = 31,
            CategoryId = Guid.Parse("019F08BB-6B1F-7605-B8A0-C2C887CF4699"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Sanat Ürünü 1",
            Description = "Sanat kategorisi örnek ürün 1",
            Price = 1728m,
            Stock = 152,
            Sold = 38,
            CategoryId = Guid.Parse("019F08BB-9B46-7DB5-91C5-BCB874F42AFF"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Sanat Ürünü 2",
            Description = "Sanat kategorisi örnek ürün 2",
            Price = 1865m,
            Stock = 155,
            Sold = 45,
            CategoryId = Guid.Parse("019F08BB-9B46-7DB5-91C5-BCB874F42AFF"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Sanat Ürünü 3",
            Description = "Sanat kategorisi örnek ürün 3",
            Price = 2002m,
            Stock = 158,
            Sold = 52,
            CategoryId = Guid.Parse("019F08BB-9B46-7DB5-91C5-BCB874F42AFF"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Sanat Ürünü 4",
            Description = "Sanat kategorisi örnek ürün 4",
            Price = 2139m,
            Stock = 161,
            Sold = 59,
            CategoryId = Guid.Parse("019F08BB-9B46-7DB5-91C5-BCB874F42AFF"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Alet Ürünü 1",
            Description = "Alet kategorisi örnek ürün 1",
            Price = 1876m,
            Stock = 164,
            Sold = 66,
            CategoryId = Guid.Parse("019F08BB-D442-7FB7-A6CF-5325FB2B51F1"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Alet Ürünü 2",
            Description = "Alet kategorisi örnek ürün 2",
            Price = 2013m,
            Stock = 167,
            Sold = 73,
            CategoryId = Guid.Parse("019F08BB-D442-7FB7-A6CF-5325FB2B51F1"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Alet Ürünü 3",
            Description = "Alet kategorisi örnek ürün 3",
            Price = 2150m,
            Stock = 170,
            Sold = 80,
            CategoryId = Guid.Parse("019F08BB-D442-7FB7-A6CF-5325FB2B51F1"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Alet Ürünü 4",
            Description = "Alet kategorisi örnek ürün 4",
            Price = 2287m,
            Stock = 173,
            Sold = 87,
            CategoryId = Guid.Parse("019F08BB-D442-7FB7-A6CF-5325FB2B51F1"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Seyahat Ürünü 1",
            Description = "Seyahat kategorisi örnek ürün 1",
            Price = 2024m,
            Stock = 176,
            Sold = 4,
            CategoryId = Guid.Parse("019F08BC-1283-75A5-A94F-E31609EB4D4E"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Seyahat Ürünü 2",
            Description = "Seyahat kategorisi örnek ürün 2",
            Price = 2161m,
            Stock = 179,
            Sold = 11,
            CategoryId = Guid.Parse("019F08BC-1283-75A5-A94F-E31609EB4D4E"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Seyahat Ürünü 3",
            Description = "Seyahat kategorisi örnek ürün 3",
            Price = 2298m,
            Stock = 182,
            Sold = 18,
            CategoryId = Guid.Parse("019F08BC-1283-75A5-A94F-E31609EB4D4E"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Seyahat Ürünü 4",
            Description = "Seyahat kategorisi örnek ürün 4",
            Price = 2435m,
            Stock = 185,
            Sold = 25,
            CategoryId = Guid.Parse("019F08BC-1283-75A5-A94F-E31609EB4D4E"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Evcil Hayvan Ürünü 1",
            Description = "Evcil Hayvan kategorisi örnek ürün 1",
            Price = 2172m,
            Stock = 188,
            Sold = 32,
            CategoryId = Guid.Parse("019F08BC-4FF4-799F-9B8E-3BADD35C0FF5"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Evcil Hayvan Ürünü 2",
            Description = "Evcil Hayvan kategorisi örnek ürün 2",
            Price = 2309m,
            Stock = 191,
            Sold = 39,
            CategoryId = Guid.Parse("019F08BC-4FF4-799F-9B8E-3BADD35C0FF5"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Evcil Hayvan Ürünü 3",
            Description = "Evcil Hayvan kategorisi örnek ürün 3",
            Price = 2446m,
            Stock = 194,
            Sold = 46,
            CategoryId = Guid.Parse("019F08BC-4FF4-799F-9B8E-3BADD35C0FF5"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Evcil Hayvan Ürünü 4",
            Description = "Evcil Hayvan kategorisi örnek ürün 4",
            Price = 2583m,
            Stock = 197,
            Sold = 53,
            CategoryId = Guid.Parse("019F08BC-4FF4-799F-9B8E-3BADD35C0FF5"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Kozmetik Ürünü 1",
            Description = "Kozmetik kategorisi örnek ürün 1",
            Price = 2320m,
            Stock = 20,
            Sold = 60,
            CategoryId = Guid.Parse("019F08BC-81C0-783C-BFD7-EEF39EDA9C5A"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Kozmetik Ürünü 2",
            Description = "Kozmetik kategorisi örnek ürün 2",
            Price = 2457m,
            Stock = 23,
            Sold = 67,
            CategoryId = Guid.Parse("019F08BC-81C0-783C-BFD7-EEF39EDA9C5A"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Kozmetik Ürünü 3",
            Description = "Kozmetik kategorisi örnek ürün 3",
            Price = 2594m,
            Stock = 26,
            Sold = 74,
            CategoryId = Guid.Parse("019F08BC-81C0-783C-BFD7-EEF39EDA9C5A"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Müzik Ürünü 1",
            Description = "Müzik kategorisi örnek ürün 1",
            Price = 2431m,
            Stock = 29,
            Sold = 81,
            CategoryId = Guid.Parse("019F08BC-BF2C-7BD0-9A50-E6C286CFED60"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Müzik Ürünü 2",
            Description = "Müzik kategorisi örnek ürün 2",
            Price = 2568m,
            Stock = 32,
            Sold = 88,
            CategoryId = Guid.Parse("019F08BC-BF2C-7BD0-9A50-E6C286CFED60"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Müzik Ürünü 3",
            Description = "Müzik kategorisi örnek ürün 3",
            Price = 2705m,
            Stock = 35,
            Sold = 5,
            CategoryId = Guid.Parse("019F08BC-BF2C-7BD0-9A50-E6C286CFED60"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Futbol Ürünü 1",
            Description = "Futbol kategorisi örnek ürün 1",
            Price = 2542m,
            Stock = 38,
            Sold = 12,
            CategoryId = Guid.Parse("019F08BC-E16D-7A9B-8D2D-3338247AD7C3"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Futbol Ürünü 2",
            Description = "Futbol kategorisi örnek ürün 2",
            Price = 2679m,
            Stock = 41,
            Sold = 19,
            CategoryId = Guid.Parse("019F08BC-E16D-7A9B-8D2D-3338247AD7C3"),
            IsActive = true
        },
        new Product
        {
            Id = Guid.NewGuid(),
            Name = "Futbol Ürünü 3",
            Description = "Futbol kategorisi örnek ürün 3",
            Price = 2816m,
            Stock = 44,
            Sold = 26,
            CategoryId = Guid.Parse("019F08BC-E16D-7A9B-8D2D-3338247AD7C3"),
            IsActive = true
        },
    };
}
