public abstract class MixedComponent
{
    public string Name { get; set; }
    public decimal Price { get; set; }
    public decimal AlcoholGrade { get; set;}
    public abstract decimal GetPrice();
    public MixedComponent(string name, decimal price, decimal alcoholGrade){
        Name = name;
        Price = price;
        AlcoholGrade = alcoholGrade;
    }
    public MixedComponent(string name) {
        Name = name;
    }
}