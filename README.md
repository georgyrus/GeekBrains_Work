# Описание программы

## Задание:

### Итоговая проверочная работа.

Данная работа необходима для проверки ваших знаний и навыков по итогу прохождения первого блока обучения на программе разработчик. Мы должны убедиться что базовое знакомство с it прошло успешно.

Задача алгоритмически не самая сложная, однако для полценного выполнения проверочной работы необходимо:
1. Создать репозиторий на GitHub
2. Нарисовать блок-схему алгоритма (можно обойтись блок-схемой основной содержательной части, если вы выделяете ее в отдельный метод)
3. Снабдить репозиторий оформленным текстовым описанием решения (файл README.md)
4. Написать программу, решающую поставленную задачу
5. Использовать контроль версий в работе над этим небольшим проектом (не должно быть так что все залито одним коммитом, как минимум этапы 2, 3 и 4 должны быть расположены в разных коммитах)

**Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

**Примеры**:

["hello", "2", "world", ":-)"] -> ["2", ":-)"]

["1234", "1567", "-2", "computer science"] -> ["-2"]

["Russia", "Denmark", "Kazan"] -> []

## Описание

Программа соответствует т.з. На вход задается произвольный string массив, а на выходе получается новый обработанный массив. **Размер нового массива соответствует кол-ву значений, а не исходному мыссиву**

Из нюансов:

void printArreyString(string[] col) - функция не используется в коде, оставлена для быстрого изменения формы вывода массива в виде чисел

Вывод сделан не в виде:

["1234", "1567", "-2", "computer science"] -> ["-2"]

А в виде:

Исходный массив:

[1234, 1567, -2, computer science]

Новый массив:

[-2]

Это сделано для более наглядного вывода значений, и возможности более простой модификации (в случае необходимости передавать обработанные данные в другой алгоритм)

# Контакты разработчика:

Георгий Денисов

GeorgyRus@mail.ru

+7 911 288 84 24

https://github.com/georgyrus/GeekBrains_Work.git