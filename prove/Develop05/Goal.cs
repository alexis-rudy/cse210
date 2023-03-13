namespace Test
{
    public class Goal{
        private string _name = "";
        private string _desc = "";
        private int _points = 0;
        private bool _complete = false;
        public Goal(string name, string description, int points){
            _name = name;
            _desc = description;
            _points = points;
        }

        public string GetName(){
            return _name;
        }
        public string GetDesc(){
            return _desc;
        }
        public virtual int GetPoints(){
            return _points;
        }
        public virtual void RecordProgress(){
            // Different for each type of goal
        }
        public virtual bool IsComplete(){
            return _complete;
        }
        public override string ToString(){
            return $"The goal is complete: {_complete}";
        }
    }
}