/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/* 
 * File:   Student.cpp
 * Author: 100073484
 * 
 * Created on May 8, 2019, 9:13 PM
 */

#include "Student.h"

Student::Student(string name): SchoolMember(name) {
   
}


void Student::AddUnit(Unit* unit){
    _units.push_back(unit);    
}
vector<Unit*> Student::getUnits(){
    return _units;
}


int Student::GetGrade(SchoolMember* student, Unit* unit){
    cout<<unit->GetName()<<" :";
    cout<<unit->GetGrade()<<"\n";    
}

void Student::ViewUnit(SchoolMember* student){
    int i =0;
    cout<<"Unit registered :\n";
    for(Unit* unit:_units)
    {
        i++;
        cout<<i<<" :"<<unit->GetName()<<"\n";        
    }    
}

void Student::ViewUnitDesc(SchoolMember* student){
    cout<<"Unit description :\n";
    for(Unit* unit:_units)
    {
        cout<<unit->GetName()<<" :"<<unit->GetDesc()<<"\n";        
    } 
}

Student::~Student() {
}

