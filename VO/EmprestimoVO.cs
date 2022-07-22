namespace BiblioDataInfo.VO
{
    public class EmprestimoVO
    {
        public long Id { get; set; }
        public long IdUsuario { get; set; }
        public long IdLivro { get; set; }
        public string DataEmprestimo { get; set; }
        public string Datadevolucao { get; set; }
        public bool EmprestimoAtivo { get; set; }
    }
}
