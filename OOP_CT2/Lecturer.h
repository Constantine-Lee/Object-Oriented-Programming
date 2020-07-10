/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/* 
 * File:   Lecturer.h
 * Author: 100073484
 *
 * Created on May 9, 2019, 8:22 AM
 */

#ifndef LECTURER_H
#define LECTURER_H
#include "SchoolMember.h"
#include "Student.h"


class Lecturer: public SchoolMember {
public:
    
    //set the name of lecturer.
    Lecturer(string name);
    virtual ~Lecturer();
    
    //set the grade of unit of a student.
    void SetGrade(SchoolMember* student, Unit* unit, int grade);  
    
    //return the grade of a unit of a student.
    int GetGrade(SchoolMember* student, Unit* unit);
    
    //view the unit registered of a student. 
    void ViewUnit(SchoolMember* student);
    
    //view the unit description of a student. 
     void ViewUnitDesc(SchoolMember* student);
private:

};

#endif /* LECTURER_H */

