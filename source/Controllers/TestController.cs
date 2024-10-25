using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TestApp.Controllers
{
    public class TestController : Controller
    {
        /// <summary>
        /// Method to check if all the letters of alphabet are present in the input string
        /// </summary>
        /// <param name="inputString"></param>
        /// <returns></returns>
        [HttpGet("Test/StringCheck")]
        public bool Index(string inputString)
        {
            //inputString = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            bool charFound = false;
            bool result = true;

            int lowerCaseAsciiIndex = 97;
            int upperCaseAsciiIndex = 65;

            if (!string.IsNullOrEmpty(inputString))
            {
                for (int j = 0; j < 26; j++)
                {
                    charFound = false;
                    for (int i = 0; i < inputString.Length; i++)
                    {
                        if ((int)inputString[i] == lowerCaseAsciiIndex ||
                            (int)inputString[i] == upperCaseAsciiIndex)
                        {
                            charFound = true;
                            break;
                        }
                    }
                    if (!charFound)
                    {
                        result = false;
                        break;
                    }
                    lowerCaseAsciiIndex++;
                    upperCaseAsciiIndex++;
                }
                return result;
            }
            else
                return false;
        }
    }
}
