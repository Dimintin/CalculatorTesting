using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test11_20.Windows;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test11_20.Windows.Tests
{
    [TestClass()]
    public class RegistWindowTests
    {

        RegistWindow registWindow = new RegistWindow();

        // Тест пароля

        // Тест, что символов больше 8

        [TestMethod()]
        public void Check_PasswordMoreThan8Symbols_ReturnTrue()
        {
            string password = "PSd134%_";
            bool expected = true;

            bool actual = registWindow.ValidatePassword(password);

            Assert.AreEqual(expected, actual);
        }

        // Тест, что символов больше 35
        [TestMethod()]
        public void Check_PasswordMoreThan35Symbols_ReturnFalse()
        {
            string password = "PSwd1234%PSwd1234%PSwd1234%PSwd1234%PSwd1234%";
            bool expected = false;

            bool actual = registWindow.ValidatePassword(password);

            Assert.AreEqual(expected, actual);
        }

        // Тест, что символов меньше 8
        [TestMethod()]
        public void Check_PasswordLessThan8Symbols_ReturnFalse()
        {
            string password = "PSwd12";
            bool expected = false;

            bool actual = registWindow.ValidatePassword(password);

            Assert.AreEqual(expected, actual);
        }

        // Тест, что в пароле есть числа
        [TestMethod()]
        public void Check_PassworHasDigits_ReturnTrue()
        {
            string password = "PSwd13t_123%";
            bool expected = true;

            bool actual = registWindow.ValidatePassword(password);

            Assert.AreEqual(expected, actual);
        }

        // Тест, что в пароле нет чисел
        [TestMethod()]
        public void Check_PasswordHasNoDigits_ReturnFalse()
        {
            string password = "PSwdopDr$#%_";
            bool expected = false;

            bool actual = registWindow.ValidatePassword(password);

            Assert.AreEqual(expected, actual);
        }

        // Тест, что в пароле есть специальные символы
        [TestMethod()]
        public void Check_PasswordHasSpecSymbols_ReturnTrue()
        {
            string password = "PSwd1234%_";
            bool expected = true;

            bool actual = registWindow.ValidatePassword(password);

            Assert.AreEqual(expected, actual);
        }

        // Тест, что в пароле нет специальных сиволов
        [TestMethod()]
        public void Check_PasswordHasNoSpecSymbols_ReturnFalse()
        {
            string password = "PSwd1234hyj";
            bool expected = false;

            bool actual = registWindow.ValidatePassword(password);

            Assert.AreEqual(expected, actual);
        }

        // Тест, что в пароле есть заглавные буквы
        [TestMethod()]
        public void Check_PasswordHasUpperLetters_ReturnTrue()
        {
            string password = "PSwd1234%_";
            bool expected = true;

            bool actual = registWindow.ValidatePassword(password);

            Assert.AreEqual(expected, actual);
        }

        // Тест, что в пароле есть прописные буквы
        [TestMethod()]
        public void Check_PasswordHasLowersLetters_ReturnTrue()
        {
            string password = "PSwd1234%_";
            bool expected = true;

            bool actual = registWindow.ValidatePassword(password);

            Assert.AreEqual(expected, actual);
        }

        // Тест, что в пароле нет прописных букв
        [TestMethod()]
        public void Check_PasswordHasNoUpperLetters_ReturnFalse()
        {
            string password = "_7wd1234%_";
            bool expected = false;

            bool actual = registWindow.ValidatePassword(password);

            Assert.AreEqual(expected, actual);
        }

        // Проверка логина


        // Тест, что в теле логина больше 10 символов
        [TestMethod()]
        public void Check_LoginBodyMoreThan10Symbols_ReturnTrue()
        {
            string login = "LoginOfMe1234#.calcul";
            bool expected = true;

            bool actual = RegistWindow.ValidateLogin(login);

            Assert.AreEqual(expected, actual);
        }



        // Тест, что во всем логине больше 35 символов
        [TestMethod()]
        public void Check_LoginMoreThan35Symbols_ReturnFalse()
        {

            string login = "LoginOfMe1234%LoginOfMe1234Log&%#inOfMe1234.calcul";
            bool expected = false;

            bool actual = RegistWindow.ValidateLogin(login);

            Assert.AreEqual(expected, actual);
        }


        // Тест, что в теле логина меньше 10 символов
        [TestMethod()]
        public void Check_LoginBodyLessThan10Symbols_ReturnFalse()
        {
            string login = "Log1234#.calcul";
            bool expected = false;

            bool actual = RegistWindow.ValidateLogin(login);

            Assert.AreEqual(expected, actual);
        }


        // Тест, что в теле логина есть числа
        [TestMethod()]
        public void Check_LoginBodyHasdigits_ReturnTrue()
        {
            string login = "LoginOfMy1234#.calcul";
            bool expected = true;

            bool actual = RegistWindow.ValidateLogin(login);

            Assert.AreEqual(expected, actual);
        }

        // Тест, что в теле логина нет чисел
        [TestMethod()]
        public void Check_LoginBodyHasNoDigits_ReturnFalse()
        {
            string login = "LoginforMePlease#.calcul";
            bool expected = false;

            bool actual = RegistWindow.ValidateLogin(login);

            Assert.AreEqual(expected, actual);
        }

        // Тест, что в теле логина есть заглавные буквы
        [TestMethod()]
        public void Check_LoginBodyHasUpperLetters_ReturnTrue()
        {
            string login = "LoginOfMe1234#.calcul";
            bool expected = true;

            bool actual = RegistWindow.ValidateLogin(login);

            Assert.AreEqual(expected, actual);
        }

        // Тест, что в теле логина есть прописные буквы
        [TestMethod()]
        public void Check_LoginBodyHasLowerLetters_ReturnTrue()
        {
            string login = "LoginOfMe1234#.calcul";
            bool expected = true;

            bool actual = RegistWindow.ValidateLogin(login);

            Assert.AreEqual(expected, actual);
        }

        // Тест, что в теле логина есть специальные символы
        [TestMethod()]
        public void Check_LoginBodyHasSpecialSymbols_ReturnTrue()
        {
            string login = "LoginOfMe12_?&#.calcul";
            bool expected = true;

            bool actual = RegistWindow.ValidateLogin(login);

            Assert.AreEqual(expected, actual);
        }

        // Тест, что в теле логина нет специальных символов
        [TestMethod()]
        public void Check_LoginBodyHasNoSpecialSymbols_ReturnFalse()
        {
            string login = "LogginOfMe12340921.calcul";
            bool expected = false;

            bool actual = RegistWindow.ValidateLogin(login);

            Assert.AreEqual(expected, actual);
        }

        // Тест, что в логине нет соответствующего окончания (.calcul)
        [TestMethod()]
        public void Check_LoginHasNoEnding_ReturnFalse()
        {
            string login = "LoginMethodOfMe1234#1344";
            bool expected = false;

            bool actual = RegistWindow.ValidateLogin(login);

            Assert.AreEqual(expected, actual);
        }
    }
}