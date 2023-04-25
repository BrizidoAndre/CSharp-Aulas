namespace CadastroAlunos
{
    public class Aluno
    {
        public string nome;
        public string curso;

        public string idade;
        public string RG;
        public bool bolsista;
        public float mediaFinal;
        public float Mensalidade;
        public void VerMediaFinal(){
           Console.WriteLine($"A média final do aluno é de: {this.mediaFinal}");
        }
        public void VerMensalidade(){
            if ((bolsista) && mediaFinal >= 8)
            {
                Console.WriteLine($"Há uma bolsa de 50% para o aluno!");
                Console.WriteLine(this.Mensalidade - this.Mensalidade * 0.5F);
            }
            else if ((bolsista) && mediaFinal > 6)
            {
                Console.WriteLine($"Há uma bolsa de 30% para o aluno!");
                Console.Write("R$");
                Console.Write(Math.Round(Mensalidade - Mensalidade * 0.3F,2));
            }
            else{
                Console.WriteLine($"Não há bolsa para o aluno");
                Console.Write("R$");
                Console.WriteLine(Mensalidade);
            }
        }
    }
}