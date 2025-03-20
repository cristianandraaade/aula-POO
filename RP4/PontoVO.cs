class PontoVO
{
    private int x;
    private int y;
    private string descricao;

    public PontoVO(int x, int y, string description){
        this.x = x;
        this.y = y;
        this.descricao = description;
    }
    public PontoVO(){
        this.x = 0;
        this.y = 0;
        this.descricao = "";
    }
    public void incrementarCoordenadas(int deltaX, int deltaY)
    {
        x += deltaX;
        y += deltaY;
    }
    public void imprimirCoordenadas()
    {
        // imprime as coordenadas x e y
        Console.WriteLine("x={0}, y={1}", x, y);
    }
    public void imprimirPonto(){
        Console.WriteLine("descriçao " + this.descricao + "Coordenadas " + this.x + " "+ this.y);
    }
    public void zerarCoordenadas()
    {
        x = 0;
        y = 0;
    }
    public int getX(){return x;}
    public int getY(){return y;}
    public string getDescription(){return descricao;}

    public void setX(int x){
        this.x = x;
    }
        public void setY(int y){
        this.y = y;
    }
        public void setDescription(string descricao){
        this.descricao = descricao;
    }
}