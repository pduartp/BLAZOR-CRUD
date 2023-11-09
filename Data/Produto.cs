namespace info_app.Data;

[Serializable]
public class Produto{
    public int Id { get; set; }
    public string? Nome { get; set; }
    public double Preco { get; set; }
    public string? Descr { get; set; }
    public int Quant { get; set; }
}