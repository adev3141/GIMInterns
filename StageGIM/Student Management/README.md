
# Student File Management System
 ## Overview 
 This application is a Student File Management System that allows users to manage student records. It supports adding and removing students, as well as serializing and deserializing student data to and from JSON and XML files. 
 ## Code Description The application includes functionality for managing student records and handling file operations for data persistence. The main components are: 
 ### Key Classes 
 - **ManageStudent**: Manages a list of students with methods to add and remove students. 
 - **Serialization**: Handles serialization and deserialization of student data to/from JSON and XML files. 
 - **Student**: Represents a student with properties such as Name. 
 ### Features 
 - **Add Student**: Allows users to add new students to the system. 
 -  **Remove Student**: Allows users to remove existing students. 
 -  **Serialize to JSON File**: Converts the list of students to a JSON format and saves it to a file. 
 -  **Deserialize from JSON File**: Reads student data from a JSON file and loads it into the application. 
 -  **Serialize to XML File**: Converts the list of students to XML format and saves it to a file. 
 -  **Deserialize from XML File**: Reads student data from an XML file and loads it into the application. 
 - ## Instructions 
 1. **Running the Application**: 
 - Compile and run the `MainWindow` class. 
 -  Use the menu to select various options for managing student records and handling file operations. 
 2. **Menu Options**: 
  - `1`: Add a new student. 
  -  `2`: Remove an existing student. 
  - `3`: Serialize the list of students to a JSON file (`students.json`). 
  - `4`: Deserialize the list of students from the JSON file (`students.json`). 
  -  `5`: Serialize the list of students to an XML file (`students.xml`). 
  -  `6`: Deserialize the list of students from the XML file (`students.xml`). 
  -  `7`: Exit the application.
