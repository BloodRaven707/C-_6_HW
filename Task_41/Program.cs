namespace Console_Program
{
    class Project
    {
        private static void Main( string[] args ) {
            // Задача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
            Console.WriteLine( "\nЗадача 41. Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.\n" );

            // 0, 7, 8, -2, -2 -> 2
            // -1, -7, 567, 89, 223 -> 3
            Console.WriteLine( "Введите несколько чисел через запятую." );
            string input_string = Console.ReadLine() ?? "";
            int count_numbers = 0;
            
            string temp_string = string.Empty;

            for ( int i = 0; i < input_string.Length; i++ )
            {
                // Набор символов образующих целое число
                if ( ( input_string[i] >= '0' && input_string[i] <= '9') || ( input_string[i] == '-' && temp_string == string.Empty ) )
                    temp_string += input_string[i];

                // Если встретили символ ',' или конец строки
                if ( ( input_string[i] == ',' || i == input_string.Length - 1 ) && temp_string != string.Empty )
                {
                    // [!] Выдает ошибку при переполнении типа int32 (445ьолд55ю ю5ю545ю4 4ю34бю535ю435 ю453ю435 .35. 535бю5б34ю354юб53)
                    int new_number = Convert.ToInt32( temp_string );
                    temp_string = string.Empty;

                    Console.WriteLine( new_number );

                    if ( new_number > 0 )
                        count_numbers++;
                }
            }

            Console.WriteLine( $"\nВо введененной строке: \"{input_string}\"" );
            Console.WriteLine( $"Количество положительных чисел -> {count_numbers}\n" );
        }
    }
}