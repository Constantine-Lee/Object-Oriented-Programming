#include <cstdlib>
#include <iostream>
#include "Unit.h"
#include "Student.h"
#include <vector>
#include "Lecturer.h"
using namespace std;

/*
 * 
 */

//function to choose student. 
int static ChooseStud(vector<SchoolMember*> studentList)
{
    int studNO = 0, chooseStud = 0;
    cout<<"\nList of students :\n";
    for(SchoolMember* stud:studentList)
    {   studNO++;     
        cout<<studNO<< " :"<<stud->GetName()<<"\n";
    }
    cout<<"\nChoose the student based on the number :";    
    cin>>chooseStud;     
    return chooseStud-1;
}

//function to choose unit.
int static ChooseUnit(SchoolMember* student)
{
    int chooseUnit = 0;    
    student->ViewUnit(student);    
    cout<<"\nChoose the unit based on the number :";
    cin>>chooseUnit;
    return chooseUnit-1;
}

int main(int argc, char** argv) {
    vector<Unit*> unitList;
    
    //create 4 unit.
    Unit* unit1 = new Unit("OOP", "Teach about object-oriented programming.", 0);   
    Unit* unit2 = new Unit("WEB", "Teach about creating web-application.", 0);
    Unit* unit3 = new Unit("FDM", "Teach about fundamental data management.", 0);
    Unit* unit4 = new Unit("FOT", "Teach about foundation of statistic.", 0);
    
    unitList.push_back(unit1);
    unitList.push_back(unit2);
    unitList.push_back(unit3);
    unitList.push_back(unit4);
            
    vector<SchoolMember*> studentList;
    
    Student* student1 = new Student("Lee");
    student1->AddUnit(unit1);
    student1->AddUnit(unit2);
    student1->AddUnit(unit3);

    
    studentList.push_back(student1);
    
    Student* student2 = new Student("Ricky");
    student2->AddUnit(unit1);
    student2->AddUnit(unit2);
    student2->AddUnit(unit4);
    
    studentList.push_back(student2);
    
    Lecturer* lecturer1 = new Lecturer("Mr.Hamada");
    SchoolMember* exec ;


    while(1)
    {
    int chooseRole = 0, chooseFunction = 0, chooseGrade = 0, chooseStud = 0, chooseUnit = 0;
    system("CLS");    
    cout<<"\nPlay as (1)Lecturer or (2)Student? :";
    cin>>chooseRole;
    //play as lecturer.
    if(chooseRole == 1)
    {
        exec = lecturer1;
        cout<<"\n(1)Update student grade, (2)View Student grade, (3)View Student Registered Units or (4)View Student Units Description? :";
        cin>>chooseFunction;
        //update student grade.
        if(chooseFunction == 1)
        {              
            chooseStud = ChooseStud(studentList);
            chooseUnit = ChooseUnit(studentList.at(chooseStud));                    
            cout<<"\nEnter grade(0-100) :";
            cin>>chooseGrade;
            lecturer1->SetGrade(studentList.at(chooseStud), unitList.at(chooseUnit), chooseGrade);            
        }
        //view student grade.
        else if(chooseFunction == 2)
        {
            chooseStud = ChooseStud(studentList);  
            chooseUnit = ChooseUnit(studentList.at(chooseStud));     
            exec->GetGrade(studentList.at(chooseStud), unitList.at(chooseUnit));
        }
        //view student units.
        else if(chooseFunction == 3)
        {
            chooseStud = ChooseStud(studentList);   
            exec->ViewUnit(studentList.at(chooseStud));            
        }
        //view student unit description.
        else if(chooseFunction == 4)
        {
            chooseStud = ChooseStud(studentList);
            exec->ViewUnitDesc(studentList.at(chooseStud));
        }       
    }
    //play as student.
    else if(chooseRole == 2)
    {
        chooseStud = ChooseStud(studentList); 
        exec = studentList.at(chooseStud);
        
        cout<<"\n(1)View grade, (2)View Units Registered or (3)View Units Description? :"; 
        cin>>chooseFunction;
             
        //view grade.
        if(chooseFunction == 1)
        {
            chooseUnit = ChooseUnit(studentList.at(chooseStud));
            exec->GetGrade(exec, unitList.at(chooseUnit));
        }        
        //view units registered.
        else if(chooseFunction == 2)
        {
            exec->ViewUnit(exec);
        }        
        //view unit description.
        else if(chooseFunction == 3)
        {
            exec->ViewUnitDesc(studentList.at(chooseStud));
        }
    }   cout<<"\n===========================================================\n";        
        system("pause");
    }
    
    return 0;
}

