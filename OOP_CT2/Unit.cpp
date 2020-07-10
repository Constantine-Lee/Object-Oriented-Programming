/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/* 
 * File:   Unit.cpp
 * Author: 100073484
 * 
 * Created on May 8, 2019, 9:13 PM
 */

#include "Unit.h"
#include <iostream>

Unit::Unit(string name, string description, int grade) {
    _name = name;
    _desc = description;
    _grade = grade;
}

Unit::Unit(const Unit& orig) {
    this->_name = orig._name;
}

void Unit::operator=(const Unit& orig) {
    this->_name = orig._name;
}

string Unit::GetName(){
    return _name;
}

void Unit::SetGrade(int grade){
    _grade = grade;
    cout<<"Grade updated";
}

int Unit::GetGrade(){
    return _grade;
}

string Unit::GetDesc(){
    return _desc;
}

Unit::~Unit() {
}

