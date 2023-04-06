using System;
public class CreateNewProject : Commands{
    public override void CreateProject()
    {
        Terminal terminal = new Terminal();
        string name = terminal.ReadInput("Name of project: ");
        string description = terminal.ReadInput("Description: ");
        string startDate = terminal.ReadInput("Start Date (format: Jan 1, 2000): ");
        string endDate = terminal.ReadInput("End Date: ");
        string type = terminal.ReadInput("Project Type: ");

        StorageBin bin = new StorageBin();
        Convert converter = new Convert();
        DateTime newStartDate = converter.convertDate(startDate);
        DateTime newEndDate = converter.convertDate(endDate);

        if (name == "" && description == "" && startDate == "" && endDate == ""){
            terminal.WriteMessage("Cannot create empty project.");

        }
        else if (name == "" && startDate == "" && endDate == ""){
            if (type == "Programming"){
            Programming project = new Programming(description);
            bin.AddToList(project);
            terminal.WriteMessage("Project added.");
        }else if (type == "Sewing"){
            Sewing project = new Sewing();
            bin.AddToList(project);
            terminal.WriteMessage("Project added.");
        }
        }
        else if (startDate == "" && endDate == ""){
            if (type == "Programming"){
            Programming project = new Programming(name, description);
            bin.AddToList(project);
            terminal.WriteMessage("Project added.");
        }else if (type == "Sewing"){
            Sewing project = new Sewing(name, description);
            bin.AddToList(project);
            terminal.WriteMessage("Project added.");
        }
        }
        else if (name == ""){
            // Project project = new Project(description, newStartDate, newEndDate);
            if (type == "Programming"){
            Programming project = new Programming(description, newStartDate, newEndDate);
            bin.AddToList(project);
            terminal.WriteMessage("Project added.");
        }else if (type == "Sewing"){
            Sewing project = new Sewing(description, newStartDate, newEndDate);
            bin.AddToList(project);
            terminal.WriteMessage("Project added.");
        }
        }
        else{
            // Project project = new Project(name, description, newStartDate, newEndDate);
            if (type == "Programming"){
            Programming project = new Programming(name, description, newStartDate, newEndDate);
            bin.AddToList(project);
            terminal.WriteMessage("Project added.");
        }else if (type == "Sewing"){
            Sewing project = new Sewing(name, description, newStartDate, newEndDate);
            bin.AddToList(project);
            terminal.WriteMessage("Project added.");
        }
        }

    }
}