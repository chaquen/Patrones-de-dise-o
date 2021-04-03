using System.Collections.Generic;
public class CoctelComposite : MixedComponent
{   
    public decimal PriceCoctail { get; set; }
    List<MixedComponent> mixed = new List<MixedComponent>();
    public override decimal GetPrice(){
        if (PriceCoctail > 0)
        {
            return PriceCoctail;
        }

        decimal price = 0;
        mixed.ForEach(m => {
            price += m.GetPrice();
        });  
        return price;
    }   
    public decimal GetAlcoholGrade(){
        decimal alcohol = 0;
        mixed.ForEach(mixed=> {
            alcohol += mixed.AlcoholGrade;
        });
        return alcohol;
    }  
    public CoctelComposite(string name): base(name) {

    }  
    public CoctelComposite(string name, decimal price): base(name) {
        PriceCoctail = price;
    }    
    public void Add(MixedComponent obj){
        mixed.Add(obj);
    }
    public string GetListLicors(){
        var licors = "";
        mixed.ForEach(m => {
            licors += m.Name+" - ";
        });
        return licors;

    }
}