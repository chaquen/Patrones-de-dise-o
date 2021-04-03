using System.Collections.Generic;
public class CoctelComposite : MixedComponent
{
    List<MixedComponent> mixed = new List<MixedComponent>();
    public override decimal GetPrice(){
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