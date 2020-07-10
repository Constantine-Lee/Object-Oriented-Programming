/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/* 
 * File:   Student.h
 * Author: 100073484
 *
 * Created on May 8, 2019, 9:13 PM
 */

#ifndef STUDENT_H
#define STUDENT_H
#include "SchoolMember.h"


class Student: public SchoolMember{
public:
    
    //set the name of student.
    Student(string name);
    virtual ~Student();
    
    //add unit into student
    void AddUnit(Unit* unit);    
    
    //return the grade of unit
    int GetGrade(SchoolMember*student, Unit* unit);
    
    //view the unit registered.
    void ViewUnit(SchoolMember* student);
    
    //view the unit description.
    void ViewUnitDesc(SchoolMember* student);
    
    //return a vector of pointer to Unit.
    vector<Unit*> getUnits();
    
private:
    vector<Unit*> _units;    
};

#endif /* STUDENT_H */

