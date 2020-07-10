/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/*
 * File:   CreditTest.h
 * Author: 100073484
 *
 * Created on May 16, 2019, 5:33:40 PM
 */

#ifndef CREDITTEST_H
#define CREDITTEST_H

#include <cppunit/extensions/HelperMacros.h>

class CreditTest : public CPPUNIT_NS::TestFixture {
    CPPUNIT_TEST_SUITE(CreditTest);

    CPPUNIT_TEST(testMethod);
    CPPUNIT_TEST(testFailedMethod);

    CPPUNIT_TEST_SUITE_END();

public:
    CreditTest();
    virtual ~CreditTest();
    void setUp();
    void tearDown();

private:
    void testMethod();
    void testFailedMethod();
};

#endif /* CREDITTEST_H */

