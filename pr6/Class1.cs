using System;

namespace TriangleApp
{
    public class Triangle
    {
        //������� ������������
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }

        //���������� ���������
        public double GetPerimeter()
        {
            return SideA + SideB + SideC;
        }

        // ������������� ����� ��� ��������� ������
        public void SetParams(double a, double b, double c)
        {
            SideA = a;
            SideB = b;
            SideC = c;
        }

        // ������������� ����� ���������� ������������ � 2 ����
        public void SetParams(double dvax)
        {
            SideA *= dvax;
            SideB *= dvax;
            SideC *= dvax;
        }
        
        
    }
}