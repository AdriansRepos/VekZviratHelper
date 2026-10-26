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
