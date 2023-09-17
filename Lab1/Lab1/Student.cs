﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class Student
    {
        private string _fullName;
        private string _major;
        private int _admissionYear;
        private int _course;

        public string FullName
        {
            get { return _fullName; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                    _fullName = value;
                else
                    throw new ArgumentException("Введите непустое ФИО");
            }
        }
        public string Major
        {
            get { return _major; }
            set 
            {
                if (!string.IsNullOrEmpty(value))
                    _major = value;
                else
                    throw new ArgumentException("Направление введено неверно");
            }
        }
        public int AdmissionYear
        {
            get { return _admissionYear; }
            set
            {
                if (value > 0)
                    _admissionYear = value;
                else
                    throw new ArgumentException("Год должен быть положительным");
            }
        }
        public int Course
        {
            get { return _course; }
            set
            {
                if (1 <= value & value <= 4)
                    _course = value;
                else
                    throw new ArgumentException("Курс должен быть от 1 до 4 включительно");
            }
        }

        public Student(string fullName, string major, int admissionYear, int course)
        {
            this.FullName = fullName;
            this.Major = major;
            this.AdmissionYear = admissionYear;
            this.Course = course;
        }

        public void CloseSession(string sessionType)
        {
            if (sessionType == "summer")
            {
                if (_course == 4)
                {
                    Expel();
                    GetDiploma();
                }
                else
                    _course++;
            }
        }

        public void Expel()
        {
            _major = "None";
            _admissionYear = 0;
            _course = 0;
        }
        public string[] GetInfo()
        {
            string[] info = {_fullName, _major, Convert.ToString(_admissionYear), Convert.ToString(_course)};
            return info;
        }

        private string GetDiploma()
        {
            return "This student waas given a diploma";
        }
    }
}
