/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/* 
 * File:   SchoolMember.cpp
 * Author: 100073484
 * 
 * Created on May 9, 2019, 8:43 AM
 */

#include "SchoolMember.h"

SchoolMember::SchoolMember(string name) {
    _name = name;
}

SchoolMember::~SchoolMember() {
}

string SchoolMember::GetName(){
    return _name;
}
