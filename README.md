## 🌐 Jazyk / Language Selection

*Klikněte na sekci níže pro zobrazení v češtině nebo angličtině.*
*Click on a section below to toggle between Czech and English.*

---

<details open>
<summary>🇨🇿 <strong>ČEŠTINA (Czech Version)</strong></summary>

# VekZviratHelper

Knihovna pro výpočet aktuálního věku zvířat z data narození, bez nutnosti ukládat věk jako samostatnou, časem zastarávající hodnotu.

## Metody

### `VypocetVeku.VypocitejVek`
Vrátí věk jako `(int roky, int mesice, int dny)`.

### `VypocetVeku.VypocitejVekTextove`
Vrátí věk jako čitelný text se správným českým skloňováním ("1 rok", "3 roky", "5 let").

```csharp
VypocetVeku.VypocitejVekTextove(datumNarozeni)  // "3 roky, 2 měsíce"
```

## Použití

Vhodné jako dynamicky počítaná vlastnost, ne jako uložená hodnota:

```csharp
[JsonIgnore]
public string Vek => VypocetVeku.VypocitejVekTextove(DatumNarozeni);
```

## Instalace jako NuGet balíček

Tato knihovna je dostupná také jako balíček v **GitHub Packages**. Můžete si ji snadno přidat do svého projektu:

1. Nastavte si jako zdroj balíčků váš GitHub (pokud ho ještě nemáte v NuGet.config).
2. V **Package Manager Console** spusťte příkaz:
```powershell
Install-Package VekZviratHelper
```

</details>

---

<details>
<summary>🇺🇸 <strong>ENGLISH (English Version)</strong></summary>

# VekZviratHelper

A library for calculating the current age of animals based on their birth date, eliminating the need to store age as a standalone value that becomes outdated over time.

## Methods

### `VypocetVeku.VypocitejVek`
Returns the age as a tuple `(int years, int months, int days)`.

### `VypocetVeku.VypocitejVekTextove`
Returns the age formatted as human-readable text with correct Czech declension ("1 rok", "3 roky", "5 let").

```csharp
VypocetVeku.VypocitejVekTextove(datumNarozeni)  // "3 roky, 2 měsíce"
```
## Usage
Ideal for use as a dynamically calculated property rather than a stored value:

```csharp
[JsonIgnore]
public string Vek => VypocetVeku.VypocitejVekTextove(DatumNarozeni);
```

## Installation as a NuGet Package
This library is also available as a package in GitHub Packages. You can easily add it to your project:

1. Set up your GitHub as a package source (if you don't have it in NuGet.config yet).
2. In the Package Manager Console, run the command:
```powershell
Install-Package VekZviratHelper
```

</details>