using System;
using System.Collections.Generic;

// The purpose of the Storage Bin class is to hold all project items.
public class StorageBin{
    private List<Project> _projects = new List<Project>();

    public List<Project> GetProjects(){
        return _projects;
    }

    public void AddToList(Project project){
        _projects.Add(project);
    }
    
    public void DisplayProjects(){
        Terminal terminal = new Terminal();
        foreach (Project p in _projects){
            terminal.WriteMessage(p);
        }
    }
}