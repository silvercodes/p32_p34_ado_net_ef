namespace _04_ef_code_first;

internal class Product
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public double Price { get; set; }
    public override string ToString()
    {
        return $"{Id} {Title} {Description} {Price}";
    }
}
