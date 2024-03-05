using System;

namespace HW2
{
    public static class FileName
    {
        public static void Task1()
        {
            // Оголошення масивів
            double[] A = new double[5];
            double[,] B = new double[3, 4];

            // Заповнення масиву A користувачем
            Console.WriteLine("Enter a value for array A:");
            for (int i = 0; i < A.Length; i++)
            {
                Console.Write($"A[{i}]: ");
                A[i] = double.Parse(Console.ReadLine());
                //double.Parse(...): Цей метод приймає рядок і намагається перетворити його на вказаний числовий тип, в нашому випадку - double.
            }

            // Заповнення масиву B випадковими числами
            Random rand = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    // Генеруємо випадкове число в діапазоні [0, 100) з двома знаками після коми 
                    B[i, j] = Math.Round(rand.NextDouble() * 100, 2);
                    //rand.NextDouble() генерує випадкове дробове число в межах від 0 до 1.Множення його на 100 забезпечує дробові числа в межах від 0 до 100.
                    //Math.Round() використовується для округлення дробових чисел до двох знаків після коми, щоб зробити числа більш читабельними.
                }
            }

            // Виведення значень масивів на екран
            Console.WriteLine("\nArray A:");
            foreach (var item in A)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine("\n\nArray B:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"{B[i, j]} ");
                }
                Console.WriteLine();
            }

            // Пошук максимального та мінімального елементів у масивах
            double maxA = A[0];
            double minA = A[0];
            double maxB = B[0, 0];
            double minB = B[0, 0];
            for (int i = 0; i < A.Length; i++)
            {
                if (A[i] > maxA)
                    maxA = A[i];
                if (A[i] < minA)
                    minA = A[i];
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    if (B[i, j] > maxB)
                        maxB = B[i, j];
                    if (B[i, j] < minB)
                        minB = B[i, j];
                }
            }

            // Знаходження загальної суми та добутку елементів масивів
            double sumA = 0;
            double productA = 1;
            double sumB = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sumA += A[i];
                productA *= A[i];
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    sumB += B[i, j];
                }
            }

            // Знаходження суми парних елементів масиву A
            double evenSumA = 0;
            for (int i = 0; i < A.Length; i++)
            {
                if (i % 2 == 0)
                    evenSumA += A[i];
            }

            // Знаходження суми непарних стовпців масиву B
            double oddColumnsSumB = 0;
            for (int j = 0; j < 4; j++)
            {
                if (j % 2 != 0)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        oddColumnsSumB += B[i, j];
                    }
                }
            }

            // Виведення результатів
            Console.WriteLine($"\nThe maximum element of the array A: {maxA}");
            Console.WriteLine($"The minimum element of the array A: {minA}");
            Console.WriteLine($"The maximum element of the array B: {maxB}");
            Console.WriteLine($"The minimum element of the array B: {minB}" );
            Console.WriteLine($"The total sum of elements of array A: {sumA}"  );
            Console.WriteLine($"The total product of the elements of the array A: {productA}");
            Console.WriteLine($"The sum of even elements of the array A: {evenSumA}");
            Console.WriteLine($"The sum of the odd columns of array B: {oddColumnsSumB}");
        }
        public static void Task2()
        {
            // Оголошення масиву
            int[,] array = new int[5, 5];

            // Заповнення масиву випадковими числами
            Random rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    array[i, j] = rand.Next(-100, 101); // випадкове число в діапазоні від -100 до 100 включно
                }
            }

            // Виведення значень масиву на екран
            Console.WriteLine("Array:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{array[i, j],5} ");
                }
                Console.WriteLine();
            }

            // Пошук мінімального та максимального елементів
            int min = array[0, 0];
            int max = array[0, 0];
            int minRow = 0, minCol = 0, maxRow = 0, maxCol = 0;

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (array[i, j] < min)
                    {
                        min = array[i, j];
                        minRow = i;
                        minCol = j;
                    }
                    if (array[i, j] > max)
                    {
                        max = array[i, j];
                        maxRow = i;
                        maxCol = j;
                    }
                }
            }

            // Обчислення суми елементів між мінімальним та максимальним
            int sum = 0;
            int startRow = Math.Min(minRow, maxRow) + 1;
            int endRow = Math.Max(minRow, maxRow);
            int startCol = Math.Min(minCol, maxCol) + 1;
            int endCol = Math.Max(minCol, maxCol);

            for (int i = startRow; i < endRow; i++)
            {
                for (int j = startCol; j < endCol; j++)
                {
                    sum += array[i, j];
                }
            }

            // Виведення суми елементів масиву, розташованих між мінімальним і максимальним
            Console.WriteLine($"Sum of elements between min and max: {sum}");
        }
        public static void Task3()
        {
            // Введення рядка для шифрування
            Console.WriteLine("Enter a string to encrypt:");
            string input = Console.ReadLine();

            // Введення зсуву
            Console.WriteLine("Enter the offset to encrypt:");
            int shift = int.Parse(Console.ReadLine());

            // Шифрування рядка та виведення результату
            string encryptedText = Encrypt(input, shift);
            Console.WriteLine($"Encrypted text: {encryptedText}");

            // Розшифрування рядка та виведення результату
            string decryptedText = Decrypt(encryptedText, shift);
            Console.WriteLine($"Decoded text: {decryptedText}");
        }
        public static void Task4()
        {
            // Створення матриць
            int[,] matrix1 = GenerateRandomMatrix(5, 5);
            int[,] matrix2 = GenerateRandomMatrix(5, 5);

            // Вивід початкових матриць
            Console.WriteLine("The first matrix:");
            PrintMatrix(matrix1);
            Console.WriteLine("\nThe second matrix:");
            PrintMatrix(matrix2);

            // Операції над матрицями
            int[,] result1 = MultiplyMatrixByNumber(matrix1, 2);
            int[,] result2 = AddMatrices(matrix1, matrix2);
            int[,] result3 = MultiplyMatrices(matrix1, matrix2);

            // Вивід результатів
            Console.WriteLine("\nMultiplication of the first matrix by the number 2:");
            PrintMatrix(result1);
            Console.WriteLine("\nAdding matrices:");
            PrintMatrix(result2);
            Console.WriteLine("\nProduct of matrices:");
            PrintMatrix(result3);
        }
        public static void Task5()
        {
            Console.WriteLine("Enter an arithmetic expression (with operations + and -):");
            string input = Console.ReadLine();

            // Розділення рядка на операнди та оператори
            string[] elements = input.Split(new char[] { '+', '-' });

            // Перша цифра є початковим значенням результату
            int result = int.Parse(elements[0]);

            // Прохід по всім елементам масиву, починаючи з індексу 1
            for (int i = 1; i < elements.Length; i++)
            {
                // Визначення оператора
                char op = input[input.IndexOf(elements[i]) - 1];

                // Визначення наступного операнду
                int operand = int.Parse(elements[i]);

                // Виконання відповідної операції та оновлення результату
                if (op == '+')
                {
                    result += operand;
                }
                else if (op == '-')
                {
                    result -= operand;
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }

            // Виведення результату
            Console.WriteLine("Result: " + result);
        }
        public static void Task6()
        {
            Console.WriteLine("Enter the text:");
            string input = Console.ReadLine();

            // Розділення введеного тексту на речення за допомогою роздільників ".", "!" та "?"
            string[] sentences = input.Split(new char[] { '.', '!', '?' });

            for (int i = 0; i < sentences.Length; i++)
            {
                if (sentences[i].Trim() != "") // Якщо речення не пусте
                {
                    // Змінюємо першу літеру речення на верхній регістр
                    sentences[i] = char.ToUpper(sentences[i].Trim()[0]) + sentences[i].Trim().Substring(1);
                }
            }

            // З'єднання речень знову в один текст
            string result = string.Join(". ", sentences);

            Console.WriteLine("The result of the application:");
            Console.WriteLine(result);
        }
        public static void Task7()
        {
            Console.WriteLine("Enter the text:");
            string text = Console.ReadLine();

            string[] forbiddenWords = { "die", "death", "kill" };
            int replacementsCount = 0;

            foreach (string word in text.Split(' '))
            {
                if (Array.IndexOf(forbiddenWords, word.ToLower()) != -1)
                {
                    text = text.Replace(word, "***");
                    replacementsCount++;
                }
            }

            Console.WriteLine("Processing result:");
            Console.WriteLine(text);
            Console.WriteLine($"Statistics: {replacementsCount} replacing words.");
        }


        // Генерація випадкової матриці
        static int[,] GenerateRandomMatrix(int rows, int cols)
        {
            Random rnd = new Random();
            int[,] matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = rnd.Next(-10, 11); // Випадкові числа в діапазоні від 1 до 10
                }
            }
            return matrix;
        }
        // Вивід матриці
        static void PrintMatrix(int[,] matrix)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        // Множення матриці на число
        static int[,] MultiplyMatrixByNumber(int[,] matrix, int number)
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix[i, j] * number;
                }
            }
            return result;
        }
        // Додавання матриць
        static int[,] AddMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows = matrix1.GetLength(0);
            int cols = matrix1.GetLength(1);
            int[,] result = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    result[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }
            return result;
        }
        // Добуток матриць
        static int[,] MultiplyMatrices(int[,] matrix1, int[,] matrix2)
        {
            int rows1 = matrix1.GetLength(0);
            int cols1 = matrix1.GetLength(1);
            int cols2 = matrix2.GetLength(1);
            int[,] result = new int[rows1, cols2];
            for (int i = 0; i < rows1; i++)
            {
                for (int j = 0; j < cols2; j++)
                {
                    for (int k = 0; k < cols1; k++)
                    {
                        result[i, j] += matrix1[i, k] * matrix2[k, j];
                    }
                }
            }
            return result;
        }

        // Метод для шифрування рядка з використанням шифру Цезаря
        static string Encrypt(string text, int shift)
        {
            string result = ""; // Результат шифрування

            // Проходимо по кожному символу в рядку
            for (int i = 0; i < text.Length; i++)
            {
                // Перевіряємо, чи символ є літерою англійського алфавіту
                if (char.IsLetter(text[i]))
                {
                    //char.IsUpper(text[i]) перевіряє, чи є символ у верхньому регістрі. 
                    char offset = char.IsUpper(text[i]) ? 'A' : 'a';
                    // Застосовуємо шифрування за допомогою зсуву
                    char encryptedChar = (char)(((text[i] + shift - offset) % 26) + offset);
                    result += encryptedChar;
                }
                else
                {
                    result += text[i];
                }
            }
            return result;
        }
        // Метод для розшифрування рядка
        static string Decrypt(string cipherText, int shift)
        {
            // Для розшифрування потрібно просто зашифрувати рядок зворотним зсувом
            return Encrypt(cipherText, 26 - shift);
        }


    }
}
