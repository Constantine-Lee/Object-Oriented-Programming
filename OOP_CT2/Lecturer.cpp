/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/* 
 * File:   Lecturer.cpp
 * Author: 100073484
 * 
 * Created on May 9, 2019, 8:22 AM
 */

#include "Lecturer.h"


Lecturer::Lecturer(string name): SchoolMember(name) {
}

Lecturer::~Lecturer() {
}

void Lecturer::SetGrade(SchoolMember* student, Unit* unit, int grade){
    unit->SetGrade(grade); 
}

int Lecturer::GetGrade(SchoolMember* student, Unit* unit){
        student->GetGrade(student, unit);
}

void Lecturer::ViewUnit(SchoolMember* student){
    cout<<"Unit registered :\n";
    Student* studCast = (Student*)(student);
    for(Unit* stud:studCast->getUnits())
    {
        cout<<stud->GetName()<<"\n";        
    } 
}

void Lecturer::ViewUnitDesc(SchoolMember* student){
    Student* studCast = (Student*)(student);
    studCast->ViewUnitDesc(studCast);
}