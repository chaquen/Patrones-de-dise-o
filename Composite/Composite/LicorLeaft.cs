class LicorLeaft : MixedComponent
{
    public LicorLeaft(string name, decimal price, decimal alcoholGrade): base(name, price, alcoholGrade) 
    {

    }
    public override decimal GetPrice(){
        return this.Price;
    }
    
}