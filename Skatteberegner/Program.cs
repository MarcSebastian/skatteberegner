    public class Beregning {
        static void Main(string[] args) {

        }
        
        // Funktionen returnerer det beløb, der skal beskattes (altså ikke selve skatten).
        public double SkatVedJulegave(double julegave, double andenGave) {
            //Hvis der kun er en julegave, og den er under 1200 kr., beskattes der ikke. Hvis der er en julegave og en anden gave, er der ingen beskatning, hvis julegaven er under 900 kr. og den anden gave er under 300 kr.
            //Hvis julegaven er over 900 kr. og den anden gave er over 300 kr., beskattes der af hele beløbet. Hvis julegaven er under 900 kr., men den anden gave er over 300 kr., beskattes der kun af den anden gave.
            if (julegave <= 1200 && andenGave == 0) {
                return 0;
            }

            if (julegave <= 900 && andenGave <= 300) {
                return 0;
            }

            if (julegave > 900 && andenGave > 300) {
                return julegave + andenGave;
            }

            if (julegave <= 900 && andenGave > 300) {
                return andenGave;
            }

            return 0;
        }
    }