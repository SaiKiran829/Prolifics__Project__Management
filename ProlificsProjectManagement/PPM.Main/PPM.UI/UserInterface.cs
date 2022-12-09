using System;
using PPM.Main.PPM.Domain;
using PPM.Main.PPM.Model;
namespace PPM.Main.PPM.UI
{
    class UI{
    public void view(){ Console.WriteLine("             ==========Hello Prolifics employee==========");
        Console.WriteLine("");
        Console.Write("Enter \"1\" for adding project               ");
        Console.WriteLine("Enter \"2\" to show all projects");
        Console.WriteLine("");
        Console.Write("Enter \"3\" for adding Employee              ");
        Console.WriteLine("Enter \"4\" for viewing all Employees");
        Console.WriteLine("");
        Console.Write("Enter \"5\" for adding Role                  ");
        Console.WriteLine("Enter \"6\" for viewing all Roles");
        Console.WriteLine("");
        Console.Write("Enter \"7\" for searching project            ");
        Console.WriteLine("Enter \"8\" for searching project through id");
        Console.WriteLine("");
        Console.WriteLine("Enter \"9\" to view all projects");
        Console.WriteLine("");
        Console.WriteLine("                           Enter \"x\" to exit application");
        ProjectManagement obj = new ProjectManagement();
        EmpManagement obj1 = new EmpManagement();
        RoleManagement objmain = new RoleManagement();
        // AddingEmptoProject obj3 = new AddingEmptoProject();
        Project project = new Project();
        Employee employee = new Employee();

        objmain.RoleList.Add(new Role(1, "Software Engineer"));
        objmain.RoleList.Add(new Role(2, "Associate Software Engineer"));
        objmain.RoleList.Add(new Role(3, "Trainee Software Engineer"));
        objmain.RoleList.Add(new Role(4, "Technical Lead"));


        Console.WriteLine("");
        var read = Console.ReadLine();
        while (true)
        {
            switch (read)
            {
                case "1":
                    Console.WriteLine("");
                    Console.WriteLine("");
                    try
                    {
                        Console.WriteLine("Enter Project Id");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the name of project");
                        string name = Console.ReadLine();
                        Console.WriteLine("Enter start date of project");
                        string start = Console.ReadLine();
                        Console.WriteLine("Enter start date of project");
                        string end = Console.ReadLine();
                        Project project1 = new Project(name, start, end, id);
                        obj.AddingProjects(project1);
                        project = project1;
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Added Successfully!");
                        Console.WriteLine("");
                        Console.WriteLine("Enter any key to get to main menu");
                        Console.ReadLine();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("\nError : Only use numbers for id");
                    }
                    break;

                case "2":
                    obj.displayAllProjects();
                    Console.WriteLine("Enter any key to get to main menu");
                    Console.ReadLine();
                    break;

                case "3":
                    Console.WriteLine("");
                    Console.WriteLine("");
                    Console.WriteLine("Enter the Id of employee");
                    int empId = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter employee first name");
                    var fname = Console.ReadLine();
                    Console.WriteLine("Enter employee last name");
                    var lname = Console.ReadLine();
                    Console.WriteLine("Enter employee email id");
                    var EMAIL = Console.ReadLine();
                    Console.WriteLine("Enter employee mobile number");
                    var mobile = Console.ReadLine();
                    Console.WriteLine("Enter address of the employee");
                    var address = Console.ReadLine();
                    Console.WriteLine("Select 1 for assinging employee with new role name and new role id");
                    Console.WriteLine("Select 2 for assinging existing role to the employee");
                    int selecting = Convert.ToInt32(Console.ReadLine());
                    if (selecting == 1)
                    {
                        try
                        {
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("Enter the Role Id");
                            int roleID = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine("Enter the name of Role");
                            string role_name = Console.ReadLine();
                            Console.WriteLine(role_name);
                            Role newRole = new Role(roleID, role_name);
                            objmain.RoleAdd(newRole);
                            Employee employee1 = new Employee(empId, fname, lname, EMAIL, mobile, address, roleID, role_name);
                            obj1.AddEmp(employee1);
                            employee=employee1;
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("Added Successfully!");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Role Id can only be in numbers");
                        }
                    }
                    else if (selecting == 2)
                    {
                        try
                        {
                            objmain.displayRole();
                            Console.WriteLine("Select Role id from above list to assign role to employee");
                            int role1 = Convert.ToInt32(Console.ReadLine());
                            string? roleNAME1 = null;
                            switch (role1)
                            {
                                case 1:
                                    roleNAME1 = "Software Engineer";
                                    break;
                                case 2:
                                    roleNAME1 = "Associate Software Engineer";
                                    break;
                                case 3:
                                    roleNAME1 = "Trainee Software Engineer";
                                    break;
                                case 4:
                                    roleNAME1 = "Technical Lead";
                                    break;
                                default:
                                    Console.WriteLine("Invalid Entry");
                                    break;
                            }
                            Employee employee1 = new Employee(empId, fname, lname, EMAIL, mobile, address, role1, roleNAME1);
                            obj1.AddEmp(employee1);
                            employee = employee1;
                            Console.WriteLine("");
                            Console.WriteLine("");
                            Console.WriteLine("Added Successfully!");
                        }
                        catch (Exception e)
                        {
                            Console.WriteLine("Emp id can only be in numbers");
                        }
                    }
                            
                            Console.WriteLine("");
                            Console.WriteLine("Enter any key to get to main menu");
                            Console.ReadLine();
                            break;
                case "4":
                    obj1.ShowEmp();
                    Console.WriteLine("Enter any key to get to main menu");
                    Console.ReadLine();
                    break;
                case "5":
                    try
                    {
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Enter the Role Id");
                        int roleID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter the name of Role");
                        string role_name = Console.ReadLine();
                        Console.WriteLine(role_name);
                        Role newRole = new Role(roleID, role_name);
                        objmain.RoleAdd(newRole);
                        Console.WriteLine("");
                        Console.WriteLine("");
                        Console.WriteLine("Added Successfully!");
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Role Id can only be in numbers");
                    }
                    Console.WriteLine("");
                    Console.WriteLine("Enter any key to get to main menu");
                    Console.ReadLine();
                    break;

                case "6":
                    objmain.displayRole();
                    Console.WriteLine("Enter any key to get to main menu");
                    Console.ReadLine();
                    break;

                case "7":
                    Console.WriteLine("Type to search for project");
                    read = Console.ReadLine();
                    obj.SearchProject(read);
                    Console.WriteLine("Enter any key to get to main menu");
                    Console.ReadLine();
                    break;

                case "8":
                    try
                    {
                        Console.WriteLine("Search via project id");
                        Console.WriteLine("Enter the id of project");
                        int eid = Convert.ToInt32(Console.ReadLine());
                        obj.ShowProject(eid);
                        Console.WriteLine();
                        Console.WriteLine("Enter any key to get to main menu");
                    }
                    catch (Exception e) { Console.WriteLine("Id can only be in numbers"); }
                    break;

                case "9":
                    obj.displayAllProjects();
                    Console.WriteLine("Enter any key to get to main menu");
                    Console.ReadLine();
                    break;
                case "10":

                    Console.WriteLine("");
                    obj.displayAllProjects();
                    Console.WriteLine("Above are the available projects");
                    Console.WriteLine();
                    obj1.ShowEmp();
                    Console.WriteLine("Above are the available employees");
                    Console.WriteLine("Enter the Name of the project from above list exactly");
                    int PROJId = Convert.ToInt32(Console.ReadLine());
                    
                    
                    
                  
                    if(obj.exist(PROJId))
                    {
                         Console.WriteLine("Enter the id of employee to add into project");
                        int EmpId = Convert.ToInt32(Console.ReadLine());
                        if( obj1.exist(EmpId)){
                            employee = obj1.eDetails(EmpId);
                            obj.emptopro(PROJId,employee);
                            //AddingEmptoProject addition = new AddingEmptoProject();
                            //addition.addingemp();
                            Console.WriteLine("Added Successfully!!!!!!!");
                        }
                        else{
                             Console.WriteLine("Invalid Employee bro");
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("Invalid Entry bro");
                    }
                    //  }
                    var Read = Console.ReadLine();
                    break;

                    case "11":
                    Console.WriteLine("Enter Project Id");
                         int pid = Convert.ToInt32(Console.ReadLine());
                    obj.display();
                    // Console.WriteLine("Enter Project Id");
                    //     int pid = Convert.ToInt32(Console.ReadLine());
                    // obj.display(pid);
                    //  Console.ReadLine();
                    break;

                case "x":
                    return;
                default:
                    Console.WriteLine("Invalid entry");
                    break;
            }
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("                          ======LIST======");
            Console.WriteLine("");
            Console.Write("Enter \"1\" for adding project               ");
            Console.WriteLine("Enter \"2\" to show all projects");
            Console.WriteLine("");
            Console.Write("Enter \"3\" for adding Employee              ");
            Console.WriteLine("Enter \"4\" for viewing all Employees");
            Console.WriteLine("");
            Console.Write("Enter \"5\" for adding Role                  ");
            Console.WriteLine("Enter \"6\" for viewing all Roles");
            Console.WriteLine("");
            Console.Write("Enter \"7\" for searching project            ");
            Console.WriteLine("Enter \"8\" for searching project through id");
            Console.WriteLine("");
            Console.WriteLine("Enter \"9\" to view all projects");
            Console.WriteLine("");
            Console.WriteLine("                           Enter \"x\" to exit application");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Select operation from above list");
            read = Console.ReadLine();
        }
    }
    }
}