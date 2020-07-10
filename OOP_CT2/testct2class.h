/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/*
 * File:   testct2class.h
 * Author: 100073484
 *
 * Created on May 16, 2019, 5:49:54 PM
 */

#ifndef TESTCT2CLASS_H
#define TESTCT2CLASS_H

#include <cppunit/extensions/HelperMacros.h>

class testct2class : public CPPUNIT_NS::TestFixture {
    CPPUNIT_TEST_SUITE(testct2class);

    CPPUNIT_TEST(testUnitSetGrade);
    CPPUNIT_TEST(testUnitDeepCopy);
    CPPUNIT_TEST(testUnitEqualOperatorOverloading);
    CPPUNIT_TEST(testStudentGetName);
    CPPUNIT_TEST(testLecturerGetName);
    //CPPUNIT_TEST(testUnitGetDescription);
    
    CPPUNIT_TEST_SUITE_END();

public:
    testct2class();
    virtual ~testct2class();
    void setUp();
    void tearDown();

private:
    void testUnitSetGrade();
    void testUnitDeepCopy();
    void testUnitEqualOperatorOverloading();
    void testStudentGetName();
    void testLecturerGetName();
    //void testUnitGetDescription();
    
};

#endif /* TESTCT2CLASS_H */

