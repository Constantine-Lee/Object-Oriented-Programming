/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/* 
 * File:   Unit.h
 * Author: 100073484
 *
 * Created on May 8, 2019, 9:13 PM
 */

#ifndef UNIT_H
#define UNIT_H
#include <string>
using namespace std;

class Unit {
public:
    
    //set the name, description and initial grade of unit.
    Unit(string name, string description, int grade);
    Unit(const Unit& orig);
    virtual ~Unit();
    
    //return the name of unit.
    string GetName();
    
    //overload the operator= to perform deep copy.
    void operator=(const Unit& orig);
    
    //set the grade of unit.
    void SetGrade(int grade);
    
    //return the grade of unit.
    int GetGrade();
    
    //return the description of unit.
    string GetDesc();
private:
    string _name;
    string _desc;
    int _grade;
};

#endif /* UNIT_H */

