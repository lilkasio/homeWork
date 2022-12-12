//1. загадать слово
//2. запомнить вопрос или подсказку к загаданному слову
//3. вводит букву
//4. проверка есть ли такая буква в в загаданном слове
//      если буква есть то эта буква в открывающемся слове показывается (открывается на всех позициях)
//      если буквы нет, то выдаётся подсказка что такой буквы нет
//5. проверка открыты ли все буквы в открывающемся слове
//      если открыты то сообщение о победе
//      если есть ещё не открытые буквы то вернуться к 3 пункту

char[] hiddenWord, guessWord;
string question;
bool isGuess;
const Char hidenLetter = '*';

Console.WriteLine("Введите загаданное слово");
hiddenWord = Console.ReadLine().ToCharArray();

Console.WriteLine("Введите вопрос к загаданному слову");
question = Console.ReadLine();

Console.Clear();


guessWord = new Char[hiddenWord.Length];
for (int i = 0; i < guessWord.Length; i++)
{
    guessWord[i] = hidenLetter;
}

Console.WriteLine(question);
do
{
    Console.WriteLine(guessWord);
    Console.WriteLine("введите очередную букву или слово целиком");

    string inputValue = Console.ReadLine();
    if (inputValue.Length == 1)
    {
        char supposedLetter = Char.Parse(inputValue);

        bool letterIsFind = false;

        for (int i = 0; i < hiddenWord.Length; i++)
        {
            if (hiddenWord[i] == supposedLetter)
            {
                letterIsFind = true;
                guessWord[i] = supposedLetter;
            }
        }

        if (letterIsFind == true)
        {
            Console.WriteLine("поздравляем такая буква есть");
        }
        else
        {
            Console.WriteLine("такой буквы нет");
        }

        isGuess = true;
        for (int i = 0; i < guessWord.Length; i++)
        {
            if (guessWord[i] != hiddenWord[i])
            {
                isGuess = false;
                break;
            }
        }
    }
    else
    {
        if (inputValue == new string(hiddenWord))
        {
            isGuess = true;
            guessWord = inputValue.ToCharArray();
        }
        else
        {
            isGuess = false;
        }

        if (isGuess==true)
        {
            Console.WriteLine("Вы ввели правильное слово");
        }
        else
        {
            Console.WriteLine("Вы ввели не правильно слово");
        }
    }

} while (!isGuess);
Console.WriteLine("Вы выйграли ");
Console.Write("слово было");
Console.WriteLine(guessWord);


// Console.Write($"слово было{new string(guessWord)}");