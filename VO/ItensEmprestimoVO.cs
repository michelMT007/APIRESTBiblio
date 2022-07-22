namespace BiblioDataInfo.VO
{
    public class ItensEmprestimoVO
    {
        public long IdEMprestimo { get; set; }
        public long IdLivro { get; set; }
        public string DataEmprestimo { get; set; }
        public string DataDevolucao { get; set; }
        public bool Emprestado { get; set; }
    }
}
