# ⚡ MULTRON PORT SCANNER

<div align="center">

![Version](https://img.shields.io/badge/version-v0.1.0_Beta-yellow?style=for-the-badge)
![Platform](https://img.shields.io/badge/platform-Windows-blue?style=for-the-badge&logo=windows)
![Language](https://img.shields.io/badge/C%23-WinForms-purple?style=for-the-badge&logo=csharp)
![Python](https://img.shields.io/badge/Python-3.x-blue?style=for-the-badge&logo=python)
![License](https://img.shields.io/badge/license-MIT-green?style=for-the-badge)

**C# WinForms arayüzü + Python tarama motoru ile geliştirilmiş güçlü port tarayıcı.**

</div>

---

## 📸 Ekran Görüntüsü

> *(Yakında eklenecek)*

---

## 🚀 Özellikler

| Özellik | Açıklama |
|---|---|
| 🎯 **Özel IP & Port Tarama** | Hedef IP ve port aralığını kendin belirle |
| ⚡ **Fast Scan** | Yüksek thread sayısıyla hızlı tarama modu |
| 🔍 **Servis Tarama** | Açık portlarda banner grabbing ile servis tespiti |
| 🌐 **-p- All Ports** | 1-65535 tüm portları tara |
| 🛠️ **Manuel Port Girişi** | İstediğin port aralığını manuel gir |
| 📡 **Ping Kontrolü** | Tarama öncesi host erişilebilirlik kontrolü |
| 🌙 **Dark / Light Mode** | Göz yormayan tema desteği |
| 📊 **Canlı Progress Bar** | Tarama ilerlemesini anlık takip et |

---

## 🏗️ Mimari

```
Multron Port Scanner
├── C# WinForms (Arayüz)
│   ├── Form1          → Ana iskelet, üst bar, navigasyon
│   ├── UC (Tarama)    → Tarama ekranı, output, progress bar
│   └── UserControl1   → Ayarlar ekranı
│
└── Python (Tarama Motoru)
    └── tarama.py      → Socket tabanlı çok iş parçacıklı tarayıcı
```

**İletişim protokolü:** C# → Python'u subprocess ile çalıştırır, stdout'u karakter karakter okur.
- `P` karakteri → progress bar ilerler
- `|ACIK:port` → açık port bulundu
- `|PING_OK` / `|PING_BASARISIZ` → host durumu
- `|BITTI|` → tarama tamamlandı

---

## 🛠️ Kurulum

### Gereksinimler

- Windows 10/11
- [.NET Framework 4.7+](https://dotnet.microsoft.com/)
- [Python 3.x](https://www.python.org/downloads/)
- [Guna UI2](https://gunaui.com/) *(NuGet üzerinden)*
- [FastColoredTextBox](https://github.com/PavelTorgashov/FastColoredTextBox) *(NuGet üzerinden)*

### Adımlar

```bash
# 1. Repoyu klonla
git clone https://github.com/Safak993/multron-port-scanner.git
cd multron-port-scanner

# 2. Python bağımlılıklarını yükle
pip install -r requirements.txt

# 3. Visual Studio'da aç ve çalıştır
# APp.sln dosyasını aç → Build → Run
```

### Python Bağımlılıkları

```
scapy
```

---

## ⚙️ Kullanım

1. Uygulamayı başlat
2. **Ayarlar** butonuna tıkla → Hedef IP ve port aralığını gir
3. Tarama modunu seç:
   - `-p-` → Tüm portlar (1-65535)
   - `Fast` → Hızlı tarama (yüksek thread)
   - `-sS SVC Scan` → Servis tespiti ile tarama
   - `No Ping` → Ping kontrolü atla
4. **▶ Tara** butonuna bas
5. Sonuçları canlı olarak izle

---

## 📁 Dosya Yapısı

```
📦 multron-port-scanner/
 ┣ 📂 APp/
 ┃ ┣ 📄 Form1.cs          → Ana form
 ┃ ┣ 📄 Uc.cs             → Tarama UserControl
 ┃ ┣ 📄 UserControl1.cs   → Ayarlar UserControl
 ┃ ┣ 📄 GlobalData.cs     → Paylaşılan veri sınıfı
 ┃ ┗ 📄 tarama.py         → Python tarama motoru
 ┣ 📄 requirements.txt
 ┣ 📄 README.md
 ┗ 📄 LICENSE
```

---

## ⚠️ Yasal Uyarı

> Bu araç **yalnızca eğitim amaçlı** ve **kendi sistemlerinizde veya izin verilen ağlarda** kullanım içindir.
> İzinsiz sistemlerde port tarama **yasadışıdır**. Geliştirici sorumluluk kabul etmez.

---

## 👤 Geliştirici

**Şafak Miraç** — [@Safak993](https://github.com/Safak993)

- 🌐 Website: [imageforgepro-six.vercel.app](https://imageforgepro-six.vercel.app)
- 👾 Discord: `mirac2_2`
- 📸 Instagram: [@sung_jinwoo126](https://www.instagram.com/sung_jinwoo126)

---

## 📜 Lisans

Bu proje iki lisans altında dağıtılmaktadır:

- **Açık Kaynak:** [MIT License](LICENSE) — kişisel, eğitim ve açık kaynak kullanım için
- **Ticari Kullanım:** [Ticari Lisans](COMMERCIAL_LICENSE) — satış, kiralama veya kurumsal kullanım için **Geliştirici'nin yazılı izni zorunludur**

> Yazılımı izinsiz satmak veya ticari ürünlerde kullanmak lisans ihlalidir.

---

<div align="center">
<i>"No vibe-coding, just pure logic and system architecture." 💻</i>
</div>
