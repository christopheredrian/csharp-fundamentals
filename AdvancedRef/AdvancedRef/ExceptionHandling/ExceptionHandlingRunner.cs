using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AdvancedRef.ExceptionHandling
{
    class ExceptionHandlingRunner
    {
        public static void Run()
        {
            ReadFile();
        }

        public static void Arithmetic()
        {
            try
            {
                var calculator = new Calculator();
                var result = calculator.Divide(5, 0);

                Console.WriteLine(result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("You cannot divide by 0");
            }
            catch (ArithmeticException ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("@Finally");
            }
        }

        public static void ReadFile()
        {
            //StreamReader streamReader = null;
            //try
            //{
            //    streamReader = new StreamReader(@"c:\file.zip");
            //    var content = streamReader.ReadToEnd();
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //} 
            //finally
            //{
            //    if (streamReader != null)
            //    {
            //        streamReader.Dispose();
            //    }
            //}

            try
            {
                using (var streamReader = new StreamReader(@"c:\file.zip"))
                {
                    var content = streamReader.ReadToEnd();
                }

            }
            catch (Exception ex) 
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
