namespace VekZviratHelper
{
    /// <summary>
    /// Poskytuje výpočet aktuálního věku zvířete na základě data narození.
    /// </summary>
    public static class VypocetVeku
    {
        /// <summary>
        /// Vypočítá aktuální věk na základě data narození, ve formátu
        /// let a měsíců (obdoba přístupu používaného v profesionálním
        /// zoo software – např. ZIMS – kde se věk odvozuje přímo
        /// z kalendářního data narození).
        /// </summary>
        /// <param name="datumNarozeni">Datum narození zvířete.</param>
        /// <returns>Věk ve formátu (roky, měsíce, dny).</returns>
        public static (int roky, int mesice, int dny) VypocitejVek(DateOnly datumNarozeni)
        {
            DateOnly dnes = DateOnly.FromDateTime(DateTime.Now);

            if (datumNarozeni > dnes)
                throw new ArgumentException("Datum narození nemůže být v budoucnosti.", nameof(datumNarozeni));

            int roky = dnes.Year - datumNarozeni.Year;
            int mesice = dnes.Month - datumNarozeni.Month;
            int dny = dnes.Day - datumNarozeni.Day;

            if (dny < 0)
            {
                mesice--;
                // počet dní v předchozím měsíci vzhledem k dnešnímu datu
                DateOnly predchoziMesic = dnes.AddMonths(-1);
                dny += DateTime.DaysInMonth(predchoziMesic.Year, predchoziMesic.Month);
            }

            if (mesice < 0)
            {
                roky--;
                mesice += 12;
            }

            return (roky, mesice, dny);
        }

        /// <summary>
        /// Vrátí věk jako čitelný text ve formátu "X let, Y měsíců".
        /// Skloňuje slova "rok" a "měsíc" podle platných pravidel češtiny.
        /// </summary>
        /// <param name="datumNarozeni">Datum narození zvířete.</param>
        /// <returns>Textová reprezentace věku.</returns>
        public static string VypocitejVekTextove(DateOnly datumNarozeni)
        {
            var (roky, mesice, _) = VypocitejVek(datumNarozeni);

            string rokyText = SklonujRoky(roky);
            string mesiceText = mesice > 0 ? $", {SklonujMesice(mesice)}" : "";

            return $"{rokyText}{mesiceText}";
        }

        private static string SklonujRoky(int roky)
        {
            if (roky == 1) return "1 rok";
            if (roky >= 2 && roky <= 4) return $"{roky} roky";
            return $"{roky} let";
        }

        private static string SklonujMesice(int mesice)
        {
            if (mesice == 1) return "1 měsíc";
            if (mesice >= 2 && mesice <= 4) return $"{mesice} měsíce";
            return $"{mesice} měsíců";
        }
    }
}
