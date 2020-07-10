/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/* 
 * File:   SchoolMember.h
 * Author: 100073484
 *
 * Created on May 9, 2019, 8:43 AM
 */

#ifndef SCHOOLMEMBER_H
#define SCHOOLMEMBER_H
#include <iostream>
#include <vector>
#include <string>
#include "Unit.h"
using namespace std;


class SchoolMember {
public:
    SchoolMember(string name);    
    virtual ~SchoolMember();
    
    //get the grade of student.
    virtual int GetGrade(SchoolMember*student, Unit* unit) {}
    
    //view the unit of student.
    virtual void ViewUnit(SchoolMember* student) {}
    
    //view the description of unit.
    virtual void ViewUnitDesc(SchoolMember* student) {}
    
    //return the name of SchoolMember.
    string GetName();
private:
    string _name;
};

#endif /* SCHOOLMEMBER_H */

