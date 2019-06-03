#include <iostream>



using namespace std;

int if1(int a)

{



    if (a > 0) {

        a += 1;

    }

    return a;

}

int if2(int b)

{

    if (b > 0) {

        return b += 1;

    }

    if (b < 0) {

        return b = b - 2;

    }

}

int if3(int c)

{

    if (c > 0) {

        return c += 1;

    }

    if (c < 0) {

        return c -= 2;

    }

    else

        return c += 10;

}

int if4(int d, int e, int g)

{

    int count = 0;

    if (d > 0) {

        count += 1;

    }

    if (e > 0) {

        count += 1;

    }

    if (g > 0) {

        count += 1;

    }

    return count;

}



void if5(int a, int b, int c)

{

    int count1 = 0;

    int count2 = 0;

    if (a > 0) {

        count1++;

    }

    else {

        count2++;

    }

    if (b > 0) {

        count1++;

    }

    else {

        count2++;

    }

    if (c > 0) {

        count1++;

    }

    else {

        count2++;

    }

    cout << "kol-vo pol " << count1 << endl;

    cout << "kol-vo ot  " << count2 << endl;

}

void if6(int a, int b)

{

    if (a > b) {

        cout << a;

    }

    if (a < b) {

        cout << b;

    }

}

void if7(int a, int b)

{

    if (a > b) {

        cout << "1";

    }

    if (a < b) {

        cout << "2";

    }

}

void if8(int a, int b)

{

    if (a > b) {

        cout << a << " " << b;

    }

    if (b > a) {

        cout << b << " " << a;

    }

}

void if9(double a, double b)

{

    double temp;

    if (a > b) {

        temp = a;

        a = b;

        b = temp;

        cout << a << " " << b;

    }

}

void if10(int a, int b)

{

    if (a != b) {

        int c = a + b;

        a = a + c;

        b = b + c;

        cout << a << " " << b;

    }

    if (a == b) {

        a = b = 0;

        cout << a << " " << b;

    }

}

void if11(int a, int b)

{

    if (a != b) {

        if (a == b) {

            a = b = 0;

        }

        if (a > b) {

            b = a;

        }

        if (b > a) {

            a = b;

        }



        cout << a << " " << b;

    }

}

int if12(int a, int b)

{

    if (b > a) {

        return a;

    }

    if (b < a) {

        return b;

    }

}

int if13(int a, int b, int c)

{

    if (a > b || a > c) {

        if (b > c) {

            cout << b << endl;

        }

        else {

            cout << c << endl;

        }

    }

    else {

        cout << a << endl;

    }

}

void if14(int a, int b, int c)

{

    int max, min;

    if (a >= b && a >= c)

        max = a;

    else if (b >= a && b >= c)

        max = b;

    else

        max = c;



    if (a <= b && b <= c)

        min = a;

    else if (b <= a && b <= c)

        min = b;

    else

        min = c;

    cout << max;

    cout << min;

}

int if15(int a, int b, int c)

{



    return a + b + c;

}

void if16(double a, double b, double c)

{

    if (a < b && a < c && b < c) {

        a *= 2;

        b *= 2;

        c *= 2;

        cout << a << " " << b << " " << c;

    }

    else {

        a *= -1;

        b *= -1;

        c *= -1;

        cout << a << " " << b << " " << c;

    }

}

int if20(int a, int b, int c)

{

    int k = b - a;

    int z = c - a;

    if (k > z)

        return k;

    if (k < z)

        return z;

}



int main()

{

    cout << if1(2) << endl;

    cout << if2(4) << endl;

    cout << if3(0) << endl;

    cout << if4(5, 3, 1) << endl;

    if5(2, 1, -1);

    if6(4, 3);

    if7(5, 6);

    if8(4, 2);

    if9(5.1, 4.3);

    if10(8, 8);

    if11(4, 6);

    cout << if12(if12(7, 6), 1);

    if13(4, 6, 9);

    if14(7, 9, 2);

    cout << if15(3, 5, 7) - if12(if12(3, 5), 7);

    cout << if20(10, 15, 30);

    if16(10.1, 4.3, 5.2);



    return 0;

}

