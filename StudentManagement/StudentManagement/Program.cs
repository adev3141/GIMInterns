using StudentManagement;

class Program
{
    static void Main(string[] args)
    {
        School school = new School();
        string name = "";
        int studentID = 0, grade = 0;
        byte keuze2 = 0;
        Student s;
        Student? student = null;
        Helpdesk helpdesk = new Helpdesk();
      
        string course = "";
        List<int> grades = new List<int>();
        while (true)
        {
            Console.WriteLine("[1] Student records\n[2] Helpdesk\n[3] Add Student\n[4] Add grade");
            int keuze = 0;
            keuze = Convert.ToInt32(Console.ReadLine());
            switch (keuze)
            {
                case 1:
                    Console.WriteLine("Student ID?");
                    studentID = Convert.ToInt32(Console.ReadLine());




                    try
                    {
                        s = school.StudentLookUp[studentID];
                    }

                    catch
                    {
                        Console.WriteLine("Not found");

                        break;
                    }







                    Console.WriteLine("Gevonden");
                    student = s;
                    Console.WriteLine("Naam: " + s.Name + "\nCourse: " + s.Course + "\nGrades: ");
                    foreach (int k in s.Grades)
                    {
                        Console.WriteLine("\n" + k);
                    }
                    Console.WriteLine("[1] Delete\n[2] Update\n[3] Cancel\n[4] See average grade\n[5] Help desk\n");
                    keuze2 = Convert.ToByte(Console.ReadLine());





                    switch (keuze2)
                    {
                        case 1:
                            school.Students.Remove(student);
                            school.StudentLookUp.Remove(studentID);
                            break;
                        case 2:
                            Console.WriteLine("[1] Update course\n[2] Update Name\n");
                            string? updateChoice = Console.ReadLine();
                            if (updateChoice == "1")
                            {
                                Console.WriteLine("Course name?");
                                student.Course = Console.ReadLine();
                                Console.WriteLine("Course updated.");


                            }
                            else if (updateChoice == "2")
                            {
                                Console.WriteLine("New name?");
                                student.Name = Console.ReadLine();
                                Console.WriteLine("Name updated.");

                            }
                            break;
                        case 3:
                            break;
                        case 4:
                            double total = 0;
                            foreach (double k in s.Grades)
                            {
                                total += k;
                                

                            }
                            Console.WriteLine(total / s.Grades.Count);

                            break;
                        
                    }
                    break;







                case 2:

                    break;

                case 3:
                    Console.WriteLine("Student name?");
                    name = Console.ReadLine();
                    Console.WriteLine("Student course?");
                    course = Console.ReadLine();
                    Console.WriteLine("Student Class?");
                    string? studentClass = Console.ReadLine();
                    List<int> newGrades = new List<int>();
                    school.AddStudent(name, course, newGrades, studentClass);
                    break;
                case 4:
                    Console.WriteLine("Student ID?");
                    studentID = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("What grade?");
                    grade = Convert.ToInt32(Console.ReadLine());
                    foreach (Student i in school.Students)
                    {
                        if (i.StudentID == studentID)
                        {
                            int index = school.Students.IndexOf(i);
                          
                            school.StudentLookUp[i.StudentID].Grades.Add(grade);
                            Console.WriteLine();
                            foreach (int k in school.Students[index].Grades) {
                                Console.WriteLine(k);
                            
                            
                            }
                        }


                    }


                    break;
                case 5:
                    Console.WriteLine("[1] Join queue\n[2] Leave queue [3] Show queue");
                    byte keuzeQueue = Convert.ToByte(Console.ReadLine());
                    Console.WriteLine("Student id?");
                    int IDqueue = Convert.ToInt16(Console.ReadLine());
                    if (keuzeQueue == 1) {
                        helpdesk.AddStudentToQueue(school.StudentLookUp[IDqueue]);
                    
                    
                    }
                    else if (keuzeQueue == 2)
                    {
                        helpdesk.RemoveStudentFromQueue(school.StudentLookUp[IDqueue]);


                    }
                    else if(keuzeQueue == 3)
                    {
                        int counterQueue = 0;
                        foreach (Student i in helpdesk.Queue) { 
                            counterQueue++;
                        
                        }
                        Console.WriteLine("The queue is: "+counterQueue);

                    }
                    break;
                case 6:
                    int count1 = 0;
                    int count2 = 0;
                    int count3 = 0;
                    int count4 = 0;
                    double average1 = 0;
                    double average2 = 0;
                    double average3 = 0;
                    double average4 = 0;
                    Console.WriteLine("Class averages:");
                    foreach (Student i in school.Students)
                    {
                        System.Console.WriteLine(i.StudentClass);
                        System.Console.WriteLine(i.Name);
                        if (i.StudentClass == "1")
                        {
                            count1++;
                            average1 += i.Grades.Average();
                            Console.WriteLine(i.Grades.Average());
                            System.Console.WriteLine("1 enzo");
                        }
                        else if (i.StudentClass == "2")
                        {
                            count2++;
                            average2 += i.Grades.Average();
                            System.Console.WriteLine("2 enzo");
                        }
                        else if (i.StudentClass == "3")
                        {
                            count3++;
                            average3 += i.Grades.Average();
                        }
                        else if (i.StudentClass == "4")
                        {
                            count4++;
                            average4 += i.Grades.Average();
                        }


                    }
                    Console.WriteLine(average1 + " " +count1);
                    Console.WriteLine(average2 + " " + count2);
                    Console.WriteLine("Class 1: " + average1/count1);
                    Console.WriteLine("Class 2: " + average2/count2);
                    Console.WriteLine("Class 3: " + average3/count3);
                    Console.WriteLine("Class 4: " + average4/count4);



                    break;
            }
            } 




        
        }
    }
