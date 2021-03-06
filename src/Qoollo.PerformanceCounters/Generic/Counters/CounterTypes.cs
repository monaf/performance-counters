﻿namespace Qoollo.PerformanceCounters
{
    /// <summary>
    /// Типы счетчиков для создания
    /// За более подробной информацией на msdn.
    /// </summary>
    public enum CounterTypes
    {
        /// <summary>
        /// Счетчик мгновенного значения, показывающий последнее наблюдавшееся значение.
        /// Используется, например, для хранения числа элементов или операций.
        /// </summary>
        NumberOfItems,

        /// <summary>
        /// Счетчик , показывающий среднее число операций, завершенных в течение каждой секунды интервала измерения.
        /// </summary>
        OperationsPerSecond,

        /// <summary>
        /// Счетчик среднего значения предназначен для исследования средней длины очереди к ресурсу за все время наблюдения.
        /// Он показывает разницу между длинами очередей, наблюдаемых в течение двух последних интервалов измерения, 
        /// деленную на продолжительность интервала.
        /// Этот тип счетчика обычно используется для хранения числа элементов, ожидающих очереди.
        /// </summary>
        //CountPerTimeInterval,

        /// <summary>
        /// Счетчик средних значений, показывающий, сколько элементов обработано в среднем за операцию.
        /// Счетчики этого типа отображают отношение обработанных элементов к числу завершенных операций.
        /// Отношение вычисляется соотношением числа обработанных элементов в течение последнего интервала времени 
        /// к числу завершенных операций за этот же интервал.
        /// </summary>
        AverageCount,

        /// <summary>
        /// Счетчик среднего значения, измеряющий время, которое он в среднем займет для завершения процесса или операции.
        /// Счетчики этого типа отображают отношение всего прошедшего интервала измерения к числу процессов или операций, 
        /// завершенных за это время.
        /// Этот тип счетчика измеряет время в тактах системных часов.
        /// Не перепутайте! Этот счетчик не показывает среднее время всех измерений, а название свое он берет из усреднения
        /// времени замера при увеличении базового счетчика больше чем на 1 еденицу.
        /// </summary>
        AverageTime,

        /// <summary>
        /// Счётчик моментального значения времени. Хранит последнее записанное в него время.
        /// </summary>
        MomentTime,

        /// <summary>
        /// Счетчик мгновенного значения в процентах, показывающий отношение подмножества к множеству в процентах.
        /// Например, он позволяет сравнить число байтов, используемых на диске, и общее число байтов на этом диске.
        /// Счетчики этого типа отображают только текущий процент, а не среднее значение за все время.
        /// </summary>
        //RawFraction,

        /// <summary>
        /// Счетчик процентов, отображающий процент отношения активности одного или более компонентов 
        /// ко всему интервалу измерения.
        /// Поскольку числитель записывает время активности работающих компонентов одновременно, 
        /// результат может превышать 100%.
        /// Этот счетчик является мультитаймером.Мультитаймеры записывают данные более одного экземпляра компонента, 
        /// например процессора или диска.
        /// </summary>
        //CounterMultiTimer,

        /// <summary>
        /// Счетчик среднего значения, который показывает среднее число операций, 
        /// завершенных за одну секунду.Когда счетчик этого типа измеряет данные, 
        /// каждое выборочное прерывание возвращает единицу или ноль.
        /// Данными счетчика является число измеренных единиц.
        /// Он измеряет время в тактах системного таймера производительности.
        /// </summary>
        //SampleCounter,

        /// <summary>
        /// Счетчик процентов, показывающий среднее отношение обращений ко всем операциям 
        /// за последние два интервала измерения.
        /// </summary>
        //SampleFraction,

        /// <summary>
        /// Counter for the difference between the raw value at the beginning and the end of the measured time frame.
        /// </summary>
        Delta,


        /// <summary>
        /// Таймер, который показывает полное время от начала работы компонента или процесса
        /// </summary>
        ElapsedTime,

        //Не используем
        //CounterTimer
    }
}
