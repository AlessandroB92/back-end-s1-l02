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

            // Assegnazione dei valori alle proprietà
            persona.Nome = "Mario";
            persona.Cognome = "Rossi";
            persona.Eta = 30;

            // Stampa dei dettagli utilizzando i metodi della classe
            Console.WriteLine("Nome: " + persona.GetNome());
            Console.WriteLine("Cognome: " + persona.GetCognome());
            Console.WriteLine("Età: " + persona.GetEta());
            Console.WriteLine("Dettagli: " + persona.GetDettagli());

            // Puoi anche accedere direttamente alle proprietà se sono impostate come pubbliche
            // Console.WriteLine("Nome: " + persona.Nome);
            // Console.WriteLine("Cognome: " + persona.Cognome);
            // Console.WriteLine("Età: " + persona.Eta);
            // Console.WriteLine("Dettagli: " + persona.GetDettagli());
        }
    }
}
