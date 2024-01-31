/*6.     Write a c# program to implement the following requirements:

		a.  Create a Custom  Attribute  ProjectInfoAttribute Class
		b.  Provides the properties :  ProjectName, DeveloperName,  IsCompleted
		c.  Target this attribute either class or interface. 
		d.  Create one class apply the above attribute with required values. 
		e.   Try to access the information of the attribute using Reflection in Main method. */

using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Class)]
public class ProjectInfoAttribute : Attribute
{
	public string ProjectName { get; set; }
	public string DeveloperName { get; set; }
	public bool IsCompleted { get; set; }
}

[ProjectInfoAttribute(ProjectName = "Project", DeveloperName = "Developer", IsCompleted = true)]

class Project
{
	public int ProjectId { get; set; }
	public bool ProjectStatus { get; set; }
}

class Program
{
	static void Main(string[] args)
	{
		Project projectObj = new Project();
		projectObj.ProjectId = 2609;
		projectObj.ProjectStatus = true;

		System.Console.WriteLine(projectObj.ProjectId);
		System.Console.WriteLine(projectObj.ProjectStatus);

		ProjectInfoAttribute projectInfoAttribute = (ProjectInfoAttribute)Attribute.GetCustomAttribute(typeof(Project), typeof(ProjectInfoAttribute));
		Console.WriteLine("Project class metadata: Attribute Information ");
		Console.WriteLine(projectInfoAttribute.ProjectName);
		Console.WriteLine(projectInfoAttribute.DeveloperName);
		Console.WriteLine(projectInfoAttribute.IsCompleted);

	}
}

