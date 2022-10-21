namespace Console_Program
{
    class Project
    {
        /// <summary>Выводит сообщение в консоль и преобразует пользовательский ввод.</summary>
        /// <param name="message">Выводимое в консоль сообщение</param>
        /// <returns>Число типа Double</returns>
        static public double ConsoleInputDouble( string message="" ) {
            Console.Write( message );
            return double.Parse( Console.ReadLine() ?? "" );
        }


        private static void Main( string[] args ) {
            string result = "";
            // Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями:
            Console.WriteLine( "\nЗадача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями.\n" );

            // значения b1, k1, b2 и k2 задаются пользователем.
            // b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
            double b1 = ConsoleInputDouble( "Введите b1 = " );
            double k1 = ConsoleInputDouble( "Введите k1 = " );
            double b2 = ConsoleInputDouble( "Введите b2 = " );
            double k2 = ConsoleInputDouble( "Введите k2 = " );

            // x = ( b2 - b1 ) / ( k1 - k2 );   y = k1 * x + b1;   y = k2 * x + b2;
            // y = ( k2 * b1 - k1 * b2 ) / ( k2 - k1 );
            if ( k1 != k2 ) {
                double x = ( b2 - b1 ) / ( k1 - k2 );
                double y = k1 * x + b1 ;
                result = $"Точка пересечения ({x}; {y})";
            } else {
                if ( b1 == b2 )
                    result = "Прямые совпадают";
                else
                    result = "Прямые параллельны";
            }

            Console.WriteLine( $"b1 = {b1}, k1 = {k1}, b2 = {b2}, k2 = {k2} -> {result}" );
        }
    }
}
