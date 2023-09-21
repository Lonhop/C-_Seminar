int Exponentiation(int numberA, int numberB){
  int result = 1;
  // Вводим число явл. количеством чисел до числа B
  for(int i=1; i <= numberB; i++){
    result = result * numberA;
    // Возводим в нашу степень
  }
    return result;
}

  Console.Write("Введите число A: ");
  int numberA = Convert.ToInt32(Console.ReadLine()??"0");
  Console.Write("Введите число B: ");
  int numberB = Convert.ToInt32(Console.ReadLine()??"0");
// Вводим наши данные
  int our_result = Exponentiation(numberA, numberB);
  Console.WriteLine("Ответ: " + our_result);
  // Вывод