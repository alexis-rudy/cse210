using System;
using System.Collections.Generic;

// The purpose of the Storage Bin class is to hold all project items.
public class StorageBin{
    private List<Project> _projects = new List<Project>();

    public List<Project> GetProjects(){
        return _projects;
    }
}