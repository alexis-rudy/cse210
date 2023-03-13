public class Shape{
    public string _color;

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