namespace Ex_List2
{
    internal class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        public override string ToString()
        {
            return "\n\n"+Nome +"\n"+Idade ;
        }
    }
}