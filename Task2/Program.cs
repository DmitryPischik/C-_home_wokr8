// Составить частотный словарь для текстовых данных: Входные данные:

// Частотный анализ – это один из методов криптоанализа, основывающийся на предположении о существовании нетривиального статистического распределения отдельных
//  символов и их последовательностей как в открытом тексте, так и шифрованном тексте, которое с точностью до замены символов будет сохраняться в процессе шифрования и дешифрования.

string s = "Частотный анализ – это один из методов криптоанализа, основывающийся на предположении о существовании нетривиального статистического распределения отдельных символов и их последовательностей как в открытом тексте, так и шифрованном тексте, которое с точностью до замены символов будет сохраняться в процессе шифрования и дешифрования.";
char[] array = s.ToArray();

char[] UniqueValues(char[] array)
{
    char[] newArray = new char[0];
    int index = 0;

    foreach (var element in array)
    {
        if (newArray.Contains(element) == false) 
        {            
            Array.Resize(ref newArray, newArray.Length + 1);
            newArray[index] = element;      
            index++;
        }
    }
    return newArray;
}

char[] uniqueArray = UniqueValues(array);
double count = 0;
for(int i = 0; i < uniqueArray.Length; i++)
{    
    foreach(char element in array)
    {
        if (element == uniqueArray[i]) count++;
    }    
    Console.WriteLine($"Символ '{uniqueArray[i]}' встречается {count} раз. Частота {Math.Round(count/array.Length*100, 2)}%");
    count = 0;
}