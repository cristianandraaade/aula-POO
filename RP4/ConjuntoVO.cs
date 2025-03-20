class ConjuntoVO
{
    private int codigo;
    private string descricao;
    private List<PontoVO> pontos;

    public ConjuntoVO(int codigo, string descricao)
    {
        this.codigo = codigo;
        this.descricao = descricao;
        pontos = new List<PontoVO>();
    }
    public ConjuntoVO()
    {
        pontos = new List<PontoVO>();
    }
    public void ImprimirDadosConjunto()
    {
        Console.WriteLine("Codigo" + codigo + "Descrição" + descricao);
    }
    public int getCodigo()
    {
        return codigo;
    }
    public string getDescription()
    {
        return descricao;
    }
    public void setCodigo(int codigo)
    {
        this.codigo = codigo;
    }
    public void setDescription(string descricao)
    {
        this.descricao = descricao;
    }
    public override string ToString()
    {
        return "Código: " + codigo + ", Descrição: " + descricao;
    }
    public void adicionar(PontoVO PontoVO)
    {
        pontos.Add(PontoVO);
    }
    public PontoVO excluir(string ponto)
    {
        for (int i = 0; i < pontos.Count; i++)
        {
            PontoVO pontoVO = pontos[i];
            if (pontoVO.getDescription() == ponto)
            {
                PontoVO removido = pontoVO;
                pontos.RemoveAt(i);
                return removido;
            }
        }
        return null;
    }
    public void listarPontos()
    {
        PontoVO pontoVO = null;
        for (int i = 0; i < pontos.Count; i++)
        {
            pontoVO = pontos[i];
            pontoVO.imprimirPonto();
        }
    }
}