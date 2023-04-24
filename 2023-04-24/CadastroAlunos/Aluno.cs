namespace CadastroAlunos
{
    public class Aluno
    {
        public string nome = "";
        public string curso = "";

        public int idade = 0;
        public string RG = "";
        public bool bolsista = false;
        public float mediaFinal =0;
        public float Mensalidade =0;
        public void VerMediaFinal(){
           Console.WriteLine($"A média final do aluno é de: {mediaFinal}");
        }
        public void VerMensalidade(){
            if ((bolsista) && mediaFinal >= 8)
            {
                Console.WriteLine($"Há uma bolsa de 50% para o aluno!");
                Console.WriteLine(Mensalidade - Mensalidade * 0.5F);
            }
            else if ((bolsista) && mediaFinal > 6)
            {
                Console.WriteLine($"Há uma bolsa de 30% para o aluno!");
                Console.WriteLine(Mensalidade - Mensalidade * 0.3F);
            }
            else{
                Console.WriteLine($"Não há bolsa para o aluno");
                Console.WriteLine(Mensalidade);
            }
        }
    }
}