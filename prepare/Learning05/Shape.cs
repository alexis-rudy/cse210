public class Shape{
    private string _color = "brown";

    public Shape(string color){
        color = _color;
    }
    public string GetColor(){
        return _color;
    }
    public void SetColor(string color){
        color = _color;
    }

    public virtual double GetArea(){
        return 1.0;
    }
}