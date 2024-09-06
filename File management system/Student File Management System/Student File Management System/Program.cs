
using System.Text.Json;
using System.Xml.Serialization;
using System.IO;
using System.Xml;
using System.Xml.Serialization;
using System.Data.SqlTypes;
using System.Diagnostics;
namespace Student_File_Management_System
{
    class Program
    {

        static void Main(string[] args)
        {
            // Display the number of command line arguments.
            bool loop = true;
            string path = "C:\\Users\\nijme\\Desktop\\OpdrachtenStage\\File management system\\Student File Management System\\dataFiles\\";
            Student k = null;
            ToXml xml = new ToXml();
            SavedRecords savedRecords = new SavedRecords();
            Student chosenStudent = null;
            School school = new School();
            while (loop) {
                Console.WriteLine("[1] Add student\n[2] Remove student\n[3] Load record\n[4] Save record\n[5] Add grade");
                int choice = Convert.ToInt32 (Console.ReadLine());
                if (choice < 1 || choice > 5) {
                    Console.WriteLine("Not an option.");
                    continue;
                
                }
                switch (choice) {

                    case 1:
                        Console.WriteLine("Student name?");
                        string name = Console.ReadLine().ToLower();
                        Console.WriteLine("Student course?");
                        string course = Console.ReadLine().ToLower();
                        Student student = new Student();
                        student.setStudent(name, course);
                        school.Students.Add(student);
                        Console.WriteLine("Student added");
                        
                        break;
                    case 2:
                        Console.WriteLine("Student ID?");
                        int id = Convert.ToInt32 (Console.ReadLine());
                        foreach (Student i in school.Students) {
                           
                            if (id == i.StudentID)
                            {
                                 k = i;


                            }
                           
                        
                        }
                        school.Students.Remove(k);
                       
                        
                        break;
                    case 3:
                        Console.WriteLine("Student ID?");
                        int counter = 0;
                        int id2 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("File name? (Including extension)");   
                        string fileNameLoad = Console.ReadLine();
                        string loadFile = path + fileNameLoad;

                        string file = File.ReadAllText(loadFile);
                        
                        Console.WriteLine(file);
                            
                        if(counter == 0)
                        {
                            Console.WriteLine("Doesnt exist.");

                        }

                        break;
                    case 4:
                        Console.WriteLine("Student ID?");
                       
                        int counter2 = 0;
                        int id3 = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("[1] JSON\n[2] XML");
                        int fileKeuze = Convert.ToInt32(Console.ReadLine());
                        foreach (Student i in school.Students)
                        {
                            if (i.StudentID == id3)
                            {
                                if(fileKeuze == 1) {
                                    Console.WriteLine("File name?");
                                    string fileName = Console.ReadLine()+".json";
                                    string path2 = path+fileName;
                                    using (StreamWriter sw = new StreamWriter(path2))
                                    {
                                        var jsonString = JsonSerializer.Serialize(i);
                                        Console.WriteLine(jsonString);
                                        savedRecords.JsonRecords.Add(jsonString);
                                        sw.WriteLine(jsonString);
                                    }



                                }
                                else if (fileKeuze == 2)
                                {
                                    Console.WriteLine("File name?");
                                    string fileName = Console.ReadLine() + ".xml";
                                    string path2 = path + fileName;
                                    using (StreamWriter sw = new StreamWriter(path2))
                                    {
                                        string xmlString = xml.SerializeToXml(i);
                                        Console.WriteLine(xmlString);
                                        savedRecords.XmlRecords.Add(xmlString);
                                        sw.WriteLine(xmlString);
                                    }
                                    
                                }
                                else { 
                                    Console.WriteLine("Not an option");
                                    
                                }

                               
                              

                            }
                           



                        }
                        

                        break;
                    case 5:
                        Console.WriteLine("Student ID?");
                        int studentID = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("What grade?");
                        int grade = Convert.ToInt32(Console.ReadLine());
                        foreach (Student i in school.Students)
                        {
                            if (i.StudentID == studentID)
                            {
                                int index = school.Students.IndexOf(i);
                                school.Students[index].Grades.Add(grade);
                                
                            }


                        }
                        break;
                
                }
            
            
            
            }
        }
        
    }
    
}
