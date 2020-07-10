/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/*
 * File:   testct2class.cpp
 * Author: 100073484
 *
 * Created on May 16, 2019, 5:49:54 PM
 */

#include "testct2class.h"
#include "Unit.h"
#include "Student.h"
#include "Lecturer.h"

CPPUNIT_TEST_SUITE_REGISTRATION(testct2class);

testct2class::testct2class() {
}

testct2class::~testct2class() {
}

void testct2class::setUp() {
}

void testct2class::tearDown() {
}

void testct2class::testUnitSetGrade() {
    Unit* unit1 = new Unit("OOP", "Teach about object-oriented programming.", 0); 
    unit1->SetGrade(80);
    CPPUNIT_ASSERT(unit1->GetGrade()==80);
}

void testct2class::testUnitDeepCopy() {
    Unit* unit1 = new Unit("OOP", "Teach about object-oriented programming.", 0); 
    Unit* unit2 = new Unit(*unit1);
    CPPUNIT_ASSERT(unit2->GetName()=="OOP");
}

void testct2class::testUnitEqualOperatorOverloading() {
    Unit* unit1 = new Unit("OOP", "Teach about object-oriented programming.", 0); 
    Unit* unit2 = new Unit("WEB", "Teach about creating web-application.", 0);
    unit2 = unit1;
    CPPUNIT_ASSERT(unit2->GetName()=="OOP");
}

void testct2class::testStudentGetName(){   
    Student* student1 = new Student("Lee");    
    CPPUNIT_ASSERT(student1->GetName()=="Lee");
}

void testct2class::testLecturerGetName(){   
    Lecturer* lecturer1 = new Lecturer("Mr.Hamada");   
    CPPUNIT_ASSERT(lecturer1->GetName()=="Mr.Hamada");
}
