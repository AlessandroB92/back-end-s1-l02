namespace back_end_s1_l02
{
    class Persona
    {
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public int Eta { get; set; }

        public string GetNome()
        {
            return Nome;
        }

        public string GetCognome()
        {
            return Cognome;
        }

        public int GetEta()
        {
            return Eta;
        }

        public string GetDettagli()
        {
            return $"Nome: {Nome}, Cognome: {Cognome}, Eta: {Eta}";
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // Creazione di un oggetto Persona
            Persona persona = new Persona();

            // Richiesta e assegnazione dei valori per Nome, Cognome ed Eta
            Console.WriteLine("Inserisci il nome:");
            persona.Nome = Console.ReadLine();

            Console.WriteLine("Inserisci il cognome:");
            persona.Cognome = Console.ReadLine();

            Console.WriteLine("Inserisci l'età:");
            if (int.TryParse(Console.ReadLine(), out int eta))
            {
                persona.Eta = eta;
            }
            else
            {
                Console.WriteLine("Inserimento non valido. L'età verrà impostata a 0.");
                persona.Eta = 0;
            }

            // Stampa dei dettagli utilizzando i metodi della classe
            Console.WriteLine("Nome: " + persona.GetNome());
            Console.WriteLine("Cognome: " + persona.GetCognome());
            Console.WriteLine("Età: " + persona.GetEta());
            Console.WriteLine("Dettagli: " + persona.GetDettagli());
        }
    }
}
