public class Program{
    static void Main(string[] args){
        Terminal terminal = new Terminal();

        terminal.WelcomeMessage();
        int response = terminal.ReadInt();
    }

}